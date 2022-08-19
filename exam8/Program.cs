// Задача 2: Задайте массив из 10 элементов и положительные элементы 
// замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    Console.WriteLine(string.Join(", ", array));
    return array;
}


int [] recurse(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0 - array[i];
    }
    Console.WriteLine(string.Join(", ", array));
    return array;
}


int[] array = new int[10];
FillArray(array);
recurse(array);
