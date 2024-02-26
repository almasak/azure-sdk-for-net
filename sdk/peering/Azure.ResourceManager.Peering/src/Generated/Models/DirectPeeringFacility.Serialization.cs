// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Peering.Models
{
    public partial class DirectPeeringFacility : IUtf8JsonSerializable, IJsonModel<DirectPeeringFacility>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DirectPeeringFacility>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DirectPeeringFacility>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DirectPeeringFacility>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DirectPeeringFacility)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Address != null)
            {
                writer.WritePropertyName("address"u8);
                writer.WriteStringValue(Address);
            }
            if (DirectPeeringType.HasValue)
            {
                writer.WritePropertyName("directPeeringType"u8);
                writer.WriteStringValue(DirectPeeringType.Value.ToString());
            }
            if (PeeringDBFacilityId.HasValue)
            {
                writer.WritePropertyName("peeringDBFacilityId"u8);
                writer.WriteNumberValue(PeeringDBFacilityId.Value);
            }
            if (PeeringDBFacilityLink != null)
            {
                writer.WritePropertyName("peeringDBFacilityLink"u8);
                writer.WriteStringValue(PeeringDBFacilityLink);
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

        DirectPeeringFacility IJsonModel<DirectPeeringFacility>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DirectPeeringFacility>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DirectPeeringFacility)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDirectPeeringFacility(document.RootElement, options);
        }

        internal static DirectPeeringFacility DeserializeDirectPeeringFacility(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> address = default;
            Optional<DirectPeeringType> directPeeringType = default;
            Optional<int> peeringDBFacilityId = default;
            Optional<string> peeringDBFacilityLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("address"u8))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("directPeeringType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    directPeeringType = new DirectPeeringType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("peeringDBFacilityId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peeringDBFacilityId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("peeringDBFacilityLink"u8))
                {
                    peeringDBFacilityLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DirectPeeringFacility(address.Value, Optional.ToNullable(directPeeringType), Optional.ToNullable(peeringDBFacilityId), peeringDBFacilityLink.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DirectPeeringFacility>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DirectPeeringFacility>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DirectPeeringFacility)} does not support '{options.Format}' format.");
            }
        }

        DirectPeeringFacility IPersistableModel<DirectPeeringFacility>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DirectPeeringFacility>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDirectPeeringFacility(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DirectPeeringFacility)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DirectPeeringFacility>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
