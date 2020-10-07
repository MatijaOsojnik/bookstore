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
    public partial class AvtorVnos : Form
    {
        public AvtorVnos()
        {
            InitializeComponent();
        }

        public Boolean checkAvtor()
        {
            DBConnect db = new DBConnect();

            string ime = imeTextBox.Text;
            string priimek = priimekTextBox.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM avtorji WHERE ime = @ime AND priimek = @priimek", db.GetConnection());

            command.Parameters.Add("@ime", MySqlDbType.VarChar).Value = ime;
            command.Parameters.Add("@priimek", MySqlDbType.VarChar).Value = priimek;


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

        private void registracijaButton_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            MySqlCommand command = new MySqlCommand("INSERT INTO `avtorji`(`ime`, `priimek`) VALUES (@ime, @priimek)", db.GetConnection());

            command.Parameters.Add("@ime", MySqlDbType.VarChar).Value = imeTextBox.Text;
            command.Parameters.Add("@priimek", MySqlDbType.VarChar).Value = priimekTextBox.Text;

            db.OpenConnection();

            if (imeTextBox.Text != "" && priimekTextBox.Text != "" )
            {
                if (checkAvtor())
                {
                    MessageBox.Show("Ta avtor že obstaja", "Enak avtor", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Uspešno si dodal novega avtorja", "Avtor ustvarjen", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        imeTextBox.Text = ""; priimekTextBox.Text = ""; 
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

        private void mainLinkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
