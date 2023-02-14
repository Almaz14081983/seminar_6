// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();
int num = Input();
Console.WriteLine(DecimalToBinary(num));

int Input()
{
    Console.Write("Введите число: ");
    int res = int.Parse(Console.ReadLine()!)!;
    return res;
}

string DecimalToBinary(int someNum)
{
    string str = "";
    do
    {
        str = Convert.ToString(someNum % 2) + str;
        someNum = someNum / 2;
    } while (someNum != 0);
    return str;
}
