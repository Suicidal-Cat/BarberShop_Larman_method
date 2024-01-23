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

		internal Control CreateUCTermin()
		{
			uCtermin = new UCSingleTermin();
			uCtermin.monthCalendar.DateSelected += (s,e)=>PrepareDateTime();
			uCtermin.dgvUsluge.UserDeletedRow += DeletedRow;
			uCtermin.btnDodajUslugu.Click += (s, e) => DodajUsluguDgv();
			PrepareUCTerminForm();

			uCtermin.btnSacuvaj.Click += SacuvajTermin;
			return uCtermin;
		}

		private void SacuvajTermin(object sender, EventArgs e)
		{
			if (!ValidateTermin()) return;
			List<DetaljiTermina> listDetaljiTermina = KreirajRezervaciju();
			Response res=Communication.Instance.SacuvajTermin(listDetaljiTermina);
			MessageBox.Show(res.Message);
		}
		private List<DetaljiTermina> KreirajRezervaciju()
		{
			List<DetaljiTermina> listDetaljiTermina = new List<DetaljiTermina>();
			Termin termin = new Termin()
			{
				Musterija = (Musterija)uCtermin.cbMusterije.SelectedItem,
				DatumTermina = uCtermin.monthCalendar.SelectionStart.Date,
				VremePocetka = uCtermin.hoursCounter.Value + ":" + uCtermin.minutesCounter.Value,
				UkupnaCena = int.Parse(uCtermin.txtCena.Text),
				TrajanjeTerminaUMinutima = int.Parse(uCtermin.txtVreme.Text),
			};
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
					Napomena = (string)row.Cells[4].Value,
				};
				listDetaljiTermina.Add(detaljiTermina);
			}
			return listDetaljiTermina;
		}

		private void DeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			DataGridViewCellCollection values = e.Row.Cells;
			uCtermin.txtCena.Text = int.Parse(uCtermin.txtCena.Text) - (int)values[2].Value + "";
			uCtermin.txtVreme.Text = int.Parse(uCtermin.txtVreme.Text) - (int)values[3].Value + "";
		}

		private void DodajUsluguDgv()
		{
			Usluga u = (Usluga)uCtermin.cbUsluge.SelectedItem;
			foreach(DataGridViewRow row in uCtermin.dgvUsluge.Rows)
			{
				if ((int)row.Cells[0].Value == u.IdUsluge)
				{
					MessageBox.Show("Usluga je vec dodata u temrin!");
					return;
				}
			}
			uCtermin.dgvUsluge.Rows.Add(u.IdUsluge,u.NazivUsluge ,u.CenaUsluge, u.TrajanjeUslugeUMinutima, uCtermin.txtNapomena.Text);
			uCtermin.txtCena.Text = int.Parse(uCtermin.txtCena.Text) + u.CenaUsluge+"";
			uCtermin.txtVreme.Text = int.Parse(uCtermin.txtVreme.Text) + u.TrajanjeUslugeUMinutima + "";
			uCtermin.txtNapomena.Text = "";
		}

		private void PrepareUCTerminForm()
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
