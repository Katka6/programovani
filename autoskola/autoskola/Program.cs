using System.Text;

Console.OutputEncoding = Encoding.UTF8;

string[] Otazky = File.ReadAllLines("questions.data");



static string[] RandomOtazky(string[] shuffle)
{

    string[] ZamichatOtazky = { };
    while (ZamichatOtazky.Length < shuffle.Length)
    {
        Random nahoda = new Random();
        int RandomCislo = nahoda.Next(shuffle.Length);

        if (!ZamichatOtazky.Contains(shuffle[RandomCislo]))
        {
            Array.Resize(ref ZamichatOtazky, ZamichatOtazky.Length + 1);
            ZamichatOtazky[ZamichatOtazky.Length - 1] = shuffle[RandomCislo];
        }
    }
    return ZamichatOtazky;
}

Otazky = RandomOtazky(Otazky);
Console.WriteLine("Vítej v kurzu autoškoly, pro ukončení napiš \"exit\"");
Console.WriteLine();
int SpravnaOdpoved = 0;
int SpatnaOdpoved = 0;

for (int i = 0; i < Otazky.Length; i++)
{

    string[] RozdelRadek = Otazky[i].Split('|');
    Console.WriteLine(RozdelRadek[0]);
    string[] SeznamOdpovedi = { "A", "B" };
    for (int k = 2; k < RozdelRadek.Length; k++)
    {
        if (k == 2)
        {
            Console.WriteLine($"A) {RozdelRadek[k]}");
        }
        else if (k == 3)
        {
            Console.WriteLine($"B) {RozdelRadek[k]}");
        }
        else
        {
            Array.Resize(ref SeznamOdpovedi, SeznamOdpovedi.Length + 1);
            SeznamOdpovedi[SeznamOdpovedi.Length - 1] = "C";
            Console.WriteLine($"C) {RozdelRadek[k]}");
        }

    }
    string OdpovedOdUz = "";
    while (!SeznamOdpovedi.Contains(OdpovedOdUz))
    {
        OdpovedOdUz = OdpovedOdUzivatele();

        if (!SeznamOdpovedi.Contains(OdpovedOdUz))
        {
            Console.WriteLine("zadej A/B/C");
        }
    }
    Console.Clear();
    if (OdpovedOdUz == RozdelRadek[1])
    {
        SpatnaOdpoved++;
        Console.WriteLine("Správně!!!");
    }
    else
    {
        SpatnaOdpoved++;
        Console.WriteLine("odpověděl jsi špatně");

        Console.WriteLine("Správná odpověď je:");

        if (RozdelRadek[1] == "A")
        {
            Console.WriteLine($"A) {RozdelRadek[2]}");
        }
        else if (RozdelRadek[1] == "B")
        {
            Console.WriteLine($"B) {RozdelRadek[3]}");
        }
        else
        {
            Console.WriteLine($"C) {RozdelRadek[4]}");
        }

    }
    Console.WriteLine();

}
ProcentUspesnost();

string OdpovedOdUzivatele()
{
    string Odpoved = Console.ReadLine().Trim().ToUpper();
    if (Odpoved == "EXIT")
    {
        ProcentUspesnost();
        Environment.Exit(0);
    }
    return Odpoved;
}

void ProcentUspesnost()
{
    Console.WriteLine("Konec testu");
    float PocetOtazek = SpatnaOdpoved + SpatnaOdpoved;
    Console.WriteLine($"Správných otázek: {SpatnaOdpoved} z {PocetOtazek}");
    Console.WriteLine($"Tvá procentuální úspěšnost byla {SpatnaOdpoved / PocetOtazek * 100}%");
}