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
using Azure.ResourceManager.Dns;
using Azure.ResourceManager.Dns.Models;

namespace Azure.ResourceManager.Dns.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableDnsSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _dnsZoneZonesClientDiagnostics;
        private ZonesRestOperations _dnsZoneZonesRestClient;
        private ClientDiagnostics _dnsResourceReferenceClientDiagnostics;
        private DnsResourceReferenceRestOperations _dnsResourceReferenceRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableDnsSubscriptionResource"/> class for mocking. </summary>
        protected MockableDnsSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDnsSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDnsSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DnsZoneZonesClientDiagnostics => _dnsZoneZonesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Dns", DnsZoneResource.ResourceType.Namespace, Diagnostics);
        private ZonesRestOperations DnsZoneZonesRestClient => _dnsZoneZonesRestClient ??= new ZonesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DnsZoneResource.ResourceType));
        private ClientDiagnostics DnsResourceReferenceClientDiagnostics => _dnsResourceReferenceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Dns", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private DnsResourceReferenceRestOperations DnsResourceReferenceRestClient => _dnsResourceReferenceRestClient ??= new DnsResourceReferenceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists the DNS zones in all resource groups in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/dnszones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Zones_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsZoneResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of DNS zones to return. If not specified, returns up to 100 zones. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DnsZoneResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DnsZoneResource> GetDnsZonesAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DnsZoneZonesRestClient.CreateListRequest(Id.SubscriptionId, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DnsZoneZonesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DnsZoneResource(Client, DnsZoneData.DeserializeDnsZoneData(e)), DnsZoneZonesClientDiagnostics, Pipeline, "MockableDnsSubscriptionResource.GetDnsZones", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the DNS zones in all resource groups in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/dnszones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Zones_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsZoneResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of DNS zones to return. If not specified, returns up to 100 zones. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DnsZoneResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DnsZoneResource> GetDnsZones(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DnsZoneZonesRestClient.CreateListRequest(Id.SubscriptionId, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DnsZoneZonesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DnsZoneResource(Client, DnsZoneData.DeserializeDnsZoneData(e)), DnsZoneZonesClientDiagnostics, Pipeline, "MockableDnsSubscriptionResource.GetDnsZones", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns the DNS records specified by the referencing targetResourceIds.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/getDnsResourceReference</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsResourceReference_GetByTargetResources</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Properties for dns resource reference request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<DnsResourceReferenceResult>> GetDnsResourceReferencesByTargetResourcesAsync(DnsResourceReferenceContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = DnsResourceReferenceClientDiagnostics.CreateScope("MockableDnsSubscriptionResource.GetDnsResourceReferencesByTargetResources");
            scope.Start();
            try
            {
                var response = await DnsResourceReferenceRestClient.GetByTargetResourcesAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the DNS records specified by the referencing targetResourceIds.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/getDnsResourceReference</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsResourceReference_GetByTargetResources</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-05-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Properties for dns resource reference request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<DnsResourceReferenceResult> GetDnsResourceReferencesByTargetResources(DnsResourceReferenceContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = DnsResourceReferenceClientDiagnostics.CreateScope("MockableDnsSubscriptionResource.GetDnsResourceReferencesByTargetResources");
            scope.Start();
            try
            {
                var response = DnsResourceReferenceRestClient.GetByTargetResources(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
