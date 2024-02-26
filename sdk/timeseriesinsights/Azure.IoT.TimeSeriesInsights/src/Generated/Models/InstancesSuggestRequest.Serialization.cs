// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class InstancesSuggestRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("searchString"u8);
            writer.WriteStringValue(SearchString);
            if (Take.HasValue)
            {
                writer.WritePropertyName("take"u8);
                writer.WriteNumberValue(Take.Value);
            }
            writer.WriteEndObject();
        }
    }
}
