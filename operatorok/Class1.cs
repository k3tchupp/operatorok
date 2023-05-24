using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorok
{
    class Adat
    {
        public int szam1;
        public string op;
        public int szam2;

        public Adat(string s)
        {
            string[] darabok = s.Split(' ');
            this.szam1 = Convert.ToInt32(darabok[0]);
            this.op = darabok[1];
            this.szam1 = Convert.ToInt32(darabok[2]);

        }
    }
}
