using System.Threading.Tasks;
using System;

namespace YNAB.SDK.Examples {
  public class BudgetMonth {
    private API _ynabAPI;
    public BudgetMonth(string accessToken)
    {
      _ynabAPI = new API(accessToken);
    }

    public async Task FetchBudgetMonth(Guid monthId)
    {
      try {
        var monthResponse = await _ynabAPI.Months.GetBudgetMonthAsync(monthId.ToString(), DateTime.Parse(Utils.GetCurrentMonthInISOFormat()));
        var budgetMonth = monthResponse.Data.Month;
        // FIXME: JS example shows AgeOfMoney, our Month doesn't have that property. Maybe a bug in the generator?
        // Age Of Money: ${budgetMonth.AgeOfMoney}
        Console.WriteLine($@"
============
BUDGET MONTH
============
             Month: ${budgetMonth.Month}
              Note: ${budgetMonth.Note ?? ""}
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
      } catch (Exception exception) {
        Console.WriteLine(exception.Message);
        throw;
      }
    }
  }
}

