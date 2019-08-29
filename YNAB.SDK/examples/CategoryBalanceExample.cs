using System.Threading.Tasks;
using System;

namespace YNAB.SDK.Examples {
  public class CategoryBalanceExample {
    private readonly API _ynabAPI;
    public CategoryBalanceExample(API api)
    {
      _ynabAPI = api;
    }

    public async Task ExecuteAsync(Guid budgetId, Guid categoryId)
    {
      try {
        var monthResponse = await _ynabAPI.Categories.GetCategoryByIdAsync(budgetId.ToString(), categoryId.ToString());
        var category = monthResponse.Data.Category;
        Console.WriteLine($@"
============
CATEGORY
============
             Name: ${category.Name}
         Budgeted: ${category.Budgeted}
          Balance: ${category.Balance}
");
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
        throw;
      }
    }

    public void Execute(Guid budgetId, Guid categoryId)
    {
      try {
        var monthResponse = _ynabAPI.Categories.GetCategoryById(budgetId.ToString(), categoryId.ToString());
        var category = monthResponse.Data.Category;
        Console.WriteLine($@"
============
CATEGORY
============
             Name: ${category.Name}
         Budgeted: ${category.Budgeted}
          Balance: ${category.Balance}
");
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
        throw;
      }
    }
  }
}

