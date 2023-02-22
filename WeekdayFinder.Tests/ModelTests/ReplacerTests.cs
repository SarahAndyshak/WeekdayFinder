using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekdayFinder.Models;
using System.Collections.Generic;
using System;

namespace WeekdayFinder.Tests
{
  [TestClass]
  public class ReplacerTests
  {
    [TestMethod]
    public void ReplaceWord_ReturnsStringWithWord1ReplacedWithWord2_string()
    {
      string phrase = "Hello, this is a failing test!";
      string word1 = "failing";
      string word2 = "passing";
      Assert.AreEqual(ReplaceWord(phrase), "Hello, this is a passing test!");
    }
  }
}