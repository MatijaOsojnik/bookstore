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

    public partial class Main : Form
    {

        public Login login;
        public Main(string ime, string priimek, int id)
        {
            InitializeComponent();
            userNameLabel.Text = ime + " " + priimek;
        }
        MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=bookstore;UID=root;PASSWORD=Crypto66_792;");

        private void Main_Load(object sender, EventArgs e)

        {
            string selectQuery = "SELECT * FROM uporabniki";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridViewMain.DataSource = table;

            izbiraComboBox.SelectedIndex = 0;
        }

        private void oNasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informacije info = new Informacije();
            info.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (izbiraComboBox.SelectedIndex == 0)
            {
                UporabnikVnos uporabnikVnosForm = new UporabnikVnos();
                uporabnikVnosForm.ShowDialog();
            }
            else if (izbiraComboBox.SelectedIndex == 1)
            {
                KnjigaVnos adminInsertForm = new KnjigaVnos();
                adminInsertForm.ShowDialog();
            }
            else if (izbiraComboBox.SelectedIndex == 2)
            {
                AvtorVnos avtorVnosForm = new AvtorVnos();
                avtorVnosForm.ShowDialog();
            }
            else if (izbiraComboBox.SelectedIndex == 3)
            {
                ZalozbaVnos zalozbaVnosForm = new ZalozbaVnos();
                zalozbaVnosForm.ShowDialog();
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (izbiraComboBox.SelectedIndex == 0)
            {
                string selectQuery1 = "SELECT * FROM uporabniki";
                DataTable table1 = new DataTable();
                MySqlDataAdapter adapter1 = new MySqlDataAdapter(selectQuery1, connection);
                adapter1.Fill(table1);
                dataGridViewMain.DataSource = table1;



                int id = Convert.ToInt32(dataGridViewMain.Rows[dataGridViewMain.CurrentRow.Index].Cells["id"].Value);
            }
            else if (izbiraComboBox.SelectedIndex == 1)
            {
                string selectQuery2 = "SELECT k.id AS ID, k.naslov AS 'Naslov', k.opis AS 'Opis', k.strani AS 'Število strani', k.datum_izdaje as 'Datum izdaje', CONCAT(a.ime, ' ', a.priimek) AS 'Avtor', z.ime as 'Zalozba' FROM avtorji a INNER JOIN knjige k ON a.id = k.avtor_id  INNER JOIN zalozbe z ON z.id = k.zalozba_id";
                DataTable table2 = new DataTable();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(selectQuery2, connection);
                adapter2.Fill(table2);
                dataGridViewMain.DataSource = table2;

                int id = Convert.ToInt32(dataGridViewMain.Rows[dataGridViewMain.CurrentRow.Index].Cells["id"].Value);

            }
            else if (izbiraComboBox.SelectedIndex == 2)
            {
                string selectQuery3 = "SELECT * FROM avtorji";
                DataTable table3 = new DataTable();
                MySqlDataAdapter adapter3 = new MySqlDataAdapter(selectQuery3, connection);
                adapter3.Fill(table3);
                dataGridViewMain.DataSource = table3;

                int id = Convert.ToInt32(dataGridViewMain.Rows[dataGridViewMain.CurrentRow.Index].Cells["id"].Value);

            }
            else if (izbiraComboBox.SelectedIndex == 3)
            {
                string selectQuery4 = "SELECT * FROM zalozbe";
                DataTable table4 = new DataTable();
                MySqlDataAdapter adapter4 = new MySqlDataAdapter(selectQuery4, connection);
                adapter4.Fill(table4);
                dataGridViewMain.DataSource = table4;
                
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (izbiraComboBox.SelectedIndex == 0)
            {
                UporabnikPosodobi uporabnikPosodobiForm = new UporabnikPosodobi();
                uporabnikPosodobiForm.ShowDialog();
            }
            if (izbiraComboBox.SelectedIndex == 1)
            {
                KnjigaPosodobi adminUpdateForm = new KnjigaPosodobi();
                adminUpdateForm.ShowDialog();
            }
            else if (izbiraComboBox.SelectedIndex == 2)
            {
                AvtorPosodobi avtorPosodobiForm = new AvtorPosodobi();
                avtorPosodobiForm.ShowDialog();
            }
            else if (izbiraComboBox.SelectedIndex == 3)
            {
                ZalozbaPosodobi zalozbaPosodobiForm = new ZalozbaPosodobi();
                zalozbaPosodobiForm.ShowDialog();
            }
        }

        private void knjigaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            KnjigaVnos adminInsertForm = new KnjigaVnos();
            adminInsertForm.ShowDialog();
        }

        private void avtorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvtorVnos avtorVnosForm = new AvtorVnos();
            avtorVnosForm.ShowDialog();
        }

        private void zalozbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZalozbaVnos zalozbaVnosForm = new ZalozbaVnos();
            zalozbaVnosForm.ShowDialog();
        }
        private void uporabnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UporabnikVnos uporabnikVnosForm = new UporabnikVnos();
            uporabnikVnosForm.ShowDialog();
        }

        private void knjigaUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KnjigaPosodobi adminUpdateForm = new KnjigaPosodobi();
            adminUpdateForm.ShowDialog();
        }
        private void avtorUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvtorPosodobi avtorPosodobiForm = new AvtorPosodobi();
            avtorPosodobiForm.ShowDialog();
        }

        private void zalozbaUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZalozbaPosodobi zalozbaPosodobiForm = new ZalozbaPosodobi();
            zalozbaPosodobiForm.ShowDialog();
        }

        private void uporabnikUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UporabnikPosodobi uporabnikPosodobiForm = new UporabnikPosodobi();
            uporabnikPosodobiForm.ShowDialog();
        }

        private void IzpisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void ZapriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (izbiraComboBox.SelectedIndex == 0)
            {
                DBConnect db = new DBConnect();

                int id = Convert.ToInt32(dataGridViewMain.Rows[dataGridViewMain.CurrentRow.Index].Cells[0].Value);


                MySqlCommand command = new MySqlCommand("DELETE FROM uporabniki WHERE `id`=" + id + ";", db.GetConnection());

                db.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Uspešno si izbrisal uporabnika", "Uporabnik izbrisan", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    searchButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Napaka");
                }

                db.CloseConnection();
            }
            else if(izbiraComboBox.SelectedIndex == 1)
            {
                DBConnect db = new DBConnect();

                int id = Convert.ToInt32(dataGridViewMain.Rows[dataGridViewMain.CurrentRow.Index].Cells[0].Value);


                MySqlCommand command = new MySqlCommand("DELETE FROM knjige WHERE `id`=" + id + ";", db.GetConnection());

                db.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Uspešno si izbrisal knjigo", "Knjiga izbrisana", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    searchButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Napaka");
                }

                db.CloseConnection();
            }
            else if (izbiraComboBox.SelectedIndex == 2)
            {
                DBConnect db = new DBConnect();

                int id = Convert.ToInt32(dataGridViewMain.Rows[dataGridViewMain.CurrentRow.Index].Cells[0].Value);


                MySqlCommand command = new MySqlCommand("DELETE FROM avtorji WHERE `id`=" + id + ";", db.GetConnection());

                db.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Uspešno si izbrisal avtorja", "Avtor izbrisan", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    searchButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Napaka");
                }

                db.CloseConnection();
            }
            else if (izbiraComboBox.SelectedIndex == 3)
            {
                DBConnect db = new DBConnect();

                int id = Convert.ToInt32(dataGridViewMain.Rows[dataGridViewMain.CurrentRow.Index].Cells[0].Value);


                MySqlCommand command = new MySqlCommand("DELETE FROM zalozbe WHERE `id`=" + id + ";", db.GetConnection());

                db.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Uspešno si izbrisal zalozbo", "Zalozba izbrisana", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    searchButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Napaka");
                }

                db.CloseConnection();
            }
        }

        private void licencaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pravilnik pravilnik = new Pravilnik();
            pravilnik.ShowDialog();
        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
