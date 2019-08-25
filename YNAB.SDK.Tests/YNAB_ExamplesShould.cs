using System;
using Xunit;
using YNAB.SDK.Api;
using YNAB.SDK.Examples;
using System.Threading.Tasks;
using System.Linq;

namespace YNAB.SDK.Tests
{
  public class YNAB_ExamplesShould
  {
    private readonly BudgetsApi _budgetsApi;
    private readonly string _token = Environment.GetEnvironmentVariable("YNAB_TEST_TOKEN");

    [Fact]
    public async Task Examples_RunSuccessfully() {
      // Arrange
      var budgetMonthId = new Guid();
      // Act
      // Assert
      try {
        await new BudgetList(_token).FetchBudgets();
        await new BudgetMonth(_token).FetchBudgetMonth(budgetMonthId);
      } catch (Exception ex) {
        Assert.True(false, ex.Message);
      }
      Assert.True(true, "Finished running examples");
    }
  }
}
