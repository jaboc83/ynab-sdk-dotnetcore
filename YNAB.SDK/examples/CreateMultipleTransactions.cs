using System;
using System.Threading.Tasks;

namespace YNAB.SDK.Examples
{
  public class CreateMultipleTransactions
  {
    private readonly API _ynabApi;
    public CreateMultipleTransactions(string accessToken)
    {
      _ynabApi = new API(accessToken);
    }

    private async Task ExecuteAsync() {
      throw new NotImplementedException();
    }
    private void Execute() {
      throw new NotImplementedException();
    }
  }
}
