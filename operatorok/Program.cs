using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Adat> list = new List<Adat>();

            using (StreamReader sr = new StreamReader("kifejezesek.txt"))
            {
                
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    Adat s = new Adat(sor);
                    list.Add(s);
                }
            }


        }
    }
}
