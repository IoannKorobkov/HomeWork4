// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Hello, World!");
int[] massiv = { 0, 0, 0, 0, 0, 0, 0, 0 };
massiv[0] = Convert.ToInt32(Console.ReadLine());
massiv[1] = Convert.ToInt32(Console.ReadLine());
massiv[2] = Convert.ToInt32(Console.ReadLine());
massiv[3] = Convert.ToInt32(Console.ReadLine());
massiv[4] = Convert.ToInt32(Console.ReadLine());
massiv[5] = Convert.ToInt32(Console.ReadLine());
massiv[6] = Convert.ToInt32(Console.ReadLine());
massiv[7] = Convert.ToInt32(Console.ReadLine());
int[] PrintArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($" {array[i]}");
    }
    return array;
}
PrintArray(massiv);