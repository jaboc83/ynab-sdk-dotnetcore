using System;
using System.Threading.Tasks;

namespace YNAB.SDK.Examples
{
  public class UpdateTransaction
  {
    private readonly API _ynabApi;
    public UpdateTransaction(string accessToken)
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

