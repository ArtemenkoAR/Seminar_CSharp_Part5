// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Array1(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-211123, 20039829);
    }
}

void Array2(double[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write($"{print[i]} ");
    }
}

double[] array = new double[10];
Array1(array);
Array2(array);
Console.WriteLine();
double max = array[0];
double min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }    
  if (array[i] < min)
{
        min = array[i];
}
}
double a = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами равна = {a}");
