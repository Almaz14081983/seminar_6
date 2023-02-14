// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!)!;
Console.WriteLine(DecimalToBinary(num));

string DecimalToBinary(int someNum)
{
    string str = "";
    string res = "";
    do
    {
        str = str + Convert.ToString(someNum % 2);
        someNum = someNum / 2;
    } while (someNum != 0);
    for(int i = 0; i < str.Length; i ++)
    {
        res += str[str.Length -1 - i];
    }
    return res;
}
