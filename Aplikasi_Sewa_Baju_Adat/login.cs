using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Aplikasi_Sewa_Baju_Adat
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=sewa_baju_adat;password=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM login WHERE username=@username AND password=@password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username.Text);
                    cmd.Parameters.AddWithValue("@password", password.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        this.Hide();
                        Main_Page halamanUtama = new Main_Page();
                        halamanUtama.FormClosed += (s, args) => this.Close();
                        halamanUtama.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username atau password salah!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }

        private void cekpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cekpass.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }
    }
}
