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
    public partial class ZalozbaPosodobi : Form
    {
        public ZalozbaPosodobi()
        {
            InitializeComponent();
        }

        private void prikaziButton_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnect db = new DBConnect();


                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM zalozbe WHERE id = " + idTextBox.Text + "", db.GetConnection());

                adapter.SelectCommand = command;

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    db.OpenConnection();
                    MySqlDataReader dr = command.ExecuteReader();

                    dr.Read();

                    imeTextBox.Text = dr.GetString(1);
                    opisTextBox.Text = dr.GetString(2);

                    db.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Založba s takšnim ID-jem ne obstaja.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void posodobiButton_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            MySqlCommand command = new MySqlCommand("UPDATE `zalozbe` SET `ime`=@ime, `opis`=@opis WHERE `id` = @id;", db.GetConnection());

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = idTextBox.Text;
            command.Parameters.Add("@ime", MySqlDbType.VarChar).Value = imeTextBox.Text;
            command.Parameters.Add("@opis", MySqlDbType.VarChar).Value = opisTextBox.Text;

            db.OpenConnection();

            if (imeTextBox.Text != "" && opisTextBox.Text != "")
            {

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Uspešno si posodobil založbo", "Založba posodobljena", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    imeTextBox.Text = ""; opisTextBox.Text = "";
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
