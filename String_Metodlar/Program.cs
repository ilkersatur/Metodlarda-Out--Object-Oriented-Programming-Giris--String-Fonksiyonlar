string mesaj = "MERHABA DÜNYA";
// bir string ifade içerisinde karakter veya string bazlı arama yapar-----varsa true yoksa false döner
Console.WriteLine(mesaj.Contains('B'));
Console.WriteLine(mesaj.Contains("DÜ"));

Console.WriteLine(mesaj.IndexOf('D')); //var olduğunu biliyor  ve  kaçıncı sırada olduğunu döndürür, yoksa -1 yazar

Console.WriteLine(mesaj.LastIndexOf('A')); // En sondaki karakterin indeksini yazar


Console.WriteLine(mesaj.Insert(1, "naber")); // indekse string içersindeki değeri ekler

Console.WriteLine(mesaj.Length);//metod değil özellik

Console.WriteLine(mesaj.Remove(2));  // 2 den sonrasını at    --------------- String ifade içerisinde istenilmeyen
Console.WriteLine(mesaj.Remove(5, 2)); //5 ten başla 2 tane at                 kısımları silmek iöin kullanılır

Console.WriteLine(mesaj.Replace('A', ' ')); //karakterlerin yerlerini değiştir
Console.WriteLine(mesaj.Replace("DÜNYA", "MARS")); // kelimeleri değiştir


//// bir string ifadeyi istenilen karakter veya string ifadeye göre bölmek için kullanılır
foreach (var item in mesaj.Split(' '))
{
    Console.WriteLine(item);
}
foreach (var item in mesaj.Split('A'))
{
    Console.WriteLine(item);
}

foreach (var item in mesaj.Split('A', 'E', 'D'))
{
    Console.WriteLine(item);
}

Console.WriteLine(mesaj.Substring(4, 1)); // bir string içerisinde istenilen indisten itibaren bir kısmını veya tamamını tutar


Console.WriteLine(mesaj.ToLower()); // hepsini büyük ya da küçük karaktere döndürür
Console.WriteLine(mesaj.ToUpper());

string str = "               MERHABA                               ";
Console.WriteLine(str);
Console.WriteLine(str.Trim()); // sadece iki boşluğu atar
Console.WriteLine(str.TrimStart()); // baştaki boşluğu atar
Console.WriteLine(str.TrimEnd()); // sondaki boşluğu atar