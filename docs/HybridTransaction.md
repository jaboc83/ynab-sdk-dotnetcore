# YNAB.SDK.Model.HybridTransaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**Date** | **DateTime** | The transaction date in ISO format (e.g. 2016-12-01) | 
**Amount** | **long** | The transaction amount in milliunits format | 
**Memo** | **string** |  | 
**Cleared** | **string** | The cleared status of the transaction | 
**Approved** | **bool** | Whether or not the transaction is approved | 
**FlagColor** | **string** | The transaction flag | 
**AccountId** | **Guid** |  | 
**PayeeId** | **Guid** |  | 
**CategoryId** | **Guid** |  | 
**TransferAccountId** | **Guid** | If a transfer transaction, the account to which it transfers | 
**TransferTransactionId** | **string** | If a transfer transaction, the id of transaction on the other side of the transfer | 
**MatchedTransactionId** | **string** | If transaction is matched, the id of the matched transaction | 
**ImportId** | **string** | If the Transaction was imported, this field is a unique (by account) import identifier.  If this transaction was imported through File Based Import or Direct Import and not through the API, the import_id will have the format: &#39;YNAB:[milliunit_amount]:[iso_date]:[occurrence]&#39;.  For example, a transaction dated 2015-12-30 in the amount of -$294.23 USD would have an import_id of &#39;YNAB:-294230:2015-12-30:1&#39;.  If a second transaction on the same account was imported and had the same date and same amount, its import_id would be &#39;YNAB:-294230:2015-12-30:2&#39;. | 
**Deleted** | **bool** | Whether or not the transaction has been deleted.  Deleted transactions will only be included in delta requests. | 
**Type** | **string** | Whether the hybrid transaction represents a regular transaction or a subtransaction | 
**ParentTransactionId** | **string** | For subtransaction types, this is the id of the parent transaction.  For transaction types, this id will be always be null. | 
**AccountName** | **string** |  | 
**PayeeName** | **string** |  | 
**CategoryName** | **string** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

