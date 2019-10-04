using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;
using Ika;

namespace ElainLuokat
{
    public class Nisakkaat : Elain
    {
        public string turkki = "Kyllä";
        private string AsetaTurkki()
        {
            return turkki;
        }
        private bool OnTurkki()
        {
            AsetaTurkki();
            if (turkki == "Kyllä" || turkki == "kyllä")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool PalautaTurkki()
        {
            if (OnTurkki() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}