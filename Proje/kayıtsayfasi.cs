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
    public partial class kayıtsayfasi : Form
    {
        public kayıtsayfasi()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "4VEOQDuWfNNRJJl1zuNTwfqNRS9ARb72HGo5TeoB",
            BasePath = "https://siparisotomasyon-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        private void button1_Click(object sender, EventArgs e)
        {
            MüşteriGirişi kullanıcı = new MüşteriGirişi();
            kullanıcı.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtkullanıcıadı.Text) ||
                  string.IsNullOrWhiteSpace(txtadsoyad.Text) ||
                  string.IsNullOrWhiteSpace(txttel.Text) ||
                  string.IsNullOrWhiteSpace(txtsifre.Text))
            {
                MessageBox.Show("Lütfen boşlukları doldurun");
                return;
            }

            MyUser user = new MyUser()
            {
                Kullanıcıad = txtkullanıcıadı.Text,
                adsoyad = txtadsoyad.Text,
                Telefon = txttel.Text,
                Password = txtsifre.Text
            };
            SetResponse set = client.Set(@"Users/" + txtkullanıcıadı.Text, user);

            MessageBox.Show("Kayıt başarılı");
        }

        private void kayıtsayfasi_Load(object sender, EventArgs e)
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
