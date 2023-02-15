//Задача 45: Напишите программу, которая будет создавать 
//копию заданного массива с помощью поэлементного 
//копирования.

Console.Clear();

int[] arr1 = GetArray(10, 0, 9);
Console.WriteLine(string.Join(", ", arr1));
int[] arr2 = CloneArray(arr1);
Console.WriteLine(string.Join(", ", arr2));
int[] arr3 = MultArrays(arr1, arr2);
Console.WriteLine(string.Join(", ", arr3));

int[] CloneArray(int[] someArray)
{
    int[] res = new int[someArray.Length];
    for (int i = 0; i < someArray.Length; i++)
    {
        res[i] = someArray[i];
    }
    return res;
}
int[] MultArrays(int[] arr1, int[] arr2)
{
    int[] res = new int[arr1.Length];
    for (int i = 0; i < arr1.Length; i++)
    {
        res[i] = arr1[i] * arr2[i];
    }
    return res;
}
int[] GetArray(int size, int min, int max)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max + 1);
    }
    return res;
}

