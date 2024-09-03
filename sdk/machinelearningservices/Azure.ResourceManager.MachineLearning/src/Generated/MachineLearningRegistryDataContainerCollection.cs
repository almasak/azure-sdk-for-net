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
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineLearningRegistryDataContainerResource"/> and their operations.
    /// Each <see cref="MachineLearningRegistryDataContainerResource"/> in the collection will belong to the same instance of <see cref="MachineLearningRegistryResource"/>.
    /// To get a <see cref="MachineLearningRegistryDataContainerCollection"/> instance call the GetMachineLearningRegistryDataContainers method from an instance of <see cref="MachineLearningRegistryResource"/>.
    /// </summary>
    public partial class MachineLearningRegistryDataContainerCollection : ArmCollection, IEnumerable<MachineLearningRegistryDataContainerResource>, IAsyncEnumerable<MachineLearningRegistryDataContainerResource>
    {
        private readonly ClientDiagnostics _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics;
        private readonly RegistryDataContainersRestOperations _machineLearningRegistryDataContainerRegistryDataContainersRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningRegistryDataContainerCollection"/> class for mocking. </summary>
        protected MachineLearningRegistryDataContainerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningRegistryDataContainerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearningRegistryDataContainerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningRegistryDataContainerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearningRegistryDataContainerResource.ResourceType, out string machineLearningRegistryDataContainerRegistryDataContainersApiVersion);
            _machineLearningRegistryDataContainerRegistryDataContainersRestClient = new RegistryDataContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningRegistryDataContainerRegistryDataContainersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningRegistryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningRegistryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataContainers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryDataContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Container name. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningRegistryDataContainerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, MachineLearningDataContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics.CreateScope("MachineLearningRegistryDataContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryDataContainerRegistryDataContainersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningRegistryDataContainerResource>(new MachineLearningRegistryDataContainerOperationSource(Client), _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics, Pipeline, _machineLearningRegistryDataContainerRegistryDataContainersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Create or update container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataContainers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryDataContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Container name. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningRegistryDataContainerResource> CreateOrUpdate(WaitUntil waitUntil, string name, MachineLearningDataContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics.CreateScope("MachineLearningRegistryDataContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryDataContainerRegistryDataContainersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningRegistryDataContainerResource>(new MachineLearningRegistryDataContainerOperationSource(Client), _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics, Pipeline, _machineLearningRegistryDataContainerRegistryDataContainersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Get container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryDataContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<MachineLearningRegistryDataContainerResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics.CreateScope("MachineLearningRegistryDataContainerCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryDataContainerRegistryDataContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryDataContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryDataContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<MachineLearningRegistryDataContainerResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics.CreateScope("MachineLearningRegistryDataContainerCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryDataContainerRegistryDataContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryDataContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Data containers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataContainers_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryDataContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="listViewType"> View type for including/excluding (for example) archived entities. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningRegistryDataContainerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningRegistryDataContainerResource> GetAllAsync(string skip = null, MachineLearningListViewType? listViewType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningRegistryDataContainerRegistryDataContainersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningRegistryDataContainerRegistryDataContainersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MachineLearningRegistryDataContainerResource(Client, MachineLearningDataContainerData.DeserializeMachineLearningDataContainerData(e)), _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics, Pipeline, "MachineLearningRegistryDataContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Data containers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataContainers_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryDataContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="listViewType"> View type for including/excluding (for example) archived entities. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningRegistryDataContainerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningRegistryDataContainerResource> GetAll(string skip = null, MachineLearningListViewType? listViewType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningRegistryDataContainerRegistryDataContainersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningRegistryDataContainerRegistryDataContainersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MachineLearningRegistryDataContainerResource(Client, MachineLearningDataContainerData.DeserializeMachineLearningDataContainerData(e)), _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics, Pipeline, "MachineLearningRegistryDataContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryDataContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics.CreateScope("MachineLearningRegistryDataContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryDataContainerRegistryDataContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryDataContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics.CreateScope("MachineLearningRegistryDataContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryDataContainerRegistryDataContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryDataContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<MachineLearningRegistryDataContainerResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics.CreateScope("MachineLearningRegistryDataContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryDataContainerRegistryDataContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningRegistryDataContainerResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryDataContainerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/data/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryDataContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryDataContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<MachineLearningRegistryDataContainerResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningRegistryDataContainerRegistryDataContainersClientDiagnostics.CreateScope("MachineLearningRegistryDataContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryDataContainerRegistryDataContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningRegistryDataContainerResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryDataContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearningRegistryDataContainerResource> IEnumerable<MachineLearningRegistryDataContainerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MachineLearningRegistryDataContainerResource> IAsyncEnumerable<MachineLearningRegistryDataContainerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
