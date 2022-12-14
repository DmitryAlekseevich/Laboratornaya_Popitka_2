using System;

public class IsLeapYear
{
    public static void Main()
    {
        for (int year = 1700; year <= 2022; year++)
        {
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0} is a leap year.", year);
                DateTime leapDay = new DateTime(year, 2, 29);
                DateTime nextYear = leapDay.AddYears(1);
                Console.WriteLine("   One year from {0} is {1}.",
                                  leapDay.ToString("d"),
                                  nextYear.ToString("d")); 
            }
        }
    }
}
