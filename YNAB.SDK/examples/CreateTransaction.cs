using System;
using System.Linq;
using System.Threading.Tasks;
using YNAB.SDK.Model;

namespace YNAB.SDK.Examples
{
  public class CreateTransaction
  {
    private readonly API _ynabApi;
    private readonly SaveTransaction _transaction;
    private readonly BudgetDetail _testBudget;
    public CreateTransaction(API api)
    {
      _ynabApi = api;
      _testBudget = _ynabApi.Budgets.GetBudgetById("14235236-8085-4cf6-9fa6-92c34ed44b0c").Data.Budget;
      _transaction = new SaveTransaction
      {
        AccountId = _testBudget.Accounts.First().Id,
        Amount = 100L,
        Date = DateTime.Now,
        PayeeId = _testBudget.Payees.First().Id,
        PayeeName = _testBudget.Payees.First().Name,
        CategoryId = _testBudget.Categories.First().Id,
        Memo = "Test Transaction",
        Approved = true,
        Cleared = SaveTransaction.ClearedEnum.Cleared,
        FlagColor = SaveTransaction.FlagColorEnum.Red
      };
    }

    public async Task ExecuteAsync() {
      _transaction.Memo = "ASYNC TEST";
      var result = await _ynabApi.Transactions.CreateTransactionAsync(_testBudget.Id.ToString(), new Model.SaveTransactionsWrapper(_transaction));
    }
    public void Execute() {
      _transaction.Memo = "TEST";
      var result = _ynabApi.Transactions.CreateTransaction(_testBudget.Id.ToString(), new Model.SaveTransactionsWrapper(_transaction));
    }
  }
}
