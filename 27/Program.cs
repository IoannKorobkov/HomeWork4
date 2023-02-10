// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int x = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int a)
{
    int result = 0;
    while (a > 0)
    {
        result = result + (a % 10);
        a = a / 10;
    }
    return result;
}
Console.WriteLine(SumNumbers(x));