// Задача 3: Задайте массив из 8 случайных чисел. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да




int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    Console.WriteLine(string.Join(", ", array));
    return array;
}

bool Find(int[] array, int find)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find)
            return true;
    }
    return false;
}

int[] array = new int[8];

// int number = new Random().Next(0, 100);
Console.WriteLine("Random array: ");
FillArray(array);
Console.WriteLine("Input find number: ");
if (int.TryParse(Console.ReadLine(), out int number))
{
    if (Find(array, number))
        Console.WriteLine("YES");
    else 
        Console.WriteLine("NO");
}
else 
    Console.WriteLine("Incorrect input");
