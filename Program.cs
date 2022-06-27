using System;

namespace diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //Dizi Tanımlama
          String[] renkler = new string[5];

          String[] hayvanlar = {"Kedi","Köpek","Kuş","Maymun"};

          int[] dizi;
          dizi = new int[5]; 

          //dizilere değer atama ve erişim
          renkler[0] = "Mavi";
          
          dizi[3] =10;

          Console.WriteLine(dizi[3]);
          Console.WriteLine(hayvanlar[1]);
          Console.WriteLine(renkler[0]);

          //Döngülerle Dizi Kullanımı

          //klavyeden girilen "n" tane sayının ortalamasını alan Proje:
         
         Console.Write("Dizinin Eleman Sayisini Giriniz :");
         int diziuzunlugu = int.Parse(Console.ReadLine());
         int[] sayi = new int[diziuzunlugu];

        for (int i = 0; i < diziuzunlugu; i++)
        {
            Console.Write("Lütfen {0} sayıyı giriniz :",i+1);
            sayi[i] = int.Parse(Console.ReadLine());

        }
        int toplam = 0;
        foreach (var s in sayi)
        {
            toplam += s;
            
        }
        Console.Write("Ortalama =" +toplam/diziuzunlugu);

        

        }
    }
}