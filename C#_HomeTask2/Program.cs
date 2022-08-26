// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Add first number: ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Add second number: ");
int b = int.Parse(Console.ReadLine() ?? "0");

bool square(int a, int b)
{
bool result = true;
    if (a * a == b)
        {
            result = true;
        }
    else
        {
            result = false;
            Console.WriteLine("Second is not perfect square of the first");
        }
    return result;
}    
if (square(a,b))
{
    Console.WriteLine("Second is perfect square of the first");
}