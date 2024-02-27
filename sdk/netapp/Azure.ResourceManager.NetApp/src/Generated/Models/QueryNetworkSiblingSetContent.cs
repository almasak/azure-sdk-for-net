// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Network sibling set query. </summary>
    public partial class QueryNetworkSiblingSetContent
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

        /// <summary> Initializes a new instance of <see cref="QueryNetworkSiblingSetContent"/>. </summary>
        /// <param name="networkSiblingSetId"> Network Sibling Set ID for a group of volumes sharing networking resources in a subnet. </param>
        /// <param name="subnetId"> The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes. Example /subscriptions/subscriptionId/resourceGroups/resourceGroup/providers/Microsoft.Network/virtualNetworks/testVnet/subnets/{mySubnet}. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSiblingSetId"/> or <paramref name="subnetId"/> is null. </exception>
        public QueryNetworkSiblingSetContent(string networkSiblingSetId, ResourceIdentifier subnetId)
        {
            if (networkSiblingSetId == null)
            {
                throw new ArgumentNullException(nameof(networkSiblingSetId));
            }
            if (subnetId == null)
            {
                throw new ArgumentNullException(nameof(subnetId));
            }

            NetworkSiblingSetId = networkSiblingSetId;
            SubnetId = subnetId;
        }

        /// <summary> Initializes a new instance of <see cref="QueryNetworkSiblingSetContent"/>. </summary>
        /// <param name="networkSiblingSetId"> Network Sibling Set ID for a group of volumes sharing networking resources in a subnet. </param>
        /// <param name="subnetId"> The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes. Example /subscriptions/subscriptionId/resourceGroups/resourceGroup/providers/Microsoft.Network/virtualNetworks/testVnet/subnets/{mySubnet}. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QueryNetworkSiblingSetContent(string networkSiblingSetId, ResourceIdentifier subnetId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NetworkSiblingSetId = networkSiblingSetId;
            SubnetId = subnetId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="QueryNetworkSiblingSetContent"/> for deserialization. </summary>
        internal QueryNetworkSiblingSetContent()
        {
        }

        /// <summary> Network Sibling Set ID for a group of volumes sharing networking resources in a subnet. </summary>
        public string NetworkSiblingSetId { get; }
        /// <summary> The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes. Example /subscriptions/subscriptionId/resourceGroups/resourceGroup/providers/Microsoft.Network/virtualNetworks/testVnet/subnets/{mySubnet}. </summary>
        public ResourceIdentifier SubnetId { get; }
    }
}
