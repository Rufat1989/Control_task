using System;
using static System.Console;

Clear();
string[] array = new string[5] {"Russia", "Denmark", "Kazan", "123", "-2"};
string[] arrayres = new string[array.Length];
void GetArray(string[] array, string[] arrayres)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        arrayres[count] = array[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}
GetArray(array, arrayres);
PrintArray(arrayres);
