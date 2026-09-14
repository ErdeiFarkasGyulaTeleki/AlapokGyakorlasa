using System;
using System.Collections.Generic;
using System.Text;

namespace Raktarkezelo
{
    public class RaktarElem
    {
        private int dbSzam;
        public string CikkNev { get; set; }

        public static readonly double AFA_KULCS = 0.27;

        public RaktarElem(string _cikkNev, int _dbSzam)
        {
            CikkNev = _cikkNev;
            dbSzam = _dbSzam;
        }

        public void Bevetelezes(int db)
        {
            if (db < 1)
            {
                Console.WriteLine("Nem vehet be nempozitív mennyiséget!");
                return;
            }

            dbSzam += db;
            Console.WriteLine($"Sikeresen hozzáadott {db} db {CikkNev} cikket, így {dbSzam} db van a raktárban.");
        }

        public void Kiadas(int db)
        {
            if (db < 1)
            {
                Console.WriteLine("Nem vehet ki nempozitív mennyiséget!");
                return;
            }

            if (db > dbSzam)
            {
                Console.WriteLine("Nem lehet kivenni több terméket, mint amennyi van a raktárban!");
                return;
            }

            dbSzam -= db;
            Console.WriteLine($"Sikeresen kivett {db} db {CikkNev} cikket, így {dbSzam} db van a raktárban.");
        }

        public static double BruttoArSzamitas(double nettoAr)
        {
            return nettoAr * (1 + AFA_KULCS);
        }
    }
}
