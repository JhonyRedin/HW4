// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNumber2(string message)

{
    int number;
    while (true)
    {
        System.Console.Write(message);
        if (!(int.TryParse(Console.ReadLine(), out number)) && number % 10 == 0)
        {
            System.Console.WriteLine("Введено некорректное число, попробуйте ещё раз.");
        }
        else break;
    }
    return number;
}

int Sum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int numb = InputNumber2("Введите целое число: ");
int result = Sum(numb);
System.Console.WriteLine(result);