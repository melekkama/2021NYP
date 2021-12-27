using System;
using System.Collections.Generic;
using Newtonsoft.Json;
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
using FireSharp;

namespace Proje
{
    public partial class yoneticibilgi : Form
    {
        public yoneticibilgi()
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
            MüşteriGirişi f= new MüşteriGirişi();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void yoneticibilgi_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("No internet or connection");
            }
            string[] pizzalar = { "Asabi Pizza", "Karışık pizza", "Pastırmalı Pizza", "Sucuklu Pizza", "talyan Usülü Pizza", "Şefin spesiyali pizza" };
            // Pizzalar veritabanında çekiliyor
            FirebaseResponse res = client.Get(@"Pizzalar/" + "Asabi Pizza");
            pizzaClass resAsabi = res.ResultAs<pizzaClass>();

            FirebaseResponse res2 = client.Get(@"Pizzalar/" + "Karışık pizza");
            pizzaClass reskar = res2.ResultAs<pizzaClass>();

            FirebaseResponse res3 = client.Get(@"Pizzalar/" + "Pastırmalı Pizza");
            pizzaClass respas = res3.ResultAs<pizzaClass>();

            FirebaseResponse res4 = client.Get(@"Pizzalar/" + "Sucuklu Pizza");
            pizzaClass ressucuk = res4.ResultAs<pizzaClass>();

            FirebaseResponse res5 = client.Get(@"Pizzalar/" + "İtalyan Usülü Pizza");
            pizzaClass resitalyan = res5.ResultAs<pizzaClass>();

            FirebaseResponse res6 = client.Get(@"Pizzalar/" + "Şefin spesiyali pizza");
            pizzaClass ressef = res6.ResultAs<pizzaClass>();
            // .veritabanından çekilen bilgiler textlere yazılıyor
            lblAsabi.Text =    resAsabi.pizzaAd + "\t\t , Stok : " + resAsabi.pizzaStok + "\t , Fiyat : " + resAsabi.pizzaTutar;
            lblitalyan.Text =  resitalyan.pizzaAd + "\t , Stok : " + resitalyan.pizzaStok + "\t , Fiyat : " + resitalyan.pizzaTutar;
            lblKarısık.Text =  reskar.pizzaAd + "\t\t , Stok : " + reskar.pizzaStok + "\t , Fiyat : " + reskar.pizzaTutar;
            lblPastırma.Text = respas.pizzaAd + "\t\t , Stok : " + respas.pizzaStok + "\t , Fiyat : " + respas.pizzaTutar;
            lblspesiyal.Text = ressef.pizzaAd + "\t , Stok : " + ressef.pizzaStok + "\t , Fiyat : " + ressef.pizzaTutar;
            lblsucuk.Text =    ressucuk.pizzaAd + "\t\t , Stok : " + ressucuk.pizzaStok + "\t , Fiyat : " + ressucuk.pizzaTutar;
            // verştabanından geçmiş sipariş bilgileri çekiliyor
            int kasa = 0;
            FirebaseResponse r = client.Get(@"tamamlanmısSiparis");
            Dictionary<string, tamamlanmısSiparis> data = JsonConvert.DeserializeObject<Dictionary<string, tamamlanmısSiparis>>(r.Body.ToString());
            foreach (var item in data)
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = item.Value.Ad.ToString();
                ekle.SubItems.Add(item.Value.siparisİcerik);
                ekle.SubItems.Add(item.Value.tel);
                ekle.SubItems.Add(item.Value.adres);
                ekle.SubItems.Add(item.Value.siparisTutar);
                listView1.Items.Add(ekle);
                kasa = Convert.ToInt32(item.Value.siparisTutar)+kasa;
            }
            txtkasa.Text = kasa.ToString(); 

            

        }

        private void btnstokGuncelle_Click(object sender, EventArgs e)
        {
            stokGuncelleme stg = new stokGuncelleme();
            stg.ShowDialog();
        }

 
    }
}
