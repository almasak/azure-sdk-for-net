// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagementLockResource"/> and their operations.
    /// Each <see cref="ManagementLockResource"/> in the collection will belong to the same instance of <see cref="ArmResource"/>.
    /// To get a <see cref="ManagementLockCollection"/> instance call the GetManagementLocks method from an instance of <see cref="ArmResource"/>.
    /// </summary>
    public partial class ManagementLockCollection : ArmCollection, IEnumerable<ManagementLockResource>, IAsyncEnumerable<ManagementLockResource>
    {
        private readonly ClientDiagnostics _managementLockClientDiagnostics;
        private readonly ManagementLocksRestOperations _managementLockRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagementLockCollection"/> class for mocking. </summary>
        protected ManagementLockCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagementLockCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagementLockCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managementLockClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ManagementLockResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagementLockResource.ResourceType, out string managementLockApiVersion);
            _managementLockRestClient = new ManagementLocksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managementLockApiVersion);
        }

        /// <summary>
        /// Create or update a management lock by scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/locks/{lockName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementLocks_CreateOrUpdateByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementLockResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="lockName"> The name of lock. </param>
        /// <param name="data"> Create or update management lock parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="lockName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="lockName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagementLockResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string lockName, ManagementLockData data, CancellationToken cancellationToken = default)
        {
            if (lockName == null)
            {
                throw new ArgumentNullException(nameof(lockName));
            }
            if (lockName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(lockName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _managementLockClientDiagnostics.CreateScope("ManagementLockCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managementLockRestClient.CreateOrUpdateByScopeAsync(Id, lockName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation<ManagementLockResource>(Response.FromValue(new ManagementLockResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a management lock by scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/locks/{lockName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementLocks_CreateOrUpdateByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementLockResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="lockName"> The name of lock. </param>
        /// <param name="data"> Create or update management lock parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="lockName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="lockName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagementLockResource> CreateOrUpdate(WaitUntil waitUntil, string lockName, ManagementLockData data, CancellationToken cancellationToken = default)
        {
            if (lockName == null)
            {
                throw new ArgumentNullException(nameof(lockName));
            }
            if (lockName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(lockName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _managementLockClientDiagnostics.CreateScope("ManagementLockCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managementLockRestClient.CreateOrUpdateByScope(Id, lockName, data, cancellationToken);
                var operation = new ResourcesArmOperation<ManagementLockResource>(Response.FromValue(new ManagementLockResource(Client, response), response.GetRawResponse()));
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
        /// Get a management lock by scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/locks/{lockName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementLocks_GetByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementLockResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="lockName"> The name of lock. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="lockName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="lockName"/> is null. </exception>
        public virtual async Task<Response<ManagementLockResource>> GetAsync(string lockName, CancellationToken cancellationToken = default)
        {
            if (lockName == null)
            {
                throw new ArgumentNullException(nameof(lockName));
            }
            if (lockName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(lockName));
            }

            using var scope = _managementLockClientDiagnostics.CreateScope("ManagementLockCollection.Get");
            scope.Start();
            try
            {
                var response = await _managementLockRestClient.GetByScopeAsync(Id, lockName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagementLockResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a management lock by scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/locks/{lockName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementLocks_GetByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementLockResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="lockName"> The name of lock. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="lockName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="lockName"/> is null. </exception>
        public virtual Response<ManagementLockResource> Get(string lockName, CancellationToken cancellationToken = default)
        {
            if (lockName == null)
            {
                throw new ArgumentNullException(nameof(lockName));
            }
            if (lockName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(lockName));
            }

            using var scope = _managementLockClientDiagnostics.CreateScope("ManagementLockCollection.Get");
            scope.Start();
            try
            {
                var response = _managementLockRestClient.GetByScope(Id, lockName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagementLockResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the management locks for a scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/locks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementLocks_ListByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementLockResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagementLockResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagementLockResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managementLockRestClient.CreateListByScopeRequest(Id, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managementLockRestClient.CreateListByScopeNextPageRequest(nextLink, Id, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ManagementLockResource(Client, ManagementLockData.DeserializeManagementLockData(e)), _managementLockClientDiagnostics, Pipeline, "ManagementLockCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the management locks for a scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/locks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementLocks_ListByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementLockResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagementLockResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagementLockResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managementLockRestClient.CreateListByScopeRequest(Id, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managementLockRestClient.CreateListByScopeNextPageRequest(nextLink, Id, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ManagementLockResource(Client, ManagementLockData.DeserializeManagementLockData(e)), _managementLockClientDiagnostics, Pipeline, "ManagementLockCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/locks/{lockName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementLocks_GetByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementLockResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="lockName"> The name of lock. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="lockName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="lockName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string lockName, CancellationToken cancellationToken = default)
        {
            if (lockName == null)
            {
                throw new ArgumentNullException(nameof(lockName));
            }
            if (lockName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(lockName));
            }

            using var scope = _managementLockClientDiagnostics.CreateScope("ManagementLockCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managementLockRestClient.GetByScopeAsync(Id, lockName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{scope}/providers/Microsoft.Authorization/locks/{lockName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementLocks_GetByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementLockResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="lockName"> The name of lock. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="lockName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="lockName"/> is null. </exception>
        public virtual Response<bool> Exists(string lockName, CancellationToken cancellationToken = default)
        {
            if (lockName == null)
            {
                throw new ArgumentNullException(nameof(lockName));
            }
            if (lockName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(lockName));
            }

            using var scope = _managementLockClientDiagnostics.CreateScope("ManagementLockCollection.Exists");
            scope.Start();
            try
            {
                var response = _managementLockRestClient.GetByScope(Id, lockName, cancellationToken: cancellationToken);
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
        /// <description>/{scope}/providers/Microsoft.Authorization/locks/{lockName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementLocks_GetByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementLockResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="lockName"> The name of lock. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="lockName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="lockName"/> is null. </exception>
        public virtual async Task<NullableResponse<ManagementLockResource>> GetIfExistsAsync(string lockName, CancellationToken cancellationToken = default)
        {
            if (lockName == null)
            {
                throw new ArgumentNullException(nameof(lockName));
            }
            if (lockName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(lockName));
            }

            using var scope = _managementLockClientDiagnostics.CreateScope("ManagementLockCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managementLockRestClient.GetByScopeAsync(Id, lockName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ManagementLockResource>(response.GetRawResponse());
                return Response.FromValue(new ManagementLockResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{scope}/providers/Microsoft.Authorization/locks/{lockName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementLocks_GetByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementLockResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="lockName"> The name of lock. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="lockName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="lockName"/> is null. </exception>
        public virtual NullableResponse<ManagementLockResource> GetIfExists(string lockName, CancellationToken cancellationToken = default)
        {
            if (lockName == null)
            {
                throw new ArgumentNullException(nameof(lockName));
            }
            if (lockName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(lockName));
            }

            using var scope = _managementLockClientDiagnostics.CreateScope("ManagementLockCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managementLockRestClient.GetByScope(Id, lockName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ManagementLockResource>(response.GetRawResponse());
                return Response.FromValue(new ManagementLockResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagementLockResource> IEnumerable<ManagementLockResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagementLockResource> IAsyncEnumerable<ManagementLockResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
