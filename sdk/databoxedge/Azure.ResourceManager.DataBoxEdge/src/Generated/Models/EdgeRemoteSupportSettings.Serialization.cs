// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeRemoteSupportSettings : IUtf8JsonSerializable, IJsonModel<EdgeRemoteSupportSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeRemoteSupportSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdgeRemoteSupportSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeRemoteSupportSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeRemoteSupportSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (RemoteApplicationType.HasValue)
            {
                writer.WritePropertyName("remoteApplicationType"u8);
                writer.WriteStringValue(RemoteApplicationType.Value.ToString());
            }
            if (AccessLevel.HasValue)
            {
                writer.WritePropertyName("accessLevel"u8);
                writer.WriteStringValue(AccessLevel.Value.ToString());
            }
            if (ExpireOn.HasValue)
            {
                writer.WritePropertyName("expirationTimeStampInUTC"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
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

        EdgeRemoteSupportSettings IJsonModel<EdgeRemoteSupportSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeRemoteSupportSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeRemoteSupportSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeRemoteSupportSettings(document.RootElement, options);
        }

        internal static EdgeRemoteSupportSettings DeserializeEdgeRemoteSupportSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<EdgeRemoteApplicationType> remoteApplicationType = default;
            Optional<EdgeRemoteApplicationAccessLevel> accessLevel = default;
            Optional<DateTimeOffset> expirationTimeStampInUtc = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("remoteApplicationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    remoteApplicationType = new EdgeRemoteApplicationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("accessLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accessLevel = new EdgeRemoteApplicationAccessLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expirationTimeStampInUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationTimeStampInUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EdgeRemoteSupportSettings(Optional.ToNullable(remoteApplicationType), Optional.ToNullable(accessLevel), Optional.ToNullable(expirationTimeStampInUtc), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeRemoteSupportSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeRemoteSupportSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdgeRemoteSupportSettings)} does not support '{options.Format}' format.");
            }
        }

        EdgeRemoteSupportSettings IPersistableModel<EdgeRemoteSupportSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeRemoteSupportSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdgeRemoteSupportSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeRemoteSupportSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeRemoteSupportSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
