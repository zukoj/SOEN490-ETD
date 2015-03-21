﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using ETD.Models.Objects;
using ETD.Services.Database.Queries;
using System.IO;

namespace ETD.Services.Database
{
    class StaticDBConnection
    {
        private static SQLiteConnection m_dbConnection;

       static StaticDBConnection()
       {
           if (!File.Exists(@".\Resources\EDT.sqlite3"))
           {
               CreateDatabase();
           }
           else
           {
               m_dbConnection = new SQLiteConnection(@"Data Source='.\Resources\EDT.sqlite3';Version=3;");
           }
       }

       private static void CreateDatabase()
        {
            SQLiteConnection.CreateFile(@".\Resources\EDT.sqlite3");
            m_dbConnection = new SQLiteConnection(@"Data Source='.\Resources\EDT.sqlite3';Version=3;");
            m_dbConnection.Open();
            String query = File.ReadAllText(@".\Resources\db.sql");
            SQLiteCommand command = new SQLiteCommand(query, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();            
        }

       private static void OpenDatabase()
        {
            m_dbConnection.Open();
            while (m_dbConnection.State != System.Data.ConnectionState.Open)
            {
                //Ensures connection is properly open before continuing
            }
        }

       private static void CloseConnection()
        {
            m_dbConnection.Close();
            while (m_dbConnection.State != System.Data.ConnectionState.Closed)
            {
                //Ensures connection is properly open before continuing
            }
        }

       public static int NonQueryDatabase(string query)
        {
            if(m_dbConnection.State == System.Data.ConnectionState.Broken)
            {
                CloseConnection();
            }
            if (m_dbConnection.State == System.Data.ConnectionState.Closed)
            {
                OpenDatabase();
            }
            
            SQLiteCommand command = new SQLiteCommand(query, m_dbConnection);
            int results = command.ExecuteNonQuery();
            CloseConnection();
            return results;
        }

       public static int NonQueryDatabaseWithID(string query)
       {
           int results = -1;
           if (m_dbConnection.State == System.Data.ConnectionState.Broken)
           {
               CloseConnection();
           }
           if (m_dbConnection.State == System.Data.ConnectionState.Closed)
           {
               OpenDatabase();
           }

           SQLiteCommand command = new SQLiteCommand(m_dbConnection);
           //TODO: Re-enable foreign keys here.
           //command.CommandText = @"PRAGMA foreign_keys = ON;";
           //command.ExecuteNonQuery();
           command.CommandText = query;
           int temp = command.ExecuteNonQuery();
           command.CommandText = @"select last_insert_rowid()";
           results = (int)(Int64)command.ExecuteScalar();
           CloseConnection();
           return results;
       }

       public static SQLiteDataReader QueryDatabase(string query)
        {
            if (m_dbConnection.State == System.Data.ConnectionState.Broken)
            {
                CloseConnection();
            }
            if (m_dbConnection.State == System.Data.ConnectionState.Closed)
            {
                OpenDatabase();
            }
            SQLiteCommand command = new SQLiteCommand(query, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            CloseConnection();
            return reader;
        }

       public static string DateTimeSQLite(DateTime datetime)
       {
           string dateTimeFormat = "{0}-{1}-{2} {3}:{4}:{5}.{6}";
           return string.Format(dateTimeFormat, datetime.Year, datetime.Month, datetime.Day, datetime.Hour, datetime.Minute, datetime.Second, datetime.Millisecond);
       }
    }
}