using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace ElainLuokat
{
    public abstract class Elain 
    {
        public string nimi= "Kalle";
        public int ika = 10;
        public string liha;
        public string AsetaElaimenNimi()
        {
            return nimi;
        }
        public int AsetaElaimenIka()
        {
            return ika;
        }
        private string AsetaOnLihanSyoja()
        {
            return liha;
        }
        public string PalautaElaimenNimi()
        {
            AsetaElaimenNimi();
            return nimi;
        }
        public object PalautaElaimenIka()
        {
            AsetaElaimenIka();
            if (ika < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool OnLihanSyoja()
        {
            AsetaOnLihanSyoja();
            if (liha =="Kyllä" || liha == "kyllä")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool PalautaOnLihanSyoja()
        {
           if( OnLihanSyoja() == true)
           {
               return true;
           }
           else
           {
               return false;
           }
        }
        public virtual void Aantele()
        {
            Console.WriteLine("Umph!");
            Console.ReadLine();
        }
    }
}
