// Задача 1. Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.). 
// Элементы двумерного массива задаются случано и лежат в промежутке от -10 до 10

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]

// Задача 2. Вычислить среднее арифметическое положительных элементов в одномерном массиве. 
// Элементы двумерного массива задаются случано и лежат в промежутке от -10 до 10

// [1, -5, 8, 4, -9] -> 4.33

int[] FillArray(int[] array, int min = -10, int max = 11)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    Console.WriteLine(string.Join(", ", array));
    return array;
}

void reverse(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
    Console.WriteLine(string.Join(", ", array));
}

double average(int[] array)
{
    double sum = 0;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) 
        {
            sum += array[i]; 
            count += 1; 
        }      
    }
    Console.WriteLine("sum: " + sum);
    Console.WriteLine("count: " + count);
    Console.WriteLine("Average: " + sum / count);
    return sum / count;
}


int [] array = new int[8];
FillArray(array);
reverse(array);
average(array);
