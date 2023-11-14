// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Diagnostics;

string KONEC = "N";
do
{
    Console.WriteLine("zadej koeficienty pro rovnici ax^2 + bx + c = 0");
    Console.WriteLine("zadej koeficient: a");

    float numberA;
    while (!float.TryParse(Console.ReadLine(), out numberA))
        Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");

    Console.WriteLine("zadej koeficient: b");

    float numberB;
    while (!float.TryParse(Console.ReadLine(), out numberB))
        Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");

    Console.WriteLine("zadej koeficient: c");

    float numberC;
    while (!float.TryParse(Console.ReadLine(), out numberC))
        Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");

    Console.Write(numberA + "x^2 + " + numberB + " x + " + numberC + " = 0 má ");

    double x1 = (-1 * numberB + Math.Sqrt(numberB * numberB - (4 * numberA * numberC))) / (2 * numberA);
    double x2 = (-1 * numberB - Math.Sqrt(numberB * numberB - (4 * numberA * numberC))) / (2 * numberA);
    double D = (numberB * numberB - (4 * numberA * numberC));


    if (D < 0)
    {
        Console.WriteLine("0 řešení");
    }


    else if (x1 == x2)
    {
        Console.WriteLine("1 řešení");
        Console.WriteLine("x = " + x1);
    }

    else
    {
        Console.WriteLine(" 2 řešení");

        Console.WriteLine("x = " + x1);
        Console.WriteLine("x = " + x2);


    }



    float X;
    float R;
    string Konec2 = "ne";

    while (Konec2 != "stop")
    {
        Console.WriteLine("vložte parametr x k výpočtu (zadej ´stop´ k zastavení)");
        Konec2 = Console.ReadLine();
        if (Konec2 != "stop")
        {
            if (!float.TryParse(Konec2, out X))
            {
                Console.WriteLine("Neplatné číslo, zadejte prosím znovu.");
            }
            else
            {
                R = numberA * X * X + numberB * X + numberC;
                Console.WriteLine(numberA + "*" + X + "^2 + " + numberB + "*" + X + " + " + numberC + " = " + R);
            }
        }
        else
        {
            Console.WriteLine("Opravdu chcete ukončit program A/N");
            KONEC = Console.ReadLine();
        }
    } 
}
while (KONEC != "A") ;


