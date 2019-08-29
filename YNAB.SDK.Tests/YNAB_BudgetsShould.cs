using System;
using Xunit;
using System.Threading.Tasks;
using System.Linq;
using Stubbery;

namespace YNAB.SDK.Tests
{
  public class YNAB_BudgetsShould
  {
    private readonly string _token = Environment.GetEnvironmentVariable("YNAB_TEST_TOKEN");

    public YNAB_BudgetsShould() { }


    [Fact]
    public void Budgets_FailWithBadAccessTokens() {
      // Arrange
      var badToken = "INVALID_TOKEN";
      var ynabApi = new YNAB.SDK.API(badToken);

      // Act
      // Assert
      Assert.Throws<YNAB.SDK.Client.ApiException>(() => {
        ynabApi.Budgets.GetBudgets();
      });
    }

    [Fact]
    public async Task Budgets_AreNotEmpty()
    {
      // Arrange
      using (var stub = new YnabApiStub())
      {
        var api = new API(_token, stub.BasePath);
        // Act
        var result = await api.Budgets.GetBudgetsAsync();
        // Assert
        Assert.True(result.Data.Budgets.Count != 0, "budget count should not be 0");
      }
    }

    [Fact]
    public async Task Budgets_TestBudgetExists()
    {
      // Arrange
      using (var stub = new YnabApiStub())
      {
        var api = new API(_token, stub.BasePath);
        var budgetName = "TestBudget";
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
}
