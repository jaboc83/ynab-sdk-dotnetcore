using YNAB.SDK;
using System.Threading.Tasks;
using System;

namespace YNAB.SDK.Examples {
  public class BudgetListExample {
    private readonly API _ynabAPI;
    public BudgetListExample(string accessToken)
    {
      _ynabAPI = new API(accessToken);
    }

    public async Task ExecuteAsync()
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
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
        throw;
      }
    }

    public void Execute()
    {
      try {
        var budgetResponse = _ynabAPI.Budgets.GetBudgets();
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
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
        throw;
      }
    }
  }
}
