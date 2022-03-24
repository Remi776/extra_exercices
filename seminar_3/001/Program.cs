Console.Write("Enter a number from 1 to 4: ");
int number = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();

int a_x = 0, a_y = 0,
    b_x = 0, b_y = 0,
    c_x = 0, c_y = 0;

void SetCoord(int x_mult, int y_mult)
{
    a_x = rnd.Next(1, 50) * x_mult;
    a_y = rnd.Next(1, 50) * y_mult;
    b_x = rnd.Next(1, 50) * x_mult;
    b_y = rnd.Next(1, 50) * y_mult;
    c_x = rnd.Next(1, 50) * x_mult;
    c_y = rnd.Next(1, 50) * y_mult;
    Console.WriteLine($"A({a_x}, {a_y})");
    Console.WriteLine($"B({b_x}, {b_y})");
    Console.WriteLine($"C({c_x}, {c_y})");
}

Console.WriteLine("\nCoordinates:");
if (number == 1)
{
    SetCoord(1, 1);
}
else if (number == 2)
{
    SetCoord(-1, 1);
}
else if (number == 3)
{
    SetCoord(-1, -1);
}
else if (number == 4)
{
    SetCoord(1, -1);
}

double a_distance = Math.Sqrt(Math.Pow(a_x, 2) + Math.Pow(a_y, 2));
double b_distance = Math.Sqrt(Math.Pow(b_x, 2) + Math.Pow(b_y, 2));
double c_distance = Math.Sqrt(Math.Pow(c_x, 2) + Math.Pow(c_y, 2));

double ab_distance = Math.Sqrt(Math.Pow((b_x - a_x), 2) + Math.Pow((b_y - a_y), 2));
double bc_distance = Math.Sqrt(Math.Pow((c_x - b_x), 2) + Math.Pow((c_y - b_y), 2));
double ca_distance = Math.Sqrt(Math.Pow((a_x - c_x), 2) + Math.Pow((a_y - c_y), 2));

Console.Write("\nDirection: ");
if (a_distance < b_distance & a_distance < c_distance)
{
    Console.Write("A -> ");
    if (ab_distance < ca_distance) Console.Write("B -> C");
    else Console.Write("C -> B");
}

if (b_distance < a_distance & b_distance < c_distance)
{
    Console.Write("B -> ");
    if (ab_distance < bc_distance) Console.Write("A -> C");
    else Console.Write("C -> A");
}

if (c_distance < b_distance & c_distance < a_distance)
{
    Console.Write("C -> ");
    if (ca_distance < bc_distance) Console.Write("A -> B");
    else Console.Write("B -> A");
}

