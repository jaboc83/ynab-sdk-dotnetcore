# YNAB.SDK.Model.BudgetSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | 
**Name** | **string** |  | 
**LastModifiedOn** | **DateTime** | The last time any changes were made to the budget from either a web or mobile client | [optional] 
**FirstMonth** | **DateTime** | The earliest budget month | [optional] 
**LastMonth** | **DateTime** | The latest budget month | [optional] 
**DateFormat** | [**DateFormat**](DateFormat.md) |  | [optional] 
**CurrencyFormat** | [**CurrencyFormat**](CurrencyFormat.md) |  | [optional] 
**Accounts** | [**List&lt;Account&gt;**](Account.md) | The budget accounts (only included if &#x60;include_accounts&#x3D;true&#x60; specified as query parameter) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

