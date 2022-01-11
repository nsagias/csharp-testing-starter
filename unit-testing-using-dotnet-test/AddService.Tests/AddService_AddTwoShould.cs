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

}