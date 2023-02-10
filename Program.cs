// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("A = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("B = ");
int b = Convert.ToInt32(Console.ReadLine());

int Stepen(int x, int y)
{
    int i = 1;
    int result = 1;
    while (i <= b)
    {
        result = result * a;
        i++;
    }
    return result;
}
Console.WriteLine(Stepen(a, b));