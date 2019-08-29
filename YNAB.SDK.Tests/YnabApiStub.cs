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
