using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplikasi_Sewa_Baju_Adat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            opsibajuadat.Items.Add("Kebaya");
            opsibajuadat.Items.Add("Kebaya Sunda");
            opsibajuadat.Items.Add("Kebaya Bali");
            opsibajuadat.Items.Add("Baju Bodo");
            opsibajuadat.Items.Add("Baju Lurik");
            opsibajuadat.Items.Add("Jarik");
            opsibajuadat.Items.Add("Blangkon");
            opsibajuadat.Items.Add("Udeng");
            ukuran.Items.Add("S");
            ukuran.Items.Add("M");
            ukuran.Items.Add("L");
            ukuran.Items.Add("XL");
            ukuran.Items.Add("XXl");
            konfirmasibayar.Items.Add("Belum Bayar");
            konfirmasibayar.Items.Add("Sudah Bayar");
            pengiriman.Items.Add("Antar");
            pengiriman.Items.Add("Ambil");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (opsibajuadat.Text == "Kebaya")
            {
                Harga.Text = "50000";
            }
            else if (opsibajuadat.Text == "Kebaya Sunda")
            {
                Harga.Text = "50000";
            }
            else if (opsibajuadat.Text == "Kebaya Bali")
            {
                Harga.Text = "55000";
            }
            else if (opsibajuadat.Text == "Baju Bodo")
            {
                Harga.Text = "65000";
            }
            else if (opsibajuadat.Text == "Baju Lurik")
            {
                Harga.Text = "35000";
            }
            else if (opsibajuadat.Text == "Jarik")
            {
                Harga.Text = "30000";
            }
            else if (opsibajuadat.Text == "Blangkon")
            {
                Harga.Text = "10000";
            }
            else if (opsibajuadat.Text == "Udeng")
            {
                Harga.Text = "10000";
            }
        }

        private void Total_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Jumlah.Text) || string.IsNullOrWhiteSpace(Harga.Text) || string.IsNullOrWhiteSpace(jumlahbarang.Text) || string.IsNullOrWhiteSpace(pengiriman.Text))
            {
                MessageBox.Show("Masukkan jumlah hari sewa, pilih baju adat, jumlah barang, dan pilih pengiriman!", "Peringatan", MessageBoxButtons.OK);
                return;
            }
            if (int.TryParse(Jumlah.Text, out int jumlahHari) && int.TryParse(Harga.Text, out int harga) && int.TryParse(jumlahbarang.Text, out int Jumlahbarang))
            {
                int totalPembayaran = Jumlahbarang * jumlahHari * harga;
                totalharga.Text = totalPembayaran.ToString("N0");

                if (pengiriman.Text == "Antar")
                {
                    totalPembayaran += 2000;
                }
                totalharga.Text = totalPembayaran.ToString("N0");
            }

            else
            {
                MessageBox.Show("Input harus berupa angka!", "Error", MessageBoxButtons.OK);
            }
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            namapenyewa.Text = "";
            opsibajuadat.Text = "";
            ukuran.Text = "";
            tanggal.Text = "";
            jumlahbarang.Text = "";
            Jumlah.Text = "";
            pengiriman.Text = "";
            alamat.Text = "";
            konfirmasibayar.Text = "";
            totalharga.Text = "";
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cetak_Click(object sender, EventArgs e)
        {
            if (konfirmasibayar.Text == "Sudah Bayar")
            {
                string connString = "server=localhost; database=sewa_baju_adat; uid=root; pwd=;";
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO sewa (nama_penyewa, baju_adat, ukuran, tanggal_sewa, jumlah_barang, jumlah_hari, pengiriman, alamat, total_harga) " +
                                       "VALUES (@nama, @baju, @ukuran, @tanggal, @barang, @hari, @pengiriman, @alamat, @total)";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nama", namapenyewa.Text);
                            cmd.Parameters.AddWithValue("@baju", opsibajuadat.Text);
                            cmd.Parameters.AddWithValue("@ukuran", ukuran.Text);
                            cmd.Parameters.AddWithValue("@tanggal", DateTime.Now.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@barang", Convert.ToInt32(Jumlah.Text));
                            cmd.Parameters.AddWithValue("@hari", Convert.ToInt32(Jumlah.Text));
                            cmd.Parameters.AddWithValue("@pengiriman", pengiriman.Text);
                            cmd.Parameters.AddWithValue("@alamat", alamat.Text);
                            if (!int.TryParse(totalharga.Text.Replace(".", "").Replace(",", ""), out int totalHarga))
                            {
                                MessageBox.Show("Total harga tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            cmd.Parameters.AddWithValue("@total", totalHarga);


                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Pembayaran Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lakukan Pembayaran Terlebih Dahulu");
            }
        }
    }
}
