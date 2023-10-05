// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("What is your name?");
string wow = Console.ReadLine();
if (wow == "pavel")
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

Console.WriteLine("Pick a number");
double number1 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Pick a number");
double number2 = Convert.ToDouble(Console.ReadLine());
double bla = number1 + number2;
Console.WriteLine("blabla "+ bla );










