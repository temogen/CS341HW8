// 
// N-Tier database app: Data Acces Tier 
// 
// Daniel A. Noventa 
// U. of Illinois, Chicago 
// CS341, Fall 2013 
// Homework 8 
//
using System.Data;
using System.Collections.Generic;
using Mono.Data.Sqlite;
using Mono.Data;
using System;

namespace databases
{
	public class DataAccess
	{
		public DataAccess (string s)
		{
			string connectionInfo = "Data Source = " + s;
			SqliteConnection db = new SqliteConnection(connectionInfo);
			db.Open();
		}

		public object getStuff(string s)
		{ 
			string connectionInfo = "Data Source = Netflix.sqlite";
			SqliteConnection db = new SqliteConnection(connectionInfo);
			db.Open();

			SqliteCommand cmd = new SqliteCommand(db);
			cmd.CommandText = s;
			object result = cmd.ExecuteScalar();

			db.Close();
			return result;
		}
	}
}

