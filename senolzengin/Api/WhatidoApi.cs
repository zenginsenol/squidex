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
    public interface IWhatidoApi
    {
        /// <summary>
        /// Change status of Whatido content. 
        /// </summary>
        /// <param name="body">The request to change content status.</param>
        /// <param name="id">The id of the Whatido content.</param>
        /// <returns>WhatidoContentDto</returns>
        WhatidoContentDto ChangeWhatidoContentStatus (ChangeStatusDto body, string id);
        /// <summary>
        /// Create a Whatido content. 
        /// </summary>
        /// <param name="body">The data of the content to be created or updated.
            




        /// <param name="publish">Set to true to autopublish content.</param>
        /// <returns>WhatidoContentDto</returns>
        WhatidoContentDto CreateWhatidoContent (WhatidoDto body, bool? publish);
        /// <summary>
        /// Delete a Whatido content. 
        /// </summary>
        /// <param name="id">The id of the Whatido content.</param>
        /// <returns></returns>
        void DeleteWhatidoContent (string id);
        /// <summary>
        /// Discard changes of Whatido content. 
        /// </summary>
        /// <param name="id">The id of the Whatido content.</param>
        /// <returns>WhatidoContentDto</returns>
        WhatidoContentDto DiscardWhatidoContent (string id);
        /// <summary>
        /// Get a Whatido content. 
        /// </summary>
        /// <param name="id">The id of the Whatido content.</param>
        /// <returns>WhatidoContentDto</returns>
        WhatidoContentDto GetWhatidoContent (string id);
        /// <summary>
        /// Patch a Whatido content. 
        /// </summary>
        /// <param name="body">The data of the content to be created or updated.
            




        /// <param name="id">The id of the Whatido content.</param>
        /// <returns>WhatidoContentDto</returns>
        WhatidoContentDto PathWhatidoContent (WhatidoDto body, string id);
        /// <summary>
        /// Queries Whatido contents. The squidex API the OData url convention to query data.   We support the following query options.  * **$top**: The $top query option requests the number of items in the queried collection to be included in the result. The default value is 20 and the maximum allowed value is 200. * **$skip**: The $skip query option requests the number of items in the queried collection that are to be skipped and not included in the result. Use it together with $top to read the all your data page by page.  * **$search**: The $search query option allows clients to request entities matching a free-text search expression. We add the data of all fields for all languages to a single field in the database and use this combined field to implement the full text search. * **$filter**: The $filter query option allows clients to filter a collection of resources that are addressed by a request URL. * **$orderby**: The $orderby query option allows clients to request resources in a particular order.  Read more about it at: https://docs.squidex.io/04-guides/02-api.html 
        /// </summary>
        /// <param name="search">Optional OData full text search.</param>
        /// <param name="top">Optional number of contents to take.</param>
        /// <param name="skip">Optional number of contents to skip.</param>
        /// <param name="orderby">Optional OData order definition.</param>
        /// <param name="filter">Optional OData filter definition.</param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 QueryWhatidoContents (string search, decimal? top, decimal? skip, string orderby, string filter);
        /// <summary>
        /// Update a Whatido content. 
        /// </summary>
        /// <param name="body">The data of the content to be created or updated.
            




        /// <param name="id">The id of the Whatido content.</param>
        /// <returns>WhatidoContentDto</returns>
        WhatidoContentDto UpdateWhatidoContent (WhatidoDto body, string id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WhatidoApi : IWhatidoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatidoApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public WhatidoApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatidoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WhatidoApi(String basePath)
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
        /// Change status of Whatido content. 
        /// </summary>
        /// <param name="body">The request to change content status.</param>
        /// <param name="id">The id of the Whatido content.</param>
        /// <returns>WhatidoContentDto</returns>
        public WhatidoContentDto ChangeWhatidoContentStatus (ChangeStatusDto body, string id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ChangeWhatidoContentStatus");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ChangeWhatidoContentStatus");
    
            var path = "/content/mycv/whatido/{id}/status";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ChangeWhatidoContentStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ChangeWhatidoContentStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WhatidoContentDto) ApiClient.Deserialize(response.Content, typeof(WhatidoContentDto), response.Headers);
        }
    
        /// <summary>
        /// Create a Whatido content. 
        /// </summary>
        /// <param name="body">The data of the content to be created or updated.
            




        /// <param name="publish">Set to true to autopublish content.</param>
        /// <returns>WhatidoContentDto</returns>
        public WhatidoContentDto CreateWhatidoContent (WhatidoDto body, bool? publish)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateWhatidoContent");
    
            var path = "/content/mycv/whatido/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateWhatidoContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateWhatidoContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WhatidoContentDto) ApiClient.Deserialize(response.Content, typeof(WhatidoContentDto), response.Headers);
        }
    
        /// <summary>
        /// Delete a Whatido content. 
        /// </summary>
        /// <param name="id">The id of the Whatido content.</param>
        /// <returns></returns>
        public void DeleteWhatidoContent (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteWhatidoContent");
    
            var path = "/content/mycv/whatido/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteWhatidoContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteWhatidoContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Discard changes of Whatido content. 
        /// </summary>
        /// <param name="id">The id of the Whatido content.</param>
        /// <returns>WhatidoContentDto</returns>
        public WhatidoContentDto DiscardWhatidoContent (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DiscardWhatidoContent");
    
            var path = "/content/mycv/whatido/{id}/discard";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DiscardWhatidoContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DiscardWhatidoContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WhatidoContentDto) ApiClient.Deserialize(response.Content, typeof(WhatidoContentDto), response.Headers);
        }
    
        /// <summary>
        /// Get a Whatido content. 
        /// </summary>
        /// <param name="id">The id of the Whatido content.</param>
        /// <returns>WhatidoContentDto</returns>
        public WhatidoContentDto GetWhatidoContent (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetWhatidoContent");
    
            var path = "/content/mycv/whatido/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetWhatidoContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWhatidoContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WhatidoContentDto) ApiClient.Deserialize(response.Content, typeof(WhatidoContentDto), response.Headers);
        }
    
        /// <summary>
        /// Patch a Whatido content. 
        /// </summary>
        /// <param name="body">The data of the content to be created or updated.
            




        /// <param name="id">The id of the Whatido content.</param>
        /// <returns>WhatidoContentDto</returns>
        public WhatidoContentDto PathWhatidoContent (WhatidoDto body, string id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PathWhatidoContent");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PathWhatidoContent");
    
            var path = "/content/mycv/whatido/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PathWhatidoContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PathWhatidoContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WhatidoContentDto) ApiClient.Deserialize(response.Content, typeof(WhatidoContentDto), response.Headers);
        }
    
        /// <summary>
        /// Queries Whatido contents. The squidex API the OData url convention to query data.   We support the following query options.  * **$top**: The $top query option requests the number of items in the queried collection to be included in the result. The default value is 20 and the maximum allowed value is 200. * **$skip**: The $skip query option requests the number of items in the queried collection that are to be skipped and not included in the result. Use it together with $top to read the all your data page by page.  * **$search**: The $search query option allows clients to request entities matching a free-text search expression. We add the data of all fields for all languages to a single field in the database and use this combined field to implement the full text search. * **$filter**: The $filter query option allows clients to filter a collection of resources that are addressed by a request URL. * **$orderby**: The $orderby query option allows clients to request resources in a particular order.  Read more about it at: https://docs.squidex.io/04-guides/02-api.html 
        /// </summary>
        /// <param name="search">Optional OData full text search.</param>
        /// <param name="top">Optional number of contents to take.</param>
        /// <param name="skip">Optional number of contents to skip.</param>
        /// <param name="orderby">Optional OData order definition.</param>
        /// <param name="filter">Optional OData filter definition.</param>
        /// <returns>InlineResponse2003</returns>
        public InlineResponse2003 QueryWhatidoContents (string search, decimal? top, decimal? skip, string orderby, string filter)
        {
    
            var path = "/content/mycv/whatido/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling QueryWhatidoContents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling QueryWhatidoContents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2003) ApiClient.Deserialize(response.Content, typeof(InlineResponse2003), response.Headers);
        }
    
        /// <summary>
        /// Update a Whatido content. 
        /// </summary>
        /// <param name="body">The data of the content to be created or updated.
            




        /// <param name="id">The id of the Whatido content.</param>
        /// <returns>WhatidoContentDto</returns>
        public WhatidoContentDto UpdateWhatidoContent (WhatidoDto body, string id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateWhatidoContent");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateWhatidoContent");
    
            var path = "/content/mycv/whatido/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateWhatidoContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateWhatidoContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WhatidoContentDto) ApiClient.Deserialize(response.Content, typeof(WhatidoContentDto), response.Headers);
        }
    
    }
}
