// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SelfDependencyTumblingWindowTriggerReference : IUtf8JsonSerializable, IJsonModel<SelfDependencyTumblingWindowTriggerReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SelfDependencyTumblingWindowTriggerReference>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SelfDependencyTumblingWindowTriggerReference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfDependencyTumblingWindowTriggerReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfDependencyTumblingWindowTriggerReference)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("offset"u8);
            writer.WriteStringValue(Offset);
            if (Size != null)
            {
                writer.WritePropertyName("size"u8);
                writer.WriteStringValue(Size);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DependencyReferenceType);
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

        SelfDependencyTumblingWindowTriggerReference IJsonModel<SelfDependencyTumblingWindowTriggerReference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfDependencyTumblingWindowTriggerReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfDependencyTumblingWindowTriggerReference)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSelfDependencyTumblingWindowTriggerReference(document.RootElement, options);
        }

        internal static SelfDependencyTumblingWindowTriggerReference DeserializeSelfDependencyTumblingWindowTriggerReference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string offset = default;
            Optional<string> size = default;
            string type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offset"u8))
                {
                    offset = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    size = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SelfDependencyTumblingWindowTriggerReference(type, serializedAdditionalRawData, offset, size.Value);
        }

        BinaryData IPersistableModel<SelfDependencyTumblingWindowTriggerReference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfDependencyTumblingWindowTriggerReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SelfDependencyTumblingWindowTriggerReference)} does not support '{options.Format}' format.");
            }
        }

        SelfDependencyTumblingWindowTriggerReference IPersistableModel<SelfDependencyTumblingWindowTriggerReference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfDependencyTumblingWindowTriggerReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSelfDependencyTumblingWindowTriggerReference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SelfDependencyTumblingWindowTriggerReference)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SelfDependencyTumblingWindowTriggerReference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
