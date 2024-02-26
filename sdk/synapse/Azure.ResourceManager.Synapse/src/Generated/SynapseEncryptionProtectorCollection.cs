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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapseEncryptionProtectorResource"/> and their operations.
    /// Each <see cref="SynapseEncryptionProtectorResource"/> in the collection will belong to the same instance of <see cref="SynapseWorkspaceResource"/>.
    /// To get a <see cref="SynapseEncryptionProtectorCollection"/> instance call the GetSynapseEncryptionProtectors method from an instance of <see cref="SynapseWorkspaceResource"/>.
    /// </summary>
    public partial class SynapseEncryptionProtectorCollection : ArmCollection, IEnumerable<SynapseEncryptionProtectorResource>, IAsyncEnumerable<SynapseEncryptionProtectorResource>
    {
        private readonly ClientDiagnostics _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics;
        private readonly WorkspaceManagedSqlServerEncryptionProtectorRestOperations _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseEncryptionProtectorCollection"/> class for mocking. </summary>
        protected SynapseEncryptionProtectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseEncryptionProtectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseEncryptionProtectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseEncryptionProtectorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseEncryptionProtectorResource.ResourceType, out string synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorApiVersion);
            _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient = new WorkspaceManagedSqlServerEncryptionProtectorRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates workspace managed sql server's encryption protector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/encryptionProtector/{encryptionProtectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerEncryptionProtector_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseEncryptionProtectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="encryptionProtectorName"> The name of the encryption protector. </param>
        /// <param name="data"> The requested encryption protector resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseEncryptionProtectorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SynapseEncryptionProtectorName encryptionProtectorName, SynapseEncryptionProtectorData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics.CreateScope("SynapseEncryptionProtectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseEncryptionProtectorResource>(new SynapseEncryptionProtectorOperationSource(Client), _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics, Pipeline, _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Updates workspace managed sql server's encryption protector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/encryptionProtector/{encryptionProtectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerEncryptionProtector_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseEncryptionProtectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="encryptionProtectorName"> The name of the encryption protector. </param>
        /// <param name="data"> The requested encryption protector resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseEncryptionProtectorResource> CreateOrUpdate(WaitUntil waitUntil, SynapseEncryptionProtectorName encryptionProtectorName, SynapseEncryptionProtectorData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics.CreateScope("SynapseEncryptionProtectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseEncryptionProtectorResource>(new SynapseEncryptionProtectorOperationSource(Client), _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics, Pipeline, _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get workspace managed sql server's encryption protector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/encryptionProtector/{encryptionProtectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerEncryptionProtector_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseEncryptionProtectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseEncryptionProtectorResource>> GetAsync(SynapseEncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics.CreateScope("SynapseEncryptionProtectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseEncryptionProtectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get workspace managed sql server's encryption protector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/encryptionProtector/{encryptionProtectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerEncryptionProtector_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseEncryptionProtectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseEncryptionProtectorResource> Get(SynapseEncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics.CreateScope("SynapseEncryptionProtectorCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseEncryptionProtectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get list of encryption protectors for workspace managed sql server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/encryptionProtector</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerEncryptionProtector_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseEncryptionProtectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseEncryptionProtectorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseEncryptionProtectorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SynapseEncryptionProtectorResource(Client, SynapseEncryptionProtectorData.DeserializeSynapseEncryptionProtectorData(e)), _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics, Pipeline, "SynapseEncryptionProtectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get list of encryption protectors for workspace managed sql server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/encryptionProtector</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerEncryptionProtector_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseEncryptionProtectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseEncryptionProtectorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseEncryptionProtectorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SynapseEncryptionProtectorResource(Client, SynapseEncryptionProtectorData.DeserializeSynapseEncryptionProtectorData(e)), _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics, Pipeline, "SynapseEncryptionProtectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/encryptionProtector/{encryptionProtectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerEncryptionProtector_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseEncryptionProtectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(SynapseEncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics.CreateScope("SynapseEncryptionProtectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/encryptionProtector/{encryptionProtectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerEncryptionProtector_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseEncryptionProtectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(SynapseEncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics.CreateScope("SynapseEncryptionProtectorCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/encryptionProtector/{encryptionProtectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerEncryptionProtector_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseEncryptionProtectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<SynapseEncryptionProtectorResource>> GetIfExistsAsync(SynapseEncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics.CreateScope("SynapseEncryptionProtectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SynapseEncryptionProtectorResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseEncryptionProtectorResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/encryptionProtector/{encryptionProtectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerEncryptionProtector_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseEncryptionProtectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="encryptionProtectorName"> The name of the encryption protector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<SynapseEncryptionProtectorResource> GetIfExists(SynapseEncryptionProtectorName encryptionProtectorName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorClientDiagnostics.CreateScope("SynapseEncryptionProtectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _synapseEncryptionProtectorWorkspaceManagedSqlServerEncryptionProtectorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, encryptionProtectorName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SynapseEncryptionProtectorResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseEncryptionProtectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseEncryptionProtectorResource> IEnumerable<SynapseEncryptionProtectorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseEncryptionProtectorResource> IAsyncEnumerable<SynapseEncryptionProtectorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
