using System.Reflection;
using Xunit;
using Add.Service;

namespace Add.UnitTests.Services;

public class AddService_AddTwoShould {

    public readonly AddService _addService;
    
    public AddService_AddTwoShould() {
      
      _addService = new AddService();
      
    }

    [Fact]
    public void Add_Two_Passing_Test() {
      // var addService = new AddService();

      double result = _addService.Add(1, 2);
      double expectedOutput = 3;
      
      Assert.Equal(result, expectedOutput);
    }

    [Fact]
    public void Add_Two_Failing_test() {
      // var addService = new AddService();

      double result = _addService.Add(2,2);
      double expectedOutput = 3;

      Assert.NotEqual(result, expectedOutput);
    }

    [Theory]
    [InlineData(2,2,3)]
    [InlineData(5,2,3)]
    [InlineData(-1,0,3)]
    public void Add_Two_Theory_Example(double num1, double num2, double expectedValue) {
       double result = _addService.Add(num1, num2);
       double expectedOutput = expectedValue;
       Assert.NotEqual(result, expectedOutput);
    }

}