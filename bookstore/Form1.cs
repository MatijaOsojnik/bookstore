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
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }



        private void PrijavaLinkButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.Show();
        }


        public Boolean checkEmail()
        {
            DBConnect db = new DBConnect();

            String email = emailTextBox.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `uporabniki` WHERE `email` = @email", db.GetConnection());

            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;

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
            MySqlCommand command = new MySqlCommand("INSERT INTO `uporabniki`(`ime`, `priimek`, `email`, `geslo`, `datum_reg`, `kraj`) VALUES (@ime, @priimek, @email, @geslo, current_timestamp(),  @kraj)", db.GetConnection());

            command.Parameters.Add("@ime", MySqlDbType.VarChar).Value = nameTextBox.Text;
            command.Parameters.Add("@priimek", MySqlDbType.VarChar).Value = priimekTextBox.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailTextBox.Text;
            command.Parameters.Add("@geslo", MySqlDbType.VarChar).Value = gesloTextBox.Text;
            command.Parameters.Add("@kraj", MySqlDbType.VarChar).Value = krajTextBox.Text;

            db.OpenConnection();

            if (emailTextBox.Text != "" || gesloTextBox.Text != "" || nameTextBox.Text != "" || priimekTextBox.Text != "" || krajTextBox.Text != "")
            {
                if (gesloTextBox.Text != potrdiGesloTextBox.Text)
                {
                    MessageBox.Show("Gesli se ne ujemata.", "Napačno geslo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (checkEmail())
                {
                    MessageBox.Show("Ta uporabnik že obstaja, vnesi drug email", "Enak email", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Uspešno si se registriral", "Račun ustvarjen", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Napaka");
                    }
                }

            }
            else
            {
                MessageBox.Show("Prosim vnesi zahtevana polja.");
            }
            db.CloseConnection();
        }
    }
}

