using System.Globalization;

ProjeYoneticisi ProjeYoneticisi1 = new ProjeYoneticisi("Hasan", "Çıldırmış", "Proje Yönetimi");
BasePerson YazılımGelistiricisi1 = new YazılımGeliştirici("Murat", "Demir", "Yazılım Geliştirme");
BasePerson VeriAnalisti1 = new VeriAnalisti("Ayşe", "Yılmaz", "Veri Analizi");
Console.WriteLine("Sorgudan çıkmak için Q tuşuna basınız.");

while (true)
{
    Console.Write("Sorgulamak istediğiniz kişiyi seçiniz(Hasan , Murat , Ayşe) :");
    string yanıt = Console.ReadLine().ToLower();
    if (yanıt == "hasan")
        ProjeYoneticisi1.Gorev();
    else if (yanıt == "murat")
    {
        YazılımGelistiricisi1.Gorev();
    }
    else if (yanıt == "ayşe" ||yanıt == "ayse")
    {
        VeriAnalisti1.Gorev();
    }
    else if (yanıt == "q")
    {
        Console.WriteLine("Sorgudan çıkılıyor...");
        break;
    }
    else
    {
        Console.WriteLine("Geçersiz giriş. Lütfen Hasan, Murat veya Ayşe giriniz.");
    }
}
