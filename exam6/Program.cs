// Задача 1:
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
// А потом выдаёт произведение чисел от 1 до А.
// 4  -> 24
// 5  -> 120

int summ(int A)
{
    int sum = 0;
    for (int i = 0; i <= A; i++)
    {
        sum += i;
    }
    return sum;
}

int multi(int A)
{
    int result = 1;
    for (int i = 1; i <= A; i++)
    {
        result *= i;
    }
    return result;
}

Console.WriteLine("Input A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Sum to A=" + summ(A));
Console.WriteLine("Product to A=" + multi(A));

int n = 5;
int min = 0, max = 2;
int [] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(min, max);
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

