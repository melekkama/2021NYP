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
    public partial class stokGuncelleme : Form
    {
        public stokGuncelleme()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "4VEOQDuWfNNRJJl1zuNTwfqNRS9ARb72HGo5TeoB",
            BasePath = "https://siparisotomasyon-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        private void txtstok_Click(object sender, EventArgs e)
        {
            #region Con
            if (txtAsabi.Text != "")
            { 
                pizzaClass pizza = new pizzaClass()
            {
                pizzaAd = lblAsabi.Text,
                pizzaStok = txtAsabi.Text,
                pizzaTutar = txtAsabiFiyat.Text
            };
            SetResponse set = client.Set(@"Pizzalar/" + lblAsabi.Text, pizza); 
            }
            if (txtİtalyan.Text != "")
            { 
                pizzaClass pizza2 = new pizzaClass()
            {
                pizzaAd = lblitalyan.Text,
                pizzaStok = txtİtalyan.Text,
                pizzaTutar = txtItalyanFiyat.Text
            };
            SetResponse set2 = client.Set(@"Pizzalar/" + lblitalyan.Text, pizza2);
            }
            if (txtKarısık.Text != "")
            {
                pizzaClass pizza3 = new pizzaClass()
                {
                    pizzaAd = lblKarısık.Text,
                    pizzaStok = txtKarısık.Text,
                    pizzaTutar = txtKarısıkFiyat.Text
                };
                SetResponse set3 = client.Set(@"Pizzalar/" + lblKarısık.Text, pizza3);
            }
            if (txtPastırma.Text != "")
            {
                pizzaClass pizza4 = new pizzaClass()
                {
                    pizzaAd = lblPastırma.Text,
                    pizzaStok = txtPastırma.Text,
                    pizzaTutar = txtPastırmalıFiyat.Text
                };
                SetResponse set4 = client.Set(@"Pizzalar/" + lblPastırma.Text, pizza4);
            }
            if (txtSpesiyal.Text != "")
            {

                pizzaClass pizza5 = new pizzaClass()
                {
                    pizzaAd = lblspesiyal.Text,
                    pizzaStok = txtSpesiyal.Text,
                    pizzaTutar = txtSpesiyalFiyat.Text
                };
                SetResponse set5 = client.Set(@"Pizzalar/" + lblspesiyal.Text, pizza5);
            }
            if (txtSucuklu.Text != "")
            {

                pizzaClass pizza6 = new pizzaClass()
                {
                    pizzaAd = lblsucuk.Text,
                    pizzaStok = txtSucuklu.Text,
                    pizzaTutar = txtSucukFiyat.Text
                };
                SetResponse set6 = client.Set(@"Pizzalar/" + lblsucuk.Text, pizza6);

            }
            #endregion

            MessageBox.Show("Kayıt başarılı");
        }

        private void stokGuncelleme_Load(object sender, EventArgs e)
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
