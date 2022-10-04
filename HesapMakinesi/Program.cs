using Hesaplama;


Basla();

void Basla()
{
    double x = Cevir("1. Sayı");
    double y = Cevir("2. Sayı");
    double sonuc = Islem(x,y);
    Console.WriteLine("Sonuç : {0}",sonuc);
    Console.ReadLine();
    Basla();
}
double Islem(double x, double y)
{
    double sonuc = 0;
    Console.WriteLine("İşlem kodu?");
    string isKod = Console.ReadLine();
    if (isKod == "+")
    {
        sonuc = Hesap.Topla(x, y);
    }
    else if (isKod == "-")
    {
        sonuc = Hesap.Cıkar(x, y);
    }
    else if (isKod == "/")
    {
        sonuc = Hesap.Bol(x, y);
    }
    else if (isKod == "*")
    {
        sonuc = Hesap.Carp(x, y);
    }
    else if (isKod =="k")
    {
        sonuc = Hesap.KarekokAlma(x);
    }
    else
    {
        Console.WriteLine("Yanlış Kod");
        return Islem(x, y);
    }
    return sonuc;
}
double Cevir(string txt)
{
    Console.WriteLine(txt);
    
    return Convert.ToDouble(Console.ReadLine());
}