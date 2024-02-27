// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownBaseEnvironmentSource. </summary>
    internal partial class UnknownBaseEnvironmentSource : BaseEnvironmentSource
    {
        /// <summary> Initializes a new instance of <see cref="UnknownBaseEnvironmentSource"/>. </summary>
        /// <param name="baseEnvironmentSourceType"> [Required] Base environment type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownBaseEnvironmentSource(BaseEnvironmentSourceType baseEnvironmentSourceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(baseEnvironmentSourceType, serializedAdditionalRawData)
        {
            BaseEnvironmentSourceType = baseEnvironmentSourceType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownBaseEnvironmentSource"/> for deserialization. </summary>
        internal UnknownBaseEnvironmentSource()
        {
        }
    }
}
