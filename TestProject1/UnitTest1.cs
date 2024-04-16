namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        
        var v = 10;
        var g = Math.Pow(9.8, 2);

        var t = 2 * v / g;
        
        
        Assert.Equal(t,0.20824656393169508);
    }
    [Fact]
    public void Test2()
    {
        
        var v = 15;
        var g = Math.Pow(9.8, 2);

        var t = 2 * v / g;
        
        
        Assert.Equal(t,0.31236984589754263);
    }
}