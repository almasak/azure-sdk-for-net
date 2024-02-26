// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the ServerPort condition for the delivery rule. </summary>
    public partial class DeliveryRuleServerPortCondition : DeliveryRuleCondition
    {
        /// <summary> Initializes a new instance of <see cref="DeliveryRuleServerPortCondition"/>. </summary>
        /// <param name="properties"> Defines the parameters for the condition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DeliveryRuleServerPortCondition(ServerPortMatchCondition properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
            Name = MatchVariable.ServerPort;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleServerPortCondition"/>. </summary>
        /// <param name="name"> The name of the condition for the delivery rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="properties"> Defines the parameters for the condition. </param>
        internal DeliveryRuleServerPortCondition(MatchVariable name, IDictionary<string, BinaryData> serializedAdditionalRawData, ServerPortMatchCondition properties) : base(name, serializedAdditionalRawData)
        {
            Properties = properties;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleServerPortCondition"/> for deserialization. </summary>
        internal DeliveryRuleServerPortCondition()
        {
        }

        /// <summary> Defines the parameters for the condition. </summary>
        public ServerPortMatchCondition Properties { get; set; }
    }
}
