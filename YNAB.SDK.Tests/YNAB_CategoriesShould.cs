using System;
using Xunit;
using System.Threading.Tasks;
using System.Linq;

namespace YNAB.SDK.Tests
{
  public class YNAB_CategoriesShould
  {
    private readonly string _token = "FAKE_TOKEN";
    private readonly string TEST_BUDGET_ID = "14235236-8085-4cf6-9fa6-92c34ed44b0c";
    private readonly string TEST_MONTH_ID = "2019-08-01";

    public YNAB_CategoriesShould() { }

    [Fact]
    public async Task Categories_NotBeEmpty() {
      // Arrange
      using (var stub = new YnabApiStub())
      {
        var api = new API(_token, stub.BasePath);

        // Act
        var categories = (await api.Categories.GetCategoriesAsync(TEST_BUDGET_ID)).Data.CategoryGroups;

        // Assert
        Assert.NotNull(categories);
        Assert.NotEmpty(categories);
      }
    }
  }
}
