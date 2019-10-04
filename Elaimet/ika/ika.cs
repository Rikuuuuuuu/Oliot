using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;


namespace Ika
{
    public class Elainika
    {
        public int koiraika;
        public int kissaika;
        public static void Main(string[] args)
        {          

        }
        public static class Util
        {
            private static Random rnd = new Random();
            public static int GetRandom1()
            {
                return rnd.Next(1,16);
            }
            public static int GetRandom2()
            {
                return rnd.Next(1, 11);
            }
        }
        public int Koiranika()
        {
            koiraika = Util.GetRandom1();
            return koiraika;     
        }
        public int Kissaika()
        {
            kissaika = Util.GetRandom2();
            return kissaika;
        }
    }
}