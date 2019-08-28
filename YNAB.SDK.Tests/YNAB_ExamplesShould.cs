using System;
using Xunit;
using YNAB.SDK.Api;
using YNAB.SDK.Examples;
using System.Threading.Tasks;
using System.Linq;
using YNAB.SDK.Client;

namespace YNAB.SDK.Tests
{
  public class YNAB_ExamplesShould
  {
    private readonly BudgetsApi _budgetsApi;
    private readonly string _token = Environment.GetEnvironmentVariable("YNAB_TEST_TOKEN");

    [Fact]
    public async Task Examples_RunSuccessfully() {
      // Arrange
      GlobalConfiguration.Instance = GlobalConfiguration.MergeConfigurations(GlobalConfiguration.Instance, new Configuration
      {
        DateTimeFormat = "yyyy-MM-dd"
      });
      var budgetMonthId = "2019-08-01";
      var budgetId = new Guid("14235236-8085-4cf6-9fa6-92c34ed44b0c");
      // Act
      // Assert
      try {
        await new BudgetList(_token).FetchBudgets();
        await new BudgetMonth(_token).FetchBudgetMonth(budgetId, budgetMonthId);
      } catch (Exception ex) {
        Assert.True(false, ex.Message);
      }
      Assert.True(true, "Finished running examples");
    }
  }
}
