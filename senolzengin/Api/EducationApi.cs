using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEducationApi
    {
        /// <summary>
        /// Change status of Education content. 
        /// </summary>
        /// <param name="body">The request to change content status.</param>
        /// <param name="id">The id of the Education content.</param>
        /// <returns>EducationContentDto</returns>
        EducationContentDto ChangeEducationContentStatus (ChangeStatusDto body, string id);
        /// <summary>
        /// Create a Education content. 
        /// </summary>
        /// <param name="body">The data of the content to be created or updated.
            
 



        /// <param name="publish">Set to true to autopublish content.</param>
        /// <returns>EducationContentDto</returns>
        EducationContentDto CreateEducationContent (EducationDto body, bool? publish);
        /// <summary>
        /// Delete a Education content. 
        /// </summary>
        /// <param name="id">The id of the Education content.</param>
        /// <returns></returns>
        void DeleteEducationContent (string id);
        /// <summary>
        /// Discard changes of Education content. 
        /// </summary>
        /// <param name="id">The id of the Education content.</param>
        /// <returns>EducationContentDto</returns>
        EducationContentDto DiscardEducationContent (string id);
        /// <summary>
        /// Get a Education content. 
        /// </summary>
        /// <param name="id">The id of the Education content.</param>
        /// <returns>EducationContentDto</returns>
        EducationContentDto GetEducationContent (string id);
        /// <summary>
        /// Patch a Education content. 
        /// </summary>
        /// <param name="body">The data of the content to be created or updated.
            
 



        /// <param name="id">The id of the Education content.</param>
        /// <returns>EducationContentDto</returns>
        EducationContentDto PathEducationContent (EducationDto body, string id);
        /// <summary>
        /// Queries Education contents. The squidex API the OData url convention to query data.   We support the following query options.  * **$top**: The $top query option requests the number of items in the queried collection to be included in the result. The default value is 20 and the maximum allowed value is 200. * **$skip**: The $skip query option requests the number of items in the queried collection that are to be skipped and not included in the result. Use it together with $top to read the all your data page by page.  * **$search**: The $search query option allows clients to request entities matching a free-text search expression. We add the data of all fields for all languages to a single field in the database and use this combined field to implement the full text search. * **$filter**: The $filter query option allows clients to filter a collection of resources that are addressed by a request URL. * **$orderby**: The $orderby query option allows clients to request resources in a particular order.  Read more about it at: https://docs.squidex.io/04-guides/02-api.html 
        /// </summary>
        /// <param name="search">Optional OData full text search.</param>
        /// <param name="top">Optional number of contents to take.</param>
        /// <param name="skip">Optional number of contents to skip.</param>
        /// <param name="orderby">Optional OData order definition.</param>
        /// <param name="filter">Optional OData filter definition.</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 QueryEducationContents (string search, decimal? top, decimal? skip, string orderby, string filter);
        /// <summary>
        /// Update a Education content. 
        /// </summary>
        /// <param name="body">The data of the content to be created or updated.
            
 



        /// <param name="id">The id of the Education content.</param>
        /// <returns>EducationContentDto</returns>
        EducationContentDto UpdateEducationContent (EducationDto body, string id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EducationApi : IEducationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EducationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EducationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EducationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EducationApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Change status of Education content. 
        /// </summary>
        /// <param name="body">The request to change content status.</param>
        /// <param name="id">The id of the Education content.</param>
        /// <returns>EducationContentDto</returns>
        public EducationContentDto ChangeEducationContentStatus (ChangeStatusDto body, string id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ChangeEducationContentStatus");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ChangeEducationContentStatus");
    
            var path = "/content/mycv/education/{id}/status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "squidex-oauth-auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ChangeEducationContentStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ChangeEducationContentStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EducationContentDto) ApiClient.Deserialize(response.Content, typeof(EducationContentDto), response.Headers);
        }
    
        /// <summary>
        /// Create a Education content. 
        /// </summary>
        /// <param name="body">The data of the content to be created or updated.
            
 



        /// <param name="publish">Set to true to autopublish content.</param>
        /// <returns>EducationContentDto</returns>
        public EducationContentDto CreateEducationContent (EducationDto body, bool? publish)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateEducationContent");
    
            var path = "/content/mycv/education/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (publish != null) queryParams.Add("publish", ApiClient.ParameterToString(publish)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "squidex-oauth-auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateEducationContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateEducationContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EducationContentDto) ApiClient.Deserialize(response.Content, typeof(EducationContentDto), response.Headers);
        }
    
        /// <summary>
        /// Delete a Education content. 
        /// </summary>
        /// <param name="id">The id of the Education content.</param>
        /// <returns></returns>
        public void DeleteEducationContent (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteEducationContent");
    
            var path = "/content/mycv/education/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "squidex-oauth-auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteEducationContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteEducationContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Discard changes of Education content. 
        /// </summary>
        /// <param name="id">The id of the Education content.</param>
        /// <returns>EducationContentDto</returns>
        public EducationContentDto DiscardEducationContent (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DiscardEducationContent");
    
            var path = "/content/mycv/education/{id}/discard";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "squidex-oauth-auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DiscardEducationContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DiscardEducationContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EducationContentDto) ApiClient.Deserialize(response.Content, typeof(EducationContentDto), response.Headers);
        }
    
        /// <summary>
        /// Get a Education content. 
        /// </summary>
        /// <param name="id">The id of the Education content.</param>
        /// <returns>EducationContentDto</returns>
        public EducationContentDto GetEducationContent (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetEducationContent");
    
            var path = "/content/mycv/education/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "squidex-oauth-auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEducationContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEducationContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EducationContentDto) ApiClient.Deserialize(response.Content, typeof(EducationContentDto), response.Headers);
        }
    
        /// <summary>
        /// Patch a Education content. 
        /// </summary>
        /// <param name="body">The data of the content to be created or updated.
            
 



        /// <param name="id">The id of the Education content.</param>
        /// <returns>EducationContentDto</returns>
        public EducationContentDto PathEducationContent (EducationDto body, string id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PathEducationContent");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PathEducationContent");
    
            var path = "/content/mycv/education/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "squidex-oauth-auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PathEducationContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PathEducationContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EducationContentDto) ApiClient.Deserialize(response.Content, typeof(EducationContentDto), response.Headers);
        }
    
        /// <summary>
        /// Queries Education contents. The squidex API the OData url convention to query data.   We support the following query options.  * **$top**: The $top query option requests the number of items in the queried collection to be included in the result. The default value is 20 and the maximum allowed value is 200. * **$skip**: The $skip query option requests the number of items in the queried collection that are to be skipped and not included in the result. Use it together with $top to read the all your data page by page.  * **$search**: The $search query option allows clients to request entities matching a free-text search expression. We add the data of all fields for all languages to a single field in the database and use this combined field to implement the full text search. * **$filter**: The $filter query option allows clients to filter a collection of resources that are addressed by a request URL. * **$orderby**: The $orderby query option allows clients to request resources in a particular order.  Read more about it at: https://docs.squidex.io/04-guides/02-api.html 
        /// </summary>
        /// <param name="search">Optional OData full text search.</param>
        /// <param name="top">Optional number of contents to take.</param>
        /// <param name="skip">Optional number of contents to skip.</param>
        /// <param name="orderby">Optional OData order definition.</param>
        /// <param name="filter">Optional OData filter definition.</param>
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 QueryEducationContents (string search, decimal? top, decimal? skip, string orderby, string filter)
        {
    
            var path = "/content/mycv/education/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (search != null) queryParams.Add("$search", ApiClient.ParameterToString(search)); // query parameter
 if (top != null) queryParams.Add("$top", ApiClient.ParameterToString(top)); // query parameter
 if (skip != null) queryParams.Add("$skip", ApiClient.ParameterToString(skip)); // query parameter
 if (orderby != null) queryParams.Add("$orderby", ApiClient.ParameterToString(orderby)); // query parameter
 if (filter != null) queryParams.Add("$filter", ApiClient.ParameterToString(filter)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "squidex-oauth-auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling QueryEducationContents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling QueryEducationContents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        /// <summary>
        /// Update a Education content. 
        /// </summary>
        /// <param name="body">The data of the content to be created or updated.
            
 



        /// <param name="id">The id of the Education content.</param>
        /// <returns>EducationContentDto</returns>
        public EducationContentDto UpdateEducationContent (EducationDto body, string id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateEducationContent");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateEducationContent");
    
            var path = "/content/mycv/education/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "squidex-oauth-auth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateEducationContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateEducationContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EducationContentDto) ApiClient.Deserialize(response.Content, typeof(EducationContentDto), response.Headers);
        }
    
    }
}
