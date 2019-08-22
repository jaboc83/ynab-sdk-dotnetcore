# YNAB.SDK.Model.BudgetDetail
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
**Accounts** | [**List&lt;Account&gt;**](Account.md) |  | [optional] 
**Payees** | [**List&lt;Payee&gt;**](Payee.md) |  | [optional] 
**PayeeLocations** | [**List&lt;PayeeLocation&gt;**](PayeeLocation.md) |  | [optional] 
**CategoryGroups** | [**List&lt;CategoryGroup&gt;**](CategoryGroup.md) |  | [optional] 
**Categories** | [**List&lt;Category&gt;**](Category.md) |  | [optional] 
**Months** | [**List&lt;MonthDetail&gt;**](MonthDetail.md) |  | [optional] 
**Transactions** | [**List&lt;TransactionSummary&gt;**](TransactionSummary.md) |  | [optional] 
**Subtransactions** | [**List&lt;SubTransaction&gt;**](SubTransaction.md) |  | [optional] 
**ScheduledTransactions** | [**List&lt;ScheduledTransactionSummary&gt;**](ScheduledTransactionSummary.md) |  | [optional] 
**ScheduledSubtransactions** | [**List&lt;ScheduledSubTransaction&gt;**](ScheduledSubTransaction.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

