// See https://aka.ms/new-console-template for more information
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

Console.WriteLine("Hi");












float[] scalevector (float[] vector, float scalar)
{
    float[] scale = new float[vector.Length];
    for (int i = 0; i < vector.Length; i++)
    {
        scale[i] = vector[i] + scalar;
    }
    
    return scale;
}



float[] myVector = new float[2];
myVector[0] = 1;
myVector[1] = 1;

float myScalar = 2f;











float[] scalevector2(float[] vector, float scalar)
{
    float[] scale = new float[vector.Length];
    for (int i = 0; i < vector.Length; i++)
    {
        scale[i] = vector[i] + vector[i];
    }

    return scale;
}



float[] myVector2 = new float[2];
myVector[0] = 1;
myVector[1] = 1;

float myScalar2 = 2f;






string replace (string text, char find)
{
    char letters = text.ToCharArray;
    for (int i = 0; i < letters.Length; i++)
    {
        if (letters[i] == find)
        {
            letters = replace;
        };
    };
        return text;
}

string text = "aaaaaskhuiseahusahfufjhaaaa";

string hiddenText = replace (text, 'a' , '*');






































