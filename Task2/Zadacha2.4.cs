// Задача 2: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе. Реализовать через функции.

long EnterNum()
{
    System.Console.Write(" Введите число >> ");
    long response = Math.Abs(Convert.ToInt64(Console.ReadLine()));
    return (response);
}

int DigitSum(long Num)
{
    int result = (int)(Num % 10);
    while (Num >= 10)
    {
        Num = Num / 10;
        result = (int)(result + Num % 10);
    }
    return (result);
}

System.Console.Write($"Сумма цифр в числе = {DigitSum(EnterNum())}.");