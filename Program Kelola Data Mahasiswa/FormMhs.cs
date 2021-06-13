using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


// Nama : Juan Simon Damanik
// NIM : 8020190358
// Kelas : 02 PT 4 Pemrograman Visual

namespace Program_Kelola_Data_Mahasiswa
{
    public partial class FormMhs : Form
    {
        public FormMhs()
        {
            InitializeComponent();
        }

        // Function to Fetch Data \\
        void FetchData()
        {
            DB_Mahasiswa.tableMhs.Clear();
            DB_Mahasiswa.dataMhs.Fill(DB_Mahasiswa.tableMhs);
        }

        // Function to Clear Data from form \\
        void ClearData()
        {
            nimMhs.Clear();
            namaMhs.Clear();
            alamatMhs.Clear();

            nimMhs.Focus();
        }

        private void FormMhs_Load(object sender, EventArgs e)
        {

            this.KeyPreview = true;

            DB_Mahasiswa.connect = DB_Mahasiswa.Connect_DB();

            DB_Mahasiswa.dataMhs = new OleDbDataAdapter
                ("Select * from Mahasiswa", DB_Mahasiswa.connect);
            FetchData();

            dataGridView1.DataSource = DB_Mahasiswa.tableMhs;

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        // Save Button \\
        private void Save_Click(object sender, EventArgs e)
        {

            DB_Mahasiswa.command = new OleDbCommand("Select * from Mahasiswa where" +
                " nim='" + nimMhs.Text + "'", DB_Mahasiswa.connect);

            DB_Mahasiswa.read = DB_Mahasiswa.command.ExecuteReader();

            if (DB_Mahasiswa.read.HasRows)
            {
                MessageBox.Show("NIM " + nimMhs.Text + " telah terdaftarkan pada Database",
                    "Pesan Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nimMhs.Clear();
                nimMhs.Focus();
            }

            else if (nimMhs.Text.Trim() == "")
            {
                MessageBox.Show("NIM masih kosong silahkan isi terlebih dahulu", "Pesan Peringatan"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nimMhs.Clear();
                nimMhs.Focus();
            }

            else
            {
                // Add Confirm Option \\
                if (MessageBox.Show("Apakah anda yakin data dengan " +
                "NIM " + nimMhs.Text + " Akan disimpan?", "Pesan Konfirmasi",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    // Insert Data to Index \\
                    DB_Mahasiswa.command = new OleDbCommand
                        ("Insert into Mahasiswa (nim, nama, alamat) values" +
                        "('" + nimMhs.Text + "'," +
                        "'" + namaMhs.Text + "'," +
                        "'" + alamatMhs.Text + "')", DB_Mahasiswa.connect);

                    DB_Mahasiswa.command.ExecuteNonQuery();

                    MessageBox.Show("Data Mahasiswa " + namaMhs.Text + "" +
                        " telah berhasil disimpan ke dalam Database", "Pesan Pemberitahuan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Data Mahasiswa " + namaMhs.Text + " batal disimpan",
                    "Pesan Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                FetchData();
                ClearData();
            }

        }

        // Close Button \\
        private void Exit_Click(object sender, EventArgs e)
        {
            // Add Confirm Option \\
            if (MessageBox.Show("Apakah anda yakin untuk keluar dari aplikasi ?", "Pesan Konfirmasi",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Close();
            }
        }

        // Change button function from Enter to Tab \\
        private void FormMhs_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }

        }

        // Clear Button \\
        private void Clear_Click(object sender, EventArgs e)
        {

            int Table_Row;
            string Table_Code;
            string Table_Name;

            Table_Row = dataGridView1.CurrentRow.Index;
            Table_Code = dataGridView1[0, Table_Row].Value.ToString();
            Table_Name = dataGridView1[1, Table_Row].Value.ToString();

            // Add Confirm Option \\
            if (MessageBox.Show("Apakah anda yakin data dengan " +
                "NIM " + Table_Code + " Akan dihapus?", "Pesan Konfirmasi",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                DB_Mahasiswa.command = new OleDbCommand
                    ("Delete from Mahasiswa where nim = '" + Table_Code + "'", DB_Mahasiswa.connect);

                DB_Mahasiswa.command.ExecuteNonQuery();

                FetchData();

                MessageBox.Show("Data Mahasiswa " + Table_Name + " telah berhasil dihapus",
                    "Pesan Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearData();
            }

            else
            {

                MessageBox.Show("Data Mahasiswa " + Table_Name + " batal dihapus",
                    "Pesan Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Correction and Edit Button \\
        private void Correct_Click(object sender, EventArgs e)
        {

            if (correct.Text == "Koreksi")
            {
                correct.Text = "Simpan";

                // Disable Button while Correcting \\
                save.Enabled = false;
                clear.Enabled = false;
                nimMhs.Enabled = false;

                //  Show Data from Index \\
                int Table_Row;

                Table_Row = dataGridView1.CurrentRow.Index;
                nimMhs.Text = dataGridView1[0, Table_Row].Value.ToString();
                namaMhs.Text = dataGridView1[1, Table_Row].Value.ToString();
                alamatMhs.Text = dataGridView1[2, Table_Row].Value.ToString();
            }

            // Add Confirm Option \\
            else if (correct.Text == "Simpan")
            {
                correct.Text = "Koreksi";

                // Enable Button while Correcting \\
                save.Enabled = true;
                clear.Enabled = true;
                nimMhs.Enabled = true;

                if (MessageBox.Show("Apakah anda yakin mengubah data dengan " +
                "NIM " + nimMhs.Text + "?", "Pesan Konfirmasi",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    // Updata Data from Index \\
                    DB_Mahasiswa.command = new OleDbCommand
                        ("Update Mahasiswa set " +
                        "Nama = '" + namaMhs.Text + "', " +
                        "Alamat ='" + alamatMhs.Text + "'" + "where " +
                        "Nim ='" + nimMhs.Text + "'", DB_Mahasiswa.connect);

                    DB_Mahasiswa.command.ExecuteNonQuery();

                    MessageBox.Show("Data Mahasiswa " + namaMhs.Text + " berhasil diubah",
                    "Pesan Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Data Mahasiswa " + namaMhs.Text + " batal diubah",
                    "Pesan Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                FetchData();
                ClearData();
            }


        }

        // Search Option List \\
        private void Option_SelectedIndexChanged(object sender, EventArgs e)
        {
            search.Focus();
        }

        // Search Text Form \\
        private void Search_TextChanged(object sender, EventArgs e)
        {

            // Search Based on NIM \\
            if (Option.SelectedIndex == 0)
            {
                DB_Mahasiswa.dataMhs = new OleDbDataAdapter
                ("Select * from Mahasiswa where nim like" +
                " '%" + search.Text +"%'", DB_Mahasiswa.connect);
            }
            // Search Based on NAMA \\
            else if (Option.SelectedIndex == 1)
            {
                DB_Mahasiswa.dataMhs = new OleDbDataAdapter
                ("Select * from Mahasiswa where nama like" +
                " '%" + search.Text + "%'", DB_Mahasiswa.connect);
            }
            // Search Based on ALAMAT \\
            else if (Option.SelectedIndex == 2)
            {
                DB_Mahasiswa.dataMhs = new OleDbDataAdapter
                ("Select * from Mahasiswa where alamat like" +
                " '%" + search.Text + "%'", DB_Mahasiswa.connect);
            }
            FetchData();
        }

        // Cancel Button \\
        private void Cancel_Click(object sender, EventArgs e)
        {
            // For Cancel Searching Process \\
            Option.SelectedIndex = -1;
            search.Clear();

            DB_Mahasiswa.dataMhs = new OleDbDataAdapter
                ("Select * from Mahasiswa", DB_Mahasiswa.connect);
            FetchData();

            // For Cancel Editing Process \\
            if (correct.Text == "Simpan")
            {
                correct.Text = "Koreksi";
            }
            ClearData();
        }

        // Print Button \\
        private void Print_Click(object sender, EventArgs e)
        {
            // Using Crystal Report as Print Helper
            axCrystalReport1.ReportFileName = "Report_DBMhs.rpt";

            axCrystalReport1.DiscardSavedData = true;

            axCrystalReport1.WindowLeft = 0;
            axCrystalReport1.WindowTop = 0;

            axCrystalReport1.WindowWidth = 1000;
            axCrystalReport1.WindowHeight = 700;

            axCrystalReport1.Action = 1;
        }
    }
}
