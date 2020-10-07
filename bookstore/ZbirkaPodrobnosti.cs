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
    public partial class ZbirkaPodrobnosti : Form
    {
        MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=bookstore;UID=root;PASSWORD=Crypto66_792;");
        string naslov;
        int id;
        public ZbirkaPodrobnosti(string zbirkaIme, int userId)
        {
            InitializeComponent();
            naslov = zbirkaIme;
            id = userId;
        }

        private void ZbirkaPodrobnosti_Load(object sender, EventArgs e)
        {
            zbirkaImeLabel.Text = naslov;

            string selectQuery = "SELECT k.naslov AS 'Naslov', k.opis AS 'Opis', k.strani AS 'Število strani', k.datum_izdaje as 'Datum izdaje', CONCAT(a.ime, ' ', a.priimek) AS 'Avtor', z.ime as 'Zalozba' FROM avtorji a INNER JOIN knjige k ON a.id=k.avtor_id INNER JOIN zalozbe z ON z.id=k.zalozba_id INNER JOIN knjige_zbirke kz ON k.id = kz.knjiga_id INNER JOIN zbirke zb ON zb.id=kz.zbirka_id WHERE kz.zbirka_id = (SELECT id FROM zbirke WHERE ime = '"+naslov+"'); ";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            zbirkaDataGridView.DataSource = table;

            string selectQuery1 = "SELECT * FROM knjige";
            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(selectQuery1, connection);
            adapter1.Fill(table1);
            knjigeListBox.DataSource = table1;
            knjigeListBox.DisplayMember = "naslov";
            knjigeListBox.ValueMember = "id";

            DBConnect db = new DBConnect();
        }

        private void mainLinkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Boolean checkKnjiga()
        {
            DBConnect db = new DBConnect();

            string imeKnjige = knjigeListBox.GetItemText(knjigeListBox.SelectedItem);

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM knjige_zbirke WHERE zbirka_id= (SELECT id FROM zbirke WHERE ime = '" + naslov + "') AND knjiga_id = (SELECT id FROM knjige WHERE naslov = '" + imeKnjige + "') ;", db.GetConnection());

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

        private void dodajZbirkoButton_Click(object sender, EventArgs e)
        {
            string imeKnjige = knjigeListBox.GetItemText(knjigeListBox.SelectedItem);
            int idKnjige = knjigeListBox.SelectedIndex;

            DBConnect db = new DBConnect();
            MySqlCommand command = new MySqlCommand("INSERT INTO knjige_zbirke(knjiga_id , zbirka_id) VALUES ((SELECT id FROM knjige WHERE naslov = @knjiga), (SELECT id FROM zbirke WHERE ime = @zbirka))", db.GetConnection());

            command.Parameters.Add("@knjiga", MySqlDbType.VarChar).Value = imeKnjige;
            command.Parameters.Add("@zbirka", MySqlDbType.VarChar).Value = naslov;

            db.OpenConnection();

            if (checkKnjiga())
            {
                MessageBox.Show("Ta knjiga že obstaja v tvoji zbirki", "Knjiga obstaja", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Uspešno si dodal knjigo v zbirko", "Knjiga dodana", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    string selectQuery = "SELECT k.naslov AS 'Naslov', k.opis AS 'Opis', k.strani AS 'Število strani', k.datum_izdaje as 'Datum izdaje', CONCAT(a.ime, ' ', a.priimek) AS 'Avtor', z.ime as 'Zalozba' FROM avtorji a INNER JOIN knjige k ON a.id=k.avtor_id INNER JOIN zalozbe z ON z.id=k.zalozba_id INNER JOIN knjige_zbirke kz ON k.id = kz.knjiga_id INNER JOIN zbirke zb ON zb.id=kz.zbirka_id WHERE kz.zbirka_id = (SELECT id FROM zbirke WHERE ime = '" + naslov + "'); ";
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
                    adapter.Fill(table);
                    zbirkaDataGridView.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Napaka");
                }
            }



            db.CloseConnection();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();

            string knjiga = Convert.ToString(zbirkaDataGridView.Rows[zbirkaDataGridView.CurrentRow.Index].Cells[0].Value);


            MySqlCommand command = new MySqlCommand("DELETE FROM knjige_zbirke WHERE zbirka_id= (SELECT id FROM zbirke WHERE ime = '" + naslov + "') AND knjiga_id = (SELECT id FROM knjige WHERE naslov = '" + knjiga + "');", db.GetConnection());

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Uspešno si izbrisal knjigo iz svoje zbirke", "Knjiga izbrisana", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                string selectQuery = "SELECT k.naslov AS 'Naslov', k.opis AS 'Opis', k.strani AS 'Število strani', k.datum_izdaje as 'Datum izdaje', CONCAT(a.ime, ' ', a.priimek) AS 'Avtor', z.ime as 'Zalozba' FROM avtorji a INNER JOIN knjige k ON a.id=k.avtor_id INNER JOIN zalozbe z ON z.id=k.zalozba_id INNER JOIN knjige_zbirke kz ON k.id = kz.knjiga_id INNER JOIN zbirke zb ON zb.id=kz.zbirka_id WHERE kz.zbirka_id = (SELECT id FROM zbirke WHERE ime = '" + naslov + "'); ";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
                adapter.Fill(table);
                zbirkaDataGridView.DataSource = table;
            }
            else
            {
                MessageBox.Show("Napaka");
            }

            db.CloseConnection();
        }
    }
}
