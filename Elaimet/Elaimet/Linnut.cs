using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;
using Ika;

namespace ElainLuokat
{
    public class Linnut : Elain
    {
        public string siivet = "Kyllä";
        private string AsetaSiivet()
        {
            return siivet;
        }
        private bool OnSiivet()
        {
            AsetaSiivet();
            if (siivet == "Kyllä" || siivet == "kyllä")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool PalautaSiivet()
        {
            if (OnSiivet() == true)
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
