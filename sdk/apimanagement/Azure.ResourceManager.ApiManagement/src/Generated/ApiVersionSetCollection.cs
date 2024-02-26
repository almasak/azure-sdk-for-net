// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiVersionSetResource"/> and their operations.
    /// Each <see cref="ApiVersionSetResource"/> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource"/>.
    /// To get an <see cref="ApiVersionSetCollection"/> instance call the GetApiVersionSets method from an instance of <see cref="ApiManagementServiceResource"/>.
    /// </summary>
    public partial class ApiVersionSetCollection : ArmCollection, IEnumerable<ApiVersionSetResource>, IAsyncEnumerable<ApiVersionSetResource>
    {
        private readonly ClientDiagnostics _apiVersionSetClientDiagnostics;
        private readonly ApiVersionSetRestOperations _apiVersionSetRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiVersionSetCollection"/> class for mocking. </summary>
        protected ApiVersionSetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiVersionSetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiVersionSetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiVersionSetClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiVersionSetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiVersionSetResource.ResourceType, out string apiVersionSetApiVersion);
            _apiVersionSetRestClient = new ApiVersionSetRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiVersionSetApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or Updates a Api Version Set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apiVersionSets/{versionSetId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiVersionSet_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiVersionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="versionSetId"> Api Version Set identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionSetId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionSetId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiVersionSetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string versionSetId, ApiVersionSetData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (versionSetId == null)
            {
                throw new ArgumentNullException(nameof(versionSetId));
            }
            if (versionSetId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(versionSetId));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _apiVersionSetClientDiagnostics.CreateScope("ApiVersionSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiVersionSetRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, versionSetId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiVersionSetResource>(Response.FromValue(new ApiVersionSetResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or Updates a Api Version Set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apiVersionSets/{versionSetId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiVersionSet_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiVersionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="versionSetId"> Api Version Set identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionSetId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionSetId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiVersionSetResource> CreateOrUpdate(WaitUntil waitUntil, string versionSetId, ApiVersionSetData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (versionSetId == null)
            {
                throw new ArgumentNullException(nameof(versionSetId));
            }
            if (versionSetId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(versionSetId));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _apiVersionSetClientDiagnostics.CreateScope("ApiVersionSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiVersionSetRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, versionSetId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiVersionSetResource>(Response.FromValue(new ApiVersionSetResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the Api Version Set specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apiVersionSets/{versionSetId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiVersionSet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiVersionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionSetId"> Api Version Set identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionSetId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionSetId"/> is null. </exception>
        public virtual async Task<Response<ApiVersionSetResource>> GetAsync(string versionSetId, CancellationToken cancellationToken = default)
        {
            if (versionSetId == null)
            {
                throw new ArgumentNullException(nameof(versionSetId));
            }
            if (versionSetId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(versionSetId));
            }

            using var scope = _apiVersionSetClientDiagnostics.CreateScope("ApiVersionSetCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiVersionSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, versionSetId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiVersionSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the Api Version Set specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apiVersionSets/{versionSetId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiVersionSet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiVersionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionSetId"> Api Version Set identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionSetId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionSetId"/> is null. </exception>
        public virtual Response<ApiVersionSetResource> Get(string versionSetId, CancellationToken cancellationToken = default)
        {
            if (versionSetId == null)
            {
                throw new ArgumentNullException(nameof(versionSetId));
            }
            if (versionSetId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(versionSetId));
            }

            using var scope = _apiVersionSetClientDiagnostics.CreateScope("ApiVersionSetCollection.Get");
            scope.Start();
            try
            {
                var response = _apiVersionSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, versionSetId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiVersionSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of API Version Sets in the specified service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apiVersionSets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiVersionSet_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiVersionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiVersionSetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiVersionSetResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiVersionSetRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiVersionSetRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiVersionSetResource(Client, ApiVersionSetData.DeserializeApiVersionSetData(e)), _apiVersionSetClientDiagnostics, Pipeline, "ApiVersionSetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a collection of API Version Sets in the specified service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apiVersionSets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiVersionSet_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiVersionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiVersionSetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiVersionSetResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiVersionSetRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiVersionSetRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiVersionSetResource(Client, ApiVersionSetData.DeserializeApiVersionSetData(e)), _apiVersionSetClientDiagnostics, Pipeline, "ApiVersionSetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apiVersionSets/{versionSetId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiVersionSet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiVersionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionSetId"> Api Version Set identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionSetId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionSetId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string versionSetId, CancellationToken cancellationToken = default)
        {
            if (versionSetId == null)
            {
                throw new ArgumentNullException(nameof(versionSetId));
            }
            if (versionSetId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(versionSetId));
            }

            using var scope = _apiVersionSetClientDiagnostics.CreateScope("ApiVersionSetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiVersionSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, versionSetId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apiVersionSets/{versionSetId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiVersionSet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiVersionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionSetId"> Api Version Set identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionSetId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionSetId"/> is null. </exception>
        public virtual Response<bool> Exists(string versionSetId, CancellationToken cancellationToken = default)
        {
            if (versionSetId == null)
            {
                throw new ArgumentNullException(nameof(versionSetId));
            }
            if (versionSetId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(versionSetId));
            }

            using var scope = _apiVersionSetClientDiagnostics.CreateScope("ApiVersionSetCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiVersionSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, versionSetId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apiVersionSets/{versionSetId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiVersionSet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiVersionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionSetId"> Api Version Set identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionSetId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionSetId"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiVersionSetResource>> GetIfExistsAsync(string versionSetId, CancellationToken cancellationToken = default)
        {
            if (versionSetId == null)
            {
                throw new ArgumentNullException(nameof(versionSetId));
            }
            if (versionSetId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(versionSetId));
            }

            using var scope = _apiVersionSetClientDiagnostics.CreateScope("ApiVersionSetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiVersionSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, versionSetId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiVersionSetResource>(response.GetRawResponse());
                return Response.FromValue(new ApiVersionSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apiVersionSets/{versionSetId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiVersionSet_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiVersionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionSetId"> Api Version Set identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionSetId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionSetId"/> is null. </exception>
        public virtual NullableResponse<ApiVersionSetResource> GetIfExists(string versionSetId, CancellationToken cancellationToken = default)
        {
            if (versionSetId == null)
            {
                throw new ArgumentNullException(nameof(versionSetId));
            }
            if (versionSetId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(versionSetId));
            }

            using var scope = _apiVersionSetClientDiagnostics.CreateScope("ApiVersionSetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiVersionSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, versionSetId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiVersionSetResource>(response.GetRawResponse());
                return Response.FromValue(new ApiVersionSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiVersionSetResource> IEnumerable<ApiVersionSetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiVersionSetResource> IAsyncEnumerable<ApiVersionSetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
