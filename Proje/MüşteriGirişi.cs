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
    public partial class MüşteriGirişi : Form
    {
        public MüşteriGirişi()
        {
            InitializeComponent();
        }

        // veritabanı için anahtar ve adres tutan degısken
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "4VEOQDuWfNNRJJl1zuNTwfqNRS9ARb72HGo5TeoB",
            BasePath = "https://siparisotomasyon-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        private void button2_Click(object sender, EventArgs e)
        {
            kayıtsayfasi kayıt = new kayıtsayfasi();
            kayıt.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtkullanıcıadı.Text) &&
                   string.IsNullOrWhiteSpace(txtsıfre.Text))
            {
                MessageBox.Show("Lütfen boşlukları doldurun");
                return;
            }
            // verş tabanında hangi adrese baglanacagımızı gösteriyoruz
            FirebaseResponse res = client.Get(@"Users/" + txtkullanıcıadı.Text);

            MyUser Resuser = res.ResultAs<MyUser>();// veritabanında ki bilgiler 
            MyUser Curuser = new MyUser() //kullanıcının girdiği bilgiler
            {
                Kullanıcıad = txtkullanıcıadı.Text,
                Password = txtsıfre.Text
            };
            if (MyUser.IsEqual(Resuser, Curuser))
            {
                magaza m = new magaza();
                m.lblad.Text = txtkullanıcıadı.Text;
                m.Show();
                this.Hide();
            }
            else
            {
                MyUser.ShowError();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yöneticigirisi ynt = new yöneticigirisi();
            ynt.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
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
