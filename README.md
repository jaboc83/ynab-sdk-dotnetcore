# YNAB API .NET Core Library

Please read the [YNAB API documentation][ynabapi] for an overview of using the
API and a complete list of available resources.

This client is generated using the [OpenAPI Code Generator][openapi]

## Include the Package

First, include the nuget package YNAB.SDK:

```shell
dotnet add package YNAB.SDK
```

## Usage

To use this client, you must [obtain an access token][accesstoken] from the
[My Account][myaccount] area of the YNAB web application.

``` csharp
var accessToken = "NOT_A_REAL_TOKEN";
var ynabApi = new YNAB.SDK.API(accessToken);

public async Task ListBudgets() {
  var budgetsResponse = await ynabApi.Budgets.GetBudgetsAsync();
  budgetsResponse.Data.Budgets.ForEach(budget => {
    Console.WriteLine($"Budget Name: {budget.Name}");
  });
}
```

### Error Handling

If a response is returned with a code >= 300, instead of returning the response,
the response will be thrown as an error to be caught.

``` csharp
var accessToken = "invalid_token";
var ynabApi = new YNAB.SDK.API(accessToken);

public async Task ListBudgets() {
  try {
    var budgetsResponse = await ynabAPI.Budgets.GetBudgets();
    // Won't get here because an error will be thrown
  } catch (YNAB.SDK.Client.ApiException ex) {
    Console.WriteLine(ex.ErrorCode); // 401
  }
}
```

## Examples

See the [examples][examples] folder for example usage scenarios.

## Methods

The following methods are available in this library from the YNAB.SDK.API class.
See [the Open API generated docs][docs] for more details on lower level objects.

|                            | Method                                                                                                                                                         | Description                                           |
|----------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------|
| **User**                   | User.GetUser() | Returns authenticated user information                |
| | User.GetUserAsync() | Returns authenticated user information                |
| **Budgets**                | Budgets.GetBudgets() | Returns budgets list with summary information         |
|                | Budgets.GetBudgetsAsync() | Returns budgets list with summary information         |
|                            | Budgets.GetBudgetsById(budgetId) | Returns a single budget with all related entities     |
|                            | Budgets.GetBudgetsByIdAsync(budgetId) | Returns a single budget with all related entities     |
|                            | Budgets.GetBudgetSettingsById(budgetId) | Returns settings for a budget                         |
|                            | Budgets.GetBudgetSettingsByIdAsync(budgetId) | Returns settings for a budget                         |
| **Accounts**               | Accounts.GetAccounts(budgetId) | Returns all accounts                                  |
|               | Accounts.GetAccountsAsync(budgetId) | Returns all accounts                                  |
|                            | Accounts.GetAccountById(budgetId, accountId) | Returns a single account                              |
|                            | Accounts.GetAccountByIdAsync(budgetId, accountId) | Returns a single account                              |
| **Categories**             | Categories.GetCategories(budgetId) | Returns all categories grouped by category group.     |
|             | Categories.GetCategoriesAsync(budgetId) | Returns all categories grouped by category group.     |
|                            | Categories.GetCategoryById(budgetId, categoryId) | Returns a single category                             |
|                            | Categories.GetCategoryByIdAsync(budgetId, categoryId) | Returns a single category                             |
| **Payees**                 | Payees.GetPayees(budgetId) | Returns all payees                                    |
|                 | Payees.GetPayeesAsync(budgetId) | Returns all payees                                    |
|                            | Payees.GetPayeeById(budgetId, payeeId) | Returns single payee                                  |
|                            | Payees.GetPayeeByIdAsync(budgetId, payeeId) | Returns single payee                                  |
| **Payee Locations**        | PayeeLocations.GetPayeeLocations(budgetId) | Returns all payee locations                           |
|        | PayeeLocations.GetPayeeLocationsAsync(budgetId) | Returns all payee locations                           |
|                            | PayeeLocations.GetPayeeLocationById(budgetId, payeeLocationId) | Returns a single payee location                       |
|                            | PayeeLocations.GetPayeeLocationByIdAsync(budgetId, payeeLocationId) | Returns a single payee location                       |
|                            | PayeeLocations.GetPayeeLocationsByPayee(budgetId, payeeId) | Returns all payee locations for the specified payee   |
|                            | PayeeLocations.GetPayeeLocationsByPayeeAsync(budgetId, payeeId) | Returns all payee locations for the specified payee   |
| **Months**                 | Months.GetBudgetMonths(budgetId) | Returns all budget months                             |
|                 | Months.GetBudgetMonthsAsync(budgetId) | Returns all budget months                             |
|                            | Months.GetBudgetMonth(budgetId, month) | Returns a single budget month                         |
|                            | Months.GetBudgetMonthAsync(budgetId, month) | Returns a single budget month                         |
|                            | Months.GetMonthCategoryById(budgetId, month, categoryId) | Returns a single category for a specific budget month |
|                            | Months.GetMonthCategoryByIdAsync(budgetId, month, categoryId) | Returns a single category for a specific budget month |
|                            | Months.updateMonthCategory(budgetId, month, categoryId, monthCategory) | Update an existing month category                     |
|                            | Months.updateMonthCategoryAsync(budgetId, month, categoryId, monthCategory) | Update an existing month category                     |
| **Transactions**           | Transactions.GetTransactions(budgetId) | Returns budget transactions                           |
|           | Transactions.GetTransactionsAsync(budgetId) | Returns budget transactions                           |
|                            | Transactions.GetTransactionsByAccount(budgetId, accountId) | Returns all transactions for a specified account      |
|                            | Transactions.GetTransactionsByAccountAsync(budgetId, accountId) | Returns all transactions for a specified account      |
|                            | Transactions.GetTransactionsByCategory(budgetId, categoryId) | Returns all transactions for a specified category     |
|                            | Transactions.GetTransactionsByCategoryAsync(budgetId, categoryId) | Returns all transactions for a specified category     |
|                            | Transactions.GetTransactionById(budgetId, transactionId) | Returns a single transaction                          |
|                            | Transactions.GetTransactionByIdAsync(budgetId, transactionId) | Returns a single transaction                          |
|                            | Transactions.CreateTransaction(budgetId, data) | Creates a single transaction                  |
|                            | Transactions.CreateTransactionAsync(budgetId, data) | Creates a single transaction                  |
|                            | Transactions.CreateTransactions(budgetId, data) | Creates multiple transactions                  |
|                            | Transactions.CreateTransactionsAsync(budgetId, data) | Creates multiple transactions                  |
|                            | Transactions.UpdateTransaction(budgetId, transactionId, data) | Updates a single transaction                                 |
|                            | Transactions.UpdateTransactionAsync(budgetId, transactionId, data) | Updates a single transaction                                 |
|                            | Transactions.UpdateTransactions(budgetId, data) | Updates multiple transactions                                 |
|                            | Transactions.UpdateTransactionsAsync(budgetId, data) | Updates multiple transactions                                 |
| **Scheduled Transactions** | ScheduledTransactions.GetScheduledTransactions(budgetId) | Returns all scheduled transactions                    |
| | ScheduledTransactions.GetScheduledTransactionsAsync(budgetId) | Returns all scheduled transactions                    |
|                            | ScheduledTransactions.GetScheduledTransactionById(budgetId, scheduledTransactionId) | Returns a single scheduled transaction                |
|                            | ScheduledTransactions.GetScheduledTransactionByIdAsync(budgetId, scheduledTransactionId) | Returns a single scheduled transaction                |

## License

Copyright (c) 2019 Jake Moening

Licensed under the Apache-2.0 license

[openapi]: https://github.com/OpenAPITools/openapi-generator
[ynabapi]: https://api.youneedabudget.com
[accesstoken]: https://api.youneedabudget.com/#authentication-overview
[myaccount]: https://app.youneedabudget.com/settings
[examples]: https://github.com/jaboc83/ynab-sdk-dotnetcore/tree/master/YNAB.SDK/examples
[docs]: https://github.com/jaboc83/ynab-sdk-dotnetcore/tree/master/docs
