using System;
using Xunit;
using YNAB.SDK.Api;
using System.Threading.Tasks;
using System.Linq;

namespace YNAB.SDK.Tests
{
  public class YNAB_BudgetsShould
  {
    private readonly BudgetsApi _budgetsApi;
    private readonly string _token = Environment.GetEnvironmentVariable("YNAB_TEST_TOKEN");

    public YNAB_BudgetsShould() {
      _budgetsApi = new BudgetsApi();
    }

    [Fact]
    public async Task Budgets_AreNotEmpty()
    {
      // Arrange
      // Act
      var result = await new YNAB.SDK.API(_token).Budgets.GetBudgetsAsync();
      // Assert
      Assert.True(result.Data.Budgets.Count != 0, "budget count should not be 0");
    }

    [Fact]
    public async Task Budgets_TestBudgetExists()
    {
      // Arrange
      var budgetName = "TestBudget";
      var api = new YNAB.SDK.API(_token);
      var budgets = (await api.Budgets.GetBudgetsAsync()).Data.Budgets;
      var testBudget = budgets.Where(budget => { return budget.Name == budgetName; }).FirstOrDefault();
      Assert.NotNull(testBudget);
      var budgetId = testBudget.Id;

      // Act
      var result = await new YNAB.SDK.API(_token).Budgets.GetBudgetByIdAsync(budgetId.ToString());

      // Assert
      Assert.True(result.Data.Budget.Name == budgetName, $"Incorrect budget name: {result.Data.Budget.Name}");
    }
  }
}
