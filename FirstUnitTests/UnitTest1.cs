using Xunit;

namespace FirstUnitTests;

public class UnitTest1
{
    [Fact]
    public void PassingTest() {
      Assert.Equal(4, Add(2,2));
    }
    
    [Fact]
    public void FailingTest() {
      Assert.NotEqual(5, Add(2 ,2));
    }

    [Theory]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    public void FirstTheory (int value) {
      Assert.True(IsOdd(value));
    }

    int Add(int x, int y) {
      return x + y;
    }

    bool IsOdd(int value) {
      return value % 2 == 1;
    }
}
