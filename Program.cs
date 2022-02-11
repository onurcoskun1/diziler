using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımla
            string [] renkler = new string[5];

            string[] hayvanlar= {"kedi", "köpek", "kuş", "fare"};

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim

            renkler[0]="mavi";
            dizi[3]= 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı

            //Klavyeden girilen n tane sayının ortalamasını alan program örneği

            Console.WriteLine("Dizinin eleman sayısını giriniz: ");
            int dizi_uzunlugu = int.Parse(Console.ReadLine());
            int[] sayi_dizisi = new int[dizi_uzunlugu];

            for (int i = 0; i < dizi_uzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i+1);
                sayi_dizisi[i] = int.Parse(Console.ReadLine());
            }
            
            int toplam=0;
            foreach (var sayi in sayi_dizisi)
           	{
                toplam+=sayi;
	        }
            Console.WriteLine("Ortalama: " + toplam/dizi_uzunlugu);
        }
    }
}
