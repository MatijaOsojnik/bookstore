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
    public partial class KnjigaPosodobi : Form
    {
        string ime, priimek;
        public KnjigaPosodobi()
        {
            InitializeComponent();
        }

        private void prikaziGumb_Click(object sender, EventArgs e)
        {
            try
            {
            DBConnect db = new DBConnect();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM knjige WHERE id = " + idTextBox.Text + "", db.GetConnection());


                adapter.SelectCommand = command;

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    db.OpenConnection();
                    MySqlDataReader dr = command.ExecuteReader();

                    dr.Read();
                    naslovTextBox.Text = dr.GetString(1);
                    opisTextBox.Text = dr.GetString(2);
                    straniTextBox.Text = dr.GetString(3);
                    avtorComboBox.SelectedItem = dr.GetString(4);
                    zalozbaComboBox.SelectedItem = dr.GetString(5);

                    db.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Knjiga s takšnim ID-jem ne obstaja.");
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
            MySqlCommand command = new MySqlCommand("UPDATE `knjige` SET `naslov`=@naslov, `opis`=@opis, `strani`=@strani, `datum_izdaje`=@datum, `avtor_id`=(SELECT id FROM avtorji WHERE ime='" + ime + "' AND priimek = '" + priimek + "'), `zalozba_id`=(SELECT id FROM zalozbe WHERE ime = @zalozba) WHERE `id` = @id ;", db.GetConnection());

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = idTextBox.Text;
            command.Parameters.Add("@naslov", MySqlDbType.VarChar).Value = naslovTextBox.Text;
            command.Parameters.Add("@opis", MySqlDbType.VarChar).Value = opisTextBox.Text;
            command.Parameters.Add("@strani", MySqlDbType.Int32).Value = straniTextBox.Text;
            command.Parameters.Add("@datum", MySqlDbType.VarChar).Value = datumIzdajeDatePicker.Text;
            command.Parameters.Add("@avtor", MySqlDbType.VarChar).Value = avtorComboBox.SelectedItem;
            command.Parameters.Add("@zalozba", MySqlDbType.VarChar).Value = zalozbaComboBox.SelectedItem;


            db.OpenConnection();

            if (idTextBox.Text != "" && naslovTextBox.Text != "" && opisTextBox.Text != "" && straniTextBox.Text != "" && datumIzdajeDatePicker.Text != "" && avtorComboBox.SelectedItem != null && zalozbaComboBox.SelectedItem != null)
            {
                int num = -1;
                if (!int.TryParse(straniTextBox.Text, out num) && !int.TryParse(idTextBox.Text, out num))
                {
                    MessageBox.Show("Prosim vnesi število", "Type napaka", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Uspešno si posodobil knjigo", "Knjiga posodobljena", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        naslovTextBox.Text = ""; opisTextBox.Text = ""; straniTextBox.Text = ""; datumIzdajeDatePicker.Text = ""; avtorComboBox.SelectedItem = null; zalozbaComboBox.SelectedItem = null;
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

        private void adminUpdate_Load(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `avtorji`", db.GetConnection());

            db.OpenConnection();

            MySqlDataReader reader1 = command1.ExecuteReader();

            while (reader1.Read())
            {
                ime = reader1.GetString("ime");
                priimek = reader1.GetString("priimek");
                avtorComboBox.Items.Add(ime + " " + priimek);
            }

            db.CloseConnection();

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `zalozbe`", db.GetConnection());

            db.OpenConnection();

            MySqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                zalozbaComboBox.Items.Add(reader2.GetString("ime"));

            }

            db.CloseConnection();
        }

        private void mainLinkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
