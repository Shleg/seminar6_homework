// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Main()
{
    double k1 = InputNum("Enter coefficient k1: ");
    double b1 = InputNum("Enter coefficient b1: ");
    double k2 = InputNum("Enter coefficient k2: ");
    double b2 = InputNum("Enter coefficient b2: ");
    double[] myArray = IntersectionPoint(k1, b1, k2, b2);
    MethodPrint(k1, b1, k2, b2, myArray);
}

double InputNum(string messageToUser)
{
    Console.Write(messageToUser);
    return double.Parse(Console.ReadLine());
}

void MethodPrint(double a, double b, double c, double d, double[] array)
{
    Console.WriteLine($"k1 = {a}, " +
                      $"b1 = {b}, " +
                      $"k2 = {c}, " +
                      $"b2 = {d}, " +
                      " -> " + string.Join(", ", array));
}

double[] IntersectionPoint(double a, double c, double b, double d )
{
    return new double[]{(d - c) / (a - b), (a * (d - c) / (a - b)) + c };
}

Main();