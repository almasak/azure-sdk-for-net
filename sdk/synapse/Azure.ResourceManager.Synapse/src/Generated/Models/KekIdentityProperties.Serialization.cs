// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class KekIdentityProperties : IUtf8JsonSerializable, IJsonModel<KekIdentityProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KekIdentityProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KekIdentityProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KekIdentityProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KekIdentityProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (UserAssignedIdentityId != null)
            {
                writer.WritePropertyName("userAssignedIdentity"u8);
                writer.WriteStringValue(UserAssignedIdentityId);
            }
            if (UseSystemAssignedIdentity != null)
            {
                writer.WritePropertyName("useSystemAssignedIdentity"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(UseSystemAssignedIdentity);
#else
                using (JsonDocument document = JsonDocument.Parse(UseSystemAssignedIdentity))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        KekIdentityProperties IJsonModel<KekIdentityProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KekIdentityProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KekIdentityProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKekIdentityProperties(document.RootElement, options);
        }

        internal static KekIdentityProperties DeserializeKekIdentityProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> userAssignedIdentity = default;
            Optional<BinaryData> useSystemAssignedIdentity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userAssignedIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userAssignedIdentity = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useSystemAssignedIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useSystemAssignedIdentity = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KekIdentityProperties(userAssignedIdentity.Value, useSystemAssignedIdentity.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KekIdentityProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KekIdentityProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KekIdentityProperties)} does not support '{options.Format}' format.");
            }
        }

        KekIdentityProperties IPersistableModel<KekIdentityProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KekIdentityProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKekIdentityProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KekIdentityProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KekIdentityProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
