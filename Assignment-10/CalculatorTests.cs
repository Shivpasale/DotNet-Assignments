using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Add_Test()
    {
        Calculator calc = new Calculator();

        var result = calc.Add(2, 3);

        Assert.AreEqual(5, result);
    }
}