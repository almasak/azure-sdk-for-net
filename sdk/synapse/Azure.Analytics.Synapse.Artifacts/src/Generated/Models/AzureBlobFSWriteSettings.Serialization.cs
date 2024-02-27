// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(AzureBlobFSWriteSettingsConverter))]
    public partial class AzureBlobFSWriteSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (BlockSizeInMB != null)
            {
                writer.WritePropertyName("blockSizeInMB"u8);
                writer.WriteObjectValue(BlockSizeInMB);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (MaxConcurrentConnections != null)
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            if (CopyBehavior != null)
            {
                writer.WritePropertyName("copyBehavior"u8);
                writer.WriteObjectValue(CopyBehavior);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static AzureBlobFSWriteSettings DeserializeAzureBlobFSWriteSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> blockSizeInMB = default;
            string type = default;
            Optional<object> maxConcurrentConnections = default;
            Optional<object> copyBehavior = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blockSizeInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blockSizeInMB = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("copyBehavior"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copyBehavior = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureBlobFSWriteSettings(type, maxConcurrentConnections.Value, copyBehavior.Value, additionalProperties, blockSizeInMB.Value);
        }

        internal partial class AzureBlobFSWriteSettingsConverter : JsonConverter<AzureBlobFSWriteSettings>
        {
            public override void Write(Utf8JsonWriter writer, AzureBlobFSWriteSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AzureBlobFSWriteSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAzureBlobFSWriteSettings(document.RootElement);
            }
        }
    }
}
