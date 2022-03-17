int Age(int month, int day, int year)
{
    if (month > 2 & day > 1) return (2022 - (year + 1));
    else return(2022 - year);
}

Console.Write("Month: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Day: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.Write("Year: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Age: {Age(m, d, y)}");