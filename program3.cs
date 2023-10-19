// See https://aka.ms/new-console-template for more information


using System.IO.Pipes;


Console.WriteLine("Pick a number");

double N6 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Pick a number");

double N7 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Pick a op");

string N8 = Console.ReadLine();

while(true)

    switch (N8)
{
    case "+":

        Console.WriteLine(N7 + N6);
        break;
    case "-":

        Console.WriteLine(N7 - N6);
        break;
    case "*":

        Console.WriteLine(N7 * N6);
        break;
    case "/":

        Console.WriteLine(N7 / N6);
        break;
    case "%":

        Console.WriteLine(N7 % N6);
        break;
    case "^":
        double e = 1;
        for (int i = 0; i < N7; i++)
            e = N6 * e;
        Console.WriteLine(e);
        break;
            Console.WriteLine("chces pokracovat?");
            string volba = Console.ReadLine();
            if (volba == "ano") ;
            
};















