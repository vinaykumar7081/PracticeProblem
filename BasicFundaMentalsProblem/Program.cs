using System;
using BasicFundaMentalsProblem;
class Program
{
    public static void Main(String[] args)
    {
        int x = 0;
        x = int.MaxValue;
        Console.WriteLine(x);
        x= int.MinValue;
        Console.WriteLine(x);
        //Console.WriteLine("Enter the integer value");
        //uint y = Convert.ToUInt32(Console.ReadLine() ) ;
        uint y= uint.MinValue;
        Console.WriteLine(y);
        Console.WriteLine(typeof(decimal).IsPrimitive);
        float f_no= 0.0f;
        double d_no = 0.0d;
        decimal m_no = 0.0m;
        f_no = 1 / 5f;
        d_no = 5 / 75d;
        m_no = 5 / 105m;

        Console.WriteLine("float number is:-->{0}",f_no);
        Console.WriteLine("Decimal number is:-->{0}", m_no );
        Console.WriteLine(" double number is:-->{0}", m_no);
    }
}
