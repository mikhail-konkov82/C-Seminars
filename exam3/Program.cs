// Напишите программу, которая выводит 
// случайное трёхзначное число и удаляет 
// вторую цифру этого числа.

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);
// string strnumber = num.ToString();
// string result = strnumber[0].ToString() + strnumber[2].ToString();
// Console.WriteLine(result);

// // Console.WriteLine($"{strnumber[0]}{strnumber[2]}");

// Console.WriteLine("Input 2 number: ");
// int A = int.Parse(Console.ReadLine());
// int B = int.Parse(Console.ReadLine());
// int modulus = A % B;
// if (modulus == 0)
// {
//     Console.WriteLine($"Number {A} multiple {B}");
// }
// else
// {
//     Console.WriteLine($"Number {A} not multiple {B} remains {modulus}");
// }

Console.WriteLine("input number: ");
int number = int.Parse(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}