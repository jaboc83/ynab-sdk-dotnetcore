# YNAB.SDK.Model.SubTransaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**TransactionId** | **string** |  | 
**Amount** | **long** | The subtransaction amount in milliunits format | 
**Memo** | **string** |  | 
**PayeeId** | **Guid** |  | 
**CategoryId** | **Guid** |  | 
**TransferAccountId** | **Guid** | If a transfer, the account_id which the subtransaction transfers to | 
**Deleted** | **bool** | Whether or not the subtransaction has been deleted.  Deleted subtransactions will only be included in delta requests. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

