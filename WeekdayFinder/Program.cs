using System;
using System.Collections.Generic;
using WeekdayFinder.Models;

namespace WeekdayFinder
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome. Check the weekday for any historical date.");
      Console.WriteLine("Enter the year:");
      int year = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the month:");
      int month = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the day:");
      int day = int.Parse(Console.ReadLine());
      string dayName = CheckDay.WeekDay(year, month, day);
      Console.WriteLine($"For that date, the weekday was or will be {dayName}");
    }
  }
}