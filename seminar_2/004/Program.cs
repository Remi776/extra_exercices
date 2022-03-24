void MaxMin(string number)
{
    int min_index = 0;
    int max_index = 0;
    int len = number.Length;
    for (int i = 1; i < len; ++i)
    {
        if (number[i] < number[min_index]) min_index = i;
        else if (number[i] > number[max_index]) max_index = i;
    }
    Console.WriteLine("\nNumber: " + number);
    Console.WriteLine($"\nMin = {number[min_index]}, Max = {number[max_index]}");
    if (min_index > max_index) Console.WriteLine($"\nMax is {max_index + 1}(the order in the number) from the right , Min is {min_index + 1}(the order in the number) from the left");
    else Console.WriteLine($"\nMin is {min_index + 1}(the order in the number) from the left , Max is {max_index + 1}(the order in the number) from the right");
}

Console.Write("Enter the natural number: ");
string n = Console.ReadLine();

MaxMin(n);
