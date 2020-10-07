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
    public partial class ZalozbaVnos : Form
    {
        public ZalozbaVnos()
        {
            InitializeComponent();
        }

        public Boolean checkZalozba()
        {
            DBConnect db = new DBConnect();

            string ime = imeTextBox.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM zalozbe WHERE ime = @ime", db.GetConnection());

            command.Parameters.Add("@ime", MySqlDbType.VarChar).Value = ime;

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

        private void zalozbaButton_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            MySqlCommand command = new MySqlCommand("INSERT INTO `zalozbe`(`ime`, `opis`) VALUES (@ime, @opis)", db.GetConnection());

            command.Parameters.Add("@ime", MySqlDbType.VarChar).Value = imeTextBox.Text;
            command.Parameters.Add("@opis", MySqlDbType.VarChar).Value = opisTextBox.Text;

            db.OpenConnection();

            if (imeTextBox.Text != "" && opisTextBox.Text != "")
            {
                if (checkZalozba())
                {
                    MessageBox.Show("Ta založba že obstaja", "Enaka založba", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Uspešno si vnesel novo založbo", "Založba ustvarjena", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void mainLinkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
