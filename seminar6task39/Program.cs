//Задача 39: Напишите программу, которая перевернёт
//одномерный массив (последний элемент будет на первом
//месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

Console.Clear();

int size = InputNumber("Введите размер массива");
int min = InputNumber("Введите минимальное значение в массиве");
int max = InputNumber("Введите максимальное значение в массиве");
int[] array = GetArray(size, min, max );
array = GetArray(size, min, max );


int InputNumber(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}

int[] GetArray(int size, int min, int max)
{
    int[] res = new int [size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(min, max+1);
    }
    return res;    
}

void PrintArray(int[] someArray)
{
  Console.Write("сгенерированный массив из случайных чисел [");
  for (int i = 0; i < someArray.Length - 1; i++)
  {
    Console.Write($"{someArray[i]}, ");
  }
  Console.WriteLine($"{someArray[someArray.Length - 1]}]");
}

int[] TurnOverArray(int[]someArray)
{         
    int leftindex = 0;  
    int rightindex = someArray.Length-1;
    while(leftindex < rightindex) 
    { 
        int index = someArray[leftindex]; 
        someArray[leftindex] = someArray[rightindex];
        someArray[rightindex] = index;
        leftindex = leftindex+1; 
        rightindex = rightindex - 1;
    }        
    return someArray;      
}

PrintArray(array);
array = TurnOverArray(array);
Console.WriteLine("перевернутый массив [" + String.Join(", ", array) + "]");
