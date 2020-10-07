using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bookstore
{
    public partial class Login : Form

    {
        int id;
        string ime, priimek, vrstaRacuna;
        public Login()
        {
            InitializeComponent();
        }

        private void zapriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oNasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informacije info = new Informacije();
            info.ShowDialog();
        }

        private void licencaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pravilnik pravilnik = new Pravilnik();
            pravilnik.ShowDialog();
        }


        //Link, ki odpre formo za registracijo
        private void registracijaLinkButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registracija registracijaform = new Registracija();
            registracijaform.Show();
        }
        //Gumb, za login

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            //Povezava baza.cs(povezava baze na to formo)
            DBConnect db = new DBConnect();

            String email = emailLoginTextBox.Text;
            String geslo = gesloLoginTextBox.Text;

            //Ustvarjanje tabele za preverjanje ali sploh obstaja tak račun, ki ga iščemo
            DataTable table = new DataTable();

            //Inicializacija MySql adapterja
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //MySql command v katerega shranimo SQL stavek
            MySqlCommand command = new MySqlCommand("SELECT * FROM `uporabniki` WHERE `email` = @email and `geslo` = @geslo", db.GetConnection());


            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@geslo", MySqlDbType.VarChar).Value = geslo;

            adapter.SelectCommand = command;

            //Če obstaja kakšen račun, ki vsebuje email in password, ki smo ga vnesli bo ta z funkcijo .Fill vnešen v tabelo
            adapter.Fill(table);

            db.OpenConnection();
                MySqlDataReader dr = command.ExecuteReader();
            // Ali uporabnik obstaja ali ne
            if (table.Rows.Count > 0)
            {

                dr.Read();
                id = dr.GetInt16(0);
                ime = dr.GetString(1);
                priimek = dr.GetString(2);
                vrstaRacuna = dr.GetString(5);
                if(vrstaRacuna == "uporabnik")
                {
                    this.Hide();
                    MainUporabnik mainUporabnikform = new MainUporabnik(ime, priimek, id);
                    mainUporabnikform.login = this;
                    mainUporabnikform.Show();
                }
                else if(vrstaRacuna == "admin")
                {
                    this.Hide();
                    Main mainform = new Main(ime, priimek, id);
                    mainform.login = this;
                    mainform.Show();
                }
            }
            else
            {
                ime = "";
                // Ali je bil vnešen email
                if (email.Trim().Equals(""))
                {
                    MessageBox.Show("Vnesi svoj email", "Ni emaila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Ali je bilo geslo vnešeno
                else if (geslo.Trim().Equals(""))
                {
                    MessageBox.Show("Vnesi svoje geslo", "Ni gesla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Ali uporabnik dejansko obstaja
                else
                {
                    MessageBox.Show("Napačen email ali geslo", "Napačni podatki", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            dr.Close();
            db.CloseConnection();
        }
    }
}
