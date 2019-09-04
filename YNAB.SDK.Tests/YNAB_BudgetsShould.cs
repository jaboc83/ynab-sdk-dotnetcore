using System;
using Xunit;
using System.Threading.Tasks;
using System.Linq;

namespace YNAB.SDK.Tests
{
  public class YNAB_BudgetsShould
  {
    private readonly string _token = "FAKE_TOKEN";
    private readonly string TEST_BUDGET_ID = "14235236-8085-4cf6-9fa6-92c34ed44b0c";

    public YNAB_BudgetsShould() { }


    [Fact]
    public async Task Budgets_FailWithBadAccessTokens() {
      // Arrange
      var badToken = "INVALID_TOKEN";
      var goodToken = Environment.GetEnvironmentVariable("YNAB_TEST_TOKEN");
      var ynabApi = new YNAB.SDK.API(goodToken);

      // Act
      var ct = new YNAB.SDK.Examples.CreateTransaction(ynabApi);
      ct.Execute();
      //await ct.ExecuteAsync();
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
        Assert.True(result.Data.Budgets.Count == 2, "budget count should be 2");
      }
    }

    //[Fact]
    public async Task LIVE_API_TESTING_FOR_DEBUG()
    {
      // Arrange
      var realToken = Environment.GetEnvironmentVariable("YNAB_TEST_TOKEN");
      var api = new API(realToken);

      // Act
      var result = api.Budgets.GetBudgetById("14235236-8085-4cf6-9fa6-92c34ed44b0c");
      // Assert
      Assert.NotNull(result);
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
        var result = await api.Budgets.GetBudgetByIdAsync(budgetId.ToString());

        // Assert
        Assert.True(result.Data.Budget.Name == budgetName, $"Incorrect budget name: {result.Data.Budget.Name}");
      }
    }

    [Fact]
    public async Task Budgets_ShouldHaveAllProperties()
    {
      // Arrange
      using (var stub = new YnabApiStub())
      {
        var api = new API(_token, stub.BasePath);
        var budgetId = TEST_BUDGET_ID;

        // Act
        var testBudget = (await api.Budgets.GetBudgetByIdAsync(budgetId)).Data.Budget;

        // Assert
        Assert.NotNull(testBudget.Name);
        Assert.NotNull(testBudget.LastModifiedOn);
        Assert.NotNull(testBudget.DateFormat.Format);
        Assert.NotNull(testBudget.CurrencyFormat.IsoCode);
        Assert.NotNull(testBudget.CurrencyFormat.ExampleFormat);
        Assert.NotNull(testBudget.CurrencyFormat.DecimalDigits);
        Assert.NotNull(testBudget.CurrencyFormat.DecimalSeparator);
        Assert.NotNull(testBudget.CurrencyFormat.SymbolFirst);
        Assert.NotNull(testBudget.CurrencyFormat.GroupSeparator);
        Assert.NotNull(testBudget.CurrencyFormat.CurrencySymbol);
        Assert.NotNull(testBudget.CurrencyFormat.DisplaySymbol);
        Assert.NotNull(testBudget.FirstMonth);
        Assert.NotNull(testBudget.LastMonth);
        Assert.NotEmpty(testBudget.Accounts);
        Assert.NotEmpty(testBudget.Payees);
        Assert.Empty(testBudget.PayeeLocations);
        Assert.NotEmpty(testBudget.CategoryGroups);
        Assert.NotEmpty(testBudget.Categories);
        Assert.NotEmpty(testBudget.Months);
        Assert.NotEmpty(testBudget.Transactions);
        Assert.Empty(testBudget.Subtransactions);
        Assert.Empty(testBudget.ScheduledTransactions);
        Assert.Empty(testBudget.ScheduledSubtransactions);
      }
    }
  }
}
