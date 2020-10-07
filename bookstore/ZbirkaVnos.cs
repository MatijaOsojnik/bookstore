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
    public partial class ZbirkaVnos : Form
    {
        int userId;
        public ZbirkaVnos(int id)
        {
            InitializeComponent();
            userId = id;
        }

        private void mainLinkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Boolean checkZbirka()
        {
            DBConnect db = new DBConnect();

            String imeZbirke = imeTextBox.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `zbirke` WHERE `ime` = @imeZbirke", db.GetConnection());

            command.Parameters.Add("@imeZbirke", MySqlDbType.VarChar).Value = imeZbirke;

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

        private void dodajButton_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            MySqlCommand command = new MySqlCommand("INSERT INTO `zbirke`(`ime`, `opis`, `uporabnik_id`) VALUES (@ime, @opis, " + userId + ")", db.GetConnection());

            command.Parameters.Add("@ime", MySqlDbType.VarChar).Value = imeTextBox.Text;
            command.Parameters.Add("@opis", MySqlDbType.VarChar).Value = opisTextBox.Text;

            db.OpenConnection();

            if (imeTextBox.Text != "" && opisTextBox.Text != "")
            {
                if (checkZbirka())
                {
                    MessageBox.Show("Zbirka s takšnim imenom že obstaja, izberi drugo ime", "Enaka zbirka", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Uspešno si dodal novo zbirko", "Zbirka ustvarjena", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    imeTextBox.Text = ""; opisTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Napaka");
                }
                }
            }
            else
            {
                MessageBox.Show("Prosim izpolni vsa polja.");
            }
            db.CloseConnection();
        }
    }
}
