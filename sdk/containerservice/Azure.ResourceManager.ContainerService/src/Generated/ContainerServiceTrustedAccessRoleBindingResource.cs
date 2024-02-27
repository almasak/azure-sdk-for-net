// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ContainerService
{
    /// <summary>
    /// A Class representing a ContainerServiceTrustedAccessRoleBinding along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ContainerServiceTrustedAccessRoleBindingResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetContainerServiceTrustedAccessRoleBindingResource method.
    /// Otherwise you can get one from its parent resource <see cref="ContainerServiceManagedClusterResource"/> using the GetContainerServiceTrustedAccessRoleBinding method.
    /// </summary>
    public partial class ContainerServiceTrustedAccessRoleBindingResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ContainerServiceTrustedAccessRoleBindingResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="resourceName"> The resourceName. </param>
        /// <param name="trustedAccessRoleBindingName"> The trustedAccessRoleBindingName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string trustedAccessRoleBindingName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/trustedAccessRoleBindings/{trustedAccessRoleBindingName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics;
        private readonly TrustedAccessRoleBindingsRestOperations _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient;
        private readonly ContainerServiceTrustedAccessRoleBindingData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ContainerService/managedClusters/trustedAccessRoleBindings";

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceTrustedAccessRoleBindingResource"/> class for mocking. </summary>
        protected ContainerServiceTrustedAccessRoleBindingResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceTrustedAccessRoleBindingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ContainerServiceTrustedAccessRoleBindingResource(ArmClient client, ContainerServiceTrustedAccessRoleBindingData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceTrustedAccessRoleBindingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ContainerServiceTrustedAccessRoleBindingResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsApiVersion);
            _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient = new TrustedAccessRoleBindingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ContainerServiceTrustedAccessRoleBindingData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a trusted access role binding.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/trustedAccessRoleBindings/{trustedAccessRoleBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedAccessRoleBindings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceTrustedAccessRoleBindingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ContainerServiceTrustedAccessRoleBindingResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics.CreateScope("ContainerServiceTrustedAccessRoleBindingResource.Get");
            scope.Start();
            try
            {
                var response = await _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceTrustedAccessRoleBindingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a trusted access role binding.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/trustedAccessRoleBindings/{trustedAccessRoleBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedAccessRoleBindings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceTrustedAccessRoleBindingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ContainerServiceTrustedAccessRoleBindingResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics.CreateScope("ContainerServiceTrustedAccessRoleBindingResource.Get");
            scope.Start();
            try
            {
                var response = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceTrustedAccessRoleBindingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a trusted access role binding.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/trustedAccessRoleBindings/{trustedAccessRoleBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedAccessRoleBindings_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceTrustedAccessRoleBindingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics.CreateScope("ContainerServiceTrustedAccessRoleBindingResource.Delete");
            scope.Start();
            try
            {
                var response = await _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerServiceArmOperation(_containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics, Pipeline, _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a trusted access role binding.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/trustedAccessRoleBindings/{trustedAccessRoleBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedAccessRoleBindings_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceTrustedAccessRoleBindingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics.CreateScope("ContainerServiceTrustedAccessRoleBindingResource.Delete");
            scope.Start();
            try
            {
                var response = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ContainerServiceArmOperation(_containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics, Pipeline, _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a trusted access role binding
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/trustedAccessRoleBindings/{trustedAccessRoleBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedAccessRoleBindings_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceTrustedAccessRoleBindingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> A trusted access role binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerServiceTrustedAccessRoleBindingResource>> UpdateAsync(WaitUntil waitUntil, ContainerServiceTrustedAccessRoleBindingData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics.CreateScope("ContainerServiceTrustedAccessRoleBindingResource.Update");
            scope.Start();
            try
            {
                var response = await _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerServiceArmOperation<ContainerServiceTrustedAccessRoleBindingResource>(new ContainerServiceTrustedAccessRoleBindingOperationSource(Client), _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics, Pipeline, _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a trusted access role binding
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/trustedAccessRoleBindings/{trustedAccessRoleBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedAccessRoleBindings_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceTrustedAccessRoleBindingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> A trusted access role binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerServiceTrustedAccessRoleBindingResource> Update(WaitUntil waitUntil, ContainerServiceTrustedAccessRoleBindingData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics.CreateScope("ContainerServiceTrustedAccessRoleBindingResource.Update");
            scope.Start();
            try
            {
                var response = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new ContainerServiceArmOperation<ContainerServiceTrustedAccessRoleBindingResource>(new ContainerServiceTrustedAccessRoleBindingOperationSource(Client), _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics, Pipeline, _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
    }
}
