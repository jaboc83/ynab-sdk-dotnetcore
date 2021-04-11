# YNAB.SDK.Model.Category

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | 
**CategoryGroupId** | **Guid** |  | 
**Name** | **string** |  | 
**Hidden** | **bool** | Whether or not the category is hidden | 
**OriginalCategoryGroupId** | **Guid** | If category is hidden this is the id of the category group it originally belonged to before it was hidden. | [optional] 
**Note** | **string** |  | [optional] 
**Budgeted** | **long** | Budgeted amount in milliunits format | 
**Activity** | **long** | Activity amount in milliunits format | 
**Balance** | **long** | Balance in milliunits format | 
**GoalType** | **string** | The type of goal, if the category has a goal (TB&#x3D;&#39;Target Category Balance&#39;, TBD&#x3D;&#39;Target Category Balance by Date&#39;, MF&#x3D;&#39;Monthly Funding&#39;, NEED&#x3D;&#39;Plan Your Spending&#39;) | [optional] 
**GoalCreationMonth** | **DateTime** | The month a goal was created | [optional] 
**GoalTarget** | **long** | The goal target amount in milliunits | [optional] 
**GoalTargetMonth** | **DateTime** | The original target month for the goal to be completed.  Only some goal types specify this date. | [optional] 
**GoalPercentageComplete** | **int** | The percentage completion of the goal | [optional] 
**GoalMonthsToBudget** | **int** | The number of months, including the current month, left in the current goal period. | [optional] 
**GoalUnderFunded** | **long** | The amount of funding still needed in the current month to stay on track towards completing the goal within the current goal period.  This amount will generally correspond to the &#39;Underfunded&#39; amount in the web and mobile clients except when viewing a category with a Needed for Spending Goal in a future month.  The web and mobile clients will ignore any funding from a prior goal period when viewing category with a Needed for Spending Goal in a future month. | [optional] 
**GoalOverallFunded** | **long** | The total amount funded towards the goal within the current goal period. | [optional] 
**GoalOverallLeft** | **long** | The amount of funding still needed to complete the goal within the current goal period. | [optional] 
**Deleted** | **bool** | Whether or not the category has been deleted.  Deleted categories will only be included in delta requests. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

