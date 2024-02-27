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
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="CapacityReservationResource"/> and their operations.
    /// Each <see cref="CapacityReservationResource"/> in the collection will belong to the same instance of <see cref="CapacityReservationGroupResource"/>.
    /// To get a <see cref="CapacityReservationCollection"/> instance call the GetCapacityReservations method from an instance of <see cref="CapacityReservationGroupResource"/>.
    /// </summary>
    public partial class CapacityReservationCollection : ArmCollection, IEnumerable<CapacityReservationResource>, IAsyncEnumerable<CapacityReservationResource>
    {
        private readonly ClientDiagnostics _capacityReservationClientDiagnostics;
        private readonly CapacityReservationsRestOperations _capacityReservationRestClient;

        /// <summary> Initializes a new instance of the <see cref="CapacityReservationCollection"/> class for mocking. </summary>
        protected CapacityReservationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CapacityReservationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CapacityReservationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _capacityReservationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", CapacityReservationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CapacityReservationResource.ResourceType, out string capacityReservationApiVersion);
            _capacityReservationRestClient = new CapacityReservationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, capacityReservationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CapacityReservationGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CapacityReservationGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update a capacity reservation. Please note some properties can be set only during capacity reservation creation. Please refer to https://aka.ms/CapacityReservation for more details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations/{capacityReservationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CapacityReservations_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CapacityReservationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="capacityReservationName"> The name of the capacity reservation. </param>
        /// <param name="data"> Parameters supplied to the Create capacity reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capacityReservationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capacityReservationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CapacityReservationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string capacityReservationName, CapacityReservationData data, CancellationToken cancellationToken = default)
        {
            if (capacityReservationName == null)
            {
                throw new ArgumentNullException(nameof(capacityReservationName));
            }
            if (capacityReservationName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(capacityReservationName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _capacityReservationClientDiagnostics.CreateScope("CapacityReservationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _capacityReservationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, capacityReservationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<CapacityReservationResource>(new CapacityReservationOperationSource(Client), _capacityReservationClientDiagnostics, Pipeline, _capacityReservationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, capacityReservationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to create or update a capacity reservation. Please note some properties can be set only during capacity reservation creation. Please refer to https://aka.ms/CapacityReservation for more details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations/{capacityReservationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CapacityReservations_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CapacityReservationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="capacityReservationName"> The name of the capacity reservation. </param>
        /// <param name="data"> Parameters supplied to the Create capacity reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capacityReservationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capacityReservationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CapacityReservationResource> CreateOrUpdate(WaitUntil waitUntil, string capacityReservationName, CapacityReservationData data, CancellationToken cancellationToken = default)
        {
            if (capacityReservationName == null)
            {
                throw new ArgumentNullException(nameof(capacityReservationName));
            }
            if (capacityReservationName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(capacityReservationName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _capacityReservationClientDiagnostics.CreateScope("CapacityReservationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _capacityReservationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, capacityReservationName, data, cancellationToken);
                var operation = new ComputeArmOperation<CapacityReservationResource>(new CapacityReservationOperationSource(Client), _capacityReservationClientDiagnostics, Pipeline, _capacityReservationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, capacityReservationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// The operation that retrieves information about the capacity reservation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations/{capacityReservationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CapacityReservations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CapacityReservationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capacityReservationName"> The name of the capacity reservation. </param>
        /// <param name="expand"> The expand expression to apply on the operation. 'InstanceView' retrieves a snapshot of the runtime properties of the capacity reservation that is managed by the platform and can change outside of control plane operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capacityReservationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capacityReservationName"/> is null. </exception>
        public virtual async Task<Response<CapacityReservationResource>> GetAsync(string capacityReservationName, CapacityReservationInstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            if (capacityReservationName == null)
            {
                throw new ArgumentNullException(nameof(capacityReservationName));
            }
            if (capacityReservationName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(capacityReservationName));
            }

            using var scope = _capacityReservationClientDiagnostics.CreateScope("CapacityReservationCollection.Get");
            scope.Start();
            try
            {
                var response = await _capacityReservationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, capacityReservationName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CapacityReservationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation that retrieves information about the capacity reservation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations/{capacityReservationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CapacityReservations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CapacityReservationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capacityReservationName"> The name of the capacity reservation. </param>
        /// <param name="expand"> The expand expression to apply on the operation. 'InstanceView' retrieves a snapshot of the runtime properties of the capacity reservation that is managed by the platform and can change outside of control plane operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capacityReservationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capacityReservationName"/> is null. </exception>
        public virtual Response<CapacityReservationResource> Get(string capacityReservationName, CapacityReservationInstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            if (capacityReservationName == null)
            {
                throw new ArgumentNullException(nameof(capacityReservationName));
            }
            if (capacityReservationName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(capacityReservationName));
            }

            using var scope = _capacityReservationClientDiagnostics.CreateScope("CapacityReservationCollection.Get");
            scope.Start();
            try
            {
                var response = _capacityReservationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, capacityReservationName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CapacityReservationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the capacity reservations in the specified capacity reservation group. Use the nextLink property in the response to get the next page of capacity reservations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CapacityReservations_ListByCapacityReservationGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CapacityReservationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CapacityReservationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CapacityReservationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _capacityReservationRestClient.CreateListByCapacityReservationGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _capacityReservationRestClient.CreateListByCapacityReservationGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CapacityReservationResource(Client, CapacityReservationData.DeserializeCapacityReservationData(e)), _capacityReservationClientDiagnostics, Pipeline, "CapacityReservationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the capacity reservations in the specified capacity reservation group. Use the nextLink property in the response to get the next page of capacity reservations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CapacityReservations_ListByCapacityReservationGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CapacityReservationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CapacityReservationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CapacityReservationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _capacityReservationRestClient.CreateListByCapacityReservationGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _capacityReservationRestClient.CreateListByCapacityReservationGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CapacityReservationResource(Client, CapacityReservationData.DeserializeCapacityReservationData(e)), _capacityReservationClientDiagnostics, Pipeline, "CapacityReservationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations/{capacityReservationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CapacityReservations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CapacityReservationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capacityReservationName"> The name of the capacity reservation. </param>
        /// <param name="expand"> The expand expression to apply on the operation. 'InstanceView' retrieves a snapshot of the runtime properties of the capacity reservation that is managed by the platform and can change outside of control plane operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capacityReservationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capacityReservationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string capacityReservationName, CapacityReservationInstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            if (capacityReservationName == null)
            {
                throw new ArgumentNullException(nameof(capacityReservationName));
            }
            if (capacityReservationName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(capacityReservationName));
            }

            using var scope = _capacityReservationClientDiagnostics.CreateScope("CapacityReservationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _capacityReservationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, capacityReservationName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations/{capacityReservationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CapacityReservations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CapacityReservationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capacityReservationName"> The name of the capacity reservation. </param>
        /// <param name="expand"> The expand expression to apply on the operation. 'InstanceView' retrieves a snapshot of the runtime properties of the capacity reservation that is managed by the platform and can change outside of control plane operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capacityReservationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capacityReservationName"/> is null. </exception>
        public virtual Response<bool> Exists(string capacityReservationName, CapacityReservationInstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            if (capacityReservationName == null)
            {
                throw new ArgumentNullException(nameof(capacityReservationName));
            }
            if (capacityReservationName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(capacityReservationName));
            }

            using var scope = _capacityReservationClientDiagnostics.CreateScope("CapacityReservationCollection.Exists");
            scope.Start();
            try
            {
                var response = _capacityReservationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, capacityReservationName, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations/{capacityReservationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CapacityReservations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CapacityReservationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capacityReservationName"> The name of the capacity reservation. </param>
        /// <param name="expand"> The expand expression to apply on the operation. 'InstanceView' retrieves a snapshot of the runtime properties of the capacity reservation that is managed by the platform and can change outside of control plane operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capacityReservationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capacityReservationName"/> is null. </exception>
        public virtual async Task<NullableResponse<CapacityReservationResource>> GetIfExistsAsync(string capacityReservationName, CapacityReservationInstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            if (capacityReservationName == null)
            {
                throw new ArgumentNullException(nameof(capacityReservationName));
            }
            if (capacityReservationName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(capacityReservationName));
            }

            using var scope = _capacityReservationClientDiagnostics.CreateScope("CapacityReservationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _capacityReservationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, capacityReservationName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CapacityReservationResource>(response.GetRawResponse());
                return Response.FromValue(new CapacityReservationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations/{capacityReservationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CapacityReservations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CapacityReservationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="capacityReservationName"> The name of the capacity reservation. </param>
        /// <param name="expand"> The expand expression to apply on the operation. 'InstanceView' retrieves a snapshot of the runtime properties of the capacity reservation that is managed by the platform and can change outside of control plane operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capacityReservationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capacityReservationName"/> is null. </exception>
        public virtual NullableResponse<CapacityReservationResource> GetIfExists(string capacityReservationName, CapacityReservationInstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            if (capacityReservationName == null)
            {
                throw new ArgumentNullException(nameof(capacityReservationName));
            }
            if (capacityReservationName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(capacityReservationName));
            }

            using var scope = _capacityReservationClientDiagnostics.CreateScope("CapacityReservationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _capacityReservationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, capacityReservationName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CapacityReservationResource>(response.GetRawResponse());
                return Response.FromValue(new CapacityReservationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CapacityReservationResource> IEnumerable<CapacityReservationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CapacityReservationResource> IAsyncEnumerable<CapacityReservationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
