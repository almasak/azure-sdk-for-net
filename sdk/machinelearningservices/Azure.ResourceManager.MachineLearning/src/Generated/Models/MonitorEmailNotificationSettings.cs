// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MonitorEmailNotificationSettings. </summary>
    internal partial class MonitorEmailNotificationSettings
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

        /// <summary> Initializes a new instance of <see cref="MonitorEmailNotificationSettings"/>. </summary>
        public MonitorEmailNotificationSettings()
        {
            Emails = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MonitorEmailNotificationSettings"/>. </summary>
        /// <param name="emails"> The email recipient list which has a limitation of 499 characters in total. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitorEmailNotificationSettings(IList<string> emails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Emails = emails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The email recipient list which has a limitation of 499 characters in total. </summary>
        public IList<string> Emails { get; set; }
    }
}
