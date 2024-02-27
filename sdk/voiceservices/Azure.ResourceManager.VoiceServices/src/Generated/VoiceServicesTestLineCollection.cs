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

namespace Azure.ResourceManager.VoiceServices
{
    /// <summary>
    /// A class representing a collection of <see cref="VoiceServicesTestLineResource"/> and their operations.
    /// Each <see cref="VoiceServicesTestLineResource"/> in the collection will belong to the same instance of <see cref="VoiceServicesCommunicationsGatewayResource"/>.
    /// To get a <see cref="VoiceServicesTestLineCollection"/> instance call the GetVoiceServicesTestLines method from an instance of <see cref="VoiceServicesCommunicationsGatewayResource"/>.
    /// </summary>
    public partial class VoiceServicesTestLineCollection : ArmCollection, IEnumerable<VoiceServicesTestLineResource>, IAsyncEnumerable<VoiceServicesTestLineResource>
    {
        private readonly ClientDiagnostics _voiceServicesTestLineTestLinesClientDiagnostics;
        private readonly TestLinesRestOperations _voiceServicesTestLineTestLinesRestClient;

        /// <summary> Initializes a new instance of the <see cref="VoiceServicesTestLineCollection"/> class for mocking. </summary>
        protected VoiceServicesTestLineCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VoiceServicesTestLineCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VoiceServicesTestLineCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _voiceServicesTestLineTestLinesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.VoiceServices", VoiceServicesTestLineResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VoiceServicesTestLineResource.ResourceType, out string voiceServicesTestLineTestLinesApiVersion);
            _voiceServicesTestLineTestLinesRestClient = new TestLinesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, voiceServicesTestLineTestLinesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VoiceServicesCommunicationsGatewayResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VoiceServicesCommunicationsGatewayResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a TestLine
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}/testLines/{testLineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TestLines_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VoiceServicesTestLineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="testLineName"> Unique identifier for this test line. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="testLineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="testLineName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VoiceServicesTestLineResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string testLineName, VoiceServicesTestLineData data, CancellationToken cancellationToken = default)
        {
            if (testLineName == null)
            {
                throw new ArgumentNullException(nameof(testLineName));
            }
            if (testLineName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(testLineName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _voiceServicesTestLineTestLinesClientDiagnostics.CreateScope("VoiceServicesTestLineCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _voiceServicesTestLineTestLinesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, testLineName, data, cancellationToken).ConfigureAwait(false);
                var operation = new VoiceServicesArmOperation<VoiceServicesTestLineResource>(new VoiceServicesTestLineOperationSource(Client), _voiceServicesTestLineTestLinesClientDiagnostics, Pipeline, _voiceServicesTestLineTestLinesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, testLineName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a TestLine
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}/testLines/{testLineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TestLines_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VoiceServicesTestLineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="testLineName"> Unique identifier for this test line. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="testLineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="testLineName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VoiceServicesTestLineResource> CreateOrUpdate(WaitUntil waitUntil, string testLineName, VoiceServicesTestLineData data, CancellationToken cancellationToken = default)
        {
            if (testLineName == null)
            {
                throw new ArgumentNullException(nameof(testLineName));
            }
            if (testLineName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(testLineName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _voiceServicesTestLineTestLinesClientDiagnostics.CreateScope("VoiceServicesTestLineCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _voiceServicesTestLineTestLinesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, testLineName, data, cancellationToken);
                var operation = new VoiceServicesArmOperation<VoiceServicesTestLineResource>(new VoiceServicesTestLineOperationSource(Client), _voiceServicesTestLineTestLinesClientDiagnostics, Pipeline, _voiceServicesTestLineTestLinesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, testLineName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a TestLine
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}/testLines/{testLineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TestLines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VoiceServicesTestLineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="testLineName"> Unique identifier for this test line. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="testLineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="testLineName"/> is null. </exception>
        public virtual async Task<Response<VoiceServicesTestLineResource>> GetAsync(string testLineName, CancellationToken cancellationToken = default)
        {
            if (testLineName == null)
            {
                throw new ArgumentNullException(nameof(testLineName));
            }
            if (testLineName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(testLineName));
            }

            using var scope = _voiceServicesTestLineTestLinesClientDiagnostics.CreateScope("VoiceServicesTestLineCollection.Get");
            scope.Start();
            try
            {
                var response = await _voiceServicesTestLineTestLinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, testLineName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VoiceServicesTestLineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a TestLine
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}/testLines/{testLineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TestLines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VoiceServicesTestLineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="testLineName"> Unique identifier for this test line. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="testLineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="testLineName"/> is null. </exception>
        public virtual Response<VoiceServicesTestLineResource> Get(string testLineName, CancellationToken cancellationToken = default)
        {
            if (testLineName == null)
            {
                throw new ArgumentNullException(nameof(testLineName));
            }
            if (testLineName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(testLineName));
            }

            using var scope = _voiceServicesTestLineTestLinesClientDiagnostics.CreateScope("VoiceServicesTestLineCollection.Get");
            scope.Start();
            try
            {
                var response = _voiceServicesTestLineTestLinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, testLineName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VoiceServicesTestLineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List TestLine resources by CommunicationsGateway
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}/testLines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TestLines_ListByCommunicationsGateway</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VoiceServicesTestLineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VoiceServicesTestLineResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VoiceServicesTestLineResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _voiceServicesTestLineTestLinesRestClient.CreateListByCommunicationsGatewayRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _voiceServicesTestLineTestLinesRestClient.CreateListByCommunicationsGatewayNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VoiceServicesTestLineResource(Client, VoiceServicesTestLineData.DeserializeVoiceServicesTestLineData(e)), _voiceServicesTestLineTestLinesClientDiagnostics, Pipeline, "VoiceServicesTestLineCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List TestLine resources by CommunicationsGateway
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}/testLines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TestLines_ListByCommunicationsGateway</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VoiceServicesTestLineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VoiceServicesTestLineResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VoiceServicesTestLineResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _voiceServicesTestLineTestLinesRestClient.CreateListByCommunicationsGatewayRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _voiceServicesTestLineTestLinesRestClient.CreateListByCommunicationsGatewayNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VoiceServicesTestLineResource(Client, VoiceServicesTestLineData.DeserializeVoiceServicesTestLineData(e)), _voiceServicesTestLineTestLinesClientDiagnostics, Pipeline, "VoiceServicesTestLineCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}/testLines/{testLineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TestLines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VoiceServicesTestLineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="testLineName"> Unique identifier for this test line. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="testLineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="testLineName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string testLineName, CancellationToken cancellationToken = default)
        {
            if (testLineName == null)
            {
                throw new ArgumentNullException(nameof(testLineName));
            }
            if (testLineName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(testLineName));
            }

            using var scope = _voiceServicesTestLineTestLinesClientDiagnostics.CreateScope("VoiceServicesTestLineCollection.Exists");
            scope.Start();
            try
            {
                var response = await _voiceServicesTestLineTestLinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, testLineName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}/testLines/{testLineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TestLines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VoiceServicesTestLineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="testLineName"> Unique identifier for this test line. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="testLineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="testLineName"/> is null. </exception>
        public virtual Response<bool> Exists(string testLineName, CancellationToken cancellationToken = default)
        {
            if (testLineName == null)
            {
                throw new ArgumentNullException(nameof(testLineName));
            }
            if (testLineName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(testLineName));
            }

            using var scope = _voiceServicesTestLineTestLinesClientDiagnostics.CreateScope("VoiceServicesTestLineCollection.Exists");
            scope.Start();
            try
            {
                var response = _voiceServicesTestLineTestLinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, testLineName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}/testLines/{testLineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TestLines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VoiceServicesTestLineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="testLineName"> Unique identifier for this test line. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="testLineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="testLineName"/> is null. </exception>
        public virtual async Task<NullableResponse<VoiceServicesTestLineResource>> GetIfExistsAsync(string testLineName, CancellationToken cancellationToken = default)
        {
            if (testLineName == null)
            {
                throw new ArgumentNullException(nameof(testLineName));
            }
            if (testLineName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(testLineName));
            }

            using var scope = _voiceServicesTestLineTestLinesClientDiagnostics.CreateScope("VoiceServicesTestLineCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _voiceServicesTestLineTestLinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, testLineName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VoiceServicesTestLineResource>(response.GetRawResponse());
                return Response.FromValue(new VoiceServicesTestLineResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}/testLines/{testLineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TestLines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VoiceServicesTestLineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="testLineName"> Unique identifier for this test line. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="testLineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="testLineName"/> is null. </exception>
        public virtual NullableResponse<VoiceServicesTestLineResource> GetIfExists(string testLineName, CancellationToken cancellationToken = default)
        {
            if (testLineName == null)
            {
                throw new ArgumentNullException(nameof(testLineName));
            }
            if (testLineName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(testLineName));
            }

            using var scope = _voiceServicesTestLineTestLinesClientDiagnostics.CreateScope("VoiceServicesTestLineCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _voiceServicesTestLineTestLinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, testLineName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VoiceServicesTestLineResource>(response.GetRawResponse());
                return Response.FromValue(new VoiceServicesTestLineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VoiceServicesTestLineResource> IEnumerable<VoiceServicesTestLineResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VoiceServicesTestLineResource> IAsyncEnumerable<VoiceServicesTestLineResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
