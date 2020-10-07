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
    public partial class ZbirkaPosodobi : Form
    {
        int userId;
        string zbirkaIme;
        public ZbirkaPosodobi(string selectedItem, int id)
        {
            InitializeComponent();
            userId = id;
            zbirkaIme = selectedItem;
        }

        private void ZbirkaPosodobi_Load(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `zbirke` WHERE ime = '" + zbirkaIme + "'", db.GetConnection());

            db.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                imeTextBox.Text = reader.GetString("ime");
                opisTextBox.Text = reader.GetString("opis");
            }

            db.CloseConnection();
        }

        private void posodobiButton_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            MySqlCommand command = new MySqlCommand("UPDATE `zbirke` SET `ime` = @ime, `opis` = @opis, `uporabnik_id` = " + userId + "", db.GetConnection());

            command.Parameters.Add("@ime", MySqlDbType.VarChar).Value = imeTextBox.Text;
            command.Parameters.Add("@opis", MySqlDbType.VarChar).Value = opisTextBox.Text;

            db.OpenConnection();

            if (imeTextBox.Text != "" && opisTextBox.Text != "")
            {

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Uspešno si posodobil zbirko", "Zbirka posodobljena", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Napaka");
                }
            }
            else
            {
                MessageBox.Show("Prosim izpolni vsa polja.");
            }
            db.CloseConnection();
        }

        private void mainLinkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
