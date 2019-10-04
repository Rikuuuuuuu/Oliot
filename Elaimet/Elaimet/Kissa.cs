using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;
using Ika;

namespace ElainLuokat
{
    public class Kissa : Nisakkaat
    {
        public int maara;
        public string emo;
        List<Kissa> pennut = new List<Kissa>();
        /* public string nimi = "Kisuli";
         public int ika = 10;
         public Kissa()
         {

         }
         public Kissa(int ika,string nimi)
         {
             this.ika = ika;
             this.nimi = nimi;
         }
         public string AsetaKissanNimi()
         {          
             if (nimi.ToLower() == "hilda")
             {
                 return "False";
             }
             else
             {
                 return "True";
             }
         }
         public object AsetaKissanIka()
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
         public string PalautaKissanNimi()
         {           
             return nimi;
         }
         public int PalautaKissanIka()
         {
             return ika;
         }
    */
        public int Kissaika()
         {
             Elainika jotain = new Elainika();
             ika = jotain.Kissaika();
             return ika;
         }
        public void Kehrää()
        {
            Console.WriteLine("hrrrr");
            Console.ReadLine();
        }
        private int PentuIka()
        {
            ika = 0;
            return ika;
        }
        public string LisaaEmo()
        {
            return emo;
        }
        private void LisaaPentu()
        {
            PentuIka();
            for (int i = 0; i < maara; i++)
            {
                pennut.Add(new Kissa());
            }
        }
        public void Pentu()
        {
            LisaaPentu();
            foreach (var Kissa in pennut)
            {
                Kissa.nimi = "Pentu";
                Console.WriteLine("Pennun emo on: " + LisaaEmo());
                Console.WriteLine(Kissa.nimi);
                Console.WriteLine("Pentu on: " + Kissa.PentuIka() + " vuotta");
                Console.ReadLine();
            }

        }

    }
}