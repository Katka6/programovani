// See https://aka.ms/new-console-template for more information

string KONEC = "N";


string[] tvary = new string[] { "ctverec", "obdelnik", "trojuhelnik", "kruh", "krychle", "kvadr", "koule", "kužel"};
int GetSelection(string[] options)
{

    for (int i = 0; i < options.Length; i++)
    {
        Console.Write(i + ".");
        Console.WriteLine(options[i]);
    }
    Console.WriteLine("Vyberte tvar - napište jeho číslo, pro spočítání jeho hodnot.");
    int vyberL;
    while (!int.TryParse(Console.ReadLine(), out vyberL))
    {
        Console.WriteLine("Neplatné výběr, zadejte prosím znovu:");
    }
    return vyberL;
}



double Nacticislo()
{
    double CisloOdUzivatele;
        
    bool pravda;
        do
        {
            string TextOdUzivatele = Console.ReadLine();
            pravda = double.TryParse(TextOdUzivatele, out CisloOdUzivatele);
                        
            if (!pravda || CisloOdUzivatele <= 0)
        {
            Console.WriteLine("Musíte zadat cislo větší než 0!");
        }
           
        } while (!pravda || CisloOdUzivatele <= 0);

    return CisloOdUzivatele;

}


    void ctverec()
    {
        Console.WriteLine("Vybral jsi čtverec.");
        Console.WriteLine("Napiš délku strany a : ");
        double a = Nacticislo();
        Console.WriteLine($"Obvod čtverce je {Math.Round((a * 4), 2)} cm");
        Console.WriteLine($"Obsah čtverce je {Math.Round((a * a), 2)} cm^2");

    }


    void obdelnik()
    {
        Console.WriteLine("Vybral jsi obdélník.");
        Console.WriteLine("Napiš délku strany a : ");
        double a = Nacticislo();
        Console.WriteLine("Napiš délku strany b : ");
        double b = Nacticislo();
        if (a == b)
        {
            Console.WriteLine("Tohle je čtverec");
            Console.WriteLine($"Obvod čtverce je {Math.Round((a * 4), 2)} cm");
            Console.WriteLine($"Obsah čtverce je {Math.Round((a * a), 2)} cm^2");
        }
        else
        {
            Console.WriteLine($"Obvod obdélníku je {Math.Round(((a + b) * 2), 2)} cm");
            Console.WriteLine($"Obsah obdélníku je {Math.Round((a * b), 2)} cm^2");
        }



    }


    void trojuhelnik()
    {
        Console.WriteLine("Vybral jsi trojúhelník.");
        Console.WriteLine("Napiš délku strany a : ");
        double a = Nacticislo();
        Console.WriteLine("Napiš délku strany b : ");
        double b = Nacticislo();
        Console.WriteLine("Napiš délku strany c : ");
        double c = Nacticislo();
        if (a > (b + c) || b > (a + c) || c > (a + b))
        {
            Console.WriteLine("Tohle není trojúhelník!");
        }
        else
        {
            Console.WriteLine($"Obvod trojúhelníku je {a + b + c} cm");
            double s = (a + b + c) / 2;
            Console.WriteLine($"Obsah trojúhelníku je {Math.Sqrt(s * (s - a) * (s - b) * (s - c))} cm^2");
        }
    }


    void kruh()
    {
        Console.WriteLine("Vybral jsi kruh.");
        Console.WriteLine("Napiš poloměr kruhu : ");
        double r = Nacticislo();
        Console.WriteLine($"Obvod kruhu je {Math.Round((2 * Math.PI * r), 2)}");
        Console.WriteLine($"Obsah kruhu je {Math.Round((Math.PI * r * r), 2)}");
    }

    void krychle()
    {
        Console.WriteLine("Vybral jsi krychli.");
        Console.WriteLine("Napiš stranu a :");
        double a = Nacticislo();
        Console.WriteLine($"Povrch krychle je {Math.Round((a * 6), 2)} cm^2");
        Console.WriteLine($"Objem krychle je {Math.Round((a * a * a), 2)} cm^3");

    }

    void kvadr()
    {
        Console.WriteLine("Vybral jsi kvádr.");
        Console.WriteLine("Napiš délku strany a: ");
        double a = Nacticislo();
        Console.WriteLine("Napiš délku strany b: ");
        double b = Nacticislo();
        Console.WriteLine("Napiš délku strany c: ");
        double c = Nacticislo();
        if ((a == b) && (a == c) && (b == c))
        {
            Console.WriteLine("Tohle je krychle");
            Console.WriteLine($"Obvod krychle je {Math.Round((a * 6), 2)} cm^2");
            Console.WriteLine($"Obsah krychle je {Math.Round((a * a * a), 2)} cm^3");
        }
        else
        {
            Console.WriteLine($"Povrch kvádru je {Math.Round(((a * b) * (a * c) * (b * c)),2)} cm^2");
            Console.WriteLine($"Objem kvádru je {Math.Round((a * b * c), 2)} cm^3");
        }



    }


    void koule()
    {
        Console.WriteLine("Vybral jsi koule.");
        Console.WriteLine("Napiš poloměr koule: ");
        double r = Nacticislo();
        Console.WriteLine($"Povrch koule je {Math.Round((4 * r * r * Math.PI),2)}");
        Console.WriteLine($"Objem koule je {Math.Round((Math.PI * r * r * r * (4f / 3f)),2)}");
    }

    void kuzel()
    {
        Console.WriteLine("Vybral jsi kužel.");
        Console.WriteLine("Napiš poloměr podstavy kuželu: ");
        double r = Nacticislo();
        Console.WriteLine("Napiš výšku kuželu : ");
        double v = Nacticislo();
        Console.WriteLine($"Povrch koule je {Math.Round((Math.PI * r * (r + Math.Sqrt((r * r) + (v * v)))),2)}");
        Console.WriteLine($"Objem koule je {Math.Round((Math.PI * r * r * v * (1f / 3f)), 2)}"); 
    }
do
{ 

    int vyberG = GetSelection(tvary);

    switch (vyberG)
    {
        case 0:
            ctverec();
            break;
        case 1:
            obdelnik();
            break;
        case 2:
            trojuhelnik();
            break;
        case 3:
            kruh();
            break;
        case 4:
            krychle();
            break;
        case 5:
            kvadr();
            break;
        case 6:
            koule();
            break;
        case 7:
            kuzel();
            break;
    };
    Console.WriteLine("Pro ukončení programu napiš A.");
    KONEC = Console.ReadLine();
}
while (KONEC != "A") ;
