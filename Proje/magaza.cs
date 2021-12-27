using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Proje
{
    public partial class magaza : Form
    {
        public magaza()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "4VEOQDuWfNNRJJl1zuNTwfqNRS9ARb72HGo5TeoB",
            BasePath = "https://siparisotomasyon-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient client;



        private void button7_Click(object sender, EventArgs e)
        {
            MüşteriGirişi frm = new MüşteriGirişi();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            malzemeekleme malzeme = new malzemeekleme();
            int tutar = 40;
            int toplam = Convert.ToInt32(malzeme.txttutar.Text);
            toplam += tutar;
            malzeme.txttutar.Text = tutar.ToString();
            malzeme.lblpizza.Text = "Asabi Pizza";
            malzeme.lblmusteri.Text = lblad.Text;
            malzeme.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sepet spt = new sepet();
            spt.txtisim.Text = lblad.Text;
            spt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            malzemeekleme malzeme = new malzemeekleme();
            int tutar = 35;
            int toplam = Convert.ToInt32(malzeme.txttutar.Text);
            toplam += tutar;
            malzeme.txttutar.Text = tutar.ToString();
            malzeme.lblmusteri.Text = lblad.Text;
            malzeme.lblpizza.Text = "Karışık pizza";
            malzeme.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            malzemeekleme malzeme = new malzemeekleme();
            int tutar = 60;
            int toplam = Convert.ToInt32(malzeme.txttutar.Text);
            toplam += tutar;
            malzeme.txttutar.Text = tutar.ToString();
            malzeme.lblmusteri.Text = lblad.Text;
            malzeme.lblpizza.Text = "İtalyan Usülü Pizza";
            malzeme.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            malzemeekleme malzeme = new malzemeekleme();
            int tutar = 50;
            int toplam = Convert.ToInt32(malzeme.txttutar.Text);
            toplam += tutar;
            malzeme.txttutar.Text = tutar.ToString();
            malzeme.lblmusteri.Text = lblad.Text;
            malzeme.lblpizza.Text = "Sucuklu Pizza";
            malzeme.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            malzemeekleme malzeme = new malzemeekleme();
            int tutar = 50;
            int toplam = Convert.ToInt32(malzeme.txttutar.Text);
            toplam += tutar;
            malzeme.txttutar.Text = tutar.ToString();
            malzeme.lblmusteri.Text = lblad.Text;
            malzeme.lblpizza.Text = "Pastırmalı Pizza";
            malzeme.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            malzemeekleme malzeme = new malzemeekleme();
            int tutar = 45;
            int toplam = Convert.ToInt32(malzeme.txttutar.Text);
            toplam += tutar;
            malzeme.txttutar.Text = tutar.ToString();
            malzeme.lblmusteri.Text = lblad.Text;
            malzeme.lblpizza.Text = "Şefin spesiyali pizza";
            malzeme.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void magaza_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("No internet or connection");
            }
            
        }
    }
}
