using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru1
{
    class Program
    {
        public static Random rnd = new Random(); 
        
        static void Main(string[] args)
        {
            int[] liste = new int[9];
            int sayac = 0;
            for (int i = 0; i < liste.Length; i++)
            {
            deger:
                var value = rnd.Next(1, 10);
                sayac++;
                if (i == 0)
                {
                    DegerAta(liste, i, value);

                }
                else if (DegerBul(liste, i, value))
                {
                    DegerAta(liste, i, value);
                }
                else
                {
                    goto deger;
                }


            }

            for (int i = 0; i < liste.Length; i++)
            {
                Console.Write(liste[i].ToString());
                if (i != liste.Length - 1)
                {
                    Console.Write(",");
                }

            }
            Console.Write("  Random fonksiyonu {0} kere çalışmıştır.", sayac);
            Console.Read();

        }

    public static bool DegerBul(int[] liste, int index, int deger)
    {
        for (int i = 0; i < index; i++)
        {
            if (liste[i] == deger)
            {
                return false;
            }

        }
        if (liste[index - 1] == deger)
        {
            return false;
        }


        return true;

    }
    public static void DegerAta(int[] liste, int index, int deger)
    {
        liste[index] = deger;
    }
}
}
