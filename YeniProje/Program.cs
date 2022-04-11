// See https://aka.ms/new-console-template for more information

//type safety = tip güvenliği

string kategoriEtiketi = "Kategori";
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi = true;
double dolarDun = 7.35;
double dolarBugun = 7.45;

if (dolarDun > dolarBugun)
{
    Console.WriteLine("Azalış butonunu göster");
}
else if (dolarDun < dolarBugun)
{
    Console.WriteLine("Artış butonunu göster");
}
else
{
    Console.WriteLine("Değişmedi butonunu göster");
}

if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullanıcı ayarları butonu");
}
else
{
    Console.WriteLine("Giriş yap butonu");
}

Console.WriteLine(kategoriEtiketi);
