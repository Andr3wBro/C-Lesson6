//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double enter(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    return double.Parse(number);
}

double k1 = enter("Enter k1 => ");
double k2 = enter("Enter k2 => ");
double b1 = enter("Enter b1 => ");
double b2 = enter("Enter b2 => ");
double x = (b2 - b1) / (k1 - k2);// Вычислил на бумажке припровняв два неравенства. 
double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
Console.WriteLine($"Point of intersection of two lines => ({x} , {y})");