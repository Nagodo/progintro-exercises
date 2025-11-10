using NUnit.Framework;
namespace PINTest;

public class Tests
{
    Pin pin;
    
    [SetUp]
    public void Setup()
    {
        pin = new Pin();
    }

    [Test]
    public void PerFourth()
    {
        Assert.That(false == pin.Expend(42));
        Assert.That(false == pin.Expend(42));
        Assert.That(false == pin.Expend(42));
        Assert.That(true == pin.Expend(42));
    }

    [Test]
    public void MaxLimit()
    {
        Assert.That(false == pin.Expend(350));
        Assert.That(false == pin.Expend(1));
        Assert.That(true == pin.Expend(351));
        Assert.That(true == pin.Expend(1000));
    }

    [Test]
    public void Random()
    {
        
    }
}
