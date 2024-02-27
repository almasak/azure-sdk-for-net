// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.LargeInstance.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LargeInstance
{
    /// <summary>
    /// A class representing the LargeInstance data model.
    /// Azure Large Instance info on Azure (ARM properties and AzureLargeInstance
    /// properties)
    /// </summary>
    public partial class LargeInstanceData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="LargeInstanceData"/>. </summary>
        /// <param name="location"> The geo-location where the resource lives. </param>
        internal LargeInstanceData(AzureLocation location)
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Location = location;
        }

        /// <summary> Initializes a new instance of <see cref="LargeInstanceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="hardwareProfile"> Specifies the hardware settings for the Azure Large Instance. </param>
        /// <param name="storageProfile"> Specifies the storage settings for the Azure Large Instance disks. </param>
        /// <param name="osProfile"> Specifies the operating system settings for the Azure Large Instance. </param>
        /// <param name="networkProfile"> Specifies the network settings for the Azure Large Instance. </param>
        /// <param name="azureLargeInstanceId"> Specifies the Azure Large Instance unique ID. </param>
        /// <param name="powerState"> Resource power state. </param>
        /// <param name="proximityPlacementGroup"> Resource proximity placement group. </param>
        /// <param name="hwRevision"> Hardware revision of an Azure Large Instance. </param>
        /// <param name="partnerNodeId">
        /// ARM ID of another AzureLargeInstance that will share a network with this
        /// AzureLargeInstance
        /// </param>
        /// <param name="provisioningState"> State of provisioning of the AzureLargeInstance. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LargeInstanceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, LargeInstanceHardwareProfile hardwareProfile, LargeInstanceStorageProfile storageProfile, LargeInstanceOSProfile osProfile, LargeInstanceNetworkProfile networkProfile, string azureLargeInstanceId, LargeInstancePowerState? powerState, string proximityPlacementGroup, string hwRevision, string partnerNodeId, LargeInstanceProvisioningState? provisioningState, IReadOnlyDictionary<string, string> tags, AzureLocation location, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            HardwareProfile = hardwareProfile;
            StorageProfile = storageProfile;
            OSProfile = osProfile;
            NetworkProfile = networkProfile;
            AzureLargeInstanceId = azureLargeInstanceId;
            PowerState = powerState;
            ProximityPlacementGroup = proximityPlacementGroup;
            HwRevision = hwRevision;
            PartnerNodeId = partnerNodeId;
            ProvisioningState = provisioningState;
            Tags = tags;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="LargeInstanceData"/> for deserialization. </summary>
        internal LargeInstanceData()
        {
        }

        /// <summary> Specifies the hardware settings for the Azure Large Instance. </summary>
        public LargeInstanceHardwareProfile HardwareProfile { get; }
        /// <summary> Specifies the storage settings for the Azure Large Instance disks. </summary>
        public LargeInstanceStorageProfile StorageProfile { get; }
        /// <summary> Specifies the operating system settings for the Azure Large Instance. </summary>
        public LargeInstanceOSProfile OSProfile { get; }
        /// <summary> Specifies the network settings for the Azure Large Instance. </summary>
        public LargeInstanceNetworkProfile NetworkProfile { get; }
        /// <summary> Specifies the Azure Large Instance unique ID. </summary>
        public string AzureLargeInstanceId { get; }
        /// <summary> Resource power state. </summary>
        public LargeInstancePowerState? PowerState { get; }
        /// <summary> Resource proximity placement group. </summary>
        public string ProximityPlacementGroup { get; }
        /// <summary> Hardware revision of an Azure Large Instance. </summary>
        public string HwRevision { get; }
        /// <summary>
        /// ARM ID of another AzureLargeInstance that will share a network with this
        /// AzureLargeInstance
        /// </summary>
        public string PartnerNodeId { get; }
        /// <summary> State of provisioning of the AzureLargeInstance. </summary>
        public LargeInstanceProvisioningState? ProvisioningState { get; }
        /// <summary> Resource tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation Location { get; }
    }
}
