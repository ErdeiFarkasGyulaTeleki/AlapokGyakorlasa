using System;
using System.Collections.Generic;
using System.Text;

namespace FelhasznaloFiok
{
    public class Felhasznalo
    {
        private string jelszo = "123456";
        public string FelhasznaloNev;

        public void JelszoModositas(string regiJelszo, string ujJelszo)
        {
            if (regiJelszo == jelszo && ujJelszo.Length >= 6)
            {
                jelszo = ujJelszo;
                Console.WriteLine("Sikeres jelszóváltás!");
            }
            else
            {
                Console.WriteLine("Sikertlen jelszóváltás!");
            }
        }

        public Felhasznalo(string felhasznaloNev, string _jelszo)
        {
            FelhasznaloNev = felhasznaloNev;
            jelszo = _jelszo;
        }
    }
}
