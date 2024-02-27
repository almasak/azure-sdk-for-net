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

namespace Azure.ResourceManager.KubernetesConfiguration
{
    /// <summary>
    /// A class representing a collection of <see cref="KubernetesClusterExtensionResource"/> and their operations.
    /// Each <see cref="KubernetesClusterExtensionResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="KubernetesClusterExtensionCollection"/> instance call the GetKubernetesClusterExtensions method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class KubernetesClusterExtensionCollection : ArmCollection, IEnumerable<KubernetesClusterExtensionResource>, IAsyncEnumerable<KubernetesClusterExtensionResource>
    {
        private readonly ClientDiagnostics _kubernetesClusterExtensionExtensionsClientDiagnostics;
        private readonly ExtensionsRestOperations _kubernetesClusterExtensionExtensionsRestClient;
        private readonly string _clusterRp;
        private readonly string _clusterResourceName;
        private readonly string _clusterName;

        /// <summary> Initializes a new instance of the <see cref="KubernetesClusterExtensionCollection"/> class for mocking. </summary>
        protected KubernetesClusterExtensionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="KubernetesClusterExtensionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="clusterRp"> The Kubernetes cluster RP - i.e. Microsoft.ContainerService, Microsoft.Kubernetes, Microsoft.HybridContainerService. </param>
        /// <param name="clusterResourceName"> The Kubernetes cluster resource name - i.e. managedClusters, connectedClusters, provisionedClusters. </param>
        /// <param name="clusterName"> The name of the kubernetes cluster. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/> or <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        internal KubernetesClusterExtensionCollection(ArmClient client, ResourceIdentifier id, string clusterRp, string clusterResourceName, string clusterName) : base(client, id)
        {
            _clusterRp = clusterRp;
            _clusterResourceName = clusterResourceName;
            _clusterName = clusterName;
            _kubernetesClusterExtensionExtensionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.KubernetesConfiguration", KubernetesClusterExtensionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(KubernetesClusterExtensionResource.ResourceType, out string kubernetesClusterExtensionExtensionsApiVersion);
            _kubernetesClusterExtensionExtensionsRestClient = new ExtensionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, kubernetesClusterExtensionExtensionsApiVersion);
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
        /// Create a new Kubernetes Cluster Extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Extensions_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesClusterExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="extensionName"> Name of the Extension. </param>
        /// <param name="data"> Properties necessary to Create an Extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<KubernetesClusterExtensionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string extensionName, KubernetesClusterExtensionData data, CancellationToken cancellationToken = default)
        {
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }
            if (extensionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(extensionName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _kubernetesClusterExtensionExtensionsClientDiagnostics.CreateScope("KubernetesClusterExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _kubernetesClusterExtensionExtensionsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, extensionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new KubernetesConfigurationArmOperation<KubernetesClusterExtensionResource>(new KubernetesClusterExtensionOperationSource(Client), _kubernetesClusterExtensionExtensionsClientDiagnostics, Pipeline, _kubernetesClusterExtensionExtensionsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, extensionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a new Kubernetes Cluster Extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Extensions_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesClusterExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="extensionName"> Name of the Extension. </param>
        /// <param name="data"> Properties necessary to Create an Extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<KubernetesClusterExtensionResource> CreateOrUpdate(WaitUntil waitUntil, string extensionName, KubernetesClusterExtensionData data, CancellationToken cancellationToken = default)
        {
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }
            if (extensionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(extensionName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _kubernetesClusterExtensionExtensionsClientDiagnostics.CreateScope("KubernetesClusterExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _kubernetesClusterExtensionExtensionsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, extensionName, data, cancellationToken);
                var operation = new KubernetesConfigurationArmOperation<KubernetesClusterExtensionResource>(new KubernetesClusterExtensionOperationSource(Client), _kubernetesClusterExtensionExtensionsClientDiagnostics, Pipeline, _kubernetesClusterExtensionExtensionsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, extensionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets Kubernetes Cluster Extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Extensions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesClusterExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="extensionName"> Name of the Extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual async Task<Response<KubernetesClusterExtensionResource>> GetAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }
            if (extensionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(extensionName));
            }

            using var scope = _kubernetesClusterExtensionExtensionsClientDiagnostics.CreateScope("KubernetesClusterExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = await _kubernetesClusterExtensionExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, extensionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KubernetesClusterExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets Kubernetes Cluster Extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Extensions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesClusterExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="extensionName"> Name of the Extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual Response<KubernetesClusterExtensionResource> Get(string extensionName, CancellationToken cancellationToken = default)
        {
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }
            if (extensionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(extensionName));
            }

            using var scope = _kubernetesClusterExtensionExtensionsClientDiagnostics.CreateScope("KubernetesClusterExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = _kubernetesClusterExtensionExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, extensionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KubernetesClusterExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all Extensions in the cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/extensions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Extensions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesClusterExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KubernetesClusterExtensionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<KubernetesClusterExtensionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _kubernetesClusterExtensionExtensionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _kubernetesClusterExtensionExtensionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new KubernetesClusterExtensionResource(Client, KubernetesClusterExtensionData.DeserializeKubernetesClusterExtensionData(e)), _kubernetesClusterExtensionExtensionsClientDiagnostics, Pipeline, "KubernetesClusterExtensionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all Extensions in the cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/extensions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Extensions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesClusterExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KubernetesClusterExtensionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<KubernetesClusterExtensionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _kubernetesClusterExtensionExtensionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _kubernetesClusterExtensionExtensionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new KubernetesClusterExtensionResource(Client, KubernetesClusterExtensionData.DeserializeKubernetesClusterExtensionData(e)), _kubernetesClusterExtensionExtensionsClientDiagnostics, Pipeline, "KubernetesClusterExtensionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Extensions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesClusterExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="extensionName"> Name of the Extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }
            if (extensionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(extensionName));
            }

            using var scope = _kubernetesClusterExtensionExtensionsClientDiagnostics.CreateScope("KubernetesClusterExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _kubernetesClusterExtensionExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, extensionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Extensions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesClusterExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="extensionName"> Name of the Extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual Response<bool> Exists(string extensionName, CancellationToken cancellationToken = default)
        {
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }
            if (extensionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(extensionName));
            }

            using var scope = _kubernetesClusterExtensionExtensionsClientDiagnostics.CreateScope("KubernetesClusterExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = _kubernetesClusterExtensionExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, extensionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Extensions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesClusterExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="extensionName"> Name of the Extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual async Task<NullableResponse<KubernetesClusterExtensionResource>> GetIfExistsAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }
            if (extensionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(extensionName));
            }

            using var scope = _kubernetesClusterExtensionExtensionsClientDiagnostics.CreateScope("KubernetesClusterExtensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _kubernetesClusterExtensionExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, extensionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<KubernetesClusterExtensionResource>(response.GetRawResponse());
                return Response.FromValue(new KubernetesClusterExtensionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Extensions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesClusterExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="extensionName"> Name of the Extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual NullableResponse<KubernetesClusterExtensionResource> GetIfExists(string extensionName, CancellationToken cancellationToken = default)
        {
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }
            if (extensionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(extensionName));
            }

            using var scope = _kubernetesClusterExtensionExtensionsClientDiagnostics.CreateScope("KubernetesClusterExtensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _kubernetesClusterExtensionExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _clusterRp, _clusterResourceName, _clusterName, extensionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<KubernetesClusterExtensionResource>(response.GetRawResponse());
                return Response.FromValue(new KubernetesClusterExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<KubernetesClusterExtensionResource> IEnumerable<KubernetesClusterExtensionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<KubernetesClusterExtensionResource> IAsyncEnumerable<KubernetesClusterExtensionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
