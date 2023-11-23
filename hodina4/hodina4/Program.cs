// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

Console.WriteLine("Hello, World!");


int[] array = new int[] {5,2,4,6,3,54,19};

int FindMax (int[] array)
{
    int max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
        if (array[i] > max)
        {
            max = array[i];
        }
    }


    return max;
}
int maximum = FindMax (array);
Console.WriteLine(maximum);










int FindMaxindex (int[] array)
{
    int max2 = array[0];
    int maxindex = 0 ;
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
        if (array[i] > max2)
        {
            max2 = array[i];
            maxindex = i;
        }
    }

    return max2;
}
int maximum2 = FindMaxindex(array);
int maximumindex = FindMaxindex(array);
Console.WriteLine("maximum is " + maximum2 + "and the index is " + maximumindex);





static void greetuser (string name = "defoult user")
{
    Console.WriteLine("hello" + name + "!");
}

greetuser("martin");





























