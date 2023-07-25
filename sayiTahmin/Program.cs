// See https://aka.ms/new-console-template for more information


Random random = new Random();
int rastgele_sayi = random.Next(1, 50);
int tahmin;
int sayac = 0;

do
{
    Console.Write("Bir sayi giriniz: ");
    tahmin = Convert.ToInt32(Console.ReadLine());
    if (tahmin > rastgele_sayi)
    {
        Console.WriteLine("Sayıyı küçültün.");
    }
    else if (tahmin < rastgele_sayi)
    {
        Console.WriteLine("Sayıyı büyültün.");
    }
    sayac++;
} while (tahmin != rastgele_sayi);
Console.WriteLine("TEBRİKLER " + sayac + ". denemede sayıyı buldunuz !!");

Console.ReadLine();
