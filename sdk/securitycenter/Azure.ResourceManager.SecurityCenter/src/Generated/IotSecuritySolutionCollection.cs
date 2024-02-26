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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="IotSecuritySolutionResource"/> and their operations.
    /// Each <see cref="IotSecuritySolutionResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="IotSecuritySolutionCollection"/> instance call the GetIotSecuritySolutions method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class IotSecuritySolutionCollection : ArmCollection, IEnumerable<IotSecuritySolutionResource>, IAsyncEnumerable<IotSecuritySolutionResource>
    {
        private readonly ClientDiagnostics _iotSecuritySolutionClientDiagnostics;
        private readonly IotSecuritySolutionRestOperations _iotSecuritySolutionRestClient;

        /// <summary> Initializes a new instance of the <see cref="IotSecuritySolutionCollection"/> class for mocking. </summary>
        protected IotSecuritySolutionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IotSecuritySolutionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IotSecuritySolutionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _iotSecuritySolutionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", IotSecuritySolutionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IotSecuritySolutionResource.ResourceType, out string iotSecuritySolutionApiVersion);
            _iotSecuritySolutionRestClient = new IotSecuritySolutionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, iotSecuritySolutionApiVersion);
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
        /// Use this method to create or update yours IoT Security solution
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotSecuritySolutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="solutionName"> The name of the IoT Security solution. </param>
        /// <param name="data"> The security solution data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="solutionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IotSecuritySolutionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string solutionName, IotSecuritySolutionData data, CancellationToken cancellationToken = default)
        {
            if (solutionName == null)
            {
                throw new ArgumentNullException(nameof(solutionName));
            }
            if (solutionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(solutionName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _iotSecuritySolutionClientDiagnostics.CreateScope("IotSecuritySolutionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _iotSecuritySolutionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, solutionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<IotSecuritySolutionResource>(Response.FromValue(new IotSecuritySolutionResource(Client, response), response.GetRawResponse()));
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
        /// Use this method to create or update yours IoT Security solution
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotSecuritySolutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="solutionName"> The name of the IoT Security solution. </param>
        /// <param name="data"> The security solution data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="solutionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IotSecuritySolutionResource> CreateOrUpdate(WaitUntil waitUntil, string solutionName, IotSecuritySolutionData data, CancellationToken cancellationToken = default)
        {
            if (solutionName == null)
            {
                throw new ArgumentNullException(nameof(solutionName));
            }
            if (solutionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(solutionName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _iotSecuritySolutionClientDiagnostics.CreateScope("IotSecuritySolutionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _iotSecuritySolutionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, solutionName, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<IotSecuritySolutionResource>(Response.FromValue(new IotSecuritySolutionResource(Client, response), response.GetRawResponse()));
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
        /// User this method to get details of a specific IoT Security solution based on solution name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotSecuritySolutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="solutionName"> The name of the IoT Security solution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="solutionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionName"/> is null. </exception>
        public virtual async Task<Response<IotSecuritySolutionResource>> GetAsync(string solutionName, CancellationToken cancellationToken = default)
        {
            if (solutionName == null)
            {
                throw new ArgumentNullException(nameof(solutionName));
            }
            if (solutionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(solutionName));
            }

            using var scope = _iotSecuritySolutionClientDiagnostics.CreateScope("IotSecuritySolutionCollection.Get");
            scope.Start();
            try
            {
                var response = await _iotSecuritySolutionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, solutionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotSecuritySolutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// User this method to get details of a specific IoT Security solution based on solution name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotSecuritySolutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="solutionName"> The name of the IoT Security solution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="solutionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionName"/> is null. </exception>
        public virtual Response<IotSecuritySolutionResource> Get(string solutionName, CancellationToken cancellationToken = default)
        {
            if (solutionName == null)
            {
                throw new ArgumentNullException(nameof(solutionName));
            }
            if (solutionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(solutionName));
            }

            using var scope = _iotSecuritySolutionClientDiagnostics.CreateScope("IotSecuritySolutionCollection.Get");
            scope.Start();
            try
            {
                var response = _iotSecuritySolutionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, solutionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotSecuritySolutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Use this method to get the list IoT Security solutions organized by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotSecuritySolutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filter the IoT Security solution with OData syntax. Supports filtering by iotHubs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IotSecuritySolutionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IotSecuritySolutionResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _iotSecuritySolutionRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _iotSecuritySolutionRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new IotSecuritySolutionResource(Client, IotSecuritySolutionData.DeserializeIotSecuritySolutionData(e)), _iotSecuritySolutionClientDiagnostics, Pipeline, "IotSecuritySolutionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Use this method to get the list IoT Security solutions organized by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotSecuritySolutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filter the IoT Security solution with OData syntax. Supports filtering by iotHubs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IotSecuritySolutionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IotSecuritySolutionResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _iotSecuritySolutionRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _iotSecuritySolutionRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new IotSecuritySolutionResource(Client, IotSecuritySolutionData.DeserializeIotSecuritySolutionData(e)), _iotSecuritySolutionClientDiagnostics, Pipeline, "IotSecuritySolutionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotSecuritySolutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="solutionName"> The name of the IoT Security solution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="solutionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string solutionName, CancellationToken cancellationToken = default)
        {
            if (solutionName == null)
            {
                throw new ArgumentNullException(nameof(solutionName));
            }
            if (solutionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(solutionName));
            }

            using var scope = _iotSecuritySolutionClientDiagnostics.CreateScope("IotSecuritySolutionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _iotSecuritySolutionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, solutionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotSecuritySolutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="solutionName"> The name of the IoT Security solution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="solutionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionName"/> is null. </exception>
        public virtual Response<bool> Exists(string solutionName, CancellationToken cancellationToken = default)
        {
            if (solutionName == null)
            {
                throw new ArgumentNullException(nameof(solutionName));
            }
            if (solutionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(solutionName));
            }

            using var scope = _iotSecuritySolutionClientDiagnostics.CreateScope("IotSecuritySolutionCollection.Exists");
            scope.Start();
            try
            {
                var response = _iotSecuritySolutionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, solutionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotSecuritySolutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="solutionName"> The name of the IoT Security solution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="solutionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionName"/> is null. </exception>
        public virtual async Task<NullableResponse<IotSecuritySolutionResource>> GetIfExistsAsync(string solutionName, CancellationToken cancellationToken = default)
        {
            if (solutionName == null)
            {
                throw new ArgumentNullException(nameof(solutionName));
            }
            if (solutionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(solutionName));
            }

            using var scope = _iotSecuritySolutionClientDiagnostics.CreateScope("IotSecuritySolutionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _iotSecuritySolutionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, solutionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<IotSecuritySolutionResource>(response.GetRawResponse());
                return Response.FromValue(new IotSecuritySolutionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolution_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotSecuritySolutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="solutionName"> The name of the IoT Security solution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="solutionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="solutionName"/> is null. </exception>
        public virtual NullableResponse<IotSecuritySolutionResource> GetIfExists(string solutionName, CancellationToken cancellationToken = default)
        {
            if (solutionName == null)
            {
                throw new ArgumentNullException(nameof(solutionName));
            }
            if (solutionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(solutionName));
            }

            using var scope = _iotSecuritySolutionClientDiagnostics.CreateScope("IotSecuritySolutionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _iotSecuritySolutionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, solutionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<IotSecuritySolutionResource>(response.GetRawResponse());
                return Response.FromValue(new IotSecuritySolutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IotSecuritySolutionResource> IEnumerable<IotSecuritySolutionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IotSecuritySolutionResource> IAsyncEnumerable<IotSecuritySolutionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
