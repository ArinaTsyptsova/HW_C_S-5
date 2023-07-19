// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int GetPositiveNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int rem = arr[i] % 2;
        if (rem == 0)
        {
            count++;
        }
    }
    return count;

}

int[] GenerateRandomArray(int elements, int start, int finish)
{
    int[] array = new int[elements];
    for (int i = 0; i < elements; i++)
    {
        array[i] = new Random().Next(start, finish + 1);
    }
    return array;
}

int[] array = GenerateRandomArray(4, 100, 999);
Console.WriteLine($"[{String.Join(", ", (array))}] -> {GetPositiveNum(array)}");
