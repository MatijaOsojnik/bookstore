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
    public partial class UporabnikPosodobi : Form
    {
        public UporabnikPosodobi()
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

                MySqlCommand command = new MySqlCommand("SELECT * FROM uporabniki WHERE id = " + idTextBox.Text + "", db.GetConnection());

                adapter.SelectCommand = command;

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    db.OpenConnection();
                    MySqlDataReader dr = command.ExecuteReader();

                    dr.Read();
                    nameTextBox.Text = dr.GetString(1);
                    priimekTextBox.Text = dr.GetString(2);
                    emailTextBox.Text = dr.GetString(3);
                    gesloTextBox.Text = dr.GetString(4);
                    krajTextBox.Text = dr.GetString(5);

                    db.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Uporabnik s takšnim ID-jem ne obstaja.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void posodobitevButton_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            MySqlCommand command = new MySqlCommand("UPDATE `uporabniki` SET `ime`=@ime, `priimek`=@priimek, `email`=@email, `geslo`=@geslo, `kraj`=@kraj WHERE `id`=@id;", db.GetConnection());

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = idTextBox.Text;
            command.Parameters.Add("@ime", MySqlDbType.VarChar).Value = nameTextBox.Text;
            command.Parameters.Add("@priimek", MySqlDbType.VarChar).Value = priimekTextBox.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailTextBox.Text;
            command.Parameters.Add("@geslo", MySqlDbType.VarChar).Value = gesloTextBox.Text;
            command.Parameters.Add("@kraj", MySqlDbType.VarChar).Value = krajTextBox.Text;


            db.OpenConnection();

            if (idTextBox.Text != "" && nameTextBox.Text != "" && priimekTextBox.Text != "" && emailTextBox.Text != "" && gesloTextBox.Text != "" && krajTextBox.Text != "")
            {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Uspešno si posodobil uporabnika", "Uporabnik posodobljen", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        nameTextBox.Text = ""; priimekTextBox.Text = ""; emailTextBox.Text = ""; gesloTextBox.Text = ""; krajTextBox.Text = ""; 
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
