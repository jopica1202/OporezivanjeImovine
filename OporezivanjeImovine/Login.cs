using Samostalni_2026_Milos_PusicB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OporezivanjeImovine
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Uloguj_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.povezi();
            SqlCommand cmd = new SqlCommand("SELECT * FROM vlasnik WHERE email='" + Txt_name.Text + "'", veza);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            int broj = tabela.Rows.Count;
            if (broj == 0)
            {
                MessageBox.Show("Nepostojeci email");
            }
            else
            {
                if (Txt_pass.Text == tabela.Rows[0]["lozinka"].ToString())
                {
                    Glavna nova = new Glavna();
                    this.Hide();
                    nova.Show();
                }
                else MessageBox.Show("Nije dobra lozinka!");
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            // Pavle Miletic
        }
    }
}
