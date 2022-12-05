// Напишите программу, которая принимает на вход два числа (A и B) и 
// метод который возводит число A в натуральную степень B.

double numbA = UserInputA();
double numbB = UserInputB();
double result = RiseNumbToPow(numbA, numbA);
Console.WriteLine(result);


// Методы:

double UserInputA()
{
    Console.WriteLine("Введите первое число:");
    bool isNum = double.TryParse(Console.ReadLine(), out double num);
    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}

double UserInputB()
{
    Console.WriteLine("Введите второе число:");
    bool isNum = double.TryParse(Console.ReadLine(), out double num);
    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}

double RiseNumbToPow(double numbA, double numB)
{
    double num = numbA;
    double pow = numB;
    double res = 0;
    
    for (int i = 1; i <= pow; i++)
    {
        res = res * num;
    }
    return res;    
}