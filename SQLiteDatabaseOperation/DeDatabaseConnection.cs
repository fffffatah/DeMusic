using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace SQLiteDatabaseOperation
{
    public class DeDatabaseConnection
    {
        //CREATE SQL VARIABLES
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        //CREATE CONNECTION WITH THE ALREADY CREATED DATABASE OR CREATE A NEW ONE
        public DeDatabaseConnection()=> sqlite_conn = new SQLiteConnection("Data Source=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DeMusic\songdatabase.db;Version=3;New=True");
        //THIS METHOD OPENS THE CONNECTION TO DB
        public void OpenConnection()=>sqlite_conn.Open();
        //THIS METHOD CLOSES THE CONECTION WITH DB
        public void CloseConnection()=>sqlite_conn.Close();
        //THIS MEHTOD EXECUTES THE QUERY AND RETURNS THE RESULT
        public SQLiteDataReader GetData(string query)
        {
            sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
            return sqlite_cmd.ExecuteReader();
        }
        //THIS METHOD EXECUTES NON-QUERY (CREATE, INSERT, UPDATE, DELETE) AND RETURNS THE NUMBER OF ROWS AFFECTED
        public int ExecuteSQL(string query)
        {
            sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
            return sqlite_cmd.ExecuteNonQuery();
        }
    }
}
