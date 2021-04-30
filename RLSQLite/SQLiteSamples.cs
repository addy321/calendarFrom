using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace PMRL.RLSQLite
{
    public class SQLiteSamples
    {

        //数据库连接
        SQLiteConnection m_dbConnection;

        private string SQLPATH = "../db/SQL.sqlite";

        public SQLiteSamples()
        {
            //createNewDatabase();
            connectToDatabase();
            //createTable();
            //fillTable();
            //printHighscores();
        }

        //创建一个空的数据库
        public void createNewDatabase()
        {
            SQLiteConnection.CreateFile(SQLPATH);
        }

        //创建一个连接到指定数据库
        public void connectToDatabase()
        {
            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
        }

        public void closeDatabase()
        {
            m_dbConnection.Close();
        }

        //在指定数据库中创建一个table
        public void createTable()
        {
            string sql = "create table tixing (date varchar(20), content varchar(1000))";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();


            string sql2 = "create table jieri (date varchar(20), content varchar(1000))";
            SQLiteCommand command2= new SQLiteCommand(sql2, m_dbConnection);
            command2.ExecuteNonQuery();

        }

        //插入一些数据
        public void fillTable()
        {
            string sql = "insert into tixing (date, content) values ('20210429', '添加提醒')";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }
        
        public void addJieRi(string date,string content)
        {
            string sql = "insert into jieri (date, content) values ('"+ date + "', '"+ content + "')";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        public void delJieRi(string date)
        {
            string sql = "delete from jieri where date='"+date+"'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }
        public string getJieRi(string date)
        {
            string sql = "select * from jieri where date='"+ date + "'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            string content = "";
            while (reader.Read())
            {
                content += reader["content"].ToString();
            }
            return content;
        }
        public void printHighscores()
        {
            string sql = "select * from jieri order by date desc";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                Console.WriteLine("date: " + reader["date"] + "\tcontent: " + reader["content"]);
            Console.ReadLine();
        }

        public void addTixing(string date, string content)
        {
            string sql = "insert into tixing (date, content) values ('" + date + "', '" + content + "')";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        public void delTixing(string date)
        {
            string sql = "delete from tixing where date='" + date + "'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }
        public string getTixing(string date)
        {
            string sql = "select * from tixing where date='" + date + "'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            string content = "";
            while (reader.Read())
            {
                content += reader["content"].ToString();
            }
            return content;
        }
    }
}
