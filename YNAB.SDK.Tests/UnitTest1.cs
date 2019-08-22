using System;
using Xunit;
using YNAB.SDK.Api;

namespace YNAB.SDK.Tests
{
  public class UnitTest1
  {
    private readonly BudgetsApi _budgetsApi;

    public UnitTest1() {
      _budgetsApi = new BudgetsApi();
    }

    [Fact]
    public void Test1()
    {
      // TODO: Write real tests for the generated code
      Assert.True(true, "test");
      //var result = _budgetsApi.GetBudgets();
      //Assert.False(result.Data.Budgets.Count == 1, "budget count should be 0");
    }
  }
}
