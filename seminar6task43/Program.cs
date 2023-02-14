//Задача 43. Напишите программу, которая найдёт точку
//пересечения двух прямых, заданных уравнениями y = k1 *
//x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
//пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// y = k1 * x + b1
// y = k2 * x + b2

Console.Clear();

Console.Write("Введите минимальное число в диапазоне ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное число в диапазоне ");
int max = int.Parse(Console.ReadLine()!);

double InputValue (int min, int max)
{
    double value = new Random().NextDouble() + new Random().Next(min, max+1);
    // Console.Write("value = "+ value);
    return value;
}

double k1 = InputValue(min, max);
Console.WriteLine("значение k1 = " + k1 );

double b1 = InputValue(min, max);
Console.WriteLine("значение b1 = " + b1 );

double k2 = InputValue(min, max);
Console.WriteLine("значение k2 = " + k2 );

double b2 = InputValue(min, max);
Console.WriteLine("значение b2 = " + b2 );

//double Intersectionline(int k1, int b1, int k2, int b2)
//{
    //double x = (b2 - b1)/(k1 - k2);
    //double y = (k1 * x) + b1;
    //Console.WriteLine("точка пересечения двух прямых (" + x + ","+ y + ")"); // (-0,5; -0,5)
    //return x;
//}

double CoordinateX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1)/(k1 - k2);
    //double y = (k1 * x) + b1;
    //Console.WriteLine("точка пересечения двух прямых (" + x + ","+ y + ")"); // (-0,5; -0,5)
    return x;
}

double CoordinateY(double k1, double b1, double x)
{
    //double x = (b2 - b1)/(k1 - k2);
    double y = (k1 * x) + b1;
    //Console.WriteLine("точка пересечения двух прямых (" + x + ","+ y + ")"); // (-0,5; -0,5)
    return y;
}

double x = CoordinateX(k1, b1, k2, b2);
double y = CoordinateY(k1, b1, x);
Console.WriteLine("точка пересечения двух прямых (" + x + "; "+ y + ")");