// Задайте массив. Напишите программу, которая определяет, присутстсвует ли заданное число в массиве. (да/нет)

using System.Reflection.Metadata.Ecma335;

int[] CreateArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}


bool FindNumber(int num, int[] array)
{
    foreach (int item in array)
    {
        if(item == num)
        {
            return true;
        }
    }
    return false;
}


int[] InvAr(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}


System.Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(size, min, max);
PrintArray(arr);
System.Console.WriteLine();
System.Console.Write("Input num wants to find: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(FindNumber(num, arr));
PrintArray(InvAr(arr));