// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class VmResourceFeatureSupportContent : IUtf8JsonSerializable, IJsonModel<VmResourceFeatureSupportContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VmResourceFeatureSupportContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VmResourceFeatureSupportContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmResourceFeatureSupportContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmResourceFeatureSupportContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (VmSize != null)
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStringValue(VmSize);
            }
            if (VmSku != null)
            {
                writer.WritePropertyName("vmSku"u8);
                writer.WriteStringValue(VmSku);
            }
            writer.WritePropertyName("featureType"u8);
            writer.WriteStringValue(FeatureType);
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

        VmResourceFeatureSupportContent IJsonModel<VmResourceFeatureSupportContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmResourceFeatureSupportContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmResourceFeatureSupportContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVmResourceFeatureSupportContent(document.RootElement, options);
        }

        internal static VmResourceFeatureSupportContent DeserializeVmResourceFeatureSupportContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> vmSize = default;
            Optional<string> vmSku = default;
            string featureType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSize"u8))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmSku"u8))
                {
                    vmSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("featureType"u8))
                {
                    featureType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VmResourceFeatureSupportContent(featureType, serializedAdditionalRawData, vmSize.Value, vmSku.Value);
        }

        BinaryData IPersistableModel<VmResourceFeatureSupportContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmResourceFeatureSupportContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VmResourceFeatureSupportContent)} does not support '{options.Format}' format.");
            }
        }

        VmResourceFeatureSupportContent IPersistableModel<VmResourceFeatureSupportContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmResourceFeatureSupportContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVmResourceFeatureSupportContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VmResourceFeatureSupportContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VmResourceFeatureSupportContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
