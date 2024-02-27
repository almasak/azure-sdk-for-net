// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxKeyEncryptionKey : IUtf8JsonSerializable, IJsonModel<DataBoxKeyEncryptionKey>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxKeyEncryptionKey>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxKeyEncryptionKey>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxKeyEncryptionKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxKeyEncryptionKey)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kekType"u8);
            writer.WriteStringValue(KekType.ToSerialString());
            if (ManagedIdentity != null)
            {
                writer.WritePropertyName("identityProperties"u8);
                writer.WriteObjectValue(ManagedIdentity);
            }
            if (KekUri != null)
            {
                writer.WritePropertyName("kekUrl"u8);
                writer.WriteStringValue(KekUri.AbsoluteUri);
            }
            if (KekVaultResourceId != null)
            {
                writer.WritePropertyName("kekVaultResourceID"u8);
                writer.WriteStringValue(KekVaultResourceId);
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

        DataBoxKeyEncryptionKey IJsonModel<DataBoxKeyEncryptionKey>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxKeyEncryptionKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxKeyEncryptionKey)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxKeyEncryptionKey(document.RootElement, options);
        }

        internal static DataBoxKeyEncryptionKey DeserializeDataBoxKeyEncryptionKey(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxKeyEncryptionKeyType kekType = default;
            Optional<DataBoxManagedIdentity> identityProperties = default;
            Optional<Uri> kekUrl = default;
            Optional<ResourceIdentifier> kekVaultResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kekType"u8))
                {
                    kekType = property.Value.GetString().ToDataBoxKeyEncryptionKeyType();
                    continue;
                }
                if (property.NameEquals("identityProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityProperties = DataBoxManagedIdentity.DeserializeDataBoxManagedIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kekUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kekUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kekVaultResourceID"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kekVaultResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxKeyEncryptionKey(kekType, identityProperties.Value, kekUrl.Value, kekVaultResourceId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxKeyEncryptionKey>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxKeyEncryptionKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxKeyEncryptionKey)} does not support '{options.Format}' format.");
            }
        }

        DataBoxKeyEncryptionKey IPersistableModel<DataBoxKeyEncryptionKey>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxKeyEncryptionKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxKeyEncryptionKey(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxKeyEncryptionKey)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxKeyEncryptionKey>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
