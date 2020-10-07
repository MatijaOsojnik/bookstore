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
    public partial class KnjigaVnos : Form
    {
        string ime, priimek;
        public KnjigaVnos()
        {
            InitializeComponent();
        }

        private void adminInsert_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookstoreUserData.uporabniki' table. You can move, or remove it, as needed.
            this.uporabnikiTableAdapter.Fill(this.bookstoreUserData.uporabniki);

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

        private void registracijaButton_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            MySqlCommand command = new MySqlCommand("INSERT INTO `knjige`(`naslov`, `opis`, `strani`, `datum_izdaje`, `avtor_id`, `zalozba_id`) VALUES (@naslov, @opis, @strani, @datum, (SELECT id FROM avtorji WHERE ime='" + ime + "' AND priimek = '" + priimek + "'),  (SELECT id FROM zalozbe WHERE ime = @zalozba))", db.GetConnection());

            command.Parameters.Add("@naslov", MySqlDbType.VarChar).Value = naslovTextBox.Text;
            command.Parameters.Add("@opis", MySqlDbType.VarChar).Value = opisTextBox.Text;
            command.Parameters.Add("@strani", MySqlDbType.Int32).Value = straniTextBox.Text;
            command.Parameters.Add("@datum", MySqlDbType.VarChar).Value = datumIzdajeDatePicker.Text;
            command.Parameters.Add("@avtor", MySqlDbType.VarChar).Value = avtorComboBox.SelectedItem;
            command.Parameters.Add("@zalozba", MySqlDbType.VarChar).Value = zalozbaComboBox.SelectedItem;

            db.OpenConnection();

            if (naslovTextBox.Text != "" && opisTextBox.Text != "" && straniTextBox.Text != "" && datumIzdajeDatePicker.Text != "" && avtorComboBox.SelectedItem != null && zalozbaComboBox.SelectedItem != null)
            {
                int num = -1;
                if(!int.TryParse(straniTextBox.Text, out num) )
                {
                    MessageBox.Show("Prosim vnesi število", "Type napaka",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Uspešno si vnesel novo knjigo", "Knjiga ustvarjena", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        naslovTextBox.Text = ""; opisTextBox.Text = ""; straniTextBox.Text = ""; datumIzdajeDatePicker.Text = "";  avtorComboBox.SelectedItem = null; zalozbaComboBox.SelectedItem = null;
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
