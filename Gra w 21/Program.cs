using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_21
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxWynik = 21;
            int liczbaPunktow = 0;
            char gramy = 't';
            Random liczbaLosowa = new Random();
            while (gramy == 't')
            {


                while (liczbaPunktow < maxWynik)
                {
                    Console.WriteLine("Masz {0} punktów. Czy chcesz grać dalej? (t/n)", liczbaPunktow);
                    char odpowiedz = Char.Parse(Console.ReadLine());
                    if (odpowiedz == 'n')
                    {
                        Console.WriteLine("Koniec gry!");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    if (odpowiedz == 't')
                    {
                        int wylosowanaLiczba = liczbaLosowa.Next(1, 7);
                        liczbaPunktow = liczbaPunktow + wylosowanaLiczba;
                    }
                }
                if (liczbaPunktow == maxWynik)
                {
                    Console.WriteLine("Udało Ci się zdobyć dokładnie 21 punktów.");
                }
                else

                {
                    Console.WriteLine("Niestety zdobyłeś za dużo punktów ({0})", liczbaPunktow);
                }
                Console.WriteLine("Czy chcesz zagrać jeszcze raz? (t/n)");
                gramy = Char.Parse(Console.ReadLine());
                if (gramy == 't')
                {
                    liczbaPunktow = 0;
                }
            }
        }
    }
}
