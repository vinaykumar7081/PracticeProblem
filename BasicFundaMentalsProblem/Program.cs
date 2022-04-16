using System;
using BasicFundaMentalsProblem;
class Program
{
    public static void Main(String[] args)
    {
        DateTime myDate = DateTime.Now;
        string formattedDate = string.Format("Date is {0:yyyy MM dddd HH mm ss tt}", myDate);
        Console.WriteLine(formattedDate);
        //o/p: Date is 2022 04 Saturday 17 46 46
    }
}

