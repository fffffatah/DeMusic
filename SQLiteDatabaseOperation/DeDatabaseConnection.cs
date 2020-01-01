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
        // We use these three SQLite objects:

        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        SQLiteDataReader sqlite_datareader;
        public void MyConnection()
        {
            try
            {
                //Data Source=database.db; Mode=ReadWriteCreate; Cache=Default
                // create a new database connection:
                sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True");

                // open the connection:
                sqlite_conn.Open();

                // create a new SQL command:
                sqlite_cmd = sqlite_conn.CreateCommand();

                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = "CREATE TABLE test (id integer primary key, text varchar(100));";

                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();

                // Lets insert something into our new table:
                sqlite_cmd.CommandText = "INSERT INTO test (id, text) VALUES (1, 'Test Text 1');";

                // And execute this again ;D
                sqlite_cmd.ExecuteNonQuery();

                // ...and inserting another line:
                sqlite_cmd.CommandText = "INSERT INTO test (id, text) VALUES (2, 'Test Text 2');";

                // And execute this again ;D
                sqlite_cmd.ExecuteNonQuery();

                // But how do we read something out of our table ?
                // First lets build a SQL-Query again:
                sqlite_cmd.CommandText = "SELECT * FROM test";

                // Now the SQLiteCommand object can give us a DataReader-Object:
                sqlite_datareader = sqlite_cmd.ExecuteReader();

                // The SQLiteDataReader allows us to run through the result lines:
                while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
                {
                    // Print out the content of the text field:
                    //Console.WriteLine(sqlite_datareader["text"]);
                    File.WriteAllText(@"out.txt", sqlite_datareader["text"].ToString());
                }

                // We are ready, now lets cleanup and close our connection:
                sqlite_conn.Close();
            }
            catch (Exception e)
            {

                File.WriteAllText(@"log.txt", e.ToString());
            }
        }
    }
}
