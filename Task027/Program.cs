// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int userNumber = UserInput();
int sumNumber = SumOfDigitsInNumber(userNumber);
Console.WriteLine("Сумма цифр в числе составляет: " + sumNumber);

int UserInput()
{
    Console.WriteLine("Введите желаемое число:");
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
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

int SumOfDigitsInNumber(int userNumber)
{
    int sum = 0;
    while (userNumber > 0)
    {
        sum = sum + userNumber % 10;
        userNumber = userNumber / 10;
    }
    return sum;
}
