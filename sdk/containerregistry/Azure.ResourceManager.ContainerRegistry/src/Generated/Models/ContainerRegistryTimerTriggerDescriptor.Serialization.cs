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
    public partial class ContainerRegistryTimerTriggerDescriptor : IUtf8JsonSerializable, IJsonModel<ContainerRegistryTimerTriggerDescriptor>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryTimerTriggerDescriptor>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistryTimerTriggerDescriptor>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTimerTriggerDescriptor>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryTimerTriggerDescriptor)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (TimerTriggerName != null)
            {
                writer.WritePropertyName("timerTriggerName"u8);
                writer.WriteStringValue(TimerTriggerName);
            }
            if (ScheduleOccurrence != null)
            {
                writer.WritePropertyName("scheduleOccurrence"u8);
                writer.WriteStringValue(ScheduleOccurrence);
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

        ContainerRegistryTimerTriggerDescriptor IJsonModel<ContainerRegistryTimerTriggerDescriptor>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTimerTriggerDescriptor>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryTimerTriggerDescriptor)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryTimerTriggerDescriptor(document.RootElement, options);
        }

        internal static ContainerRegistryTimerTriggerDescriptor DeserializeContainerRegistryTimerTriggerDescriptor(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> timerTriggerName = default;
            Optional<string> scheduleOccurrence = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timerTriggerName"u8))
                {
                    timerTriggerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scheduleOccurrence"u8))
                {
                    scheduleOccurrence = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryTimerTriggerDescriptor(timerTriggerName.Value, scheduleOccurrence.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerRegistryTimerTriggerDescriptor>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTimerTriggerDescriptor>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryTimerTriggerDescriptor)} does not support '{options.Format}' format.");
            }
        }

        ContainerRegistryTimerTriggerDescriptor IPersistableModel<ContainerRegistryTimerTriggerDescriptor>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTimerTriggerDescriptor>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryTimerTriggerDescriptor(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryTimerTriggerDescriptor)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryTimerTriggerDescriptor>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
