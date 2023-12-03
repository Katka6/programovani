// See https://aka.ms/new-console-template for more information

string KONEC = "N";


string[] tvary = new string[] { "ctverec", "obdelnik", "trojuhelnik", "kruh", "krychle", "kvadr", "koule" };
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
        Console.WriteLine("vybral jsi čtverec.");
        Console.WriteLine("Napiš délku strany a : ");
        double a = Nacticislo();
        Console.WriteLine($"Obvod čtverce je {a * 4} cm");
        Console.WriteLine($"Obsah čtverce je {a * a} cm^2");

    }


    void obdelnik()
    {
        Console.WriteLine("vybral jsi obdélník.");
        Console.WriteLine("Napiš délku strany a : ");
        double a = Nacticislo();
        Console.WriteLine("Napiš délku strany b : ");
        double b = Nacticislo();
        if (a == b)
        {
            Console.WriteLine("Tohle je čtverec");
            Console.WriteLine($"Obvod čtverce je {a * 4} cm");
            Console.WriteLine($"Obsah čtverce je {a * a} cm^2");
        }
        else
        {
            Console.WriteLine($"Obvod obdélníku je {(a + b) * 2} cm");
            Console.WriteLine($"Obsah obdélníku je {a * b} cm^2");
        }



    }


    void trojuhelnik()
    {
        Console.WriteLine("vybral jsi trojúhelník");
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
        Console.WriteLine("vybral jsi kruh");
        Console.WriteLine("Napiš poloměr kruhu : ");
        double r = Nacticislo();
        Console.WriteLine($"Obvod kruhu je {2 * Math.PI * r}");
        Console.WriteLine($"Obsah kruhu je {Math.PI * r * r}");
    }

    void krychle()
    {
        Console.WriteLine("vybral jsi krychli");
        Console.WriteLine("Napiš stranu a :");
        double a = Nacticislo();
        Console.WriteLine($"Povrch krychle je {a * 6} cm^2");
        Console.WriteLine($"Objem krychle je {a * a * a} cm^3");

    }

    void kvadr()
    {
        Console.WriteLine("vybral jsi kvádr.");
        Console.WriteLine("Napiš délku strany a : ");
        double a = Nacticislo();
        Console.WriteLine("Napiš délku strany b : ");
        double b = Nacticislo();
        Console.WriteLine("Napiš délku strany c : ");
        double c = Nacticislo();
        if ((a == b) && (a == c) && (b == c))
        {
            Console.WriteLine("Tohle je krychle");
            Console.WriteLine($"Obvod krychle je {a * 6} cm^2");
            Console.WriteLine($"Obsah krychle je {a * a * a} cm^3");
        }
        else
        {
            Console.WriteLine($"Povrch kvádru je {(a * b) * (a * c) * (b * c)} cm^2");
            Console.WriteLine($"Objem kvádru je {a * b * c} cm^3");
        }



    }


    void koule()
    {
        Console.WriteLine("vybral jsi koule");
        Console.WriteLine("Napiš poloměr koule : ");
        double r = Nacticislo();
        Console.WriteLine($"Povrch koule je {4 * r * r * Math.PI}");
        Console.WriteLine($"Objem koule je {Math.PI * r * r * r * (4 / 3)}");
    }

    void kuzel()
    {
        Console.WriteLine("vybral jsi kužel");
        Console.WriteLine("Napiš poloměr podstavy kuželu : ");
        double r = Nacticislo();
        Console.WriteLine("Napiš výšku kuželu : ");
        double v = Nacticislo();
        Console.WriteLine($"Povrch koule je {Math.PI * r * (r + Math.Sqrt((r * r) + (v * v)))}");
        Console.WriteLine($"Objem koule je {Math.PI * r * r * v * (1 / 3)}");
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
