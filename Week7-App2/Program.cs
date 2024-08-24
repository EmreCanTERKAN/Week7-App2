using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7_App2;

class Program
{

    static public void Main(string[] args)
    {
        List<DataBase> sarkicilar = new List<DataBase>
        {
            new DataBase { Ad = "Ajda Pekkan", MuzikTuru = "Pop", CikisYili = 1968, AlbumSatislari = 20 },
            new DataBase { Ad = "Sezen Aksu", MuzikTuru = "Türk Halk Müziği / Pop", CikisYili = 1971, AlbumSatislari = 10 },
            new DataBase { Ad = "Funda Arar", MuzikTuru = "Pop", CikisYili = 1999, AlbumSatislari = 3 },
            new DataBase { Ad = "Sertab Erener", MuzikTuru = "Pop", CikisYili = 1994, AlbumSatislari = 5 },
            new DataBase { Ad = "Sıla", MuzikTuru = "Pop", CikisYili = 2009, AlbumSatislari = 3 },
            new DataBase { Ad = "Serdar Ortaç", MuzikTuru = "Pop", CikisYili = 1994, AlbumSatislari = 10 },
            new DataBase { Ad = "Tarkan", MuzikTuru = "Pop", CikisYili = 1992, AlbumSatislari = 40 },
            new DataBase { Ad = "Hande Yener", MuzikTuru = "Pop", CikisYili = 1999, AlbumSatislari = 7 },
            new DataBase { Ad = "Hadise", MuzikTuru = "Pop", CikisYili = 2005, AlbumSatislari = 5 },
            new DataBase { Ad = "Gülben Ergen", MuzikTuru = "Pop / Türk Halk Müziği", CikisYili = 1997, AlbumSatislari = 10 },
            new DataBase { Ad = "Neşet Ertaş", MuzikTuru = "Türk Halk Müziği / Türk Sanat Müziği", CikisYili = 1960, AlbumSatislari = 2 }
        };

        var sIleBaslayanSarkicilar = sarkicilar.Where(ad => ad.Ad.StartsWith('S')).Select(ad => ad.Ad).ToList();
        Console.WriteLine("S ile Başlayan Şarkıcılar");
        foreach (var item in sIleBaslayanSarkicilar)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("******************");

        Console.WriteLine("Albüm Satışları 10 Milyonun Üstünde Olan Sanatçılar");
        var albumSatislari10MilyonUstunde = sarkicilar.Where(s => s.AlbumSatislari > 10).Select(s => s.Ad).ToList();
        Console.WriteLine("__________________________________");
        foreach (var item in albumSatislari10MilyonUstunde)
        {
            Console.WriteLine(item);
        }


        Console.WriteLine("******************");
        Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar.");
        var popMuzikYapan2000Oncesi = sarkicilar
            .Where(s => s.CikisYili < 2000 && s.MuzikTuru.Contains("Pop"))
            .OrderBy(s => s.CikisYili)
            .ThenBy(s => s.Ad)
            .Select(s => s.Ad)
            .ToList();
        foreach (var item in popMuzikYapan2000Oncesi)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("******************");
        var enCokAlbumSatanSarkici = sarkicilar.OrderByDescending(s => s.AlbumSatislari).First().Ad;
        Console.WriteLine($"En Çok Albüm Satan Şarkıcı: {enCokAlbumSatanSarkici}");
        var enYeniCikisYapanSarkici = sarkicilar.OrderByDescending(s => s.CikisYili).First().Ad;
        Console.WriteLine($"En Yeni Çıkış Yapan Şarkıcı:{enYeniCikisYapanSarkici} ");
        var enEskiCikisYapanSarkici = sarkicilar.OrderBy(s => s.CikisYili).First().Ad;
        Console.WriteLine($"En Eski Çıkış Yapan Şarkıcı:{enEskiCikisYapanSarkici} ");




    }

}