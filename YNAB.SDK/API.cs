using YNAB.SDK.Client;
using YNAB.SDK.Api;

namespace YNAB.SDK
{
  public class API {
    private Configuration _config = new Configuration();
    private bool _useHttps;
    public API(string accessToken, string host = "api.youneedabudget.com", bool useHttps = true)
    {
      // TODO: Use this
      _useHttps = useHttps;
      _config.AddApiKey("Authorization", accessToken);
      _config.AddApiKeyPrefix("Authorization", "Bearer");
      _config.BasePath = host;
    }

    public UserApi User { get { return new UserApi(_config); } }
    public BudgetsApi Budgets { get { return new BudgetsApi(_config); } }
    public AccountsApi Accounts { get { return new AccountsApi(_config); } }
    public CategoriesApi Categories { get { return new CategoriesApi(_config); } }
    public MonthsApi Months { get { return new MonthsApi(_config); } }
    public PayeesApi Payees { get { return new PayeesApi(_config); } }
    public PayeeLocationsApi PayeesLocations { get { return new PayeeLocationsApi(_config); } }
    public TransactionsApi Transactions { get { return new TransactionsApi(_config); } }
    public ScheduledTransactionsApi ScheduledTransactions { get { return new ScheduledTransactionsApi(_config); } }
  }
}
