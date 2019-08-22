/* 
 * YNAB API Endpoints
 *
 * Our API uses a REST based design, leverages the JSON data format, and relies upon HTTPS for transport. We respond with meaningful HTTP response codes and if an error occurs, we include error details in the response body.  API Documentation is at https://api.youneedabudget.com
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using YNAB.SDK.Client;
using YNAB.SDK.Model;

namespace YNAB.SDK.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPayeesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Single payee
        /// </summary>
        /// <remarks>
        /// Returns single payee
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)</param>
        /// <param name="payeeId">The id of the payee</param>
        /// <returns>PayeeResponse</returns>
        PayeeResponse GetPayeeById (string budgetId, string payeeId);

        /// <summary>
        /// Single payee
        /// </summary>
        /// <remarks>
        /// Returns single payee
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)</param>
        /// <param name="payeeId">The id of the payee</param>
        /// <returns>ApiResponse of PayeeResponse</returns>
        ApiResponse<PayeeResponse> GetPayeeByIdWithHttpInfo (string budgetId, string payeeId);
        /// <summary>
        /// List payees
        /// </summary>
        /// <remarks>
        /// Returns all payees
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since last_knowledge_of_server will be included. (optional)</param>
        /// <returns>PayeesResponse</returns>
        PayeesResponse GetPayees (string budgetId, long? lastKnowledgeOfServer = null);

        /// <summary>
        /// List payees
        /// </summary>
        /// <remarks>
        /// Returns all payees
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since last_knowledge_of_server will be included. (optional)</param>
        /// <returns>ApiResponse of PayeesResponse</returns>
        ApiResponse<PayeesResponse> GetPayeesWithHttpInfo (string budgetId, long? lastKnowledgeOfServer = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPayeesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Single payee
        /// </summary>
        /// <remarks>
        /// Returns single payee
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)</param>
        /// <param name="payeeId">The id of the payee</param>
        /// <returns>Task of PayeeResponse</returns>
        System.Threading.Tasks.Task<PayeeResponse> GetPayeeByIdAsync (string budgetId, string payeeId);

        /// <summary>
        /// Single payee
        /// </summary>
        /// <remarks>
        /// Returns single payee
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)</param>
        /// <param name="payeeId">The id of the payee</param>
        /// <returns>Task of ApiResponse (PayeeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PayeeResponse>> GetPayeeByIdAsyncWithHttpInfo (string budgetId, string payeeId);
        /// <summary>
        /// List payees
        /// </summary>
        /// <remarks>
        /// Returns all payees
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since last_knowledge_of_server will be included. (optional)</param>
        /// <returns>Task of PayeesResponse</returns>
        System.Threading.Tasks.Task<PayeesResponse> GetPayeesAsync (string budgetId, long? lastKnowledgeOfServer = null);

        /// <summary>
        /// List payees
        /// </summary>
        /// <remarks>
        /// Returns all payees
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since last_knowledge_of_server will be included. (optional)</param>
        /// <returns>Task of ApiResponse (PayeesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PayeesResponse>> GetPayeesAsyncWithHttpInfo (string budgetId, long? lastKnowledgeOfServer = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPayeesApi : IPayeesApiSync, IPayeesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PayeesApi : IPayeesApi
    {
        private YNAB.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PayeesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PayeesApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayeesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PayeesApi(String basePath)
        {
            this.Configuration = YNAB.SDK.Client.Configuration.MergeConfigurations(
                YNAB.SDK.Client.GlobalConfiguration.Instance,
                new YNAB.SDK.Client.Configuration { BasePath = basePath }
            );
            this.Client = new YNAB.SDK.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new YNAB.SDK.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = YNAB.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayeesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PayeesApi(YNAB.SDK.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = YNAB.SDK.Client.Configuration.MergeConfigurations(
                YNAB.SDK.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new YNAB.SDK.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new YNAB.SDK.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = YNAB.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayeesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PayeesApi(YNAB.SDK.Client.ISynchronousClient client,YNAB.SDK.Client.IAsynchronousClient asyncClient, YNAB.SDK.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = YNAB.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public YNAB.SDK.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public YNAB.SDK.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public YNAB.SDK.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public YNAB.SDK.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Single payee Returns single payee
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)</param>
        /// <param name="payeeId">The id of the payee</param>
        /// <returns>PayeeResponse</returns>
        public PayeeResponse GetPayeeById (string budgetId, string payeeId)
        {
             YNAB.SDK.Client.ApiResponse<PayeeResponse> localVarResponse = GetPayeeByIdWithHttpInfo(budgetId, payeeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Single payee Returns single payee
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)</param>
        /// <param name="payeeId">The id of the payee</param>
        /// <returns>ApiResponse of PayeeResponse</returns>
        public YNAB.SDK.Client.ApiResponse< PayeeResponse > GetPayeeByIdWithHttpInfo (string budgetId, string payeeId)
        {
            // verify the required parameter 'budgetId' is set
            if (budgetId == null)
                throw new YNAB.SDK.Client.ApiException(400, "Missing required parameter 'budgetId' when calling PayeesApi->GetPayeeById");

            // verify the required parameter 'payeeId' is set
            if (payeeId == null)
                throw new YNAB.SDK.Client.ApiException(400, "Missing required parameter 'payeeId' when calling PayeesApi->GetPayeeById");

            YNAB.SDK.Client.RequestOptions requestOptions = new YNAB.SDK.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };

            var localVarContentType = YNAB.SDK.Client.ClientUtils.SelectHeaderContentType(@contentTypes);
            if (localVarContentType != null) requestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = YNAB.SDK.Client.ClientUtils.SelectHeaderAccept(@accepts);
            if (localVarAccept != null) requestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (budgetId != null)
                requestOptions.PathParameters.Add("budget_id", YNAB.SDK.Client.ClientUtils.ParameterToString(budgetId)); // path parameter
            if (payeeId != null)
                requestOptions.PathParameters.Add("payee_id", YNAB.SDK.Client.ClientUtils.ParameterToString(payeeId)); // path parameter

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                requestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var response = this.Client.Get< PayeeResponse >("/budgets/{budget_id}/payees/{payee_id}", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetPayeeById", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Single payee Returns single payee
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)</param>
        /// <param name="payeeId">The id of the payee</param>
        /// <returns>Task of PayeeResponse</returns>
        public async System.Threading.Tasks.Task<PayeeResponse> GetPayeeByIdAsync (string budgetId, string payeeId)
        {
             YNAB.SDK.Client.ApiResponse<PayeeResponse> localVarResponse = await GetPayeeByIdAsyncWithHttpInfo(budgetId, payeeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Single payee Returns single payee
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)</param>
        /// <param name="payeeId">The id of the payee</param>
        /// <returns>Task of ApiResponse (PayeeResponse)</returns>
        public async System.Threading.Tasks.Task<YNAB.SDK.Client.ApiResponse<PayeeResponse>> GetPayeeByIdAsyncWithHttpInfo (string budgetId, string payeeId)
        {
            // verify the required parameter 'budgetId' is set
            if (budgetId == null)
                throw new YNAB.SDK.Client.ApiException(400, "Missing required parameter 'budgetId' when calling PayeesApi->GetPayeeById");

            // verify the required parameter 'payeeId' is set
            if (payeeId == null)
                throw new YNAB.SDK.Client.ApiException(400, "Missing required parameter 'payeeId' when calling PayeesApi->GetPayeeById");


            YNAB.SDK.Client.RequestOptions requestOptions = new YNAB.SDK.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var contentType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", contentType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            
            if (budgetId != null)
                requestOptions.PathParameters.Add("budget_id", YNAB.SDK.Client.ClientUtils.ParameterToString(budgetId)); // path parameter
            if (payeeId != null)
                requestOptions.PathParameters.Add("payee_id", YNAB.SDK.Client.ClientUtils.ParameterToString(payeeId)); // path parameter

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                requestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var response = await this.AsynchronousClient.GetAsync<PayeeResponse>("/budgets/{budget_id}/payees/{payee_id}", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetPayeeById", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// List payees Returns all payees
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since last_knowledge_of_server will be included. (optional)</param>
        /// <returns>PayeesResponse</returns>
        public PayeesResponse GetPayees (string budgetId, long? lastKnowledgeOfServer = null)
        {
             YNAB.SDK.Client.ApiResponse<PayeesResponse> localVarResponse = GetPayeesWithHttpInfo(budgetId, lastKnowledgeOfServer);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List payees Returns all payees
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since last_knowledge_of_server will be included. (optional)</param>
        /// <returns>ApiResponse of PayeesResponse</returns>
        public YNAB.SDK.Client.ApiResponse< PayeesResponse > GetPayeesWithHttpInfo (string budgetId, long? lastKnowledgeOfServer = null)
        {
            // verify the required parameter 'budgetId' is set
            if (budgetId == null)
                throw new YNAB.SDK.Client.ApiException(400, "Missing required parameter 'budgetId' when calling PayeesApi->GetPayees");

            YNAB.SDK.Client.RequestOptions requestOptions = new YNAB.SDK.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };

            var localVarContentType = YNAB.SDK.Client.ClientUtils.SelectHeaderContentType(@contentTypes);
            if (localVarContentType != null) requestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = YNAB.SDK.Client.ClientUtils.SelectHeaderAccept(@accepts);
            if (localVarAccept != null) requestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (budgetId != null)
                requestOptions.PathParameters.Add("budget_id", YNAB.SDK.Client.ClientUtils.ParameterToString(budgetId)); // path parameter
            if (lastKnowledgeOfServer != null)
            {
                foreach (var kvp in YNAB.SDK.Client.ClientUtils.ParameterToMultiMap("", "last_knowledge_of_server", lastKnowledgeOfServer))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                requestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var response = this.Client.Get< PayeesResponse >("/budgets/{budget_id}/payees", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetPayees", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// List payees Returns all payees
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since last_knowledge_of_server will be included. (optional)</param>
        /// <returns>Task of PayeesResponse</returns>
        public async System.Threading.Tasks.Task<PayeesResponse> GetPayeesAsync (string budgetId, long? lastKnowledgeOfServer = null)
        {
             YNAB.SDK.Client.ApiResponse<PayeesResponse> localVarResponse = await GetPayeesAsyncWithHttpInfo(budgetId, lastKnowledgeOfServer);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List payees Returns all payees
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget (\&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget)</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since last_knowledge_of_server will be included. (optional)</param>
        /// <returns>Task of ApiResponse (PayeesResponse)</returns>
        public async System.Threading.Tasks.Task<YNAB.SDK.Client.ApiResponse<PayeesResponse>> GetPayeesAsyncWithHttpInfo (string budgetId, long? lastKnowledgeOfServer = null)
        {
            // verify the required parameter 'budgetId' is set
            if (budgetId == null)
                throw new YNAB.SDK.Client.ApiException(400, "Missing required parameter 'budgetId' when calling PayeesApi->GetPayees");


            YNAB.SDK.Client.RequestOptions requestOptions = new YNAB.SDK.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var contentType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", contentType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            
            if (budgetId != null)
                requestOptions.PathParameters.Add("budget_id", YNAB.SDK.Client.ClientUtils.ParameterToString(budgetId)); // path parameter
            if (lastKnowledgeOfServer != null)
            {
                foreach (var kvp in YNAB.SDK.Client.ClientUtils.ParameterToMultiMap("", "last_knowledge_of_server", lastKnowledgeOfServer))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                requestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var response = await this.AsynchronousClient.GetAsync<PayeesResponse>("/budgets/{budget_id}/payees", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetPayees", response);
                if (exception != null) throw exception;
            }

            return response;
        }

    }
}
