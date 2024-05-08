namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal money = 279.98M;
        var cents = money.ToCents();

        Assert.AreEqual(27998, cents);
    }
}