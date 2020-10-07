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
    public partial class MainUporabnik : Form
    {
        public Login login;
        int idNumber, avtorId;
        public MainUporabnik(string ime, string priimek, int id)
        {
            InitializeComponent();
            userNameLabel.Text = ime + " " + priimek;
            idNumber = id;
        }

        public void prikazUporabnika (int knjigaId, Label naslov, Label avtor)
        {
            DBConnect db = new DBConnect();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `knjige` WHERE id = "+knjigaId+"", db.GetConnection());

            db.OpenConnection();

            MySqlDataReader reader1 = command1.ExecuteReader();

            while (reader1.Read())
            {
                naslov.Text = reader1.GetString("naslov");
                avtorId = reader1.GetInt16("avtor_id");
            }

            db.CloseConnection();

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `avtorji` WHERE id = " + avtorId + "", db.GetConnection());

            db.OpenConnection();

            MySqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                string ime = reader2.GetString("ime");
                string priimek = reader2.GetString("priimek");
                avtor.Text = ime + " " + priimek;
            }

            db.CloseConnection();
        }

        MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=bookstore;UID=root;PASSWORD=Crypto66_792;");


        private void MainUporabnik_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM zbirke WHERE uporabnik_id = " + idNumber + "";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            zbirkeListBox.DataSource = table;
            zbirkeListBox.DisplayMember = "ime";
            zbirkeListBox.ValueMember = "id";

            prikazUporabnika(3, romanNaslov, romanAvtor);
            prikazUporabnika(7, kriminalkaNaslov, kriminalkaAvtor);
            prikazUporabnika(5, scifiNaslov, scifiAvtor);
            prikazUporabnika(6, biografijaNaslov, biografijaAvtor);
            prikazUporabnika(6, knjigaMesecaNaslov, knjigaMesecaAvtor);

        }

        private void searchZbirkeButton_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM zbirke WHERE uporabnik_id = " + idNumber + "";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            zbirkeListBox.DataSource = table;
            zbirkeListBox.DisplayMember = "ime";
            zbirkeListBox.ValueMember = "id";
        }
        private void zapriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void izpisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
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

        private void zbirkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZbirkaVnos dodaj = new ZbirkaVnos(idNumber);
            dodaj.ShowDialog();
        }

        private void editZbirkoButton_Click(object sender, EventArgs e)
        {
            string selectedItem = zbirkeListBox.GetItemText(zbirkeListBox.SelectedItem);

            ZbirkaPosodobi posodobi = new ZbirkaPosodobi(selectedItem, idNumber);
            posodobi.ShowDialog();
        }

        public Boolean zbirkaNiPrazna()
        {
            DBConnect db = new DBConnect();

            string imeZbirke = zbirkeListBox.GetItemText(zbirkeListBox.SelectedItem);

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM knjige_zbirke WHERE zbirka_id= (SELECT id FROM zbirke WHERE ime = '" + imeZbirke + "');", db.GetConnection());

            adapter.SelectCommand = command;

            adapter.Fill(table);

            // check if this username already exists in the database
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void deleteZbirkoButton_Click(object sender, EventArgs e)
        {
            string imeZbirke = zbirkeListBox.GetItemText(zbirkeListBox.SelectedItem);

            DBConnect db = new DBConnect();


            MySqlCommand command = new MySqlCommand("DELETE FROM zbirke WHERE `ime`='" + imeZbirke + "';", db.GetConnection());

            MySqlCommand commandDeleteAll = new MySqlCommand("DELETE FROM knjige_zbirke WHERE zbirka_id = (SELECT id FROM zbirke WHERE ime = '"+imeZbirke+"');", db.GetConnection());

            db.OpenConnection();

            if (zbirkaNiPrazna())
            {
                commandDeleteAll.ExecuteNonQuery();

                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Uspešno si izbrisal zbirko", "Zbirka izbrisana", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    searchZbirkeButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Napaka");
                }

            }
            else
            {
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Uspešno si izbrisal zbirko", "Zbirka izbrisana", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                searchZbirkeButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Napaka");
            }

            }


            db.CloseConnection();
        }

        private void zbirkeListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (zbirkeListBox.SelectedItem != null)
            {
                string imeZbirke = zbirkeListBox.GetItemText(zbirkeListBox.SelectedItem);
                ZbirkaPodrobnosti podrobnosti = new ZbirkaPodrobnosti(imeZbirke, idNumber);
                podrobnosti.ShowDialog();
            }
        }

        private void urediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedItem = zbirkeListBox.GetItemText(zbirkeListBox.SelectedItem);

            ZbirkaPosodobi posodobi = new ZbirkaPosodobi(selectedItem, idNumber);
            posodobi.ShowDialog();
        }

        private void dodajZbirkoButton_Click(object sender, EventArgs e)
        {
            ZbirkaVnos dodaj = new ZbirkaVnos(idNumber);
            dodaj.ShowDialog();
        }
    }
}
