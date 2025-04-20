namespace Aplikasi_Sewa_Baju_Adat
{
    partial class Main_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Page));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.opsibajuadat = new System.Windows.Forms.ComboBox();
            this.ukuran = new System.Windows.Forms.ComboBox();
            this.konfirmasibayar = new System.Windows.Forms.ComboBox();
            this.pengiriman = new System.Windows.Forms.ComboBox();
            this.tanggal = new System.Windows.Forms.DateTimePicker();
            this.Harga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.alamat = new System.Windows.Forms.TextBox();
            this.totalharga = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.namapenyewa = new System.Windows.Forms.TextBox();
            this.Jumlah = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Button();
            this.keluar = new System.Windows.Forms.Button();
            this.Hapus = new System.Windows.Forms.Button();
            this.cetak = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.jumlahbarang = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.metodepembayaran = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "APLIKASI SEWA BAJU ADAT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BAJU ADAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "UKURAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TANGGAL SEWA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "KONFIRMASI PEMBAYARAN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "PILIHAN PENGIRIMAN";
            // 
            // opsibajuadat
            // 
            this.opsibajuadat.FormattingEnabled = true;
            this.opsibajuadat.Location = new System.Drawing.Point(192, 142);
            this.opsibajuadat.Name = "opsibajuadat";
            this.opsibajuadat.Size = new System.Drawing.Size(121, 21);
            this.opsibajuadat.TabIndex = 6;
            this.opsibajuadat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ukuran
            // 
            this.ukuran.FormattingEnabled = true;
            this.ukuran.Location = new System.Drawing.Point(192, 184);
            this.ukuran.Name = "ukuran";
            this.ukuran.Size = new System.Drawing.Size(121, 21);
            this.ukuran.TabIndex = 7;
            // 
            // konfirmasibayar
            // 
            this.konfirmasibayar.FormattingEnabled = true;
            this.konfirmasibayar.Location = new System.Drawing.Point(579, 337);
            this.konfirmasibayar.Name = "konfirmasibayar";
            this.konfirmasibayar.Size = new System.Drawing.Size(137, 21);
            this.konfirmasibayar.TabIndex = 8;
            // 
            // pengiriman
            // 
            this.pengiriman.FormattingEnabled = true;
            this.pengiriman.Location = new System.Drawing.Point(192, 353);
            this.pengiriman.Name = "pengiriman";
            this.pengiriman.Size = new System.Drawing.Size(121, 21);
            this.pengiriman.TabIndex = 9;
            // 
            // tanggal
            // 
            this.tanggal.Location = new System.Drawing.Point(192, 225);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(121, 20);
            this.tanggal.TabIndex = 10;
            // 
            // Harga
            // 
            this.Harga.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Harga.Location = new System.Drawing.Point(330, 142);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(90, 20);
            this.Harga.TabIndex = 11;
            this.Harga.Text = "Harga";
            this.Harga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "ALAMAT";
            // 
            // alamat
            // 
            this.alamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alamat.Location = new System.Drawing.Point(192, 395);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(121, 20);
            this.alamat.TabIndex = 13;
            // 
            // totalharga
            // 
            this.totalharga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalharga.Location = new System.Drawing.Point(579, 270);
            this.totalharga.Name = "totalharga";
            this.totalharga.Size = new System.Drawing.Size(137, 20);
            this.totalharga.TabIndex = 14;
            this.totalharga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(420, 272);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "TOTAL PEMBAYARAN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "NAMA PENYEWA";
            // 
            // namapenyewa
            // 
            this.namapenyewa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.namapenyewa.Location = new System.Drawing.Point(192, 103);
            this.namapenyewa.Name = "namapenyewa";
            this.namapenyewa.Size = new System.Drawing.Size(121, 20);
            this.namapenyewa.TabIndex = 17;
            // 
            // Jumlah
            // 
            this.Jumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Jumlah.Location = new System.Drawing.Point(192, 309);
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.Size = new System.Drawing.Size(121, 20);
            this.Jumlah.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "JUMLAH HARI SEWA";
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.Color.RosyBrown;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Total.Location = new System.Drawing.Point(579, 238);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(75, 26);
            this.Total.TabIndex = 21;
            this.Total.Text = "Total";
            this.Total.UseVisualStyleBackColor = false;
            this.Total.Click += new System.EventHandler(this.Total_Click_1);
            // 
            // keluar
            // 
            this.keluar.BackColor = System.Drawing.Color.RosyBrown;
            this.keluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keluar.Location = new System.Drawing.Point(641, 412);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(75, 26);
            this.keluar.TabIndex = 22;
            this.keluar.Text = "Keluar";
            this.keluar.UseVisualStyleBackColor = false;
            this.keluar.Click += new System.EventHandler(this.keluar_Click);
            // 
            // Hapus
            // 
            this.Hapus.BackColor = System.Drawing.Color.RosyBrown;
            this.Hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hapus.Location = new System.Drawing.Point(560, 412);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(75, 26);
            this.Hapus.TabIndex = 23;
            this.Hapus.Text = "Bersihkan";
            this.Hapus.UseVisualStyleBackColor = false;
            this.Hapus.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // cetak
            // 
            this.cetak.BackColor = System.Drawing.Color.RosyBrown;
            this.cetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cetak.Location = new System.Drawing.Point(641, 364);
            this.cetak.Name = "cetak";
            this.cetak.Size = new System.Drawing.Size(75, 26);
            this.cetak.TabIndex = 24;
            this.cetak.Text = "Cetak";
            this.cetak.UseVisualStyleBackColor = false;
            this.cetak.Click += new System.EventHandler(this.cetak_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "JUMLAH BARANG";
            // 
            // jumlahbarang
            // 
            this.jumlahbarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jumlahbarang.Location = new System.Drawing.Point(192, 270);
            this.jumlahbarang.Name = "jumlahbarang";
            this.jumlahbarang.Size = new System.Drawing.Size(121, 20);
            this.jumlahbarang.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(510, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 147);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(420, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "METODE PEMBAYARAN";
            // 
            // metodepembayaran
            // 
            this.metodepembayaran.FormattingEnabled = true;
            this.metodepembayaran.Location = new System.Drawing.Point(579, 304);
            this.metodepembayaran.Name = "metodepembayaran";
            this.metodepembayaran.Size = new System.Drawing.Size(137, 21);
            this.metodepembayaran.TabIndex = 28;
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metodepembayaran);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.jumlahbarang);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cetak);
            this.Controls.Add(this.Hapus);
            this.Controls.Add(this.keluar);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Jumlah);
            this.Controls.Add(this.namapenyewa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.totalharga);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.pengiriman);
            this.Controls.Add(this.konfirmasibayar);
            this.Controls.Add(this.ukuran);
            this.Controls.Add(this.opsibajuadat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main_Page";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox opsibajuadat;
        private System.Windows.Forms.ComboBox ukuran;
        private System.Windows.Forms.ComboBox konfirmasibayar;
        private System.Windows.Forms.ComboBox pengiriman;
        private System.Windows.Forms.DateTimePicker tanggal;
        private System.Windows.Forms.TextBox Harga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.TextBox totalharga;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox namapenyewa;
        private System.Windows.Forms.TextBox Jumlah;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Total;
        private System.Windows.Forms.Button keluar;
        private System.Windows.Forms.Button Hapus;
        private System.Windows.Forms.Button cetak;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox jumlahbarang;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox metodepembayaran;
    }
}

