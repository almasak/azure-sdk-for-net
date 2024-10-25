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
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HealthDataAIServices
{
    /// <summary>
    /// A class representing a collection of <see cref="DeidServiceResource"/> and their operations.
    /// Each <see cref="DeidServiceResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="DeidServiceCollection"/> instance call the GetDeidServices method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class DeidServiceCollection : ArmCollection, IEnumerable<DeidServiceResource>, IAsyncEnumerable<DeidServiceResource>
    {
        private readonly ClientDiagnostics _deidServiceClientDiagnostics;
        private readonly DeidServicesRestOperations _deidServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeidServiceCollection"/> class for mocking. </summary>
        protected DeidServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeidServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DeidServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deidServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HealthDataAIServices", DeidServiceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DeidServiceResource.ResourceType, out string deidServiceApiVersion);
            _deidServiceRestClient = new DeidServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deidServiceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a DeidService
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthDataAIServices/deidServices/{deidServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeidService_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-28-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeidServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deidServiceName"> The name of the deid service. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deidServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deidServiceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DeidServiceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string deidServiceName, DeidServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deidServiceName, nameof(deidServiceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deidServiceClientDiagnostics.CreateScope("DeidServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _deidServiceRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, deidServiceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HealthDataAIServicesArmOperation<DeidServiceResource>(new DeidServiceOperationSource(Client), _deidServiceClientDiagnostics, Pipeline, _deidServiceRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, deidServiceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a DeidService
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthDataAIServices/deidServices/{deidServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeidService_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-28-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeidServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deidServiceName"> The name of the deid service. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deidServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deidServiceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DeidServiceResource> CreateOrUpdate(WaitUntil waitUntil, string deidServiceName, DeidServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deidServiceName, nameof(deidServiceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deidServiceClientDiagnostics.CreateScope("DeidServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _deidServiceRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, deidServiceName, data, cancellationToken);
                var operation = new HealthDataAIServicesArmOperation<DeidServiceResource>(new DeidServiceOperationSource(Client), _deidServiceClientDiagnostics, Pipeline, _deidServiceRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, deidServiceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a DeidService
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthDataAIServices/deidServices/{deidServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeidService_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-28-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeidServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deidServiceName"> The name of the deid service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deidServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deidServiceName"/> is null. </exception>
        public virtual async Task<Response<DeidServiceResource>> GetAsync(string deidServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deidServiceName, nameof(deidServiceName));

            using var scope = _deidServiceClientDiagnostics.CreateScope("DeidServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _deidServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, deidServiceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeidServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a DeidService
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthDataAIServices/deidServices/{deidServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeidService_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-28-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeidServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deidServiceName"> The name of the deid service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deidServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deidServiceName"/> is null. </exception>
        public virtual Response<DeidServiceResource> Get(string deidServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deidServiceName, nameof(deidServiceName));

            using var scope = _deidServiceClientDiagnostics.CreateScope("DeidServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _deidServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, deidServiceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeidServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List DeidService resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthDataAIServices/deidServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeidService_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-28-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeidServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeidServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeidServiceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deidServiceRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _deidServiceRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DeidServiceResource(Client, DeidServiceData.DeserializeDeidServiceData(e)), _deidServiceClientDiagnostics, Pipeline, "DeidServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List DeidService resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthDataAIServices/deidServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeidService_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-28-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeidServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeidServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeidServiceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deidServiceRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _deidServiceRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DeidServiceResource(Client, DeidServiceData.DeserializeDeidServiceData(e)), _deidServiceClientDiagnostics, Pipeline, "DeidServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthDataAIServices/deidServices/{deidServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeidService_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-28-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeidServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deidServiceName"> The name of the deid service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deidServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deidServiceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string deidServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deidServiceName, nameof(deidServiceName));

            using var scope = _deidServiceClientDiagnostics.CreateScope("DeidServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _deidServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, deidServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthDataAIServices/deidServices/{deidServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeidService_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-28-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeidServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deidServiceName"> The name of the deid service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deidServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deidServiceName"/> is null. </exception>
        public virtual Response<bool> Exists(string deidServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deidServiceName, nameof(deidServiceName));

            using var scope = _deidServiceClientDiagnostics.CreateScope("DeidServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = _deidServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, deidServiceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthDataAIServices/deidServices/{deidServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeidService_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-28-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeidServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deidServiceName"> The name of the deid service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deidServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deidServiceName"/> is null. </exception>
        public virtual async Task<NullableResponse<DeidServiceResource>> GetIfExistsAsync(string deidServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deidServiceName, nameof(deidServiceName));

            using var scope = _deidServiceClientDiagnostics.CreateScope("DeidServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _deidServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, deidServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DeidServiceResource>(response.GetRawResponse());
                return Response.FromValue(new DeidServiceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthDataAIServices/deidServices/{deidServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeidService_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-28-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeidServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deidServiceName"> The name of the deid service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deidServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deidServiceName"/> is null. </exception>
        public virtual NullableResponse<DeidServiceResource> GetIfExists(string deidServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deidServiceName, nameof(deidServiceName));

            using var scope = _deidServiceClientDiagnostics.CreateScope("DeidServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deidServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, deidServiceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DeidServiceResource>(response.GetRawResponse());
                return Response.FromValue(new DeidServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DeidServiceResource> IEnumerable<DeidServiceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeidServiceResource> IAsyncEnumerable<DeidServiceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
