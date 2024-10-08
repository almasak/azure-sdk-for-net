// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> BoolEquals Filter. </summary>
    public partial class BoolEqualsFilter : EventGridFilter
    {
        /// <summary> Initializes a new instance of <see cref="BoolEqualsFilter"/>. </summary>
        public BoolEqualsFilter()
        {
            OperatorType = FilterOperatorType.BoolEquals;
        }

        /// <summary> Initializes a new instance of <see cref="BoolEqualsFilter"/>. </summary>
        /// <param name="operatorType"> The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others. </param>
        /// <param name="key"> The field/property in the event based on which you want to filter. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="value"> The boolean filter value. </param>
        internal BoolEqualsFilter(FilterOperatorType operatorType, string key, IDictionary<string, BinaryData> serializedAdditionalRawData, bool? value) : base(operatorType, key, serializedAdditionalRawData)
        {
            Value = value;
            OperatorType = operatorType;
        }

        /// <summary> The boolean filter value. </summary>
        [WirePath("value")]
        public bool? Value { get; set; }
    }
}
