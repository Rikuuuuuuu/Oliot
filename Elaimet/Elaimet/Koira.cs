using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;
using Ika;

namespace ElainLuokat 
{
    public class Koira : Nisakkaat
    {
         
       /* public string nimi = "Haukkuli";
        public int ika = 10;
        public Koira()
        {

        }
        public Koira(int ika, string nimi)
        {
            this.ika = ika;
            this.nimi = nimi;
        }
        public string AsetaKoiranNimi()
        {
            if (nimi.ToLower() == "musti")
            {
                return "False";
            }
            else
            {
                return "True";
            }
        }
        public object AsetaKoiranIka()
        {
            if (ika < 0)
            {
                return "False";
            }
            else
            {
                return "True"; 
            }
        }
        public string PalautaKoiranNimi()
        {
            return nimi;
        }
        */
        public int KoiranIka()
        {
            Elainika jotain = new Elainika();
            ika = jotain.Koiranika();
            return ika;
        }
    }
}