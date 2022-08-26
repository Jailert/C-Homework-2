// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Add day number: ");

int a = int.Parse(Console.ReadLine() ?? "0");
bool days(int a)
{
bool result = true;
    if (a > 0 && a <= 7)
        {
            result = true;
        }
    else
        {
            result = false;
            Console.WriteLine("Not valid day number, please choose from 1 to 7");
        }
    return result;
}    
if (days(a))
{
    if (a < 6)
    {
        Console.WriteLine("Today is Weekday");
    }
    else if (a == 6)  
    {
        Console.WriteLine("Today is Weekend");
    }
    else if (a ==7)
    {
        Console.WriteLine("Today is Weekend");
    }
}    


