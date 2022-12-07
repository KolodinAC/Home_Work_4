// Напишите программу, которая принимает на вход два числа (A и B) и 
// метод который возводит число A в натуральную степень B.

Console.Write("Введите число:  ");
double numbA = UserInput();
Console.Write("Введите степень для числа:  ");
double numbB = UserInput();
double result = RiseNumbToPow(numbA, numbA);
Console.WriteLine($"Результат возведения числа {numbA} в степень {numbB} равняется:  " + result);


// Methods:

double UserInput()
{
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
    double pow = numbB;
    double res = 1;
    
    for (int i = 1; i <= pow; i++)
    {
        res = res * num;
    }
    return res;    
}