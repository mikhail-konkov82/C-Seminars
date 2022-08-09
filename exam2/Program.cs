// int num = new Random().Next(0, 10); // random number generator

// while (a < 7)
// {
//     Console.WriteLine(a);
//     a++;
// }
// for (int i = 0; i < 5, i++);
// {
//     Console.WriteLine("i");
// }

// do
// {
//     Console.WriteLine("a");
// }while (a > 5);

// // int // Целое число 10
// // float & double // дробное число 10.1
// // string // строка Hello World
// // bool // логическое true False
// // char // символ 'd'
// // void // пустой тип

int [] array = new int[] { 1, 2, 3, 4};
// double [] array2 = new double[] { 1.2, 2.2, 3.2, 4, 5};
// string [] people = new string[] { "John", "Sam", "Tom"};
// bool [] bools = new bool[] { true, false};
// char [] chars = new char[] { 'a', 'b', 'c', 'd'};

for (int i = 0; i < array.Length; i++)
{
    array[i] += 5;
    Console.WriteLine(array[i]);
}

