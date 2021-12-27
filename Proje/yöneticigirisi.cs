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
    public partial class yöneticigirisi : Form
    {
        public yöneticigirisi()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            MüşteriGirişi frm= new MüşteriGirişi();
            frm.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
             if(txtkullanıcıadı.Text =="admin" && txtsıfre.Text =="1234")
               {
                yoneticibilgi ynb =new  yoneticibilgi();
                ynb.Show();
                this.Hide();
               }
               else
               {
                   MessageBox.Show("Hatalı ıd yada şifre girişi !!!");
               }
        }
    }
}
