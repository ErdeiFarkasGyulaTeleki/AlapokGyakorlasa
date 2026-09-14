using System;
using System.Collections.Generic;
using System.Text;

namespace Mertekegyseg
{
    public class Atvalto
    {
        public double Szorzo;

        public Atvalto(double _szorzo)
        {
            Szorzo = _szorzo;
        }

        public static double KmBolMeter(double km)
        {
            return km * 1000;
        }

        public double EgyediAtvaltas(double ertek)
        {
            return ertek * Szorzo;
        }
    }
}
