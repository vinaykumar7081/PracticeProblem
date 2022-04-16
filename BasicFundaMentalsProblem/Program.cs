using System;
using BasicFundaMentalsProblem;
class Program
{
    public static void Main(String[] args)
    {
       DateTime myDate=DateTime.Now;
        Console.WriteLine(myDate.AddDays(10));
        Console.WriteLine(myDate.AddDays(-10));
        Console.WriteLine(myDate.AddYears(10));
        Console.WriteLine(myDate.AddTicks(10));
        Console.WriteLine(myDate.AddSeconds (1000));
        Console.WriteLine(myDate.ToOADate());

    }
}

