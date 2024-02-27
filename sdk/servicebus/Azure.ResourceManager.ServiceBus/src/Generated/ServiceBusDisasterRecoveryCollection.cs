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

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceBusDisasterRecoveryResource"/> and their operations.
    /// Each <see cref="ServiceBusDisasterRecoveryResource"/> in the collection will belong to the same instance of <see cref="ServiceBusNamespaceResource"/>.
    /// To get a <see cref="ServiceBusDisasterRecoveryCollection"/> instance call the GetServiceBusDisasterRecoveries method from an instance of <see cref="ServiceBusNamespaceResource"/>.
    /// </summary>
    public partial class ServiceBusDisasterRecoveryCollection : ArmCollection, IEnumerable<ServiceBusDisasterRecoveryResource>, IAsyncEnumerable<ServiceBusDisasterRecoveryResource>
    {
        private readonly ClientDiagnostics _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics;
        private readonly DisasterRecoveryConfigsRestOperations _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceBusDisasterRecoveryCollection"/> class for mocking. </summary>
        protected ServiceBusDisasterRecoveryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceBusDisasterRecoveryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceBusDisasterRecoveryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ServiceBusDisasterRecoveryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceBusDisasterRecoveryResource.ResourceType, out string serviceBusDisasterRecoveryDisasterRecoveryConfigsApiVersion);
            _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient = new DisasterRecoveryConfigsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceBusDisasterRecoveryDisasterRecoveryConfigsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceBusNamespaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceBusNamespaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a new Alias(Disaster Recovery configuration)
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusDisasterRecoveryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="data"> Parameters required to create an Alias(Disaster Recovery configuration). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceBusDisasterRecoveryResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string @alias, ServiceBusDisasterRecoveryData data, CancellationToken cancellationToken = default)
        {
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }
            if (@alias.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(@alias));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("ServiceBusDisasterRecoveryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation<ServiceBusDisasterRecoveryResource>(Response.FromValue(new ServiceBusDisasterRecoveryResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a new Alias(Disaster Recovery configuration)
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusDisasterRecoveryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="data"> Parameters required to create an Alias(Disaster Recovery configuration). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceBusDisasterRecoveryResource> CreateOrUpdate(WaitUntil waitUntil, string @alias, ServiceBusDisasterRecoveryData data, CancellationToken cancellationToken = default)
        {
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }
            if (@alias.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(@alias));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("ServiceBusDisasterRecoveryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, data, cancellationToken);
                var operation = new ServiceBusArmOperation<ServiceBusDisasterRecoveryResource>(Response.FromValue(new ServiceBusDisasterRecoveryResource(Client, response), response.GetRawResponse()));
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
        /// Retrieves Alias(Disaster Recovery configuration) for primary or secondary namespace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusDisasterRecoveryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public virtual async Task<Response<ServiceBusDisasterRecoveryResource>> GetAsync(string @alias, CancellationToken cancellationToken = default)
        {
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }
            if (@alias.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(@alias));
            }

            using var scope = _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("ServiceBusDisasterRecoveryCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusDisasterRecoveryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves Alias(Disaster Recovery configuration) for primary or secondary namespace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusDisasterRecoveryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public virtual Response<ServiceBusDisasterRecoveryResource> Get(string @alias, CancellationToken cancellationToken = default)
        {
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }
            if (@alias.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(@alias));
            }

            using var scope = _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("ServiceBusDisasterRecoveryCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusDisasterRecoveryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all Alias(Disaster Recovery configurations)
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusDisasterRecoveryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceBusDisasterRecoveryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceBusDisasterRecoveryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServiceBusDisasterRecoveryResource(Client, ServiceBusDisasterRecoveryData.DeserializeServiceBusDisasterRecoveryData(e)), _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics, Pipeline, "ServiceBusDisasterRecoveryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all Alias(Disaster Recovery configurations)
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusDisasterRecoveryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceBusDisasterRecoveryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceBusDisasterRecoveryResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServiceBusDisasterRecoveryResource(Client, ServiceBusDisasterRecoveryData.DeserializeServiceBusDisasterRecoveryData(e)), _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics, Pipeline, "ServiceBusDisasterRecoveryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusDisasterRecoveryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string @alias, CancellationToken cancellationToken = default)
        {
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }
            if (@alias.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(@alias));
            }

            using var scope = _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("ServiceBusDisasterRecoveryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusDisasterRecoveryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public virtual Response<bool> Exists(string @alias, CancellationToken cancellationToken = default)
        {
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }
            if (@alias.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(@alias));
            }

            using var scope = _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("ServiceBusDisasterRecoveryCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusDisasterRecoveryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public virtual async Task<NullableResponse<ServiceBusDisasterRecoveryResource>> GetIfExistsAsync(string @alias, CancellationToken cancellationToken = default)
        {
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }
            if (@alias.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(@alias));
            }

            using var scope = _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("ServiceBusDisasterRecoveryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServiceBusDisasterRecoveryResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceBusDisasterRecoveryResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusDisasterRecoveryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alias"/> is null. </exception>
        public virtual NullableResponse<ServiceBusDisasterRecoveryResource> GetIfExists(string @alias, CancellationToken cancellationToken = default)
        {
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }
            if (@alias.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(@alias));
            }

            using var scope = _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("ServiceBusDisasterRecoveryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alias, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServiceBusDisasterRecoveryResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceBusDisasterRecoveryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceBusDisasterRecoveryResource> IEnumerable<ServiceBusDisasterRecoveryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceBusDisasterRecoveryResource> IAsyncEnumerable<ServiceBusDisasterRecoveryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
