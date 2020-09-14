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
