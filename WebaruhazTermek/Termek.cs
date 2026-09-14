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
            }
        }
        
        public int Keszlet
        {
            get;
            set
            {
                if (value < 0) field = 0;
            }
        }
    }
}
