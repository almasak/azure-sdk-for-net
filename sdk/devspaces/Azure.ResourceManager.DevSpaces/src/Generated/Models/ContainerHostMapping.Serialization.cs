// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevSpaces.Models
{
    public partial class ContainerHostMapping : IUtf8JsonSerializable, IJsonModel<ContainerHostMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerHostMapping>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerHostMapping>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerHostMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerHostMapping)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ContainerHostResourceId != null)
            {
                writer.WritePropertyName("containerHostResourceId"u8);
                writer.WriteStringValue(ContainerHostResourceId);
            }
            if (options.Format != "W" && MappedControllerResourceId != null)
            {
                writer.WritePropertyName("mappedControllerResourceId"u8);
                writer.WriteStringValue(MappedControllerResourceId);
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

        ContainerHostMapping IJsonModel<ContainerHostMapping>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerHostMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerHostMapping)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerHostMapping(document.RootElement, options);
        }

        internal static ContainerHostMapping DeserializeContainerHostMapping(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> containerHostResourceId = default;
            Optional<string> mappedControllerResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("containerHostResourceId"u8))
                {
                    containerHostResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mappedControllerResourceId"u8))
                {
                    mappedControllerResourceId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerHostMapping(containerHostResourceId.Value, mappedControllerResourceId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerHostMapping>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerHostMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerHostMapping)} does not support '{options.Format}' format.");
            }
        }

        ContainerHostMapping IPersistableModel<ContainerHostMapping>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerHostMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerHostMapping(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerHostMapping)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerHostMapping>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
