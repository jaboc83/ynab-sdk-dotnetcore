# YNAB.SDK.Model.SaveTransactionsResponseData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionIds** | **List&lt;string&gt;** | The transaction ids that were saved | 
**Transaction** | [**TransactionDetail**](TransactionDetail.md) |  | [optional] 
**Transactions** | [**List&lt;TransactionDetail&gt;**](TransactionDetail.md) | If multiple transactions were specified, the transactions that were saved | [optional] 
**DuplicateImportIds** | **List&lt;string&gt;** | If multiple transactions were specified, a list of import_ids that were not created because of an existing import_id found on the same account | [optional] 
**ServerKnowledge** | **long** | The knowledge of the server | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

