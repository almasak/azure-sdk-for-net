// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ApplicationDeltaHealthPolicy : IUtf8JsonSerializable, IJsonModel<ApplicationDeltaHealthPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationDeltaHealthPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationDeltaHealthPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationDeltaHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationDeltaHealthPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DefaultServiceTypeDeltaHealthPolicy != null)
            {
                writer.WritePropertyName("defaultServiceTypeDeltaHealthPolicy"u8);
                writer.WriteObjectValue(DefaultServiceTypeDeltaHealthPolicy);
            }
            if (!(ServiceTypeDeltaHealthPolicies is ChangeTrackingDictionary<string, ServiceTypeDeltaHealthPolicy> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("serviceTypeDeltaHealthPolicies"u8);
                writer.WriteStartObject();
                foreach (var item in ServiceTypeDeltaHealthPolicies)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
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

        ApplicationDeltaHealthPolicy IJsonModel<ApplicationDeltaHealthPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationDeltaHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationDeltaHealthPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationDeltaHealthPolicy(document.RootElement, options);
        }

        internal static ApplicationDeltaHealthPolicy DeserializeApplicationDeltaHealthPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ServiceTypeDeltaHealthPolicy> defaultServiceTypeDeltaHealthPolicy = default;
            IDictionary<string, ServiceTypeDeltaHealthPolicy> serviceTypeDeltaHealthPolicies = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultServiceTypeDeltaHealthPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultServiceTypeDeltaHealthPolicy = ServiceTypeDeltaHealthPolicy.DeserializeServiceTypeDeltaHealthPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("serviceTypeDeltaHealthPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ServiceTypeDeltaHealthPolicy> dictionary = new Dictionary<string, ServiceTypeDeltaHealthPolicy>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ServiceTypeDeltaHealthPolicy.DeserializeServiceTypeDeltaHealthPolicy(property0.Value, options));
                    }
                    serviceTypeDeltaHealthPolicies = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationDeltaHealthPolicy(defaultServiceTypeDeltaHealthPolicy.Value, serviceTypeDeltaHealthPolicies ?? new ChangeTrackingDictionary<string, ServiceTypeDeltaHealthPolicy>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationDeltaHealthPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationDeltaHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationDeltaHealthPolicy)} does not support '{options.Format}' format.");
            }
        }

        ApplicationDeltaHealthPolicy IPersistableModel<ApplicationDeltaHealthPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationDeltaHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationDeltaHealthPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationDeltaHealthPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationDeltaHealthPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
