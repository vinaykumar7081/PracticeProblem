using System;
using BasicFundaMentalsProblem;
class Program
{ 
    public static void Main(String[] args)
    {
        DateTime myDate = DateTime.Now ;
        string formattedDate = " ";
        //First Format of the Date Displaying. 
         formattedDate = string.Format("{0:yyyy MM HH:mm:ss:tt}", myDate);
        Console.WriteLine(formattedDate);//outPut:-> 16-04-2022 17:55:51

        //Second Formate: <ToDay_DayName> of Month <Month_Name> <Current_year>
        formattedDate = string.Format("{0: dddd 'of Month'  HHHH 'year'  yyyy}",myDate);
        Console.WriteLine(formattedDate); // output:->Sunday of Month  09 year  2022

        /*Third Format
         * <ToDay_DayName>
         * Month <current_MonthName>
         * year <Current_Year>
         */
        formattedDate = string.Format(" {0: 'Day' dddd  \n ' Month'  HHHH  \n  'year'  yyyy}", myDate);
        Console.WriteLine(formattedDate); /* output:->
                                           * 
                                           */



    }
}

