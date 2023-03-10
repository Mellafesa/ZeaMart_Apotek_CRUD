using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ZeaMart_Apotek
{
    public partial class Form1 : Form
    {
        MySqlConnection koneksi = connections.getConnection();
        DataTable dataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //perintah reset increment 
        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @id := 0; UPDATE daftar_barang SET id = @id := (@id+1); " +
                    "ALTER TABLE daftar_barang AUTO_INCREMENT = 1;");
            script.Execute();
        }


        
        //menampilkan data barang, supaya datanya bisa tampil di form 1
        public DataTable getDataBarang()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM daftar_barang", koneksi))
            {
                koneksi.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;
        }

        public void filldataTable()
        {
            //menampilkan data barang ke datagridview
            dgv_apotek.DataSource = getDataBarang();

            //perintah edit data di dalam dgv
            DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn();
            colEdit.UseColumnTextForButtonValue = true;
            colEdit.Text = "Edit";
            colEdit.Name = "";
            dgv_apotek.Columns.Add(colEdit);

            //perintah hapus data di dalam dgv
            DataGridViewButtonColumn colDelete = new DataGridViewButtonColumn();
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Text = "Delete";
            colDelete.Name = "";
            dgv_apotek.Columns.Add(colDelete);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
        }

        private void textBoxStok_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        //menambah data
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            //panggil reset increment
            resetIncrement();
            //conn.Open();
            try
            {
                //perintah tambah data
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "INSERT INTO daftar_barang(nama_obat,jenis_obat,kedaluwarsa,stok_obat,harga) VALUE(@nama_obat,@jenis_obat,@kedaluwarsa,@stok_obat,@harga)";
                cmd.Parameters.AddWithValue("@nama_obat", textBoxNama.Text);
                cmd.Parameters.AddWithValue("@jenis_obat", textBoxJenis.Text);
                cmd.Parameters.AddWithValue("@kedaluwarsa", textBoxKedaluwarsa.Text);
                cmd.Parameters.AddWithValue("@stok_obat", textBoxStok.Text);
                cmd.Parameters.AddWithValue("@harga", textBoxHarga.Text);
                cmd.ExecuteNonQuery();
                //long id = cmd.LastInsertedId;
                koneksi.Close();

                dgv_apotek.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }

            catch (Exception ex)
            {

            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }



        private void buttonHapus_Click(object sender, EventArgs e)
        {

        }

        //aksi setelah button edit yang di dalam dg di klik -> data akan masuk ke form dan siap untuk di edit
        private void dgv_apotek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int id = Convert.ToInt32(dgv_apotek.CurrentCell.RowIndex.ToString());
                textBox1.Text = dgv_apotek.Rows[id].Cells[0].Value.ToString();
                textBoxNama.Text = dgv_apotek.Rows[id].Cells[1].Value.ToString();
                textBoxJenis.Text = dgv_apotek.Rows[id].Cells[2].Value.ToString();
                textBoxKedaluwarsa.Text = dgv_apotek.Rows[id].Cells[3].Value.ToString();
                textBoxStok.Text = dgv_apotek.Rows[id].Cells[4].Value.ToString();
                textBoxHarga.Text = dgv_apotek.Rows[id].Cells[5].Value.ToString();

                textBoxNama.Enabled = true;
                textBoxJenis.Enabled = true;
                textBoxKedaluwarsa.Enabled = true;
                textBoxStok.Enabled = true;
                textBoxHarga.Enabled = true;
            }
            if (e.ColumnIndex == 7)
            {
                int id = Convert.ToInt32(dgv_apotek.CurrentCell.RowIndex.ToString());

                MySqlCommand cmd;

                try
                {

                    cmd = koneksi.CreateCommand();
                    cmd.CommandText = "DELETE FROM daftar_barang WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", dgv_apotek.Rows[id].Cells[0].Value.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data obat berhasil dihapus!");
                    resetIncrement();
                    koneksi.Close();

                    dgv_apotek.Columns.Clear();
                    dataTable.Clear();
                    filldataTable();

                }
                catch (Exception ex)
                {

                }

            }
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "UPDATE daftar_barang SET nama_obat = @nama_obat, jenis_obat = @jenis_obat, kedaluwarsa = @kedaluwarsa, stok_obat = @stok_obat, harga = @harga WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@nama_obat", textBoxNama.Text);
                cmd.Parameters.AddWithValue("@jenis_obat", textBoxJenis.Text);
                cmd.Parameters.AddWithValue("@kedaluwarsa", textBoxKedaluwarsa.Text);
                cmd.Parameters.AddWithValue("@stok_obat", textBoxStok.Text);
                cmd.Parameters.AddWithValue("@harga", textBoxHarga.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data obat berhasil diubah!");
                koneksi.Close();

                dgv_apotek.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }

            catch
            {

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {
        }

        private void textBox_id(object sender, EventArgs e)
        {

        }

        private void textBox_nama(object sender, EventArgs e)
        {

        }

        private void textBox_jenis(object sender, EventArgs e)
        {

        }

        private void textBox_keda(object sender, EventArgs e)
        {

        }

        private void textBox_stok(object sender, EventArgs e)
        {

        }

        private void textBox_harga(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        public void searchData(string ValueToFind)
        {
            string searchQuery = "SELECT * FROM daftar_barang WHERE CONCAT(nama_obat,jenis_obat,kedaluwarsa,stok_obat,harga) LIKE '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, koneksi);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv_apotek.DataSource = table;
        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            searchData(textBox2.Text);
        }


    }
}