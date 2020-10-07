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
    public partial class AvtorPosodobi : Form
    {
        public AvtorPosodobi()
        {
            InitializeComponent();
        }

        private void posodobiButton_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            MySqlCommand command = new MySqlCommand("UPDATE `avtorji` SET `ime`=@ime, `priimek`=@priimek WHERE `id` = @id;", db.GetConnection());

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = idTextBox.Text;
            command.Parameters.Add("@ime", MySqlDbType.VarChar).Value = imeTextBox.Text;
            command.Parameters.Add("@priimek", MySqlDbType.VarChar).Value = priimekTextBox.Text;

            db.OpenConnection();

            if (imeTextBox.Text != "" && priimekTextBox.Text != "")
            {

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Uspešno si posodobil avtorja", "Avtor posodobljen", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    imeTextBox.Text = ""; priimekTextBox.Text = "";
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

        private void prikaziButton_Click(object sender, EventArgs e)
        {
            try
            {
            DBConnect db = new DBConnect();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();


                MySqlCommand command = new MySqlCommand("SELECT * FROM avtorji WHERE id = " + idTextBox.Text + "", db.GetConnection()); ;

                adapter.SelectCommand = command;

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    db.OpenConnection();
                    MySqlDataReader dr = command.ExecuteReader();

                    dr.Read();
                    imeTextBox.Text = dr.GetString(1);
                    priimekTextBox.Text = dr.GetString(2);

                    db.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Avtor s takšnim ID-jem ne obstaja.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void mainLinkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
