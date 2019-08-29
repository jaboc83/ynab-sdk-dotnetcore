using System;
using System.Threading.Tasks;

namespace YNAB.SDK.Examples
{
  public class BulkTransactionCreate
  {
    private readonly API _ynabApi;
    public BulkTransactionCreate(string accessToken)
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
