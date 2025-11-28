using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomolyaN_telefonszamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<string> lista = new List<string>();
                lista.Add("+36202275895");
                lista.Add("06203568987");
                lista.Add("(06)20/2558222");
                lista.Add("203568978+");
                lista.Add("203568978+");
                lista.Add("nullahat202289578548");


                Console.Clear();
               
                Console.WriteLine("1 Mindent megjelenít");
                Console.WriteLine("2 Csak a számjegyeket tartalmazók");
                Console.WriteLine("3 Csak a 12 hosszúak");
                Console.WriteLine("4 Csak számjegyeket és +jelet tartalmazhat");
                Console.WriteLine("5 Csak azok jelenjenek meg amiben 6 - os szám van");
                Console.WriteLine("6 Csak számok és + jel, de csak elől lehet a + jel");
                Console.WriteLine("7 06 - al kezdődik (és vagy) jel van benne");
                Console.WriteLine("0 Kilépés");


                string kezelo = Console.ReadLine();
                if (kezelo == "1") {
                    Console.WriteLine(lista);
                }
                else if (kezelo == "2") {
                    bool jo = true;
                    foreach (var tel in lista)
                    {
                        foreach (var betu in tel)
                        {
                            if (char.IsDigit(betu))
                                jo = false;
                        }
                        if (jo)
                        {
                            Console.WriteLine(tel);
                        }
                        
                    }
                }
                else if (kezelo == "3") {
                    foreach (var tel in lista)
                    {
                        foreach (int i in tel)
                        {
                            if (i == 12)
                            {
                                Console.WriteLine(tel);
                            }
                        }
                    }
                }
                else if (kezelo == "4") {
                    foreach (var nev in lista)
                    {
                        bool jo = true;
                        foreach (char betu in nev)
                        {
                            if (char.IsLetter(betu) && betu != ' ')
                            {
                                jo = false;
                            }
                            if (jo)
                            {
                                Console.WriteLine(nev);
                            }
                        }

                    }
                }
                

            
                else if (kezelo == "5") {
                    foreach (var tel in lista)
                    {
                        if (tel.Contains(' '))
                        {
                            Console.WriteLine(tel);
                        }
                    }
                }
                else if (kezelo == "6") { }
                else if (kezelo == "7") { }
                else if (kezelo == "0")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Hiba");
                }



            }
        }
    }
}
