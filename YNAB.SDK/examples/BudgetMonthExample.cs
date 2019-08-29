using System.Threading.Tasks;
using System;

namespace YNAB.SDK.Examples {
  public class BudgetMonthExample {
    private readonly API _ynabAPI;
    public BudgetMonthExample(string accessToken)
    {
      _ynabAPI = new API(accessToken);
    }

    public async Task ExecuteAsync(Guid budgetId, string monthId)
    {
      try {
        var monthResponse = await _ynabAPI.Months.GetBudgetMonthAsync(budgetId.ToString(), DateTime.Parse(monthId));
        var budgetMonth = monthResponse.Data.Month;
        Console.WriteLine($@"
============
BUDGET MONTH
============
             Month: ${budgetMonth.Month}
              Note: ${budgetMonth.Note ?? ""}
      Age Of Money: ${budgetMonth.AgeOfMoney}
 Category Balances:
");
        budgetMonth.Categories.ForEach(category => {
          var balance = string.Format("{0:0.00}", Utils.ConvertMilliUnitsToCurrencyAmount(category.Balance, 2));
          Console.WriteLine(
            $"                    {category.Name} - ${balance}"
          );
            /*
                    Month:  2017-11-01
                      Note: Month Note here
              Age Of Money: 103
        Category Balances:
                            Medical - $50.00
                            Deferred Income SubCategory - $0.00
                            Immediate Income SubCategory - $0.00
                            Renter's/Home Insurance - $0.00
                            ...
            */
        });
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
        throw;
      }
    }

    public void Execute(Guid budgetId, string monthId)
    {
      try {
        var monthResponse = _ynabAPI.Months.GetBudgetMonth(budgetId.ToString(), DateTime.Parse(monthId));
        var budgetMonth = monthResponse.Data.Month;
        Console.WriteLine($@"
============
BUDGET MONTH
============
             Month: ${budgetMonth.Month}
              Note: ${budgetMonth.Note ?? ""}
      Age Of Money: ${budgetMonth.AgeOfMoney}
 Category Balances:
");
        budgetMonth.Categories.ForEach(category => {
          var balance = string.Format("{0:0.00}", Utils.ConvertMilliUnitsToCurrencyAmount(category.Balance, 2));
          Console.WriteLine(
            $"                    {category.Name} - ${balance}"
          );
            /*
                    Month:  2017-11-01
                      Note: Month Note here
              Age Of Money: 103
        Category Balances:
                            Medical - $50.00
                            Deferred Income SubCategory - $0.00
                            Immediate Income SubCategory - $0.00
                            Renter's/Home Insurance - $0.00
                            ...
            */
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

