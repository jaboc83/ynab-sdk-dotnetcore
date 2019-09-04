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

    /// <summary>
    /// Verify that the code examples are all still working
    /// </summary>
    /// <returns></returns>
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
        using (var stub = new YnabApiStub()) {
          var api = new API(_token, stub.BasePath);
          var ble = new BudgetListExample(api);
          ble.Execute();
          await ble.ExecuteAsync();

          var bme = new BudgetMonthExample(api);
          bme.Execute(budgetId, budgetMonthId);
          await bme.ExecuteAsync(budgetId, budgetMonthId);

          var btc = new BulkTransactionCreate(api);
          // btc.Execute();
          // await btc.ExecuteAsync();

          var cbe = new CategoryBalanceExample(api);
          cbe.Execute(budgetId, categoryId);
          await cbe.ExecuteAsync(budgetId, categoryId);

          var cmt = new CreateMultipleTransactions(api);
          // cmt.Execute();
          // await cmt.ExecuteAsync();

          var ct = new CreateTransaction(api);
          ct.Execute();
          await ct.ExecuteAsync();

          var dre = new DeltaRequestExample(api);
          dre.Execute();
          await dre.ExecuteAsync();

          var ucb = new UpdateCategoryBudgeted(api);
          // ucb.Execute();
          // await ucb.ExecuteAsync();

          var ut = new UpdateTransaction(api);
          // ut.Execute();
          // await ut.ExecuteAsync();
        }
      } catch (Exception ex) {
        Assert.True(false, ex.Message);
      }
      Assert.True(true, "Finished running examples");
    }
  }
}
