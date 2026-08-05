
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
      Assert.That(Maths.Pow(2, 2), Is.EqualTo(4), "Pow didnt work");
    }
    [Test]
    public void Is_Square_Correct()
    {
      Assert.That(Maths.Square(2), Is.Not.EqualTo(5), "square of 2 is 4!!!");
    }
    [Test]
    public void Is_Multiplying_Correct()
    {
      Assert.That(Maths.Multiply(3, 3), Is.Not.EqualTo(6), "3*3 should not be 6!");
    }
    [TestCase(0,0,0)]
    [TestCase(0,1,1)]
    [TestCase(2,3,5)]
    public void Test_Add(int a,int b,int sum)
    {
      Assert.That(Maths.Add(a, b), Is.EqualTo(sum));
    }
  }
}