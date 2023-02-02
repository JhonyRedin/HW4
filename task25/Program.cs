// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNumber(string str)
{
    int number;
    string? text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();

        if (int.TryParse(text, out number))
        {
            break;
        }

        System.Console.WriteLine("Введено не корректное число, попробуй ещё раз");
    }
    return number;

}

int InputNumber2(string message)
{
    int number;
    while (true)
    {
        System.Console.Write(message);
        if (!(int.TryParse(Console.ReadLine(), out number)))
        {
            System.Console.WriteLine("Введено некорректное число, попробуйте ещё раз.");
        }
        else break;
    }
    return number;
}

int Exponent ( int number, int exp)
{
    int result = number;
    for (int i = 1; i < exp; i++)
    {
        result = result * number;
    }
    return result;
}

int A =InputNumber ("Введите число А: ");
int B = InputNumber2 ("Введите число B: ");

int res = Exponent (A,B);
System.Console.WriteLine($"Результат возведения числа {A} в степень {B}: {res}");