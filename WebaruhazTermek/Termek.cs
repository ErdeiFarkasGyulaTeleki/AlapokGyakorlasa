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
    }
}
