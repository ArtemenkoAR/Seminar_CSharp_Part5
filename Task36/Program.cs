// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] Random(int num, int a, int b)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(a, b + 1);
    }
    return arr;
}

void Print(int[] arr2)
{
    for (int i = 0; i < arr2.Length; i++)
    {
        Console.Write($"{arr2[i]} ");
    }
}

int[] array = Random(4, -100, 100);
Print(array);
Console.WriteLine();
int num = 0;
for (int i = 1; i < array.Length; i = i + 2)
{
    {
        num += array[i];
    }
}
Console.WriteLine(num);
