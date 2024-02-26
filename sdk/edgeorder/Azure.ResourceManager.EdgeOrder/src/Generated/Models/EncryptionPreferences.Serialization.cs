// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    internal partial class EncryptionPreferences : IUtf8JsonSerializable, IJsonModel<EncryptionPreferences>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EncryptionPreferences>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EncryptionPreferences>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionPreferences>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EncryptionPreferences)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DoubleEncryptionStatus.HasValue)
            {
                writer.WritePropertyName("doubleEncryptionStatus"u8);
                writer.WriteStringValue(DoubleEncryptionStatus.Value.ToString());
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

        EncryptionPreferences IJsonModel<EncryptionPreferences>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionPreferences>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EncryptionPreferences)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEncryptionPreferences(document.RootElement, options);
        }

        internal static EncryptionPreferences DeserializeEncryptionPreferences(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DoubleEncryptionStatus> doubleEncryptionStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("doubleEncryptionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    doubleEncryptionStatus = new DoubleEncryptionStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EncryptionPreferences(Optional.ToNullable(doubleEncryptionStatus), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EncryptionPreferences>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionPreferences>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EncryptionPreferences)} does not support '{options.Format}' format.");
            }
        }

        EncryptionPreferences IPersistableModel<EncryptionPreferences>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionPreferences>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEncryptionPreferences(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EncryptionPreferences)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EncryptionPreferences>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
