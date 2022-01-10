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

public class CalculatorTests () {
  [Fact]
  public void  Sum_Of_Two_Numbers () {
    // Arrange
    double firstNumber = 10;
    double secondNumber = 11;
    double expectedOutput = 21;
    var calculator = new Calculator();

    // Act
    double result = calculator.Sum(firstNumber, secondNumber);

    // Assert
    
    Assert.Equal(expectedOutput, result);
  }

}