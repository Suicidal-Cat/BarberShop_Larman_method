﻿using Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
	public class Broker
	{
		DBConnection connection;
		public Broker()
		{
			connection = new DBConnection();
		}
		public void CloseConnection()
		{
			connection.CloseConnection();
		}
		public void OpenConnection()
		{
			connection.OpenConnection();
		}
		public void Rollback()
		{
			connection.Rollback();
		}
		public void Commit()
		{
			connection.Commit();
		}
		public void BeginTransaction()
		{
			connection.BeginTransaction();
		}
		public void Add(IEntity entity)
		{
			SqlCommand cmd = connection.CreateCommand();
			cmd.CommandText = $"INSERT INTO {entity.TableName} values({entity.GetParametres()})";
			entity.PrepareCommand(cmd);
			cmd.ExecuteNonQuery();
			cmd.Dispose();
		}
		public void Delete(IEntity entity)
		{
			SqlCommand cmd = connection.CreateCommand();
			cmd.CommandText = $"DELETE FROM {entity.TableName} WHERE {entity.GetByIDQuery()}";
			cmd.ExecuteNonQuery();
			cmd.Dispose();
		}
		public void Update(IEntity entity)
		{
			SqlCommand cmd = connection.CreateCommand();
			cmd.CommandText = $"UPDATE {entity.TableName} SET {entity.UpdateQuery()} WHERE {entity.GetByIDQuery()}";
			cmd.ExecuteNonQuery();
			cmd.Dispose();
		}
		public List<IEntity> ReadAll(IEntity entity)
		{
			SqlCommand cmd = connection.CreateCommand();
			cmd.CommandText = $"SELECT * FROM {entity.TableName}";
			SqlDataReader reader = cmd.ExecuteReader();
			List<IEntity>entities= entity.GetReaderList(reader);
			reader.Close();
			cmd.Dispose();
			return entities;
		}

		public List<IEntity> ReadAllSearch(IEntity entity)
		{
			SqlCommand cmd = connection.CreateCommand();
			cmd.CommandText = $"SELECT {entity.GetSearchAttributes()} FROM {entity.TableName}";
			SqlDataReader reader = cmd.ExecuteReader();
			List<IEntity>entities= entity.ReadAllSearch(reader);
			reader.Close();
			cmd.Dispose();
			return entities;
		}

		public List<IEntity> GetAllByFilter(IEntity entity,string filter)
		{
			SqlCommand cmd = connection.CreateCommand();
			cmd.CommandText = $"SELECT {entity.GetSearchAttributes()} FROM {entity.TableName} WHERE {entity.GetFilterQuery(filter)}";
			SqlDataReader reader = cmd.ExecuteReader();
			List<IEntity> entities = entity.ReadAllSearch(reader);
			reader.Close();
			cmd.Dispose();
            return entities;
		}
		public IEntity GetEntityById(IEntity entity)
		{
			SqlCommand cmd = connection.CreateCommand();
			cmd.CommandText = $"SELECT * FROM {entity.TableName} WHERE {entity.GetByIDQuery()}";
			SqlDataReader reader = cmd.ExecuteReader();
			entity = entity.GetReaderResult(reader);
			reader.Close();
			cmd.Dispose();
			return entity;
		}
	}
}
