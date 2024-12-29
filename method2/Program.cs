using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Geriye değer döndürmeyen bir void metot
        YazSevdiginSarkiSozu();

        // 2. Geriye tamsayı döndüren bir metot
        int kalan = RastgeleSayiBolumdenKalan();
        Console.WriteLine($"Rastgele sayının 2'ye bölümünden kalan: {kalan}");

        // 3. Parametre alan ve geriye değer döndüren bir metot
        int carpimSonucu = IkiSayininCarpimi(5, 7);
        Console.WriteLine($"5 ve 7'nin çarpımı: {carpimSonucu}");

        // 4. Parametre alan ve geriye değer döndürmeyen bir metot
        HosGeldinizMesaji("Hamdullah", "Özkan");

        // Programın sonlanmasını beklemek için
        Console.ReadLine();
    }

    // Geriye değer döndürmeyen bir void metot
    static void YazSevdiginSarkiSozu()
    {
        Console.WriteLine("Gün olur alır başımı giderim, denizden yeni çıkmış ağlarım kokusunda.");
    }

    // Geriye tamsayı döndüren bir metot
    static int RastgeleSayiBolumdenKalan()
    {
        Random rastgele = new Random();
        int sayi = rastgele.Next(1, 101); // 1 ile 100 arasında rastgele sayı üret
        return sayi % 2;
    }

    // Parametre alan ve geriye değer döndüren bir metot
    static int IkiSayininCarpimi(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
    }

    // Parametre alan ve geriye değer döndürmeyen bir metot
    static void HosGeldinizMesaji(string isim, string soyisim)
    {
        Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");
    }
}
