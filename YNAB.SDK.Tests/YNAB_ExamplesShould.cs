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
      var categoryId = new Guid("3b89df53-1869-4d2f-a636-d09eadc3f0ca");
      // Act
      // Assert
      try {
        var ble = new BudgetListExample(_token);
        ble.Execute();
        await ble.ExecuteAsync();

        var bme = new BudgetMonthExample(_token);
        bme.Execute(budgetId, budgetMonthId);
        await bme.ExecuteAsync(budgetId, budgetMonthId);

        var btc = new BulkTransactionCreate(_token);
        // btc.Execute();
        // await btc.ExecuteAsync();

        var cbe = new CategoryBalanceExample(_token);
        cbe.Execute(budgetId, categoryId);
        await cbe.ExecuteAsync(budgetId, categoryId);

        var cmt = new CreateMultipleTransactions(_token);
        // cmt.Execute();
        // await cmt.ExecuteAsync();

        var ct = new CreateTransaction(_token);
        // ct.Execute();
        // await ct.ExecuteAsync();

        var dre = new DeltaRequestExample(_token);
        dre.Execute();
        await dre.ExecuteAsync();

        var ucb = new UpdateCategoryBudgeted(_token);
        // ucb.Execute();
        // await ucb.ExecuteAsync();

        var ut = new UpdateTransaction(_token);
        // ut.Execute();
        // await ut.ExecuteAsync();
      } catch (Exception ex) {
        Assert.True(false, ex.Message);
      }
      Assert.True(true, "Finished running examples");
    }
  }
}
