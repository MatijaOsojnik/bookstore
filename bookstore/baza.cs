using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace bookstore
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //konstruktor
        public DBConnect()
        {
            Initialize();
        }

        //Inicializacija vrednosti
        private void Initialize()
        {
            server = "localhost";
            database = "bookstore";
            uid = "root";
            password = "Crypto66_792";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        //odpiranje povezave na podatkovno bazo
        public void OpenConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        //Zapiranje povezave
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        //Insert stavek
//        public void Insert()
//        {
//            string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";
//            //odpiranje povezave
//            if (this.OpenConnection() == true)
//            {
//                //ustvarimo ukaz in Priredimo poizvedbo in povezavo iz konstruktorja
//                MySqlCommand cmd = new MySqlCommand(query, connection);

//                //Izvršitev ukaza
//                cmd.ExecuteNonQuery();
//                //zapiranje povezave
//                this.CloseConnection();
//            }

//        }
//        //Update stavek
//        public void Update()
//        {
//            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

//            //Odpiranje povezave
//            if (this.OpenConnection() == true)
//            {
//                //ustvarjanje mysql ukaza
//                MySqlCommand cmd = new MySqlCommand();
//                //Priredimo poizvedbo z uporabo CommandText
//                cmd.CommandText = query;
//                //Priredimo povezavo z uporabo Connection
//                cmd.Connection = connection;
//                //Izvršitev poizvedbe
//                cmd.ExecuteNonQuery();
//                //zapiranje povezave
//                this.CloseConnection();
//            }

//        }
//        //Delete stavek
//        public void Delete()
//        {
//            string query = "DELETE FROM tableinfo WHERE name='John Smith'";
//            if (this.OpenConnection() == true)
//            {
//                MySqlCommand cmd = new MySqlCommand(query, connection);
//                cmd.ExecuteNonQuery();
//                this.CloseConnection();
//            }

//        }
//        //Select stavek
//        public List<string>[] Select()
//        {
//            string query = "SELECT * FROM uporabniki";

//            //Ustvarjanje seznama, ki bo hranil rezultat
//            List<string>[] list = new List<string>[3];
//            list[0] = new List<string>();
//            list[1] = new List<string>();
//            list[2] = new List<string>();
//            //Odpiranje povezave
//            if (this.OpenConnection() == true)
//            {
//                //Ustvarimo ukaz
//                MySqlCommand cmd = new MySqlCommand(query, connection);
//                //Ustvarjanje data Readerja in Izvršitev ukaza
//                MySqlDataReader dataReader = cmd.ExecuteReader();

//                // Branje zapisov in hranjenje v seznamu
//                while (dataReader.Read())
//                {
//                    list[0].Add(dataReader["id"] + "");
//                    list[1].Add(dataReader["name"] + "");
//                    list[2].Add(dataReader["age"] + "");
//                }
//                //zapiranje Data Readerja
//                dataReader.Close();
//                //zapiranje Povezave
//                this.CloseConnection();
//                //vrnitev seznama, ki bo prikazan
//                return list;
//            }
//            else
//            {
//                return list;
//            }

//        }
//        //Count stavek
//        public int Count()
//        {
//            string query = "SELECT Count(*) FROM tableinfo";
//            int Count = -1;

//            //Odpiranje Povezave
//            if (this.OpenConnection() == true)
//            {
//                //Ustvarjanje Mysql Ukaza
//                MySqlCommand cmd = new MySqlCommand(query, connection);

//                //ExecuteScalar bo vrnil eno vrednost
//                Count = int.Parse(cmd.ExecuteScalar() + "");

//                //zapiranje Povezave
//                this.CloseConnection();

//                return Count;
//            }
//            else
//            {
//                return Count;
//            }

//        }
//        //Backup
//        //public void Backup()
//        //{
//        //}
//        //Restore
//        //public void Restore()
//        //{
//        //}
    }

}
