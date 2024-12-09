using System;
using System.Text.RegularExpressions;
namespace PatikaWhileForeach;
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int rastgeleSayi = rnd.Next(1,101);
        int kullaniciTahmini = 0;
        System.Console.WriteLine("Lütfen 1-100 arası sayı düşünün!");
        while(kullaniciTahmini!=rastgeleSayi)
        {
            System.Console.Write("Lütfen tahmininizi giriniz: ");
            string girdi = Console.ReadLine();
            if(int.TryParse(girdi,out kullaniciTahmini))
            {
                if(kullaniciTahmini>rastgeleSayi)
                {
                    System.Console.WriteLine("Daha küçük sayı giriniz!");
                }
                else if(kullaniciTahmini<rastgeleSayi)
                {
                    System.Console.WriteLine("Daha büyük sayı giriniz!");
                }
                else
                {
                    System.Console.WriteLine("Tebrikler doğru tahmin ettiniz!");
                }
            }else
            {
                System.Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
            }
        }
        List <int> ogrenciNotlari = new List<int>{55,60,75,77,94,84,49,42,36,62};
        int toplam=0;
        foreach(var not in ogrenciNotlari)
        {
            toplam+=not;
        }
        double ortalama = (double)toplam/ogrenciNotlari.Count;
        System.Console.WriteLine($"Sınıfın ortalaması: {ortalama}");

        int ortalamaUstendekiOgrenciSayisi=0;
        foreach(var not in ogrenciNotlari)
        {
            if(not > ortalama)
            {
                ortalamaUstendekiOgrenciSayisi++;
            }
        }
        System.Console.WriteLine($"Ortalmadan yüksek not alan öğrenci sayısı: {ortalamaUstendekiOgrenciSayisi}");
        int kalanOgrenciSayisi = 0;
        foreach(var not in ogrenciNotlari)
        {
            if(not < 50)
            {
                kalanOgrenciSayisi++;
            }
        }
        System.Console.WriteLine($"Kalan öğrenci sayısı: {kalanOgrenciSayisi}");
    }
}
