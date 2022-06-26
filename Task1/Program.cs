// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Полностью сделал сам без использования гугла.
Console.Write("Enter count of numbers => ");
string countNumbers = Console.ReadLine();
int countNumbersInt = int.Parse(countNumbers);

double[] CreateAndFillArray(int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        double x = enter($"Enter number {i+1} => ");
        arr[i] = x;
    }
    return arr;
}

double enter(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    return double.Parse(number);
}

int SearchMoreZero(double[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"You enter {count} numbers more then zero");
    return count;
}
void printArr(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
    Console.WriteLine();
}

double[] myArray = CreateAndFillArray(countNumbersInt);
printArr(myArray);
SearchMoreZero(myArray);