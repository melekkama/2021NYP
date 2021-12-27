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
    public partial class malzemeekleme : Form
    {
        public malzemeekleme()
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
            
           // Siarpiş sınıfından sipariş nesnesi oluşturuluyor
            siparisClass siparis = new siparisClass()
            {
                Ad = lblmusteri.Text,
                siparisİcerik = lblpizza.Text,
                siparisTutar = txttutar.Text
            };
            // Oluşturduğumuz sipariş nesnesini veritabanına yazıyoruz
            SetResponse set = client.Set(@"siparisDetay/" + lblmusteri.Text + lblpizza.Text, siparis);

            // Veritabanından pizzanın stok bilgisi alınıyor
            FirebaseResponse rStokAl = client.Get(@"Pizzalar/"+lblpizza.Text);
            pizzaClass stok = rStokAl.ResultAs<pizzaClass>();
            int s = Convert.ToInt32(stok.pizzaStok);
            string pizzatutar = stok.pizzaTutar;
            //Pizza nesnesi oluşturuluyor stok düşürülüp veritabanında güncelleniyor
            pizzaClass pizzaa = new pizzaClass()
            {
                pizzaAd = lblpizza.Text,
                pizzaTutar = pizzatutar,
                pizzaStok = (s-1).ToString()
            };

            siparis.siparisTutar=(s-1).ToString();
            FirebaseResponse response= client.Update("Pizzalar/" + lblpizza.Text ,pizzaa);
            this.Hide(); ;
            
        }

     

        private void cmbpizzaboyut_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Pizzaların boyutlarına göre fiyat eklemesi yapılıyor
            int sabit = Convert.ToInt32(txttutar.Text);
            if (cmbpizzaboyut.SelectedItem.ToString() == "orta")
            {
                
                int toplam;
                toplam = sabit + 4;
                txttutar.Text = toplam.ToString();
                
            }
            else if(cmbpizzaboyut.SelectedItem.ToString()=="buyuk")
            {
                int toplam;
                toplam = sabit + 8;
                txttutar.Text = toplam.ToString();
             }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          if(checkBox1.Checked==true)
            {
                int sabit = Convert.ToInt32(txttutar.Text);
                int toplam;
                toplam = sabit + 6;
                txttutar.Text = toplam.ToString();
                
            }
        }

        private void malzemeekleme_Load(object sender, EventArgs e)
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
