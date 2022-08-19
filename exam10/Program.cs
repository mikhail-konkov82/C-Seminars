// Задача 4: Задайте одномерный массив из 12 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// *Пример для массива из 5, а не 12 элементов. В своём решении сделайте для 12*

// [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2] -> 0

// [10, 11, 12, 13, 14] -> 5

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    Console.WriteLine(string.Join(", ", array));
    return array;
}

int findinrange(int [] array, int min = 10, int max = 99)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max)
        {
            count += 1;
        }
    }
    Console.WriteLine("Count = " + count);
    return count;
}

int [] array = new int[12];
FillArray(array);
findinrange(array);

