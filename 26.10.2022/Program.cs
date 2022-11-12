//metodlarda out kullanımı

//string deger = Convert.ToString(Console.ReadLine());

//int sonuc = Convert.ToInt16(Console.ReadLine());

//Console.WriteLine(int.TryParse(deger, out sonuc));

// out : bir metodun içerisinde out parametresi varsa o parametre üzerinden metodun dışına aktarılır...
//bool kontrol=int.TryParse(Console.ReadLine(), out int result);
//if (kontrol)
//{
//    Console.WriteLine(result);
//}

//

void Islem1(int sayi)
{
    sayi = 111;
}
void Islem2(int[] sayilar)
{
    for (int i = 0; i < sayilar.Length; i++)
    {
        sayilar[i] = 111;
    }
}

int a = 1;
int[] dizi = { 1, 2, 3, 4, 5 };

void DiziYazdir(int[] sayılar)
{
    foreach (int a in sayılar)
    {
        Console.Write(a + " ");
    }
    Console.WriteLine();
}
Console.WriteLine($"metod  öncesi a={a}");
Islem1(a);
Console.WriteLine($"metod  sonrası a={a}");
Console.WriteLine();
Console.WriteLine("metod öncesi dizi değerleri");
DiziYazdir(dizi);
Islem2(dizi);
Console.WriteLine("metod öncesi dizi değerleri");
DiziYazdir(dizi);