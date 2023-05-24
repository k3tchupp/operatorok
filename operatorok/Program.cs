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
            

            Console.WriteLine("5. feladat: Statisztika");
            string[] operatorok = new string[6] { "mod", "/", "div", "-", "*", "+" };

            foreach (string item1 in operatorok)
            {
                int count = 0;

                foreach (Adat item2 in list)
                {
                    if (item2.op == item1)
                    {
                        count++;
                    }
                }

                Console.WriteLine($"\t{item1} -> {count} db");
            }



            public string Kiszamol(int szam1, int szam2, string oper)
            {
                try
                {
                    switch (oper)
                    {
                        case "+":
                            return (szam1 + szam2).ToString();
                        case "-":
                            return (szam1 - szam2).ToString();
                        case "*":
                            return (szam1 * szam2).ToString();
                        case "/":
                            if (szam2 == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            return (szam1 / (double)szam2).ToString();
                        case "div":
                            if (szam2 == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            return (szam1 / szam2).ToString();
                        case "mod":
                            if (szam2 == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            return (szam1 % szam2).ToString();
                        default:
                            return "Hibás operátor!";
                    }
                }
                catch
                {
                    return "Egyéb hiba!";
                }
            }


            while (true)
            {
                Console.Write("7. feladat: Kérek egy kifejezést (pl.: 1 + 1): ");
                string elso = Console.ReadLine();
                string log = Console.ReadLine();
                string masodik = Console.ReadLine();

                // nem tudom 
            }


            StreamWriter sw = new StreamWriter("eredmenyek.txt");
            list.ForEach(x => sw.WriteLine($"{x.szam1} {x.op} {x.szam2} = {Eval(x)}"));

            Console.WriteLine("8. feladat: eredmenyek.txt");
        }
    }
}
