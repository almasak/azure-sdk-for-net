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
    public partial class DevTestLabNotificationChannelEvent : IUtf8JsonSerializable, IJsonModel<DevTestLabNotificationChannelEvent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabNotificationChannelEvent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevTestLabNotificationChannelEvent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabNotificationChannelEvent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabNotificationChannelEvent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (EventName.HasValue)
            {
                writer.WritePropertyName("eventName"u8);
                writer.WriteStringValue(EventName.Value.ToString());
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

        DevTestLabNotificationChannelEvent IJsonModel<DevTestLabNotificationChannelEvent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabNotificationChannelEvent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabNotificationChannelEvent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabNotificationChannelEvent(document.RootElement, options);
        }

        internal static DevTestLabNotificationChannelEvent DeserializeDevTestLabNotificationChannelEvent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DevTestLabNotificationChannelEventType> eventName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventName = new DevTestLabNotificationChannelEventType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevTestLabNotificationChannelEvent(Optional.ToNullable(eventName), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabNotificationChannelEvent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabNotificationChannelEvent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabNotificationChannelEvent)} does not support '{options.Format}' format.");
            }
        }

        DevTestLabNotificationChannelEvent IPersistableModel<DevTestLabNotificationChannelEvent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabNotificationChannelEvent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabNotificationChannelEvent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabNotificationChannelEvent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabNotificationChannelEvent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
