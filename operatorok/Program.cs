using System;
using System.Collections;
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

            Console.WriteLine($"2. feladat: Napi kölcsönzések száma: {list.Count}");

            Console.WriteLine($"3. feladat: Kifejezések maradékos osztással: {list.Where(x => x.op == "mod").Count()}";

            Console.WriteLine($"4. feladat: {(list.Any(x => x.szam1 % 10 == 0 && x.szam2 % 10 == 0) ? "Van ilyen kifejezés!" : "Nincs ilyen kifejezés!")};

            
        }
    }
}
