using System;
using System.IO;
using System.Reflection;
using Stubbery;

namespace YNAB.SDK.Tests
{

  /// <summary>
  /// A server stub for testing the YNAB API
  /// </summary>
  public class YnabApiStub : IDisposable
  {
    private readonly ApiStub _stub;
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="port">The Port to host the stub on</param>
    /// <param name="useDefaultResponses">Add the default YNAB stub responses</param>
    public YnabApiStub(int? port = null, bool useDefaultResponses = true) {
      _stub = new ApiStub();
      if(port.HasValue) {
        _stub.Port = port;
      }

      // Read in default configurations
      if(useDefaultResponses)
      {
        foreach (var fileName in Directory.GetFiles("stub-responses"))
        {
          using (var reader = new StreamReader(fileName))
          {
            var endpoint = fileName.Substring(fileName.IndexOf("\\") + 1).Split(".")[0];
            endpoint = endpoint.Replace("__", "/");
            var content = reader.ReadToEnd();
            _stub.Get(
              $"/{endpoint}",
              (req, args) => {
                return content;
              }
            )
            .AddDefaultHeaders();
          }
          var postEndpoint = "budgets/14235236-8085-4cf6-9fa6-92c34ed44b0c/transactions";
          _stub.Post(
            $"/{postEndpoint}",
            (req, args) => {
              return "{\"data\":{\"transaction_ids\":[\"013a8128-d78f-42ff-a59e-633a4c75253e\"],\"transaction\":{\"id\":\"013a8128-d78f-42ff-a59e-633a4c75253e\",\"date\":\"2019-09-04\",\"amount\":100,\"memo\":\"TEST\",\"cleared\":\"cleared\",\"approved\":true,\"flag_color\":\"red\",\"account_id\":\"09c21bf0-8bd0-4b7b-b158-4fe2df899991\",\"account_name\":\"Checking Account\",\"payee_id\":\"51b1c8ad-f51e-4782-a0dc-f1b2b2cadd61\",\"payee_name\":\"Starting Balance\",\"category_id\":\"6e6c1877-6fa7-461a-8f5f-0aadf361f8cd\",\"category_name\":\"Immediate Income SubCategory\",\"transfer_account_id\":null,\"transfer_transaction_id\":null,\"matched_transaction_id\":null,\"import_id\":null,\"deleted\":false,\"subtransactions\":[]},\"server_knowledge\":174}}";
            }
          );
        }
      }

      _stub.Start();
    }

    /// <summary>
    /// The URL where the stub is hosted
    /// </summary>
    public string BasePath { get { return _stub.Address; } }

    /// <summary>
    /// Add a simple get request stub response
    /// </summary>
    /// <param name="relativePath"></param>
    /// <param name="expectedOutput"></param>
    public void AddGetRequest(string relativePath, string expectedOutput) {
      _stub.Get(
        relativePath,
        (req, args) => {
          return expectedOutput;
        }
      )
        .AddDefaultHeaders();
    }

    /// <summary>
    /// Add a get request stub response
    /// </summary>
    /// <param name="relativePath"></param>
    /// <param name="response"></param>
    public void AddGetRequest(string relativePath, Stubbery.RequestMatching.CreateStubResponse response)
    {
      _stub.Get(relativePath, response)
        .AddDefaultHeaders();
    }

    public void AddPostRequest(string relativePath, Stubbery.RequestMatching.CreateStubResponse response)
    {
      _stub.Post(relativePath, response)
        .AddDefaultHeaders();
    }

    /// <summary>
    /// Tear down the stub
    /// </summary>
    public void Dispose()
    {
      _stub.Dispose();
    }
  }

  public static class StubExtensions
  {
    public static ISetup AddDefaultHeaders(this ISetup respSetup)
    {
      return respSetup
        .Header("content-type", "application/json")
        .Header("charset", "utf-8");
    }
  }
}
