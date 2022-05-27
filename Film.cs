using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA220527_2
{
    internal class Film
    {
        //prop + TAB + TAB
        public string Cim { get; set; }
        public int Fazis { get; set; }
        public string Premier { get; set; }
        public int Kiadas { get; set; }
        public int Bevetel { get; set; }

        public float BKArany => Bevetel / (float)Kiadas;
        public int Haszon => Bevetel - Kiadas;



        //ctor + TAB + TAB

        public Film(string sor)
        {
            var v = sor.Split(';');

            Cim = v[0];
            Fazis = int.Parse(v[1]);
            Premier = v[2];
            Kiadas = int.Parse(v[3]);
            Bevetel = int.Parse(v[4]);
        }


    }
}
