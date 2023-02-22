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
      string dayWeek = CheckDay.WeekDay(2023, 2, 22);
      Assert.AreEqual("Wednesday", dayWeek);
    }
  }
}