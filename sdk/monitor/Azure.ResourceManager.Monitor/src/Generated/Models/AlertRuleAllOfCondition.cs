// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> An Activity Log Alert rule condition that is met when all its member conditions are met. </summary>
    internal partial class AlertRuleAllOfCondition
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

        /// <summary> Initializes a new instance of <see cref="AlertRuleAllOfCondition"/>. </summary>
        /// <param name="allOf"> The list of Activity Log Alert rule conditions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="allOf"/> is null. </exception>
        public AlertRuleAllOfCondition(IEnumerable<ActivityLogAlertAnyOfOrLeafCondition> allOf)
        {
            if (allOf == null)
            {
                throw new ArgumentNullException(nameof(allOf));
            }

            AllOf = allOf.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AlertRuleAllOfCondition"/>. </summary>
        /// <param name="allOf"> The list of Activity Log Alert rule conditions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AlertRuleAllOfCondition(IList<ActivityLogAlertAnyOfOrLeafCondition> allOf, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AllOf = allOf;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AlertRuleAllOfCondition"/> for deserialization. </summary>
        internal AlertRuleAllOfCondition()
        {
        }

        /// <summary> The list of Activity Log Alert rule conditions. </summary>
        public IList<ActivityLogAlertAnyOfOrLeafCondition> AllOf { get; }
    }
}
