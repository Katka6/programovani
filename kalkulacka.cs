// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");
Console.WriteLine("Pick a number");

double N1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Pick a number");

double N2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Pick a op");

string N3 = Console.ReadLine ();

if (N3 == "+")
{
    double u = N1 + N2;
    Console.WriteLine("v " + u);
}

    if (N3 == "-") ;
    {
        double t = N1 - N2;
        Console.WriteLine("v " + t);
    }
 
    if (N3 == "*")
    {
        double q = N1 * N2;
        Console.WriteLine("v " + q);
    }



    if (N3 == "/")
    {
        double w = N1 / N2;
        Console.WriteLine("v " + w);
    }

    if (N3 == "^")
    {
        double e = 1;
        for (int i = 0; i < N2; i++)
            e = N1 * e;
        Console.WriteLine("v " + e);
    }


    if (N3 == "%")
    {
        double e = N1 % N2;
        Console.WriteLine("v " + e);
    }



