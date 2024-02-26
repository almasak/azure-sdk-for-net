// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class TwinUpdatesNotInAllowedRange : IUtf8JsonSerializable, IJsonModel<TwinUpdatesNotInAllowedRange>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TwinUpdatesNotInAllowedRange>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TwinUpdatesNotInAllowedRange>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TwinUpdatesNotInAllowedRange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TwinUpdatesNotInAllowedRange)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("timeWindowSize"u8);
            writer.WriteStringValue(TimeWindowSize, "P");
            writer.WritePropertyName("minThreshold"u8);
            writer.WriteNumberValue(MinThreshold);
            writer.WritePropertyName("maxThreshold"u8);
            writer.WriteNumberValue(MaxThreshold);
            if (options.Format != "W" && DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            writer.WritePropertyName("ruleType"u8);
            writer.WriteStringValue(RuleType);
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

        TwinUpdatesNotInAllowedRange IJsonModel<TwinUpdatesNotInAllowedRange>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TwinUpdatesNotInAllowedRange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TwinUpdatesNotInAllowedRange)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTwinUpdatesNotInAllowedRange(document.RootElement, options);
        }

        internal static TwinUpdatesNotInAllowedRange DeserializeTwinUpdatesNotInAllowedRange(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSpan timeWindowSize = default;
            int minThreshold = default;
            int maxThreshold = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            bool isEnabled = default;
            string ruleType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeWindowSize"u8))
                {
                    timeWindowSize = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("minThreshold"u8))
                {
                    minThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxThreshold"u8))
                {
                    maxThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ruleType"u8))
                {
                    ruleType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TwinUpdatesNotInAllowedRange(displayName.Value, description.Value, isEnabled, ruleType, serializedAdditionalRawData, minThreshold, maxThreshold, timeWindowSize);
        }

        BinaryData IPersistableModel<TwinUpdatesNotInAllowedRange>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TwinUpdatesNotInAllowedRange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TwinUpdatesNotInAllowedRange)} does not support '{options.Format}' format.");
            }
        }

        TwinUpdatesNotInAllowedRange IPersistableModel<TwinUpdatesNotInAllowedRange>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TwinUpdatesNotInAllowedRange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTwinUpdatesNotInAllowedRange(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TwinUpdatesNotInAllowedRange)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TwinUpdatesNotInAllowedRange>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
