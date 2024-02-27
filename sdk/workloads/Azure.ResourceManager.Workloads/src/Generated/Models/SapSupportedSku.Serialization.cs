// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SapSupportedSku : IUtf8JsonSerializable, IJsonModel<SapSupportedSku>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SapSupportedSku>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SapSupportedSku>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapSupportedSku>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapSupportedSku)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (VmSku != null)
            {
                writer.WritePropertyName("vmSku"u8);
                writer.WriteStringValue(VmSku);
            }
            if (IsAppServerCertified.HasValue)
            {
                writer.WritePropertyName("isAppServerCertified"u8);
                writer.WriteBooleanValue(IsAppServerCertified.Value);
            }
            if (IsDatabaseCertified.HasValue)
            {
                writer.WritePropertyName("isDatabaseCertified"u8);
                writer.WriteBooleanValue(IsDatabaseCertified.Value);
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

        SapSupportedSku IJsonModel<SapSupportedSku>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapSupportedSku>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapSupportedSku)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSapSupportedSku(document.RootElement, options);
        }

        internal static SapSupportedSku DeserializeSapSupportedSku(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> vmSku = default;
            Optional<bool> isAppServerCertified = default;
            Optional<bool> isDatabaseCertified = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSku"u8))
                {
                    vmSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAppServerCertified"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAppServerCertified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDatabaseCertified"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDatabaseCertified = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SapSupportedSku(vmSku.Value, Optional.ToNullable(isAppServerCertified), Optional.ToNullable(isDatabaseCertified), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SapSupportedSku>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapSupportedSku>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SapSupportedSku)} does not support '{options.Format}' format.");
            }
        }

        SapSupportedSku IPersistableModel<SapSupportedSku>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapSupportedSku>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSapSupportedSku(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SapSupportedSku)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SapSupportedSku>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
