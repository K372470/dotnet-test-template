using System;
using CoolSoftware.Functions;
using NUnit.Framework;

namespace CoolSoftware.Tests
{
  [TestFixture]
  public class MathsTests
  {
    [Test]
    public void Is_Pow_Correct()
    {
      Assert.AreEqual(4, Maths.Pow(2, 2), "Pow didnt work");
    }
    [Test]
    public void Is_Square_Correct()
    {//ya yebal
      Assert.AreEqual(5, Maths.Square(2), "square of 2 is 4!!!");
    }
    [Test]
    public void Is_Multiplying_Correct()
    {
      Assert.AreNotEqual(6, Maths.Multiply(3, 3), "3*3 should not be 6!");
    }
  }
}