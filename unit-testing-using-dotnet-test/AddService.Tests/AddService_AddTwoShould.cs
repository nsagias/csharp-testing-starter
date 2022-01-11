using System.Reflection;
using Xunit;
using Add.Service;

namespace Add.UnitTests.Services;

public class AddService_AddTwoShould
{
    [Fact]
    public void AddTwo() {
      var addService = new AddService();
      double result = addService.Add(1, 2);
      double expectedOutput = 3;
      
      Assert.Equal(result, expectedOutput);
    }
}