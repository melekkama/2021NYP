using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    internal class MyUser
    {
      /*  public MyUser(string ad, string soyad, string telefon, string password)
        {
            Ad = ad;
            Soyad = soyad;
            Telefon = telefon;
            Password = password;
        }*/
        public string Kullanıcıad { get; set; }
        public string adsoyad { get; set; }
        public string Telefon { get; set; }
        public string Password { get; set; }

        private static string error;

        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }
        //veritabanındaki ve kullanıcının girdiği bilgiler karşılaştırıyor
        public static bool IsEqual(MyUser user1,MyUser user2)
        {
            if(user1 == null || user2 == null)
            {
                return false;
            }
            if(user1.Kullanıcıad != user2.Kullanıcıad)
            {
                error = "Hatalı kullanıcı adı";
                return false;
            }
            else if(user1.Password != user2.Password)
            {
                error = "Hatalı şifre";
                return false;
            }
            return true;
        }
    }
}
