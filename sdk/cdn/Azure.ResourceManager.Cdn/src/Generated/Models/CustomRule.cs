// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the common attributes for a custom rule that can be included in a waf policy. </summary>
    public partial class CustomRule
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CustomRule"/>. </summary>
        /// <param name="name"> Defines the name of the custom rule. </param>
        /// <param name="priority"> Defines in what order this rule be evaluated in the overall list of custom rules. </param>
        /// <param name="matchConditions"> List of match conditions. </param>
        /// <param name="action"> Describes what action to be applied when rule matches. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="matchConditions"/> is null. </exception>
        public CustomRule(string name, int priority, IEnumerable<CustomRuleMatchCondition> matchConditions, OverrideActionType action)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (matchConditions == null)
            {
                throw new ArgumentNullException(nameof(matchConditions));
            }

            Name = name;
            Priority = priority;
            MatchConditions = matchConditions.ToList();
            Action = action;
        }

        /// <summary> Initializes a new instance of <see cref="CustomRule"/>. </summary>
        /// <param name="name"> Defines the name of the custom rule. </param>
        /// <param name="enabledState"> Describes if the custom rule is in enabled or disabled state. Defaults to Enabled if not specified. </param>
        /// <param name="priority"> Defines in what order this rule be evaluated in the overall list of custom rules. </param>
        /// <param name="matchConditions"> List of match conditions. </param>
        /// <param name="action"> Describes what action to be applied when rule matches. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomRule(string name, CustomRuleEnabledState? enabledState, int priority, IList<CustomRuleMatchCondition> matchConditions, OverrideActionType action, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            EnabledState = enabledState;
            Priority = priority;
            MatchConditions = matchConditions;
            Action = action;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CustomRule"/> for deserialization. </summary>
        internal CustomRule()
        {
        }

        /// <summary> Defines the name of the custom rule. </summary>
        public string Name { get; set; }
        /// <summary> Describes if the custom rule is in enabled or disabled state. Defaults to Enabled if not specified. </summary>
        public CustomRuleEnabledState? EnabledState { get; set; }
        /// <summary> Defines in what order this rule be evaluated in the overall list of custom rules. </summary>
        public int Priority { get; set; }
        /// <summary> List of match conditions. </summary>
        public IList<CustomRuleMatchCondition> MatchConditions { get; }
        /// <summary> Describes what action to be applied when rule matches. </summary>
        public OverrideActionType Action { get; set; }
    }
}
