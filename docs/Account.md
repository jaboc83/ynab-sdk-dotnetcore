# YNAB.SDK.Model.Account
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | 
**Name** | **string** |  | 
**Type** | **string** | The type of account. Note: payPal, merchantAccount, investmentAccount, and mortgage types have been deprecated and will be removed in the future. | 
**OnBudget** | **bool** | Whether this account is on budget or not | 
**Closed** | **bool** | Whether this account is closed or not | 
**Note** | **string** |  | 
**Balance** | **long** | The current balance of the account in milliunits format | 
**ClearedBalance** | **long** | The current cleared balance of the account in milliunits format | 
**UnclearedBalance** | **long** | The current uncleared balance of the account in milliunits format | 
**TransferPayeeId** | **Guid** | The payee id which should be used when transferring to this account | 
**Deleted** | **bool** | Whether or not the account has been deleted.  Deleted accounts will only be included in delta requests. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

