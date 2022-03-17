void Deposite(int m)
{
    double result = 1000;
    for (int i = 0; i < m; ++i)
    {
        result += result * 1.5 / 100;
    }
    Console.WriteLine($"\nFinal deposite: {Math.Ceiling(result)}");
}

Console.Write("Enter month number: ");
int month = Convert.ToInt32(Console.ReadLine());

Deposite(month);