using System;

namespace Odev4_DizilerVeDonguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınacak sayılar için 5 elemanlı bir dizi oluşturuyoruz.
            int[] sayilar = new int[5];

            // Toplamı hesaplamak için değişken tanımlıyoruz.
            int toplam = 0;

            Console.WriteLine("Lütfen 5 adet sayı giriniz:");

            // for döngüsü kullanarak kullanıcıdan 5 sayı alıyoruz.
            for (int i = 0; i < 5; i++)
            {
                Console.Write((i + 1) + ". sayıyı giriniz: ");
                // Kullanıcıdan alınan sayıyı diziye kaydediyoruz.
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            // foreach döngüsü ile dizideki tüm sayıları topluyoruz.
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }

            // Ortalama hesaplanıyor.
            double ortalama = toplam / 5.0; // 5.0 diyerek ondalıklı bölme yaptık.

            // Sonuç ekrana yazdırılıyor.
            Console.WriteLine("Girdiğiniz sayıların ortalaması: " + ortalama);

            // Program kapanmasın diye kullanıcıdan bir tuşa basmasını bekliyoruz.
            Console.WriteLine("Çıkmak için bir tuşa basınız...");
            Console.ReadKey();
        }
    }
}
