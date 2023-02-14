// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
double[] array = GetArray(size);
Console.WriteLine("сгенерированный массив из случайных чисел [" + String.Join(", ", array) + "]");
Console.WriteLine($"разницу между максимальным и минимальным элементами массива: {ChangeSign(array)}");

// int size = InputNumber("Введите размер массива");
//int min = InputNumber("Введите минимальное значение в массиве");
//int max = InputNumber("Введите максимальное значение в массиве");


double[] GetArray(int size)
{
    double[] res = new double [size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().NextDouble() + new Random().Next(-100, 100);
        // res[i] = new Random().NextDouble()*100;
    }
    return res;    
}

// array = GetArray(size);

//int InputNumber(string message)
//{
//    Console.Write($"{message}: ");
//    int res = int.Parse(Console.ReadLine()!);
//    return res;
//}

//void PrintArray(int[] someArray)
//{
  
//  Console.Write("сгенерированный массив из случайных чисел [");
//  for (int i = 0; i < someArray.Length - 1; i++)
//  {
//    Console.Write($"{someArray[i]}, ");
//  }
//  Console.WriteLine($"{someArray[someArray.Length - 1]}]");
//}

double ChangeSign(double[] someArray)
{
    //double index = someArray[0];
    double maxindex = someArray[0];
    double minindex = someArray[0];
    foreach( var index in someArray)
    {
        if(maxindex < index) maxindex = index;
        if(minindex > index) minindex = index;      
    }
    var result = maxindex - minindex;
 
    Console.WriteLine($"из них максимальное число: {maxindex}");
    Console.WriteLine($"из них минимальное число: {minindex}");
    //Console.WriteLine($"разницу между макс-ым и мин-ым элементами массива: {result}");
    return result;          
}

//PrintArray(array);
//array = ChangeSign(array);
