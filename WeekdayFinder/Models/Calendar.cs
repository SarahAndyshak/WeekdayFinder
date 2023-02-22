using System;
using System.Collections.Generic;

namespace WeekdayFinder.Models
{
  public class CheckDay
  {
    public static string WeekDay(int year, int month, int day)
    {
      DateTime date = new DateTime(year, month, day);
      string expectedDayOfWeek = date.DayOfWeek.ToString();
      return expectedDayOfWeek;
    }
  }
}