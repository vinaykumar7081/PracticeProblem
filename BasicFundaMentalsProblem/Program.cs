using System;
using BasicFundaMentalsProblem;
class Program
{
    public static void Main(String[] args)
    {
       DateTime myDate=DateTime.Today;
        Console.WriteLine(myDate);
        DateTime myDate1 = DateTime.Now;
        Console.WriteLine(myDate1);
            DateTime myDate2 = DateTime.Now;//It will Display TodayDate with the name of month
        Console.WriteLine(myDate2.ToLongDateString());
        DateTime myDate3 = DateTime.Now;//It will Display TodayDate with the name of month
        Console.WriteLine(myDate3.ToLongTimeString());

    }
}

