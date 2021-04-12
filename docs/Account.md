# YNAB.SDK.Model.Account

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | 
**Name** | **string** |  | 
**Type** | **string** | The type of account. Note: payPal, merchantAccount, investmentAccount, and mortgage types have been deprecated and will be removed in the future. | 
**OnBudget** | **bool** | Whether this account is on budget or not | 
**Closed** | **bool** | Whether this account is closed or not | 
**Note** | **string** |  | [optional] 
**Balance** | **long** | The current balance of the account in milliunits format | 
**ClearedBalance** | **long** | The current cleared balance of the account in milliunits format | 
**UnclearedBalance** | **long** | The current uncleared balance of the account in milliunits format | 
**TransferPayeeId** | **Guid** | The payee id which should be used when transferring to this account | 
**DirectImportLinked** | **bool** | Whether or not the account is linked to a financial institution for automatic transaction import. | [optional] 
**DirectImportInError** | **bool** | If an account linked to a financial institution (direct_import_linked&#x3D;true) and the linked connection is not in a healthy state, this will be true. | [optional] 
**Deleted** | **bool** | Whether or not the account has been deleted.  Deleted accounts will only be included in delta requests. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

