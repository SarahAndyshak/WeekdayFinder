using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekdayFinder.Models;
using System.Collections.Generic;
using System;

namespace WeekdayFinder.Tests
{
  [TestClass]
  public class CheckDayTests
  {
    [TestMethod]
    public void CheckDay_ReturnsCorrectDay_Weekday()
    {
      string dayWeek = CheckDay.WeekDay();
      Assert.AreEqual("Wednesday", dayWeek);

    //  // DayOfWeek expectedDayOfWeek = CalculateWeekDay(date);
    //  // DayOfWeek expectedDayOfWeek = date.DayOfWeek;
    //  // Assert.AreEqual(expectedDayOfWeek, DayOfWeek.Thursday);
    }
  }
}