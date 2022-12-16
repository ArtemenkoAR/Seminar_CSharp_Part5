// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

int[] Random(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
    return array;
}

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.Write("Введите число элементов массива: ");
int N = int.Parse(Console.ReadLine()!);

int[] array = Random(N);
Print(array);
Console.WriteLine();
int a = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        a += 1;
    }
}
Console.WriteLine(a);
