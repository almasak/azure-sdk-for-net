// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> Unknown version of RequiredToolCall. </summary>
    internal partial class UnknownRequiredToolCall : RequiredToolCall
    {
        /// <summary> Initializes a new instance of <see cref="UnknownRequiredToolCall"/>. </summary>
        /// <param name="type"> The object type for the required tool call. </param>
        /// <param name="id"> The ID of the tool call. This ID must be referenced when submitting tool outputs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownRequiredToolCall(string type, string id, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(type, id, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownRequiredToolCall"/> for deserialization. </summary>
        internal UnknownRequiredToolCall()
        {
        }
    }
}
