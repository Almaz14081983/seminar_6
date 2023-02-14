// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

int InputNumber(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;}

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
  Console.Write("Числа введеные пользователем для проверки ");
  for (int i = 0; i < someArray.Length - 1; i++)
  {
    Console.Write($"{someArray[i]}, ");
  }
  Console.WriteLine($"{someArray[someArray.Length - 1]},");
}

int[] HowManyNumbers(int[]someArray)
{         
    int positiveNumber = 0;  
    for(int i = 0; i<= someArray.Length-1; i=i+1) 
    { 
        if(someArray[i]>0) positiveNumber = positiveNumber + 1; 
    }
    if(positiveNumber <= 0) Console.WriteLine($"среди введенных пользователем чисел, нет чисел которые больше 0");
    if(positiveNumber == 1) Console.WriteLine($"пользователь ввёл {positiveNumber} число больше 0");
    if((positiveNumber == 2)||(positiveNumber == 3)||(positiveNumber == 4)) Console.WriteLine($"пользователь ввёл {positiveNumber} числа больше 0");
    if(positiveNumber >= 5) Console.WriteLine($"пользователь ввёл {positiveNumber} чисел больше 0");
    return someArray;           
}

int size = InputNumber("Введите количество чисел необходимое для проверки M = ");
int min = InputNumber("Введите минимальное число");
int max = InputNumber("Введите максимальное число");
int[] array = GetArray(size, min, max );
array = GetArray(size, min, max );
PrintArray(array);
array = HowManyNumbers(array);
