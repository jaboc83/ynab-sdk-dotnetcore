# YNAB.SDK.Api.BudgetsApi

All URIs are relative to *https://api.youneedabudget.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBudgetById**](BudgetsApi.md#getbudgetbyid) | **GET** /budgets/{budget_id} | Single budget
[**GetBudgetSettingsById**](BudgetsApi.md#getbudgetsettingsbyid) | **GET** /budgets/{budget_id}/settings | Budget Settings
[**GetBudgets**](BudgetsApi.md#getbudgets) | **GET** /budgets | List budgets


<a name="getbudgetbyid"></a>
# **GetBudgetById**
> BudgetDetailResponse GetBudgetById (string budgetId, long? lastKnowledgeOfServer = null)

Single budget

Returns a single budget with all related entities.  This resource is effectively a full budget export.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YNAB.SDK.Api;
using YNAB.SDK.Client;
using YNAB.SDK.Model;

namespace Example
{
    public class GetBudgetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.youneedabudget.com/v1";
            // Configure API key authorization: bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BudgetsApi(config);
            var budgetId = budgetId_example;  // string | The id of the budget. \"last-used\" can be used to specify the last used budget and \"default\" can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).
            var lastKnowledgeOfServer = 789;  // long? | The starting server knowledge.  If provided, only entities that have changed since `last_knowledge_of_server` will be included. (optional) 

            try
            {
                // Single budget
                BudgetDetailResponse result = apiInstance.GetBudgetById(budgetId, lastKnowledgeOfServer);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.GetBudgetById: " + e.Message );
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
 **budgetId** | **string**| The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget). | 
 **lastKnowledgeOfServer** | **long?**| The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. | [optional] 

### Return type

[**BudgetDetailResponse**](BudgetDetailResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested budget |  -  |
| **404** | The specified budget was not found |  -  |
| **0** | An error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbudgetsettingsbyid"></a>
# **GetBudgetSettingsById**
> BudgetSettingsResponse GetBudgetSettingsById (string budgetId)

Budget Settings

Returns settings for a budget

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YNAB.SDK.Api;
using YNAB.SDK.Client;
using YNAB.SDK.Model;

namespace Example
{
    public class GetBudgetSettingsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.youneedabudget.com/v1";
            // Configure API key authorization: bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BudgetsApi(config);
            var budgetId = budgetId_example;  // string | The id of the budget. \"last-used\" can be used to specify the last used budget and \"default\" can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).

            try
            {
                // Budget Settings
                BudgetSettingsResponse result = apiInstance.GetBudgetSettingsById(budgetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.GetBudgetSettingsById: " + e.Message );
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
 **budgetId** | **string**| The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget). | 

### Return type

[**BudgetSettingsResponse**](BudgetSettingsResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested budget settings |  -  |
| **404** | The specified Budget was not found |  -  |
| **0** | An error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbudgets"></a>
# **GetBudgets**
> BudgetSummaryResponse GetBudgets (bool? includeAccounts = null)

List budgets

Returns budgets list with summary information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YNAB.SDK.Api;
using YNAB.SDK.Client;
using YNAB.SDK.Model;

namespace Example
{
    public class GetBudgetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.youneedabudget.com/v1";
            // Configure API key authorization: bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BudgetsApi(config);
            var includeAccounts = true;  // bool? | Whether to include the list of budget accounts (optional) 

            try
            {
                // List budgets
                BudgetSummaryResponse result = apiInstance.GetBudgets(includeAccounts);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.GetBudgets: " + e.Message );
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
 **includeAccounts** | **bool?**| Whether to include the list of budget accounts | [optional] 

### Return type

[**BudgetSummaryResponse**](BudgetSummaryResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of budgets |  -  |
| **404** | No budgets were found |  -  |
| **0** | An error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

