# YNAB.SDK.Model.Category
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | 
**CategoryGroupId** | **Guid** |  | 
**Name** | **string** |  | 
**Hidden** | **bool** | Whether or not the category is hidden | 
**OriginalCategoryGroupId** | **Guid** | If category is hidden this is the id of the category group it originally belonged to before it was hidden. | [optional] 
**Note** | **string** |  | 
**Budgeted** | **long** | Budgeted amount in milliunits format | 
**Activity** | **long** | Activity amount in milliunits format | 
**Balance** | **long** | Balance in milliunits format | 
**GoalType** | **string** | The type of goal, if the cagegory has a goal (TB&#x3D;Target Category Balance, TBD&#x3D;Target Category Balance by Date, MF&#x3D;Monthly Funding) | 
**GoalCreationMonth** | **DateTime** | The month a goal was created | 
**GoalTarget** | **long** | The goal target amount in milliunits | 
**GoalTargetMonth** | **DateTime** | If the goal type is &#39;TBD&#39; (Target Category Balance by Date), this is the target month for the goal to be completed | 
**GoalPercentageComplete** | **int** | The percentage completion of the goal | 
**Deleted** | **bool** | Whether or not the category has been deleted.  Deleted categories will only be included in delta requests. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

