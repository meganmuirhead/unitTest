using Xunit;


public class testclass

{
    [Theory]
    [InlineData(3)]
    [InlineData(5)]

    public void MyFirstTheory(int mynumber) 
    {
    Assert.True(Program.IsOdd(mynumber));
    }

    [Fact]
    public void PassingAddTest()
    {
        Assert.Equal(4, Program.Add(2,2)); 
    }
    [Fact]
    public void FailingTest()
    {
        Assert.NotEqual(5, Program.Add(2,2)); 
    }
}