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
using Azure.ResourceManager.MySql.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MySql
{
    /// <summary>
    /// A class representing a collection of <see cref="MySqlServerResource"/> and their operations.
    /// Each <see cref="MySqlServerResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="MySqlServerCollection"/> instance call the GetMySqlServers method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class MySqlServerCollection : ArmCollection, IEnumerable<MySqlServerResource>, IAsyncEnumerable<MySqlServerResource>
    {
        private readonly ClientDiagnostics _mySqlServerServersClientDiagnostics;
        private readonly ServersRestOperations _mySqlServerServersRestClient;
        private readonly ClientDiagnostics _replicasClientDiagnostics;
        private readonly ReplicasRestOperations _replicasRestClient;

        /// <summary> Initializes a new instance of the <see cref="MySqlServerCollection"/> class for mocking. </summary>
        protected MySqlServerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MySqlServerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MySqlServerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mySqlServerServersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql", MySqlServerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MySqlServerResource.ResourceType, out string mySqlServerServersApiVersion);
            _mySqlServerServersRestClient = new ServersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mySqlServerServersApiVersion);
            _replicasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _replicasRestClient = new ReplicasRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
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
        /// Creates a new server or updates an existing server. The update action will overwrite the existing server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="content"> The required parameters for creating or updating a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<MySqlServerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string serverName, MySqlServerCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (serverName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverName));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _mySqlServerServersClientDiagnostics.CreateScope("MySqlServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mySqlServerServersRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, serverName, content, cancellationToken).ConfigureAwait(false);
                var operation = new MySqlArmOperation<MySqlServerResource>(new MySqlServerOperationSource(Client), _mySqlServerServersClientDiagnostics, Pipeline, _mySqlServerServersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, serverName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a new server or updates an existing server. The update action will overwrite the existing server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="content"> The required parameters for creating or updating a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<MySqlServerResource> CreateOrUpdate(WaitUntil waitUntil, string serverName, MySqlServerCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (serverName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverName));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _mySqlServerServersClientDiagnostics.CreateScope("MySqlServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mySqlServerServersRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, serverName, content, cancellationToken);
                var operation = new MySqlArmOperation<MySqlServerResource>(new MySqlServerOperationSource(Client), _mySqlServerServersClientDiagnostics, Pipeline, _mySqlServerServersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, serverName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets information about a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual async Task<Response<MySqlServerResource>> GetAsync(string serverName, CancellationToken cancellationToken = default)
        {
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (serverName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverName));
            }

            using var scope = _mySqlServerServersClientDiagnostics.CreateScope("MySqlServerCollection.Get");
            scope.Start();
            try
            {
                var response = await _mySqlServerServersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serverName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual Response<MySqlServerResource> Get(string serverName, CancellationToken cancellationToken = default)
        {
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (serverName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverName));
            }

            using var scope = _mySqlServerServersClientDiagnostics.CreateScope("MySqlServerCollection.Get");
            scope.Start();
            try
            {
                var response = _mySqlServerServersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serverName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the servers in a given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlServerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MySqlServerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mySqlServerServersRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new MySqlServerResource(Client, MySqlServerData.DeserializeMySqlServerData(e)), _mySqlServerServersClientDiagnostics, Pipeline, "MySqlServerCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all the servers in a given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlServerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MySqlServerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mySqlServerServersRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new MySqlServerResource(Client, MySqlServerData.DeserializeMySqlServerData(e)), _mySqlServerServersClientDiagnostics, Pipeline, "MySqlServerCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all the replicas for a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/replicas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-12-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        /// <returns> An async collection of <see cref="MySqlServerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MySqlServerResource> GetReplicasAsync(string serverName, CancellationToken cancellationToken = default)
        {
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (serverName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverName));
            }

            HttpMessage FirstPageRequest(int? pageSizeHint) => _replicasRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, serverName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new MySqlServerResource(Client, MySqlServerData.DeserializeMySqlServerData(e)), _replicasClientDiagnostics, Pipeline, "MySqlServerCollection.GetReplicas", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all the replicas for a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/replicas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-12-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        /// <returns> A collection of <see cref="MySqlServerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MySqlServerResource> GetReplicas(string serverName, CancellationToken cancellationToken = default)
        {
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (serverName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverName));
            }

            HttpMessage FirstPageRequest(int? pageSizeHint) => _replicasRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, serverName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new MySqlServerResource(Client, MySqlServerData.DeserializeMySqlServerData(e)), _replicasClientDiagnostics, Pipeline, "MySqlServerCollection.GetReplicas", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serverName, CancellationToken cancellationToken = default)
        {
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (serverName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverName));
            }

            using var scope = _mySqlServerServersClientDiagnostics.CreateScope("MySqlServerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mySqlServerServersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serverName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual Response<bool> Exists(string serverName, CancellationToken cancellationToken = default)
        {
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (serverName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverName));
            }

            using var scope = _mySqlServerServersClientDiagnostics.CreateScope("MySqlServerCollection.Exists");
            scope.Start();
            try
            {
                var response = _mySqlServerServersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serverName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual async Task<NullableResponse<MySqlServerResource>> GetIfExistsAsync(string serverName, CancellationToken cancellationToken = default)
        {
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (serverName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverName));
            }

            using var scope = _mySqlServerServersClientDiagnostics.CreateScope("MySqlServerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mySqlServerServersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serverName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MySqlServerResource>(response.GetRawResponse());
                return Response.FromValue(new MySqlServerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual NullableResponse<MySqlServerResource> GetIfExists(string serverName, CancellationToken cancellationToken = default)
        {
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (serverName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverName));
            }

            using var scope = _mySqlServerServersClientDiagnostics.CreateScope("MySqlServerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mySqlServerServersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serverName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MySqlServerResource>(response.GetRawResponse());
                return Response.FromValue(new MySqlServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MySqlServerResource> IEnumerable<MySqlServerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MySqlServerResource> IAsyncEnumerable<MySqlServerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
