// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryPlatformProperties : IUtf8JsonSerializable, IJsonModel<ContainerRegistryPlatformProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryPlatformProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistryPlatformProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryPlatformProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryPlatformProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("os"u8);
            writer.WriteStringValue(OS.ToString());
            if (Architecture.HasValue)
            {
                writer.WritePropertyName("architecture"u8);
                writer.WriteStringValue(Architecture.Value.ToString());
            }
            if (Variant.HasValue)
            {
                writer.WritePropertyName("variant"u8);
                writer.WriteStringValue(Variant.Value.ToString());
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

        ContainerRegistryPlatformProperties IJsonModel<ContainerRegistryPlatformProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryPlatformProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryPlatformProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryPlatformProperties(document.RootElement, options);
        }

        internal static ContainerRegistryPlatformProperties DeserializeContainerRegistryPlatformProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerRegistryOS os = default;
            Optional<ContainerRegistryOSArchitecture> architecture = default;
            Optional<ContainerRegistryCpuVariant> variant = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("os"u8))
                {
                    os = new ContainerRegistryOS(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("architecture"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    architecture = new ContainerRegistryOSArchitecture(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("variant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    variant = new ContainerRegistryCpuVariant(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryPlatformProperties(os, Optional.ToNullable(architecture), Optional.ToNullable(variant), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerRegistryPlatformProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryPlatformProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryPlatformProperties)} does not support '{options.Format}' format.");
            }
        }

        ContainerRegistryPlatformProperties IPersistableModel<ContainerRegistryPlatformProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryPlatformProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryPlatformProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryPlatformProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryPlatformProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
