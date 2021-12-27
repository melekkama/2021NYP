using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class odemeekranı : Form
    {
        public odemeekranı()
        {
            InitializeComponent();
        }
    


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            button1.Visible = true;
            groupBox2.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cash c = new cash()
            {
                amount =Convert.ToInt32(odemeucret.Text),
                cashh = "Nakit ödeme alınmıştır Afiyet olsun...",
            };

            MessageBox.Show("Ucret : "+c.amount.ToString()+"\n"+c.cashh);
            button1.Visible = false;
            button3.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            MüşteriGirişi frm = new MüşteriGirişi();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            credit kredi = new credit()
            {
                amount = Convert.ToInt32(odemeucret.Text),
                adsoyad = txtadsoyad.Text,
                cvv = Convert.ToInt32(cvv),
                kartno = Convert.ToInt32(kartno),
                sonTarih = Convert.ToInt32(tarih),
            };
            MessageBox.Show("Ucret : "+ kredi.amount.ToString()+"\n"+"Ad Soyad : "+kredi.adsoyad+"\n"+"Kredi kartı ödemesi alınmıştır. Afiyet olsun...");
            button3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kod hediye = new kod()
            {
                amount = Convert.ToInt32(odemeucret.Text),
                hediyekod = Convert.ToInt32(hediyekod.Text),
            };
            MessageBox.Show("Ucret : " + hediye.amount.ToString() + "\n" + "Hediye kodu : "+ hediye.hediyekod.ToString());
            button3.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            button1.Visible = false;
            groupBox2.Visible = true;
        }
    }
}
