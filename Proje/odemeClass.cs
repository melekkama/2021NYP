using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    internal class payment
    {
        public int amount { get; set; }
    }
    internal class cash:payment
    {
        public string cashh{ get; set; }
    }
    internal class credit:payment
    {
        public string adsoyad { get; set; }
        public int kartno { get; set; }
        public int cvv { get; set; }
        public int sonTarih { get; set; }
    }
    internal class kod:payment
    {
        public int hediyekod { get; set; }
    }
}
