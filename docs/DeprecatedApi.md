# YNAB.SDK.Api.DeprecatedApi

All URIs are relative to *https://api.youneedabudget.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkCreateTransactions**](DeprecatedApi.md#bulkcreatetransactions) | **POST** /budgets/{budget_id}/transactions/bulk | Bulk create transactions


<a name="bulkcreatetransactions"></a>
# **BulkCreateTransactions**
> BulkResponse BulkCreateTransactions (string budgetId, BulkTransactions transactions)

Bulk create transactions

Creates multiple transactions.  Although this endpoint is still supported, it is recommended to use 'POST /budgets/{budget_id}/transactions' to create multiple transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YNAB.SDK.Api;
using YNAB.SDK.Client;
using YNAB.SDK.Model;

namespace Example
{
    public class BulkCreateTransactionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.youneedabudget.com/v1";
            // Configure API key authorization: bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeprecatedApi(Configuration.Default);
            var budgetId = budgetId_example;  // string | The id of the budget (\"last-used\" can be used to specify the last used budget and \"default\" can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)
            var transactions = new BulkTransactions(); // BulkTransactions | The list of transactions to create

            try
            {
                // Bulk create transactions
                BulkResponse result = apiInstance.BulkCreateTransactions(budgetId, transactions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeprecatedApi.BulkCreateTransactions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **budgetId** | **string**| The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget) | 
 **transactions** | [**BulkTransactions**](BulkTransactions.md)| The list of transactions to create | 

### Return type

[**BulkResponse**](BulkResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The bulk request was processed successfully |  -  |
| **400** | The request could not be understood due to malformed syntax or validation error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

