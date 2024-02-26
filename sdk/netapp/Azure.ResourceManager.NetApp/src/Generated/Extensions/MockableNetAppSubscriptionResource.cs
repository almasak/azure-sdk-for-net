// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.NetApp;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableNetAppSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _netAppResourceClientDiagnostics;
        private NetAppResourceRestOperations _netAppResourceRestClient;
        private ClientDiagnostics _netAppResourceQuotaLimitsClientDiagnostics;
        private NetAppResourceQuotaLimitsRestOperations _netAppResourceQuotaLimitsRestClient;
        private ClientDiagnostics _netAppAccountAccountsClientDiagnostics;
        private AccountsRestOperations _netAppAccountAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableNetAppSubscriptionResource"/> class for mocking. </summary>
        protected MockableNetAppSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableNetAppSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableNetAppSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics NetAppResourceClientDiagnostics => _netAppResourceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.NetApp", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private NetAppResourceRestOperations NetAppResourceRestClient => _netAppResourceRestClient ??= new NetAppResourceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics NetAppResourceQuotaLimitsClientDiagnostics => _netAppResourceQuotaLimitsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.NetApp", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private NetAppResourceQuotaLimitsRestOperations NetAppResourceQuotaLimitsRestClient => _netAppResourceQuotaLimitsRestClient ??= new NetAppResourceQuotaLimitsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics NetAppAccountAccountsClientDiagnostics => _netAppAccountAccountsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.NetApp", NetAppAccountResource.ResourceType.Namespace, Diagnostics);
        private AccountsRestOperations NetAppAccountAccountsRestClient => _netAppAccountAccountsRestClient ??= new AccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(NetAppAccountResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Check if a resource name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResource_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> Name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<NetAppCheckAvailabilityResult>> CheckNetAppNameAvailabilityAsync(AzureLocation location, NetAppNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = NetAppResourceClientDiagnostics.CreateScope("MockableNetAppSubscriptionResource.CheckNetAppNameAvailability");
            scope.Start();
            try
            {
                var response = await NetAppResourceRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if a resource name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResource_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> Name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<NetAppCheckAvailabilityResult> CheckNetAppNameAvailability(AzureLocation location, NetAppNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = NetAppResourceClientDiagnostics.CreateScope("MockableNetAppSubscriptionResource.CheckNetAppNameAvailability");
            scope.Start();
            try
            {
                var response = NetAppResourceRestClient.CheckNameAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if a file path is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkFilePathAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResource_CheckFilePathAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> File path availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<NetAppCheckAvailabilityResult>> CheckNetAppFilePathAvailabilityAsync(AzureLocation location, NetAppFilePathAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = NetAppResourceClientDiagnostics.CreateScope("MockableNetAppSubscriptionResource.CheckNetAppFilePathAvailability");
            scope.Start();
            try
            {
                var response = await NetAppResourceRestClient.CheckFilePathAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if a file path is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkFilePathAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResource_CheckFilePathAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> File path availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<NetAppCheckAvailabilityResult> CheckNetAppFilePathAvailability(AzureLocation location, NetAppFilePathAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = NetAppResourceClientDiagnostics.CreateScope("MockableNetAppSubscriptionResource.CheckNetAppFilePathAvailability");
            scope.Start();
            try
            {
                var response = NetAppResourceRestClient.CheckFilePathAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if a quota is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkQuotaAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResource_CheckQuotaAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> Quota availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<NetAppCheckAvailabilityResult>> CheckNetAppQuotaAvailabilityAsync(AzureLocation location, NetAppQuotaAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = NetAppResourceClientDiagnostics.CreateScope("MockableNetAppSubscriptionResource.CheckNetAppQuotaAvailability");
            scope.Start();
            try
            {
                var response = await NetAppResourceRestClient.CheckQuotaAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if a quota is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/checkQuotaAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResource_CheckQuotaAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> Quota availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<NetAppCheckAvailabilityResult> CheckNetAppQuotaAvailability(AzureLocation location, NetAppQuotaAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = NetAppResourceClientDiagnostics.CreateScope("MockableNetAppSubscriptionResource.CheckNetAppQuotaAvailability");
            scope.Start();
            try
            {
                var response = NetAppResourceRestClient.CheckQuotaAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Provides storage to network proximity and logical zone mapping information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/regionInfo</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResource_QueryRegionInfo</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetAppRegionInfo>> QueryRegionInfoNetAppResourceAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = NetAppResourceClientDiagnostics.CreateScope("MockableNetAppSubscriptionResource.QueryRegionInfoNetAppResource");
            scope.Start();
            try
            {
                var response = await NetAppResourceRestClient.QueryRegionInfoAsync(Id.SubscriptionId, location, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Provides storage to network proximity and logical zone mapping information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/regionInfo</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResource_QueryRegionInfo</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetAppRegionInfo> QueryRegionInfoNetAppResource(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = NetAppResourceClientDiagnostics.CreateScope("MockableNetAppSubscriptionResource.QueryRegionInfoNetAppResource");
            scope.Start();
            try
            {
                var response = NetAppResourceRestClient.QueryRegionInfo(Id.SubscriptionId, location, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get details of the specified network sibling set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/queryNetworkSiblingSet</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResource_QueryNetworkSiblingSet</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> Network sibling set to query. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<NetworkSiblingSet>> QueryNetworkSiblingSetNetAppResourceAsync(AzureLocation location, QueryNetworkSiblingSetContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = NetAppResourceClientDiagnostics.CreateScope("MockableNetAppSubscriptionResource.QueryNetworkSiblingSetNetAppResource");
            scope.Start();
            try
            {
                var response = await NetAppResourceRestClient.QueryNetworkSiblingSetAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get details of the specified network sibling set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/queryNetworkSiblingSet</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResource_QueryNetworkSiblingSet</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> Network sibling set to query. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<NetworkSiblingSet> QueryNetworkSiblingSetNetAppResource(AzureLocation location, QueryNetworkSiblingSetContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = NetAppResourceClientDiagnostics.CreateScope("MockableNetAppSubscriptionResource.QueryNetworkSiblingSetNetAppResource");
            scope.Start();
            try
            {
                var response = NetAppResourceRestClient.QueryNetworkSiblingSet(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the network features of the specified network sibling set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/updateNetworkSiblingSet</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResource_UpdateNetworkSiblingSet</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> Update for the specified network sibling set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkSiblingSet>> UpdateNetworkSiblingSetNetAppResourceAsync(WaitUntil waitUntil, AzureLocation location, UpdateNetworkSiblingSetContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = NetAppResourceClientDiagnostics.CreateScope("MockableNetAppSubscriptionResource.UpdateNetworkSiblingSetNetAppResource");
            scope.Start();
            try
            {
                var response = await NetAppResourceRestClient.UpdateNetworkSiblingSetAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                var operation = new NetAppArmOperation<NetworkSiblingSet>(new NetworkSiblingSetOperationSource(), NetAppResourceClientDiagnostics, Pipeline, NetAppResourceRestClient.CreateUpdateNetworkSiblingSetRequest(Id.SubscriptionId, location, content).Request, response, OperationFinalStateVia.Location);
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
        /// Update the network features of the specified network sibling set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/updateNetworkSiblingSet</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResource_UpdateNetworkSiblingSet</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> Update for the specified network sibling set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<NetworkSiblingSet> UpdateNetworkSiblingSetNetAppResource(WaitUntil waitUntil, AzureLocation location, UpdateNetworkSiblingSetContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = NetAppResourceClientDiagnostics.CreateScope("MockableNetAppSubscriptionResource.UpdateNetworkSiblingSetNetAppResource");
            scope.Start();
            try
            {
                var response = NetAppResourceRestClient.UpdateNetworkSiblingSet(Id.SubscriptionId, location, content, cancellationToken);
                var operation = new NetAppArmOperation<NetworkSiblingSet>(new NetworkSiblingSetOperationSource(), NetAppResourceClientDiagnostics, Pipeline, NetAppResourceRestClient.CreateUpdateNetworkSiblingSetRequest(Id.SubscriptionId, location, content).Request, response, OperationFinalStateVia.Location);
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
        /// Get the default and current limits for quotas
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/quotaLimits</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResourceQuotaLimits_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetAppSubscriptionQuotaItem"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetAppSubscriptionQuotaItem> GetNetAppQuotaLimitsAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => NetAppResourceQuotaLimitsRestClient.CreateListRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => NetAppSubscriptionQuotaItem.DeserializeNetAppSubscriptionQuotaItem(e), NetAppResourceQuotaLimitsClientDiagnostics, Pipeline, "MockableNetAppSubscriptionResource.GetNetAppQuotaLimits", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get the default and current limits for quotas
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/quotaLimits</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResourceQuotaLimits_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetAppSubscriptionQuotaItem"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetAppSubscriptionQuotaItem> GetNetAppQuotaLimits(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => NetAppResourceQuotaLimitsRestClient.CreateListRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => NetAppSubscriptionQuotaItem.DeserializeNetAppSubscriptionQuotaItem(e), NetAppResourceQuotaLimitsClientDiagnostics, Pipeline, "MockableNetAppSubscriptionResource.GetNetAppQuotaLimits", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get the default and current subscription quota limit
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/quotaLimits/{quotaLimitName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResourceQuotaLimits_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="quotaLimitName"> The name of the Quota Limit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="quotaLimitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="quotaLimitName"/> is null. </exception>
        public virtual async Task<Response<NetAppSubscriptionQuotaItem>> GetNetAppQuotaLimitAsync(AzureLocation location, string quotaLimitName, CancellationToken cancellationToken = default)
        {
            if (quotaLimitName == null)
            {
                throw new ArgumentNullException(nameof(quotaLimitName));
            }
            if (quotaLimitName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(quotaLimitName));
            }

            using var scope = NetAppResourceQuotaLimitsClientDiagnostics.CreateScope("MockableNetAppSubscriptionResource.GetNetAppQuotaLimit");
            scope.Start();
            try
            {
                var response = await NetAppResourceQuotaLimitsRestClient.GetAsync(Id.SubscriptionId, location, quotaLimitName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the default and current subscription quota limit
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/quotaLimits/{quotaLimitName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResourceQuotaLimits_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="quotaLimitName"> The name of the Quota Limit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="quotaLimitName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="quotaLimitName"/> is null. </exception>
        public virtual Response<NetAppSubscriptionQuotaItem> GetNetAppQuotaLimit(AzureLocation location, string quotaLimitName, CancellationToken cancellationToken = default)
        {
            if (quotaLimitName == null)
            {
                throw new ArgumentNullException(nameof(quotaLimitName));
            }
            if (quotaLimitName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(quotaLimitName));
            }

            using var scope = NetAppResourceQuotaLimitsClientDiagnostics.CreateScope("MockableNetAppSubscriptionResource.GetNetAppQuotaLimit");
            scope.Start();
            try
            {
                var response = NetAppResourceQuotaLimitsRestClient.Get(Id.SubscriptionId, location, quotaLimitName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List and describe all NetApp accounts in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/netAppAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetAppAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetAppAccountResource> GetNetAppAccountsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => NetAppAccountAccountsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => NetAppAccountAccountsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetAppAccountResource(Client, NetAppAccountData.DeserializeNetAppAccountData(e)), NetAppAccountAccountsClientDiagnostics, Pipeline, "MockableNetAppSubscriptionResource.GetNetAppAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List and describe all NetApp accounts in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/netAppAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetAppAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetAppAccountResource> GetNetAppAccounts(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => NetAppAccountAccountsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => NetAppAccountAccountsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetAppAccountResource(Client, NetAppAccountData.DeserializeNetAppAccountData(e)), NetAppAccountAccountsClientDiagnostics, Pipeline, "MockableNetAppSubscriptionResource.GetNetAppAccounts", "value", "nextLink", cancellationToken);
        }
    }
}
