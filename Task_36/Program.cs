// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetSumOddNum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        int rem = i % 2;
        if (rem != 0)
        {
            sum = sum + arr[i];
        }
    }
    return sum;

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

int[] array = GenerateRandomArray(4, -100, 100);
Console.WriteLine($"[{String.Join(", ", (array))}] -> {GetSumOddNum(array)}");