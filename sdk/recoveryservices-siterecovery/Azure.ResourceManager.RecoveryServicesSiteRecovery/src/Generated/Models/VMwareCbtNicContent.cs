// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMwareCbt NIC input. </summary>
    public partial class VMwareCbtNicContent
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

        /// <summary> Initializes a new instance of <see cref="VMwareCbtNicContent"/>. </summary>
        /// <param name="nicId"> The NIC Id. </param>
        /// <param name="isPrimaryNic"> A value indicating whether this is the primary NIC. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nicId"/> or <paramref name="isPrimaryNic"/> is null. </exception>
        public VMwareCbtNicContent(string nicId, string isPrimaryNic)
        {
            if (nicId == null)
            {
                throw new ArgumentNullException(nameof(nicId));
            }
            if (isPrimaryNic == null)
            {
                throw new ArgumentNullException(nameof(isPrimaryNic));
            }

            NicId = nicId;
            IsPrimaryNic = isPrimaryNic;
        }

        /// <summary> Initializes a new instance of <see cref="VMwareCbtNicContent"/>. </summary>
        /// <param name="nicId"> The NIC Id. </param>
        /// <param name="isPrimaryNic"> A value indicating whether this is the primary NIC. </param>
        /// <param name="targetSubnetName"> Target subnet name. </param>
        /// <param name="targetStaticIPAddress"> The static IP address. </param>
        /// <param name="isSelectedForMigration"> A value indicating whether this NIC is selected for migration. </param>
        /// <param name="targetNicName"> Target NIC name. </param>
        /// <param name="testSubnetName"> The test subnet name. </param>
        /// <param name="testStaticIPAddress"> The test static IP address. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VMwareCbtNicContent(string nicId, string isPrimaryNic, string targetSubnetName, IPAddress targetStaticIPAddress, string isSelectedForMigration, string targetNicName, string testSubnetName, IPAddress testStaticIPAddress, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NicId = nicId;
            IsPrimaryNic = isPrimaryNic;
            TargetSubnetName = targetSubnetName;
            TargetStaticIPAddress = targetStaticIPAddress;
            IsSelectedForMigration = isSelectedForMigration;
            TargetNicName = targetNicName;
            TestSubnetName = testSubnetName;
            TestStaticIPAddress = testStaticIPAddress;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VMwareCbtNicContent"/> for deserialization. </summary>
        internal VMwareCbtNicContent()
        {
        }

        /// <summary> The NIC Id. </summary>
        public string NicId { get; }
        /// <summary> A value indicating whether this is the primary NIC. </summary>
        public string IsPrimaryNic { get; }
        /// <summary> Target subnet name. </summary>
        public string TargetSubnetName { get; set; }
        /// <summary> The static IP address. </summary>
        public IPAddress TargetStaticIPAddress { get; set; }
        /// <summary> A value indicating whether this NIC is selected for migration. </summary>
        public string IsSelectedForMigration { get; set; }
        /// <summary> Target NIC name. </summary>
        public string TargetNicName { get; set; }
        /// <summary> The test subnet name. </summary>
        public string TestSubnetName { get; set; }
        /// <summary> The test static IP address. </summary>
        public IPAddress TestStaticIPAddress { get; set; }
    }
}
