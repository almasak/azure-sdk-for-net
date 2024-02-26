// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing the NetworkCloudCloudServicesNetwork data model.
    /// Upon creation, the additional services that are provided by the platform will be allocated and
    /// represented in the status of this resource. All resources associated with this cloud services network will be part
    /// of the same layer 2 (L2) isolation domain. At least one service network must be created but may be reused across many
    /// virtual machines and/or Hybrid AKS clusters.
    /// </summary>
    public partial class NetworkCloudCloudServicesNetworkData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkCloudCloudServicesNetworkData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location of the cluster associated with the resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extendedLocation"/> is null. </exception>
        public NetworkCloudCloudServicesNetworkData(AzureLocation location, ExtendedLocation extendedLocation) : base(location)
        {
            if (extendedLocation == null)
            {
                throw new ArgumentNullException(nameof(extendedLocation));
            }

            ExtendedLocation = extendedLocation;
            AdditionalEgressEndpoints = new ChangeTrackingList<EgressEndpoint>();
            AssociatedResourceIds = new ChangeTrackingList<ResourceIdentifier>();
            EnabledEgressEndpoints = new ChangeTrackingList<EgressEndpoint>();
            HybridAksClustersAssociatedIds = new ChangeTrackingList<ResourceIdentifier>();
            VirtualMachinesAssociatedIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudCloudServicesNetworkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location of the cluster associated with the resource. </param>
        /// <param name="additionalEgressEndpoints"> The list of egress endpoints. This allows for connection from a Hybrid AKS cluster to the specified endpoint. </param>
        /// <param name="associatedResourceIds"> The list of resource IDs for the other Microsoft.NetworkCloud resources that have attached this network. </param>
        /// <param name="clusterId"> The resource ID of the Network Cloud cluster this cloud services network is associated with. </param>
        /// <param name="detailedStatus"> The more detailed status of the cloud services network. </param>
        /// <param name="detailedStatusMessage"> The descriptive message about the current detailed status. </param>
        /// <param name="enableDefaultEgressEndpoints"> The indicator of whether the platform default endpoints are allowed for the egress traffic. </param>
        /// <param name="enabledEgressEndpoints"> The full list of additional and default egress endpoints that are currently enabled. </param>
        /// <param name="hybridAksClustersAssociatedIds"> Field Deprecated. These fields will be empty/omitted. The list of Hybrid AKS cluster resource IDs that are associated with this cloud services network. </param>
        /// <param name="interfaceName"> The name of the interface that will be present in the virtual machine to represent this network. </param>
        /// <param name="provisioningState"> The provisioning state of the cloud services network. </param>
        /// <param name="virtualMachinesAssociatedIds"> Field Deprecated. These fields will be empty/omitted. The list of virtual machine resource IDs, excluding any Hybrid AKS virtual machines, that are currently using this cloud services network. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkCloudCloudServicesNetworkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, IList<EgressEndpoint> additionalEgressEndpoints, IReadOnlyList<ResourceIdentifier> associatedResourceIds, ResourceIdentifier clusterId, CloudServicesNetworkDetailedStatus? detailedStatus, string detailedStatusMessage, CloudServicesNetworkEnableDefaultEgressEndpoint? enableDefaultEgressEndpoints, IReadOnlyList<EgressEndpoint> enabledEgressEndpoints, IReadOnlyList<ResourceIdentifier> hybridAksClustersAssociatedIds, string interfaceName, CloudServicesNetworkProvisioningState? provisioningState, IReadOnlyList<ResourceIdentifier> virtualMachinesAssociatedIds, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            AdditionalEgressEndpoints = additionalEgressEndpoints;
            AssociatedResourceIds = associatedResourceIds;
            ClusterId = clusterId;
            DetailedStatus = detailedStatus;
            DetailedStatusMessage = detailedStatusMessage;
            EnableDefaultEgressEndpoints = enableDefaultEgressEndpoints;
            EnabledEgressEndpoints = enabledEgressEndpoints;
            HybridAksClustersAssociatedIds = hybridAksClustersAssociatedIds;
            InterfaceName = interfaceName;
            ProvisioningState = provisioningState;
            VirtualMachinesAssociatedIds = virtualMachinesAssociatedIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudCloudServicesNetworkData"/> for deserialization. </summary>
        internal NetworkCloudCloudServicesNetworkData()
        {
        }

        /// <summary> The extended location of the cluster associated with the resource. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> The list of egress endpoints. This allows for connection from a Hybrid AKS cluster to the specified endpoint. </summary>
        public IList<EgressEndpoint> AdditionalEgressEndpoints { get; }
        /// <summary> The list of resource IDs for the other Microsoft.NetworkCloud resources that have attached this network. </summary>
        public IReadOnlyList<ResourceIdentifier> AssociatedResourceIds { get; }
        /// <summary> The resource ID of the Network Cloud cluster this cloud services network is associated with. </summary>
        public ResourceIdentifier ClusterId { get; }
        /// <summary> The more detailed status of the cloud services network. </summary>
        public CloudServicesNetworkDetailedStatus? DetailedStatus { get; }
        /// <summary> The descriptive message about the current detailed status. </summary>
        public string DetailedStatusMessage { get; }
        /// <summary> The indicator of whether the platform default endpoints are allowed for the egress traffic. </summary>
        public CloudServicesNetworkEnableDefaultEgressEndpoint? EnableDefaultEgressEndpoints { get; set; }
        /// <summary> The full list of additional and default egress endpoints that are currently enabled. </summary>
        public IReadOnlyList<EgressEndpoint> EnabledEgressEndpoints { get; }
        /// <summary> Field Deprecated. These fields will be empty/omitted. The list of Hybrid AKS cluster resource IDs that are associated with this cloud services network. </summary>
        public IReadOnlyList<ResourceIdentifier> HybridAksClustersAssociatedIds { get; }
        /// <summary> The name of the interface that will be present in the virtual machine to represent this network. </summary>
        public string InterfaceName { get; }
        /// <summary> The provisioning state of the cloud services network. </summary>
        public CloudServicesNetworkProvisioningState? ProvisioningState { get; }
        /// <summary> Field Deprecated. These fields will be empty/omitted. The list of virtual machine resource IDs, excluding any Hybrid AKS virtual machines, that are currently using this cloud services network. </summary>
        public IReadOnlyList<ResourceIdentifier> VirtualMachinesAssociatedIds { get; }
    }
}
