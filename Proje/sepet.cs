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
    public partial class sepet : Form
    {
        public sepet()
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
            // Geçici oluşturulan sipariş nesnesi ödeme tamamlanınca kalıcı olarak veritabanına ekleniyor
            tamamlanmısSiparis siparis = new tamamlanmısSiparis()
            {
                Ad = txtisim.Text,
                siparisİcerik = lblToplamIcerik.Text,
                siparisTutar = txttutar.Text,
                adres = txtadres.Text,
                tel = txttel.Text
            };

            // Kalıcı sipariş veritabanına yazılıyor
            SetResponse set = client.Set(@"tamamlanmısSiparis/" + txtisim.Text, siparis);

            var result = client.Delete(@"siparisDetay");


            odemeekranı odeme = new odemeekranı();
            odeme.odemeucret.Text = txttutar.Text;
            odeme.Show();
            this.Hide();

        }

        private void sepet_Load(object sender, EventArgs e)
        {
            
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("No internet or connection");
            }
            string[] pizzalar = { "Asabi Pizza", "Karışık pizza", "Pastırmalı Pizza", "Sucuklu Pizza", "İtalyan Usülü Pizza", "Şefin spesiyali pizza" };

            int toplam = 0;
            string toplamİcerik = "";

            for (int i = 0; i < 6; i++)
            {
                // Sipariş detayı altındaki tüm siparişleri listview'a ekliyoruz
                FirebaseResponse res = client.Get(@"siparisDetay/" + txtisim.Text + pizzalar[i]);
                siparisClass resSiparis = res.ResultAs<siparisClass>();
               if(resSiparis!=null) { 
                ListViewItem ekle = new ListViewItem();
                ekle.Text = resSiparis.Ad.ToString();
                ekle.SubItems.Add(resSiparis.siparisİcerik.ToString());
                ekle.SubItems.Add(resSiparis.siparisTutar.ToString());

                toplam = Convert.ToInt32(resSiparis.siparisTutar) + toplam;
                toplamİcerik = toplamİcerik + resSiparis.siparisİcerik + "  ";
                listView1.Items.Add(ekle);
            }
            }
            txttutar.Text = toplam.ToString();
            lblToplamIcerik.Text = toplamİcerik;


            FirebaseResponse resad = client.Get(@"Users/" + txtisim.Text);
            MyUser user = resad.ResultAs<MyUser>();
            txttel.Text = user.Telefon.ToString();



        }
        
    }
}
