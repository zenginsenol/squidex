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
    public interface IExperienceApi
    {
        /// <summary>
        /// Change status of Experience content. 
        /// </summary>
        /// <param name="body">The request to change content status.</param>
        /// <param name="id">The id of the Experience content.</param>
        /// <returns>ExperienceContentDto</returns>
        ExperienceContentDto ChangeExperienceContentStatus (ChangeStatusDto body, string id);
        /// <summary>
        /// Create a Experience content. 
        /// </summary>
        /// <param name="body">The data of the content to be created or updated.
            




        /// <param name="publish">Set to true to autopublish content.</param>
        /// <returns>ExperienceContentDto</returns>
        ExperienceContentDto CreateExperienceContent (ExperienceDto body, bool? publish);
        /// <summary>
        /// Delete a Experience content. 
        /// </summary>
        /// <param name="id">The id of the Experience content.</param>
        /// <returns></returns>
        void DeleteExperienceContent (string id);
        /// <summary>
        /// Discard changes of Experience content. 
        /// </summary>
        /// <param name="id">The id of the Experience content.</param>
        /// <returns>ExperienceContentDto</returns>
        ExperienceContentDto DiscardExperienceContent (string id);
        /// <summary>
        /// Get a Experience content. 
        /// </summary>
        /// <param name="id">The id of the Experience content.</param>
        /// <returns>ExperienceContentDto</returns>
        ExperienceContentDto GetExperienceContent (string id);
        /// <summary>
        /// Patch a Experience content. 
        /// </summary>
        /// <param name="body">The data of the content to be created or updated.
            




        /// <param name="id">The id of the Experience content.</param>
        /// <returns>ExperienceContentDto</returns>
        ExperienceContentDto PathExperienceContent (ExperienceDto body, string id);
        /// <summary>
        /// Queries Experience contents. The squidex API the OData url convention to query data.   We support the following query options.  * **$top**: The $top query option requests the number of items in the queried collection to be included in the result. The default value is 20 and the maximum allowed value is 200. * **$skip**: The $skip query option requests the number of items in the queried collection that are to be skipped and not included in the result. Use it together with $top to read the all your data page by page.  * **$search**: The $search query option allows clients to request entities matching a free-text search expression. We add the data of all fields for all languages to a single field in the database and use this combined field to implement the full text search. * **$filter**: The $filter query option allows clients to filter a collection of resources that are addressed by a request URL. * **$orderby**: The $orderby query option allows clients to request resources in a particular order.  Read more about it at: https://docs.squidex.io/04-guides/02-api.html 
        /// </summary>
        /// <param name="search">Optional OData full text search.</param>
        /// <param name="top">Optional number of contents to take.</param>
        /// <param name="skip">Optional number of contents to skip.</param>
        /// <param name="orderby">Optional OData order definition.</param>
        /// <param name="filter">Optional OData filter definition.</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 QueryExperienceContents (string search, decimal? top, decimal? skip, string orderby, string filter);
        /// <summary>
        /// Update a Experience content. 
        /// </summary>
        /// <param name="body">The data of the content to be created or updated.
            




        /// <param name="id">The id of the Experience content.</param>
        /// <returns>ExperienceContentDto</returns>
        ExperienceContentDto UpdateExperienceContent (ExperienceDto body, string id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ExperienceApi : IExperienceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExperienceApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ExperienceApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExperienceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExperienceApi(String basePath)
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
        /// Change status of Experience content. 
        /// </summary>
        /// <param name="body">The request to change content status.</param>
        /// <param name="id">The id of the Experience content.</param>
        /// <returns>ExperienceContentDto</returns>
        public ExperienceContentDto ChangeExperienceContentStatus (ChangeStatusDto body, string id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ChangeExperienceContentStatus");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ChangeExperienceContentStatus");
    
            var path = "/content/mycv/experience/{id}/status";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ChangeExperienceContentStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ChangeExperienceContentStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ExperienceContentDto) ApiClient.Deserialize(response.Content, typeof(ExperienceContentDto), response.Headers);
        }
    
        /// <summary>
        /// Create a Experience content. 
        /// </summary>
        /// <param name="body">The data of the content to be created or updated.
            




        /// <param name="publish">Set to true to autopublish content.</param>
        /// <returns>ExperienceContentDto</returns>
        public ExperienceContentDto CreateExperienceContent (ExperienceDto body, bool? publish)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateExperienceContent");
    
            var path = "/content/mycv/experience/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateExperienceContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateExperienceContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ExperienceContentDto) ApiClient.Deserialize(response.Content, typeof(ExperienceContentDto), response.Headers);
        }
    
        /// <summary>
        /// Delete a Experience content. 
        /// </summary>
        /// <param name="id">The id of the Experience content.</param>
        /// <returns></returns>
        public void DeleteExperienceContent (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteExperienceContent");
    
            var path = "/content/mycv/experience/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExperienceContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteExperienceContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Discard changes of Experience content. 
        /// </summary>
        /// <param name="id">The id of the Experience content.</param>
        /// <returns>ExperienceContentDto</returns>
        public ExperienceContentDto DiscardExperienceContent (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DiscardExperienceContent");
    
            var path = "/content/mycv/experience/{id}/discard";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DiscardExperienceContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DiscardExperienceContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ExperienceContentDto) ApiClient.Deserialize(response.Content, typeof(ExperienceContentDto), response.Headers);
        }
    
        /// <summary>
        /// Get a Experience content. 
        /// </summary>
        /// <param name="id">The id of the Experience content.</param>
        /// <returns>ExperienceContentDto</returns>
        public ExperienceContentDto GetExperienceContent (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetExperienceContent");
    
            var path = "/content/mycv/experience/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetExperienceContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExperienceContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ExperienceContentDto) ApiClient.Deserialize(response.Content, typeof(ExperienceContentDto), response.Headers);
        }
    
        /// <summary>
        /// Patch a Experience content. 
        /// </summary>
        /// <param name="body">The data of the content to be created or updated.
            




        /// <param name="id">The id of the Experience content.</param>
        /// <returns>ExperienceContentDto</returns>
        public ExperienceContentDto PathExperienceContent (ExperienceDto body, string id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PathExperienceContent");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PathExperienceContent");
    
            var path = "/content/mycv/experience/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PathExperienceContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PathExperienceContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ExperienceContentDto) ApiClient.Deserialize(response.Content, typeof(ExperienceContentDto), response.Headers);
        }
    
        /// <summary>
        /// Queries Experience contents. The squidex API the OData url convention to query data.   We support the following query options.  * **$top**: The $top query option requests the number of items in the queried collection to be included in the result. The default value is 20 and the maximum allowed value is 200. * **$skip**: The $skip query option requests the number of items in the queried collection that are to be skipped and not included in the result. Use it together with $top to read the all your data page by page.  * **$search**: The $search query option allows clients to request entities matching a free-text search expression. We add the data of all fields for all languages to a single field in the database and use this combined field to implement the full text search. * **$filter**: The $filter query option allows clients to filter a collection of resources that are addressed by a request URL. * **$orderby**: The $orderby query option allows clients to request resources in a particular order.  Read more about it at: https://docs.squidex.io/04-guides/02-api.html 
        /// </summary>
        /// <param name="search">Optional OData full text search.</param>
        /// <param name="top">Optional number of contents to take.</param>
        /// <param name="skip">Optional number of contents to skip.</param>
        /// <param name="orderby">Optional OData order definition.</param>
        /// <param name="filter">Optional OData filter definition.</param>
        /// <returns>InlineResponse2001</returns>
        public InlineResponse2001 QueryExperienceContents (string search, decimal? top, decimal? skip, string orderby, string filter)
        {
    
            var path = "/content/mycv/experience/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling QueryExperienceContents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling QueryExperienceContents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2001) ApiClient.Deserialize(response.Content, typeof(InlineResponse2001), response.Headers);
        }
    
        /// <summary>
        /// Update a Experience content. 
        /// </summary>
        /// <param name="body">The data of the content to be created or updated.
            




        /// <param name="id">The id of the Experience content.</param>
        /// <returns>ExperienceContentDto</returns>
        public ExperienceContentDto UpdateExperienceContent (ExperienceDto body, string id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateExperienceContent");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateExperienceContent");
    
            var path = "/content/mycv/experience/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateExperienceContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateExperienceContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ExperienceContentDto) ApiClient.Deserialize(response.Content, typeof(ExperienceContentDto), response.Headers);
        }
    
    }
}
