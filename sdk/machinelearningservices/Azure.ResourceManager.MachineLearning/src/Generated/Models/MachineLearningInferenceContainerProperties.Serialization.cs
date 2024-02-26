// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningInferenceContainerProperties : IUtf8JsonSerializable, IJsonModel<MachineLearningInferenceContainerProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningInferenceContainerProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningInferenceContainerProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningInferenceContainerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningInferenceContainerProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (LivenessRoute != null)
            {
                writer.WritePropertyName("livenessRoute"u8);
                writer.WriteObjectValue(LivenessRoute);
            }
            if (ReadinessRoute != null)
            {
                writer.WritePropertyName("readinessRoute"u8);
                writer.WriteObjectValue(ReadinessRoute);
            }
            if (ScoringRoute != null)
            {
                writer.WritePropertyName("scoringRoute"u8);
                writer.WriteObjectValue(ScoringRoute);
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

        MachineLearningInferenceContainerProperties IJsonModel<MachineLearningInferenceContainerProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningInferenceContainerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningInferenceContainerProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningInferenceContainerProperties(document.RootElement, options);
        }

        internal static MachineLearningInferenceContainerProperties DeserializeMachineLearningInferenceContainerProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineLearningInferenceContainerRoute> livenessRoute = default;
            Optional<MachineLearningInferenceContainerRoute> readinessRoute = default;
            Optional<MachineLearningInferenceContainerRoute> scoringRoute = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("livenessRoute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    livenessRoute = MachineLearningInferenceContainerRoute.DeserializeMachineLearningInferenceContainerRoute(property.Value, options);
                    continue;
                }
                if (property.NameEquals("readinessRoute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readinessRoute = MachineLearningInferenceContainerRoute.DeserializeMachineLearningInferenceContainerRoute(property.Value, options);
                    continue;
                }
                if (property.NameEquals("scoringRoute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scoringRoute = MachineLearningInferenceContainerRoute.DeserializeMachineLearningInferenceContainerRoute(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningInferenceContainerProperties(livenessRoute.Value, readinessRoute.Value, scoringRoute.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningInferenceContainerProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningInferenceContainerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningInferenceContainerProperties)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningInferenceContainerProperties IPersistableModel<MachineLearningInferenceContainerProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningInferenceContainerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningInferenceContainerProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningInferenceContainerProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningInferenceContainerProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
