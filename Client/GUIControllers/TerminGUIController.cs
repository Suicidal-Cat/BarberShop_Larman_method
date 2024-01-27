using Client.UserControls;
using Client.UserControls.UCTermin;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUIControllers
{
	internal class TerminGUIController
	{
		private UCSingleTermin uCtermin;
		private UCDodajFrizeraTerminu uCTerminFrizer;

		internal Control CreateUCTermin(UCMode mode=UCMode.Add,List<DetaljiTermina>dtTer=null)
		{
			uCtermin = new UCSingleTermin();
			uCtermin.monthCalendar.DateSelected += (s,e)=>PrepareDateTime();
			uCtermin.dgvUsluge.CellClick += DeleteRow;
			uCtermin.btnDodajUslugu.Click += (s, e) => DodajUsluguDgv();
			PrepareUCTerminForm(mode,dtTer);

			if (mode == UCMode.Add)
			{
				uCtermin.btnSacuvaj.Click += SacuvajTermin;
				uCtermin.btnBack.Click += (s, e) => MainCoordinator.Instance.ShowDefault();
			}
			else if (mode == UCMode.Update)
			{
				uCtermin.btnSacuvaj.Click += SacuvajIzmeneTermina;
				uCtermin.btnBack.Click += (s, e) => MainCoordinator.Instance.ShowTerminFrizerPanel();
			}
			
			return uCtermin;
		}
		internal Control CreateUCDodajFrizeraTerminu()
		{
			uCTerminFrizer = new UCDodajFrizeraTerminu();
			uCTerminFrizer.btnDostupnost.Click += ProveriDostupnostClick;
			uCTerminFrizer.btnDodeliFrizera.Click += DodeliFrizeraTerminu;
			uCTerminFrizer.btnBack.Click += (s, e) => MainCoordinator.Instance.ShowDefault();
			uCTerminFrizer.monthCalendar.DateSelected += (s, e) => UpdateCalendar();
			uCTerminFrizer.btnIzmeniTermin.Click += PrikaziIzmenuTermina;
			PrepareUCFrizerTerminForm();
			return uCTerminFrizer;
		}

		private void DeleteRow(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == uCtermin.dgvUsluge.Columns.Count - 1 && e.RowIndex>=0)
			{
				DataGridViewRow row= uCtermin.dgvUsluge.Rows[e.RowIndex];
				if (row.Cells["Status"].Value.ToString() == "Added")
				{
					uCtermin.dgvUsluge.Rows.RemoveAt(e.RowIndex);
				}
				else if (row.Cells["Status"].Value.ToString() == "Unchanged")
				{
					row.Cells["Status"].Value = "Deleted";
				}
				else if (row.Cells["Status"].Value.ToString() == "Deleted") return;
					DataGridViewCellCollection values = row.Cells;
				uCtermin.txtCena.Text = int.Parse(uCtermin.txtCena.Text) - (int)values[2].Value + "";
				uCtermin.txtVreme.Text = int.Parse(uCtermin.txtVreme.Text) - (int)values[3].Value + "";
			}
		}

		private void SacuvajIzmeneTermina(object sender, EventArgs e)
		{
			if (!ValidateTermin()) return;
			if (!ProveriDaLiTerminImaUsluge())
			{
				MessageBox.Show("Termin mora imati barem jednu uslugu!");
                return;
			}
			List<DetaljiTermina> listDetaljiTermina = KreirajRezervaciju();
			Response res=Communication.Instance.IzmeniTermin(listDetaljiTermina);
			MessageBox.Show(res.Message);
		}

		private bool ProveriDaLiTerminImaUsluge()
		{
			if(uCtermin.dgvUsluge.Rows.Count==0) return false;
			foreach(DataGridViewRow row in uCtermin.dgvUsluge.Rows)
			{
				if (row.Cells["Status"].Value.ToString() != "Deleted") return true;
			}
			return false;
		}

		private void PrikaziIzmenuTermina(object sender, EventArgs e)
		{
			if (uCTerminFrizer.dgvTermini.SelectedRows.Count < 1)
			{
				MessageBox.Show("Selektujte red termina!");
				return;
			}
			DataGridViewRow row = uCTerminFrizer.dgvTermini.SelectedRows[0];
			Termin termin = new Termin() {
				IdTermina = int.Parse(row.Cells["IdTermina"].Value.ToString())
			};
			List<DetaljiTermina> dtTermina = Communication.Instance.VratiDetaljeTermina(termin);
			MainCoordinator.Instance.ShowTerminPanel(UCMode.Update, dtTermina);
        }

		private void UpdateCalendar()
		{
			uCTerminFrizer.dgvTermini.Rows.Clear();
			List<Termin> termini = Communication.Instance.PretraziSveTerminePoDatumu(uCTerminFrizer.monthCalendar.SelectionStart.ToString("yyyy-MM-dd")).OrderBy(t => t.VremePocetka).ToList();
			foreach (Termin ter in termini)
			{
				string frizer = null;
				if (ter.Frizer != null) frizer = ter.Frizer.DisplayValue;
				uCTerminFrizer.dgvTermini.Rows.Add(ter.IdTermina, ter.DatumTermina.ToString("yyyy-MM-dd"), ter.VremePocetka, ter.TrajanjeTerminaUMinutima, ter.Musterija.DisplayValue, frizer);
			}
		}

		private void DodeliFrizeraTerminu(object sender, EventArgs e)
		{
			if (uCTerminFrizer.dgvTermini.SelectedRows.Count < 1)
			{
				MessageBox.Show("Selektujte red termina!");
				return;
			}
			DataGridViewRow row = uCTerminFrizer.dgvTermini.SelectedRows[0];

			if (row.Cells["Frizer"].Value!=null && row.Cells["Frizer"].Value.ToString() == ((Frizer)uCTerminFrizer.cbFrizeri.SelectedItem).DisplayValue)
			{
				MessageBox.Show("Frizer je vec dodeljen datom terminu");
				return;
			};

			string vremePocetka = (string)row.Cells["vremePocetka"].Value;
			string vremeZavrsetka = IzracunajVremeKrajaTermina((string)row.Cells["vremePocetka"].Value,row.Cells["Trajanje"].Value.ToString());

			var result = ProveriDostupnost();
			string message = result.Item1;
			string[,] reservations = result.Item2;
			if (message != null && !ProveraVremenaTerminaFrizera(reservations, vremePocetka, vremeZavrsetka))
			{
				MessageBox.Show("Frizer je zauzet u tom terminu");
				return;
			}

			Termin termin = new Termin()
			{
				IdTermina = int.Parse(row.Cells["IdTermina"].Value.ToString()),
				DatumTermina = DateTime.Parse(row.Cells["DatumTermina"].Value.ToString()),
				VremePocetka = vremePocetka,
				TrajanjeTerminaUMinutima = int.Parse(row.Cells["Trajanje"].Value.ToString()),
				Frizer =(Frizer)uCTerminFrizer.cbFrizeri.SelectedItem,
			};

			Response res = Communication.Instance.DodeliFrizeraTerminu(termin);

			MessageBox.Show(res.Message);
			PrepareUCFrizerTerminForm();
		}

		private void ProveriDostupnostClick(object sender, EventArgs e)
		{
			var result = ProveriDostupnost();
			string message = result.Item1;
			string[,] reservations = result.Item2;
			if (message == null) MessageBox.Show("Frizer nema dodeljenih termina za izabrani datum");
			else MessageBox.Show(message);
		}

		private bool ProveraVremenaTerminaFrizera(string[,]reservations,string vremePocetka,string vremeZavrsetka)
		{
			for (int i = 0; i < reservations.GetLength(0); i++)
			{
				string trenutniP = reservations[i, 0];
				string trenutniK = reservations[i, 1];
				int result = string.CompareOrdinal(vremePocetka, trenutniP);
				if (result < 0 && string.CompareOrdinal(vremeZavrsetka,trenutniP)>0)
				{
					return false;
				}
				else if (result > 0 && string.CompareOrdinal(vremePocetka, trenutniK) < 0)
				{
					return false;
				}
				else if(result==0)return false;
			}
			return true;
		}

		private (string,string[,]) ProveriDostupnost()
		{
			
			Frizer f = (Frizer)uCTerminFrizer.cbFrizeri.SelectedItem;
			string message = $"Zakazani termini izabranog frizera:\n" +
				$"Datuma: {uCTerminFrizer.monthCalendar.SelectionStart.Date.ToString("yyyy-MM-dd")}\n";
			bool reserved = false;
			string[,] reservations=new string[uCTerminFrizer.dgvTermini.Rows.Count,2];
			int reservationsCounter = 0;
			foreach (DataGridViewRow row in uCTerminFrizer.dgvTermini.Rows)
			{
				if ((string)row.Cells["Frizer"].Value == f.DisplayValue)
				{
					string vremePocetka = row.Cells["vremePocetka"].Value.ToString();
					string vremeZavrsetka = IzracunajVremeKrajaTermina(row.Cells["vremePocetka"].Value.ToString(),row.Cells["Trajanje"].Value.ToString());
					message += $"\nMusterija: {row.Cells["Musterija"].Value.ToString()}\nPocetak termina: {vremePocetka}\nKraj termina: {vremeZavrsetka}\n";
					reserved = true;
					reservations[reservationsCounter,0] = vremePocetka;
					reservations[reservationsCounter, 1] = vremeZavrsetka;
					reservationsCounter++;
				}
			}
			if (reserved == true)
			{
				return (message,reservations);
			}
			else return (null,null);
		}
		private string IzracunajVremeKrajaTermina(string start,string trajanje)
		{
			string end;
			string[] startSplit = start.Split(':');
			int minutes = int.Parse(startSplit[1]) + int.Parse(trajanje);
			int hours = int.Parse(startSplit[0]);
			while (minutes > 60)
			{
				minutes -= 60;
				hours++;
			}
			end = hours.ToString()+":"+minutes.ToString();
			return end;
		}

		private void PrepareUCFrizerTerminForm()
		{
			uCTerminFrizer.monthCalendar.MinDate = DateTime.Now.Date;
			uCTerminFrizer.monthCalendar.MaxDate = DateTime.Now.AddMonths(3).Date;
			uCTerminFrizer.cbFrizeri.DataSource = Communication.Instance.PretraziSveFrizere().Where(f=>f.Status==Status.Aktivan).ToList();
			uCTerminFrizer.cbFrizeri.DisplayMember = "DisplayValue";

			uCTerminFrizer.dgvTermini.Rows.Clear();
			List<Termin> termini = Communication.Instance.PretraziSveTerminePoDatumu(uCTerminFrizer.monthCalendar.SelectionStart.ToString("yyyy-MM-dd")).OrderBy(t=>t.VremePocetka).ToList();
			foreach (Termin ter in termini)
			{
				string frizer=null;
				if (ter.Frizer != null) frizer = ter.Frizer.DisplayValue;
					uCTerminFrizer.dgvTermini.Rows.Add(ter.IdTermina,ter.DatumTermina.ToString("yyyy-MM-dd"),ter.VremePocetka,ter.TrajanjeTerminaUMinutima,ter.Musterija.DisplayValue, frizer);
			}
        }

		private void SacuvajTermin(object sender, EventArgs e)
		{
			if (!ValidateTermin()) return;
			List<DetaljiTermina> listDetaljiTermina = KreirajRezervaciju();
			Response res=Communication.Instance.SacuvajTermin(listDetaljiTermina);
			MessageBox.Show(res.Message);
			uCtermin.dgvUsluge.Rows.Clear();
		}
		private List<DetaljiTermina> KreirajRezervaciju()
		{
			List<DetaljiTermina> listDetaljiTermina = new List<DetaljiTermina>();
			string minutes;
			if (uCtermin.minutesCounter.Value == 0) minutes = "00";
			else minutes = uCtermin.minutesCounter.Value.ToString();
			Termin termin = new Termin()
			{
				Musterija = (Musterija)uCtermin.cbMusterije.SelectedItem,
				DatumTermina = uCtermin.monthCalendar.SelectionStart.Date,
				VremePocetka = uCtermin.hoursCounter.Value + ":" + minutes,
				UkupnaCena = int.Parse(uCtermin.txtCena.Text),
				TrajanjeTerminaUMinutima = int.Parse(uCtermin.txtVreme.Text),
			};
			if (!string.IsNullOrEmpty(uCtermin.txtIdTermina.Text)) termin.IdTermina=int.Parse( uCtermin.txtIdTermina.Text);
			foreach (DataGridViewRow row in uCtermin.dgvUsluge.Rows)
			{
				Usluga u = new Usluga
				{
					IdUsluge = (int)row.Cells[0].Value,
					NazivUsluge = (string)row.Cells[1].Value,
					CenaUsluge = (int)row.Cells[2].Value,
					TrajanjeUslugeUMinutima = (int)row.Cells[3].Value,
				};
				DetaljiTermina detaljiTermina = new DetaljiTermina()
				{
					Termin = termin,
					Usluga = u,
					Napomena = row.Cells[4].Value.ToString(),
					Status = row.Cells["Status"].Value.ToString(),
				};
				listDetaljiTermina.Add(detaljiTermina);
			}
			return listDetaljiTermina;
		}

		private void DodajUsluguDgv()
		{
			Usluga u = (Usluga)uCtermin.cbUsluge.SelectedItem;
			foreach(DataGridViewRow row in uCtermin.dgvUsluge.Rows)
			{
				if ((int)row.Cells[0].Value == u.IdUsluge)
				{
					string status = row.Cells[uCtermin.dgvUsluge.ColumnCount - 2].Value.ToString();
					if(status=="Deleted")
					{
						row.Cells[uCtermin.dgvUsluge.ColumnCount - 2].Value = "Unchanged";
						uCtermin.txtCena.Text = int.Parse(uCtermin.txtCena.Text) + u.CenaUsluge + "";
						uCtermin.txtVreme.Text = int.Parse(uCtermin.txtVreme.Text) + u.TrajanjeUslugeUMinutima + "";
					}	
					else
					{
						MessageBox.Show("Usluga je vec dodata u temrin!");
					}		
					return;
				}
			}
			uCtermin.dgvUsluge.Rows.Add(u.IdUsluge,u.NazivUsluge ,u.CenaUsluge, u.TrajanjeUslugeUMinutima, uCtermin.txtNapomena.Text,"Added","Izbrisi");
			uCtermin.txtCena.Text = int.Parse(uCtermin.txtCena.Text) + u.CenaUsluge+"";
			uCtermin.txtVreme.Text = int.Parse(uCtermin.txtVreme.Text) + u.TrajanjeUslugeUMinutima + "";
			uCtermin.txtNapomena.Text = "";
		}

		private void PrepareUCTerminForm(UCMode mode=UCMode.Add,List<DetaljiTermina> dtTer = null)
		{
			uCtermin.monthCalendar.MinDate = DateTime.Now.Date;
			DateTime now3 = DateTime.Now.AddMonths(3);
			uCtermin.monthCalendar.MaxDate = now3;

			uCtermin.minutesCounter.Minimum = 0;
			uCtermin.minutesCounter.Maximum = 45;
			uCtermin.minutesCounter.Increment = 15;
			uCtermin.hoursCounter.TextAlign = HorizontalAlignment.Right;
			uCtermin.minutesCounter.TextAlign = HorizontalAlignment.Right;

			uCtermin.txtCena.Text = "0";
			uCtermin.txtVreme.Text = "0";

			uCtermin.txtCena.Enabled = false;
			uCtermin.txtVreme.Enabled = false;
			PrepareHourCounter(DateTime.Now.Hour);
			uCtermin.cbMusterije.DataSource = Communication.Instance.VratiSveMusterije();
			uCtermin.cbMusterije.DisplayMember = "DisplayValue";
			uCtermin.cbUsluge.DataSource = Communication.Instance.VratiSveUsluge();
			uCtermin.cbUsluge.DisplayMember = "DisplayValue";
			if (mode == UCMode.Update)
			{
				Termin termin = dtTer[0].Termin;
				uCtermin.monthCalendar.SelectionStart = termin.DatumTermina;
				uCtermin.txtIdTermina.Text=termin.IdTermina.ToString();
				uCtermin.cbMusterije.SelectedItem = termin.Musterija;
				uCtermin.cbMusterije.Enabled = false;
				string[] vreme = termin.VremePocetka.Split(':');
				int sati= int.Parse(vreme[0]);
				if (sati > uCtermin.hoursCounter.Minimum && sati < uCtermin.hoursCounter.Maximum)
				{
					uCtermin.hoursCounter.Value = sati;
				}
				else
				{
					uCtermin.hoursCounter.Minimum = sati;
					uCtermin.hoursCounter.Maximum = sati;
					uCtermin.hoursCounter.Value = sati;
					
				}
				uCtermin.minutesCounter.Value = int.Parse(vreme[1]);
				foreach(DetaljiTermina dt in dtTer)
				{
					Usluga u = dt.Usluga;

					uCtermin.dgvUsluge.Rows.Add(u.IdUsluge,u.NazivUsluge,u.CenaUsluge,u.TrajanjeUslugeUMinutima,dt.Napomena,"Unchanged","Izbrisi");

					uCtermin.txtCena.Text = int.Parse(uCtermin.txtCena.Text) + u.CenaUsluge + "";
					uCtermin.txtVreme.Text = int.Parse(uCtermin.txtVreme.Text) + u.TrajanjeUslugeUMinutima + "";
				}
			}
		}

		private void PrepareHourCounter(int hour)
		{
			uCtermin.hoursCounter.Enabled = true;
			uCtermin.minutesCounter.Enabled = true;
			uCtermin.hoursCounter.Maximum = 20;
			if (hour == -1)
			{
				uCtermin.hoursCounter.Minimum = 12;
				uCtermin.hoursCounter.Value = 12;
			}
			else if (hour < 12) {
				uCtermin.hoursCounter.Minimum = 12;
				uCtermin.hoursCounter.Value = 12;
			}
			else if (hour <= 19) {
				uCtermin.hoursCounter.Minimum = hour + 1;
				uCtermin.hoursCounter.Value = hour+1;
			}
			else
			{
				uCtermin.hoursCounter.Minimum = 0;
				uCtermin.hoursCounter.Maximum = 0;
				uCtermin.hoursCounter.Value = 0;
				uCtermin.hoursCounter.Enabled = false;
				uCtermin.minutesCounter.Enabled = false;
			}
		}
		private void PrepareDateTime()
		{
			DateTime izabrani = uCtermin.monthCalendar.SelectionStart;
			uCtermin.minutesCounter.Value = 0;
			if (izabrani.DayOfWeek == DayOfWeek.Sunday)
			{
				MessageBox.Show("Nedeljom ne radimo!");
				uCtermin.monthCalendar.SelectionStart = DateTime.Now;
				PrepareHourCounter(DateTime.Now.Hour);
			}
			else if (izabrani.Date == DateTime.Now.Date)
			{
				PrepareHourCounter(DateTime.Now.Hour);
			}
			else PrepareHourCounter(-1);
		}
		private bool ValidateTermin()
		{
			string message = string.Empty;
			if (uCtermin.hoursCounter.Value==0)
			{
				message += "Molim vas izaberite validan datum i vreme\n";
			}
			if (uCtermin.dgvUsluge.Rows.Count < 1)
			{
				message += "Morate izabrati neku uslugu kako bi rezervisali termin\n";
			}
			if (message == string.Empty) return true;
			else
			{
				MessageBox.Show(message);
				return false;
			}
		}
	}
}
