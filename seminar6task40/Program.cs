
//Задача 40: Напишите программу, которая принимает на вход три
//числа и проверяет, может ли существовать треугольник с сторонами
//такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника
//меньше суммы двух других сторон.

Console.Clear();

double a = Input();
double b = Input();
double c = Input();


if (CheckTriangle(a, b, c))
{
    Console.WriteLine("Треугольник со сторонами такой длины может существовать.");
}
else
{
    Console.WriteLine($"Треугольник со сторонами такой длины не может существовать.");
}

bool CheckTriangle(double a, double b, double c)
{
    if ((a < (b + c)) && (b < (a + c)) && (c < (a + b))) return true; else return false;
}

double Input()
{
    Console.Write("Введите длину стороны треугольника: ");
    double res = double.Parse(Console.ReadLine()!)!;
    return res;
}