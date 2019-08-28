# YNAB.SDK.Model.ScheduledSubTransaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | 
**ScheduledTransactionId** | **Guid** |  | 
**Amount** | **long** | The scheduled subtransaction amount in milliunits format | 
**Memo** | **string** |  | [optional] 
**PayeeId** | **Guid** |  | [optional] 
**CategoryId** | **Guid** |  | [optional] 
**TransferAccountId** | **Guid** | If a transfer, the account_id which the scheduled subtransaction transfers to | [optional] 
**Deleted** | **bool** | Whether or not the scheduled subtransaction has been deleted.  Deleted scheduled subtransactions will only be included in delta requests. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

