// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Add quarter number: ");

int a = int.Parse(Console.ReadLine() ?? "0");
bool quarter(int a)
{
bool result = true;
    if (a > 0 && a <= 4)
        {
            result = true;
        }
    else
        {
            result = false;
            Console.WriteLine("Not valid quarter number, please choose from 1 to 4");
        }
    return result;
}    
if (quarter(a))
{
    if (a == 1)
    {
        Console.WriteLine("Coordinates: ");
        Console.WriteLine("X > 0, Y > 0");
    }
     if (a == 2)
    {
        Console.WriteLine("Coordinates: ");
        Console.WriteLine("X < 0, Y > 0");
    }
     if (a == 3)
    {
        Console.WriteLine("Coordinates: ");
        Console.WriteLine("X < 0, Y < 0");
    }
     if (a == 4)
    {
        Console.WriteLine("Coordinates: ");
        Console.WriteLine("X > 0, Y < 0");
    }
}
