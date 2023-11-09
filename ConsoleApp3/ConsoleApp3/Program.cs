// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



int[] number = { 1, 2, 3 };
int[] number2 = number;
//int[] number2 = new int[] {1,2,3};
//int[] number3 = new int[10];

//úplně stelný u všeho ostatního
Console.WriteLine(number);
Console.WriteLine(number2);
//Console.WriteLine(number[0]);

void printarray (int[] array)
{
    for (int i = 0; i<3; i++) 
    {
        Console.Write(array[i]);
    };
};

printarray (number);

printarray(number2);



void changefirst(ref int[] array, int newvalue)
{
    array[0] = newvalue;
    array = new int[] { 20, 30, 20, 3 };
}
changefirst(ref number, 42);
printarray (number);
printarray (number2);

int[] coefficients = new int[] { 6, 5, 4, -2, 4, 9 };


void printpolynomial (int[] array)
{
    for (int d = 0; d<coefficients.Length; d++)
    {
        Console.Write(coefficients[d]);
        Console.Write("+") ;
        Console.Write(coefficients.Length - d - 1) ;

    }
}













