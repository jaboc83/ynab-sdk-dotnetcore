using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YNAB.SDK.Examples
{
  public class DeltaRequestExample
  {
    private readonly API _ynabApi;
    private int lastKnownServerKnowledge;
    const int POLL_WAIT_TIME_IN_MS = 5000;

    public DeltaRequestExample(API api)
    {
      _ynabApi = api;
    }

    private async Task QueueUpPollAsync(string budgetToFetchId)
    {
      Console.WriteLine($"Current server knowledge is {lastKnownServerKnowledge}");
      Console.WriteLine($"Will poll for changes in {POLL_WAIT_TIME_IN_MS}ms...");
      await Task.Delay(POLL_WAIT_TIME_IN_MS);
      Console.WriteLine("Polling for changes now...");
      var budgetChangesResponse = await _ynabApi.Budgets.GetBudgetByIdAsync(budgetToFetchId, lastKnownServerKnowledge);
      Console.WriteLine($"Current server knowledge is now: {budgetChangesResponse.Data.ServerKnowledge}");
      if(budgetChangesResponse.Data.ServerKnowledge > lastKnownServerKnowledge)
      {
        Console.WriteLine("There have been changes to the following entities: ");
        Console.WriteLine(JsonConvert.SerializeObject(budgetChangesResponse.Data.Budget));
      }
      else
      {
        Console.WriteLine("No changes found");
      }
    }
    private void QueueUpPoll(string budgetToFetchId)
    {
      Console.WriteLine($"Current server knowledge is {lastKnownServerKnowledge}");
      Console.WriteLine($"Will poll for changes in {POLL_WAIT_TIME_IN_MS}ms...");
      Thread.Sleep(POLL_WAIT_TIME_IN_MS);
      Console.WriteLine("Polling for changes now...");
      var budgetChangesResponse = _ynabApi.Budgets.GetBudgetById(budgetToFetchId, lastKnownServerKnowledge);
      Console.WriteLine($"Current server knowledge is now: {budgetChangesResponse.Data.ServerKnowledge}");
      if(budgetChangesResponse.Data.ServerKnowledge > lastKnownServerKnowledge)
      {
        Console.WriteLine("There have been changes to the following entities: ");
        Console.WriteLine(JsonConvert.SerializeObject(budgetChangesResponse.Data.Budget));
      }
      else
      {
        Console.WriteLine("No changes found");
      }
    }
    public async Task ExecuteAsync()
    {
      try
      {
        Console.WriteLine("Fetching budgets...");
        var response = await _ynabApi.Budgets.GetBudgetsAsync();
        var allBudgets = response.Data.Budgets;
        var budgetName = "TestBudget";
        var budgetToFetch = allBudgets.First(budget => budget.Name == budgetName);
        Console.WriteLine($"Fetching contents of budget: {budgetToFetch.Name} - {budgetToFetch.Id}");
        var budgetContents = await _ynabApi.Budgets.GetBudgetByIdAsync(budgetToFetch.Id.ToString());
        var categories = budgetContents.Data.Budget.Categories;
        Console.WriteLine("Here is the budget data for the current month: ");
        var currentMonthISO = Utils.GetCurrentMonthInISOFormat();
        var monthDetailForCurrentMonth = budgetContents.Data.Budget.Months.Find(m => m.Month.ToString("yyyy-MM-dd") == currentMonthISO);
        if (monthDetailForCurrentMonth != null)
        {
          Console.WriteLine(JsonConvert.SerializeObject(monthDetailForCurrentMonth));
        }
        else
        {
          throw new Exception($"Could not find month detail for the current month: {currentMonthISO}");
        }

        var lastServerKnowledge = budgetContents.Data.ServerKnowledge;

        var iterationCount = 0;
        do {
          await QueueUpPollAsync(budgetToFetch.Id.ToString());
        } while(iterationCount++ < 2);

      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
        throw;
      }
    }

    public void Execute()
    {
      try
      {
        Console.WriteLine("Fetching budgets...");
        var response = _ynabApi.Budgets.GetBudgets();
        var allBudgets = response.Data.Budgets;
        var budgetName = "TestBudget";
        var budgetToFetch = allBudgets.First(budget => budget.Name == budgetName);
        Console.WriteLine($"Fetching contents of budget: {budgetToFetch.Name} - {budgetToFetch.Id}");
        var budgetContents = _ynabApi.Budgets.GetBudgetById(budgetToFetch.Id.ToString());
        var categories = budgetContents.Data.Budget.Categories;
        Console.WriteLine("Here is the budget data for the current month: ");
        var currentMonthISO = Utils.GetCurrentMonthInISOFormat();
        var monthDetailForCurrentMonth = budgetContents.Data.Budget.Months.Find(m => m.Month.ToString("yyyy-MM-dd") == currentMonthISO);
        if (monthDetailForCurrentMonth != null)
        {
          Console.WriteLine(JsonConvert.SerializeObject(monthDetailForCurrentMonth));
        }
        else
        {
          throw new Exception($"Could not find month detail for the current month: {currentMonthISO}");
        }

        var lastServerKnowledge = budgetContents.Data.ServerKnowledge;

        var iterationCount = 0;
        do {
          QueueUpPoll(budgetToFetch.Id.ToString());
        } while(iterationCount++ < 2);

      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
        throw;
      }
    }
  }
}
