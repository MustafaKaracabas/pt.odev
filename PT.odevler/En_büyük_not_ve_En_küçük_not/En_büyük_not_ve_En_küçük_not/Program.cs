using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace En_büyük_not_ve_En_küçük_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c, EnBuyuk = -1500, yer = 0;
            String[] A = { "Emin", "Emir", "İclal", "Bekir", "Cem", "Arda", "Kaan", "Metin", "Can", "Ramiz" };
            int[] B = { 56, 78, 95, 23, 95, 87, 61, 77, 23, 33 };
            for (c = 0; c < B.Length; c++)
            {
                if (B[c] >= EnBuyuk)
                {
                    EnBuyuk = B[c];
                }
            }
            Console.WriteLine("En yüksek Not = " + EnBuyuk);
            Console.WriteLine("En yüksek not alan kişiler:");
            for (c = 0; c < B.Length; c++)
            {
                if (B[c] == EnBuyuk)
                {
                    Console.WriteLine(A[c]);
                }
            }
            for (c = 0; c < B.Length; c++)
            {
                if (B[c] <= EnBuyuk)
                {
                    EnBuyuk = B[c];
                    //yer = c;
                }
            }
            Console.WriteLine("En düşük Not = " + EnBuyuk);
            Console.WriteLine("En düşük not alan kişiler:");
            for (c = 0; c < B.Length; c++)
            {
                if (B[c] == EnBuyuk)
                {
                    Console.WriteLine(A[c]);
                }
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
