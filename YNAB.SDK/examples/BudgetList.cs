using YNAB.SDK;
using System.Threading.Tasks;
using System;

namespace YNAB.SDK.Examples {
  public class BudgetList {
    private API _ynabAPI;
    public BudgetList(string accessToken)
    {
      _ynabAPI = new API(accessToken);
    }

    public async Task FetchBudgets()
    {
      try {
        var budgetResponse = await _ynabAPI.Budgets.GetBudgetsAsync();
        var budgets = budgetResponse.Data.Budgets;
        Console.WriteLine($"This user has {budgets.Count} budgets.");
        Console.WriteLine(@"
===========
BUDGET LIST
===========
");
        budgets.ForEach(budget => {
          Console.WriteLine(
            $"[id: {budget.Id}, name: {budget.Name}, lastModifiedOn: {budget.LastModifiedOn}]"
          );
        });
      } catch (Exception exception) {
        Console.WriteLine(exception.Message);
        throw;
      }
    }
  }
}
