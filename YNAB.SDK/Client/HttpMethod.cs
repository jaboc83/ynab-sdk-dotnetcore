/*
 * YNAB API Endpoints
 *
 * Our API uses a REST based design, leverages the JSON data format, and relies upon HTTPS for transport. We respond with meaningful HTTP response codes and if an error occurs, we include error details in the response body.  API Documentation is at https://api.youneedabudget.com
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


namespace YNAB.SDK.Client
{
    /// <summary>
    /// Http methods supported by swagger
    /// </summary>
    public enum HttpMethod
    {
        /// <summary>HTTP GET request.</summary>
        Get,
        /// <summary>HTTP POST request.</summary>
        Post,
        /// <summary>HTTP PUT request.</summary>
        Put,
        /// <summary>HTTP DELETE request.</summary>
        Delete,
        /// <summary>HTTP HEAD request.</summary>
        Head,
        /// <summary>HTTP OPTIONS request.</summary>
        Options,
        /// <summary>HTTP PATCH request.</summary>
        Patch
    }
}
