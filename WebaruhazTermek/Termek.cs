using System;
using System.Collections.Generic;
using System.Text;

namespace WebaruhazTermek
{
    public class Termek
    {
        public string Nev { get; set; }
        public int Egysegar
        {
            get;
            set
            {
                if (value < 1) field = 1;
                else field = value;
            }
        }
        
        public int Keszlet
        {
            get;
            set
            {
                if (value < 0) field = 0;
                else field = value;
            }
        }

        public Termek(string _nev, int _egysegar, int _keszlet)
        {
            Nev = _nev;
            Egysegar = _egysegar;
            Keszlet = _keszlet;
        }

        public void Kiiras()
        {
            Console.WriteLine($"Termék neve: {Nev}, Egységár: {Egysegar} Ft, Készlet: {Keszlet} db");
        }
    }
}
