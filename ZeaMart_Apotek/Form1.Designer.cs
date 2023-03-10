namespace ZeaMart_Apotek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgv_apotek = new DataGridView();
            textBoxNama = new TextBox();
            namaObat = new Label();
            jenisObat = new Label();
            textBoxJenis = new TextBox();
            kedaluwarsa = new Label();
            textBoxKedaluwarsa = new TextBox();
            stokObat = new Label();
            textBoxStok = new TextBox();
            harga = new Label();
            textBoxHarga = new TextBox();
            buttonTambah = new Button();
            buttonEdit = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_apotek).BeginInit();
            SuspendLayout();
            // 
            // dgv_apotek
            // 
            dgv_apotek.BackgroundColor = SystemColors.ControlLightLight;
            dgv_apotek.BorderStyle = BorderStyle.Fixed3D;
            dgv_apotek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_apotek.Location = new Point(363, 140);
            dgv_apotek.Name = "dgv_apotek";
            dgv_apotek.RowHeadersWidth = 62;
            dgv_apotek.RowTemplate.Height = 33;
            dgv_apotek.Size = new Size(803, 520);
            dgv_apotek.TabIndex = 0;
            dgv_apotek.CellClick += dgv_apotek_CellClick;
            dgv_apotek.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBoxNama
            // 
            textBoxNama.BorderStyle = BorderStyle.FixedSingle;
            textBoxNama.Location = new Point(22, 247);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(311, 31);
            textBoxNama.TabIndex = 1;
            textBoxNama.TextChanged += textBox1_TextChanged;
            // 
            // namaObat
            // 
            namaObat.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            namaObat.Location = new Point(25, 220);
            namaObat.Name = "namaObat";
            namaObat.Size = new Size(109, 25);
            namaObat.TabIndex = 2;
            namaObat.Text = "Nama Obat ";
            namaObat.Click += label1_Click;
            // 
            // jenisObat
            // 
            jenisObat.AutoSize = true;
            jenisObat.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            jenisObat.Location = new Point(27, 293);
            jenisObat.Name = "jenisObat";
            jenisObat.Size = new Size(98, 21);
            jenisObat.TabIndex = 4;
            jenisObat.Text = "Jenis Obat ";
            jenisObat.Click += label2_Click;
            // 
            // textBoxJenis
            // 
            textBoxJenis.BorderStyle = BorderStyle.FixedSingle;
            textBoxJenis.Location = new Point(22, 318);
            textBoxJenis.Name = "textBoxJenis";
            textBoxJenis.Size = new Size(311, 31);
            textBoxJenis.TabIndex = 3;
            textBoxJenis.TextChanged += textBox1_TextChanged_1;
            // 
            // kedaluwarsa
            // 
            kedaluwarsa.AutoSize = true;
            kedaluwarsa.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kedaluwarsa.Location = new Point(27, 366);
            kedaluwarsa.Name = "kedaluwarsa";
            kedaluwarsa.Size = new Size(111, 21);
            kedaluwarsa.TabIndex = 6;
            kedaluwarsa.Text = "Kedaluwarsa";
            kedaluwarsa.Click += label1_Click_1;
            // 
            // textBoxKedaluwarsa
            // 
            textBoxKedaluwarsa.BorderStyle = BorderStyle.FixedSingle;
            textBoxKedaluwarsa.Location = new Point(22, 390);
            textBoxKedaluwarsa.Name = "textBoxKedaluwarsa";
            textBoxKedaluwarsa.Size = new Size(311, 31);
            textBoxKedaluwarsa.TabIndex = 5;
            textBoxKedaluwarsa.TextChanged += textBox1_TextChanged_2;
            // 
            // stokObat
            // 
            stokObat.AutoSize = true;
            stokObat.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            stokObat.Location = new Point(26, 439);
            stokObat.Name = "stokObat";
            stokObat.Size = new Size(90, 21);
            stokObat.TabIndex = 8;
            stokObat.Text = "Stok Obat";
            stokObat.Click += label2_Click_1;
            // 
            // textBoxStok
            // 
            textBoxStok.BorderStyle = BorderStyle.FixedSingle;
            textBoxStok.Location = new Point(22, 465);
            textBoxStok.Name = "textBoxStok";
            textBoxStok.Size = new Size(311, 31);
            textBoxStok.TabIndex = 7;
            textBoxStok.TextChanged += textBoxStok_TextChanged;
            // 
            // harga
            // 
            harga.AutoSize = true;
            harga.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            harga.Location = new Point(26, 512);
            harga.Name = "harga";
            harga.Size = new Size(59, 21);
            harga.TabIndex = 10;
            harga.Text = "Harga";
            // 
            // textBoxHarga
            // 
            textBoxHarga.BorderStyle = BorderStyle.FixedSingle;
            textBoxHarga.Location = new Point(22, 537);
            textBoxHarga.Name = "textBoxHarga";
            textBoxHarga.Size = new Size(311, 31);
            textBoxHarga.TabIndex = 9;
            // 
            // buttonTambah
            // 
            buttonTambah.BackColor = Color.SlateBlue;
            buttonTambah.FlatStyle = FlatStyle.Popup;
            buttonTambah.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTambah.ForeColor = SystemColors.ControlLightLight;
            buttonTambah.Location = new Point(22, 590);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(140, 46);
            buttonTambah.TabIndex = 11;
            buttonTambah.Text = "Tambah";
            buttonTambah.UseVisualStyleBackColor = false;
            buttonTambah.Click += button1_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.SlateBlue;
            buttonEdit.FlatStyle = FlatStyle.Popup;
            buttonEdit.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.ForeColor = SystemColors.ControlLightLight;
            buttonEdit.Location = new Point(190, 590);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(140, 46);
            buttonEdit.TabIndex = 12;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // textBox1
            // 
            textBox1.AutoCompleteMode = AutoCompleteMode.Append;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(25, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 31);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox_id;
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 145);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 16;
            label2.Text = "Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(46, 16);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 17;
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(27, 31);
            label3.Name = "label3";
            label3.Size = new Size(286, 94);
            label3.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(499, 84);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(667, 40);
            textBox2.TabIndex = 19;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(363, 94);
            label4.Name = "label4";
            label4.Size = new Size(130, 21);
            label4.TabIndex = 20;
            label4.Text = "Search Data :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1178, 681);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(buttonEdit);
            Controls.Add(buttonTambah);
            Controls.Add(harga);
            Controls.Add(textBoxHarga);
            Controls.Add(stokObat);
            Controls.Add(textBoxStok);
            Controls.Add(kedaluwarsa);
            Controls.Add(textBoxKedaluwarsa);
            Controls.Add(jenisObat);
            Controls.Add(textBoxJenis);
            Controls.Add(namaObat);
            Controls.Add(textBoxNama);
            Controls.Add(dgv_apotek);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_apotek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_apotek;
        private TextBox textBoxNama;
        private Label namaObat;
        private Label jenisObat;
        private TextBox textBoxJenis;
        private Label kedaluwarsa;
        private TextBox textBoxKedaluwarsa;
        private Label stokObat;
        private TextBox textBoxStok;
        private Label harga;
        private TextBox textBoxHarga;
        private Button buttonTambah;
        private Button buttonEdit;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
    }
}