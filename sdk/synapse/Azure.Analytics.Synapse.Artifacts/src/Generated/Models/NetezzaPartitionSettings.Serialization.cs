// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(NetezzaPartitionSettingsConverter))]
    public partial class NetezzaPartitionSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (PartitionColumnName != null)
            {
                writer.WritePropertyName("partitionColumnName"u8);
                writer.WriteObjectValue(PartitionColumnName);
            }
            if (PartitionUpperBound != null)
            {
                writer.WritePropertyName("partitionUpperBound"u8);
                writer.WriteObjectValue(PartitionUpperBound);
            }
            if (PartitionLowerBound != null)
            {
                writer.WritePropertyName("partitionLowerBound"u8);
                writer.WriteObjectValue(PartitionLowerBound);
            }
            writer.WriteEndObject();
        }

        internal static NetezzaPartitionSettings DeserializeNetezzaPartitionSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> partitionColumnName = default;
            Optional<object> partitionUpperBound = default;
            Optional<object> partitionLowerBound = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionColumnName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionUpperBound"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionUpperBound = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionLowerBound"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionLowerBound = property.Value.GetObject();
                    continue;
                }
            }
            return new NetezzaPartitionSettings(partitionColumnName.Value, partitionUpperBound.Value, partitionLowerBound.Value);
        }

        internal partial class NetezzaPartitionSettingsConverter : JsonConverter<NetezzaPartitionSettings>
        {
            public override void Write(Utf8JsonWriter writer, NetezzaPartitionSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override NetezzaPartitionSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeNetezzaPartitionSettings(document.RootElement);
            }
        }
    }
}
