using System;
using Xunit;
using YNAB.SDK.Api;
using System.Threading.Tasks;
using System.Linq;
using Stubbery;

namespace YNAB.SDK.Tests
{
  public class YNAB_BudgetsShould
  {
    private readonly ApiStub _stub;
    private readonly string _token = Environment.GetEnvironmentVariable("YNAB_TEST_TOKEN");

    public YNAB_BudgetsShould() {
      _stub = StartStub();
    }

    private ApiStub StartStub()
    {
      var ynabApiStub = new ApiStub();
      ynabApiStub.Get(
        "/budgets",
        (req, args) => {
          return @"{""data"":{""budgets"":[{""id"":""14235236-8085-4cf6-9fa6-92c34ed44b0c"",""name"":""TestBudget"",""last_modified_on"":""2019-08-26T17:51:05+00:00"",""first_month"":""2019-08-01"",""last_month"":""2019-09-01"",""date_format"":{""format"":""MM/DD/YYYY""},""currency_format"":{""iso_code"":""USD"",""example_format"":""123,456.78"",""decimal_digits"":2,""decimal_separator"":""."",""symbol_first"":true,""group_separator"":"","",""currency_symbol"":""$"",""display_symbol"":true}}],""default_budget"":null}}";
        }
      );
      ynabApiStub.Start();
      return ynabApiStub;
    }

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
      var api = new YNAB.SDK.API(_token, _stub.Address);
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
