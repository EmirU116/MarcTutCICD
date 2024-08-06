namespace Utility.Test;

public class FibTest
{

    [Test]
    public void WorksForAnArbitraryValue()
    {
        // given 
        int n = 6;
        
        // when
        int result = Fibonacci.Recrusive(n);
        
        // then 
        Assert.That(result, Is.EqualTo(8));
    }
}