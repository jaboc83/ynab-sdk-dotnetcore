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

FIXME Replace with working code example
``` csharp
var accessToken = "b43439eaafe2_this_is_fake_b43439eaafe2";
var ynabAPI = new YNAB.API(accessToken);

public async Task ListBudgets() {
  var budgetsResponse = await ynabAPI.Budgets.GetBudgets();
  var budgets = budgetsResponse.Data.Budgets;
  budgets.ForEach(budget => {
    Console.WriteLine($"Budget Name: {budget.Name}");
  });
}
```

### Error Handling

If a response is returned with a code >= 300, instead of returning the response,
the response will be thrown as an error to be caught.

FIXME Replace with working code example
``` csharp
var accessToken = "invalid_token";
var ynabAPI = new YNAB.API(accessToken);

async function ListBudgets() {
  try {
    var budgetsResponse = await ynabAPI.Budgets.GetBudgets();
    // Won't get here because an error will be thrown
  } catch (Exception ex) {
    Console.WriteLine(ex);
    /*
     *  {
     *    error: {
     *      id: "401",
     *      name: "unauthorized",
     *      detail: "unauthorized"
     *    }
     *  }
     */
  }
}
```

## Examples

TODO Write example documentation.
See the [examples][examples]
folder for example usage scenarios.

## Methods

FIXME method documentation.
The following methods are available in this library.

|                            | Method                                                                                                                                                         | Description                                           |
|----------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------|
| **User**                   | User.GetUser() | Returns authenticated user information                |
| **Budgets**                | Budgets.GetBudgets() | Returns budgets list with summary information         |
|                            | Budgets.GetBudgetsById(budgetId) | Returns a single budget with all related entities     |
|                            | Budgets.GetBudgetSettingsById(budgetId) | Returns settings for a budget                         |
| **Accounts**               | Accounts.GetAccounts(budgetId) | Returns all accounts                                  |
|                            | Accounts.GetAccountById(budgetId, accountId) | Returns a single account                              |
| **Categories**             | Categories.GetCategories(budgetId) | Returns all categories grouped by category group.     |
|                            | Categories.GetCategoryById(budgetId, categoryId) | Returns a single category                             |
| **Payees**                 | Payees.GetPayees(budgetId) | Returns all payees                                    |
|                            | Payees.GetPayeeById(budgetId, payeeId) | Returns single payee                                  |
| **Payee Locations**        | PayeeLocations.GetPayeeLocations(budgetId) | Returns all payee locations                           |
|                            | PayeeLocations.GetPayeeLocationById(budgetId, payeeLocationId) | Returns a single payee location                       |
|                            | PayeeLocations.GetPayeeLocationsByPayee(budgetId, payeeId) | Returns all payee locations for the specified payee   |
| **Months**                 | Months.GetBudgetMonths(budgetId) | Returns all budget months                             |
|                            | Months.GetBudgetMonth(budgetId, month) | Returns a single budget month                         |
|                            | Months.GetMonthCategoryById(budgetId, month, categoryId) | Returns a single category for a specific budget month |
|                            | Months.updateMonthCategory(budgetId, month, categoryId, monthCategory) | Update an existing month category                     |
| **Transactions**           | Transactions.GetTransactions(budgetId) | Returns budget transactions                           |
|                            | Transactions.GetTransactionsByAccount(budgetId, accountId) | Returns all transactions for a specified account      |
|                            | Transactions.GetTransactionsByCategory(budgetId, categoryId) | Returns all transactions for a specified category     |
|                            | Transactions.GetTransactionById(budgetId, transactionId) | Returns a single transaction                          |
|                            | Transactions.createTransaction(budgetId, data) | Creates a single transaction                  |
|                            | Transactions.createTransactions(budgetId, data) | Creates multiple transactions                  |
|                            | Transactions.updateTransaction(budgetId, transactionId, data) | Updates a single transaction                                 |
|                            | Transactions.updateTransactions(budgetId, data) | Updates multiple transactions                                 |
| **Scheduled Transactions** | ScheduledTransactions.GetScheduledTransactions(budgetId) | Returns all scheduled transactions                    |
|                            | ScheduledTransactions.GetScheduledTransactionById(budgetId, scheduledTransactionId) | Returns a single scheduled transaction                |

## License

Copyright (c) 2019 Jake Moening

Licensed under the Apache-2.0 license

[openapi]: https://github.com/OpenAPITools/openapi-generator
[ynabapi]: https://api.youneedabudget.com
[accesstoken]: https://api.youneedabudget.com/#authentication-overview
[myaccount]: https://app.youneedabudget.com/settings
[examples]: https://github.com/jaboc83/ynab-sdk-dotnetcore/tree/master/examples
