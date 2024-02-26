// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabPolicyViolation : IUtf8JsonSerializable, IJsonModel<DevTestLabPolicyViolation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabPolicyViolation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevTestLabPolicyViolation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabPolicyViolation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabPolicyViolation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Code != null)
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (Message != null)
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
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

        DevTestLabPolicyViolation IJsonModel<DevTestLabPolicyViolation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabPolicyViolation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabPolicyViolation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabPolicyViolation(document.RootElement, options);
        }

        internal static DevTestLabPolicyViolation DeserializeDevTestLabPolicyViolation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> code = default;
            Optional<string> message = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevTestLabPolicyViolation(code.Value, message.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabPolicyViolation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabPolicyViolation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabPolicyViolation)} does not support '{options.Format}' format.");
            }
        }

        DevTestLabPolicyViolation IPersistableModel<DevTestLabPolicyViolation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabPolicyViolation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabPolicyViolation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabPolicyViolation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabPolicyViolation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
