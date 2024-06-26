// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> A role that can be assigned to a user. </summary>
    public partial class DevCenterEnvironmentRole
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

        /// <summary> Initializes a new instance of <see cref="DevCenterEnvironmentRole"/>. </summary>
        public DevCenterEnvironmentRole()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterEnvironmentRole"/>. </summary>
        /// <param name="roleName"> The common name of the Role Assignment. This is a descriptive name such as 'AcrPush'. </param>
        /// <param name="description"> This is a description of the Role Assignment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DevCenterEnvironmentRole(string roleName, string description, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RoleName = roleName;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The common name of the Role Assignment. This is a descriptive name such as 'AcrPush'. </summary>
        public string RoleName { get; }
        /// <summary> This is a description of the Role Assignment. </summary>
        public string Description { get; }
    }
}
