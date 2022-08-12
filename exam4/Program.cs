// int a = 4;
// double sqrtA = Math.Sqrt(a); // корень квадратный
// Console.WriteLine(sqrtA);
// int b = 2;
// double powB = Math.Pow(b, 2); // возведение в степень
// Console.WriteLine(powB);

void PrintText(string text)
{
    if (string.IsNullOrEmpty(text))
    {
        Console.WriteLine("Empty String");
        return;
    }
    Console.WriteLine(text);
}

int Sum(int x, int y)
{
    return x + y;
}
PrintText("");
PrintText("Don't Empty string ");
int result = Sum(5, 8);
PrintText(result.ToString());
