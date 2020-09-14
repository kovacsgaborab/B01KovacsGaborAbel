using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace B01KovácsGáborÁbel
{
    class Program
    {
        static int[] adat = new int[1000];
        static void Main(string[] args)
        {
            Beolvas();
            Minimumertek();
            Egyediek();

            Console.ReadKey();
        }

        private static void Egyediek()
        {
            int db = 0;

            for (int i = 0; i < adat.Length; i++)
            {
                if (adat[i] % 5 == 0 && adat[i] % 4 != 0)
                {
                    db = db + 1;
                }
            }

            Console.WriteLine("5 osztható de 4 nem oszthatóak száma: {0}", db);
        }

        private static void Minimumertek()
        {
            int min = 1000;

            for (int i = 0; i < adat.Length; i++)
            {
                if (adat[i] < min)
                {
                    min = adat[i];
                }
            }

            Console.WriteLine("A minimum: {0}", min);

        }

        private static void Beolvas()
        {
            StreamReader sr = new StreamReader("adatok.dat");

            string[] atmeneti= sr.ReadLine().Split(' '); ;

            while (!sr.EndOfStream)
            {
                for (int i = 0; i < adat.Length; i++)
                {
                    adat[0] = int.Parse(atmeneti[0]) * 3;
                }
            }
            sr.Close();
        }
    }
}
