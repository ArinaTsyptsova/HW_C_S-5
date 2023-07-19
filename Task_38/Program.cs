// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



double GetDiffOfMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    double diff = max - min;
    Console.Write($" => {max} - {min}");
    return Math.Round(diff,2);
}

double[] GenerateRandomArray(int elements, double start, double finish)
{
    double[] array = new double[elements];
    for (int i = 0; i < elements; i++)
    {
        array[i] = Math.Round((start + new Random().NextDouble()*(finish-start)),2);
    }
    return array;
}

double[] array = GenerateRandomArray(5, 0, 100);
Console.Write($"[{String.Join("; ", array)}]");
Console.WriteLine($" = {GetDiffOfMaxMin(array)}");