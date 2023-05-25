

using ConsoleAppKutyak;



List<Kutyak> kutyak = new List<Kutyak>();

StreamReader srNevek = new StreamReader("KutyaNevek.csv");
StreamReader srFajtak = new StreamReader("KutyaFajtak.csv");
StreamReader srKutyak = new StreamReader("Kutyak.csv");

int kutyanevekCount = 0;

srNevek.ReadLine();
srFajtak.ReadLine();
srKutyak.ReadLine();

while (!srNevek.EndOfStream && !srFajtak.EndOfStream && !srKutyak.EndOfStream)
{
    Kutyak kifejezes = new Kutyak(srNevek.ReadLine(),srFajtak.ReadLine(),srKutyak.ReadLine());
    kutyak.Add(kifejezes);
}



srNevek.Close();
srFajtak.Close();
srKutyak.Close();


// 3. feladat
Console.WriteLine("3. feladat: Kutyanevek száma: " + kutyak.Count.ToString());

// 6. feladat
double eletkorAVG = kutyak.Average(x => x.Eletkor);
eletkorAVG = Math.Round(eletkorAVG,2);
Console.WriteLine($"6. feladat: Kutyák átlag életkora: {eletkorAVG}");

// 7.feladat
int maxKutyaEletkor = kutyak.Max(x => x.Eletkor);
string maxKutyaNev = "";
string maxKutyaFajta = "";
foreach (var item in kutyak)
{
    if (item.Eletkor == maxKutyaEletkor)
    {
        maxKutyaNev = item.Kutyanev;
        maxKutyaFajta = item.FajtaMagyar;
    }
}
Console.WriteLine($"7.feladat: Legidősebb kutya neve és fajtája: {maxKutyaNev}, {maxKutyaFajta}");

// 9. feladat

List<string> nevek = kutyak.Select(x => x.Kutyanev).Distinct().ToList();

foreach (var item in nevek)
{
    Console.WriteLine(item);
}

