using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnıncıEleman
{
    class Program
    {
        static void Main(string[] args)
        {   
            int k=0;
            Console.WriteLine("Kaç elemanlı dizi olsun istersin?");
            int sayi = Convert.ToInt32(Console.ReadLine()); // dizinin eleman sayısı klavyeden okunuyor.
            int[] dizi = new int[sayi];
            Random RasgeleSayi = new Random(); // randomla sayi üretmek için rasgele nesnesi oluşturuluyor.
            for (int i = 0; i < sayi; i++)
            {
                dizi[i] = RasgeleSayi.Next(1, 100); // diziye dizinin eleman sayısı kadar 1 ile 100 arasında sayı atıyor.
                
            }
            for (int i = 0; i < sayi; i++)
            {
                Console.Write(dizi[i] + "-");
                
            }
            Console.WriteLine();
            Console.Write("k sayisini giriniz: "); // getirilecek olan k sayısı
            k=Convert.ToInt32(Console.ReadLine()); // k sayısı klavyeden okunuyor.
            Console.WriteLine(dizi[k-1]);  // dizinin k. elemanı ekrana yazılıyor.
            

            Console.ReadLine();
        }
    }
}
