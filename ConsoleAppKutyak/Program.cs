using ConsoleAppKutyak;



// 3. feladat

List<Kutyak> kutyak = new List<Kutyak>();

StreamReader srNevek = new StreamReader("KutyaNevek.csv");
StreamReader srFajtak = new StreamReader("KutyaFajtak.csv");
StreamReader srKutyak = new StreamReader("Kutyak.csv");

int kutyanevekCount = 0;

srNevek.ReadLine();
srFajtak.ReadLine();
srKutyak.ReadLine();
while (!srKutyak.EndOfStream)
{
    Kutyak kifejezes = new Kutyak(srNevek.ReadLine(),srFajtak.ReadLine(),srKutyak.ReadLine());
    kutyak.Add(kifejezes);
}


while (!srNevek.EndOfStream)
{
    kutyanevekCount++;
}
Console.WriteLine("3. feladat: Kutyanevek száma: " + kutyanevekCount.ToString());

srNevek.Close();
srFajtak.Close();
srKutyak.Close();




// 4. fealdat
