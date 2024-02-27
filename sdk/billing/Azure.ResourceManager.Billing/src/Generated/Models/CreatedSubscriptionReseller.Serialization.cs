// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class CreatedSubscriptionReseller : IUtf8JsonSerializable, IJsonModel<CreatedSubscriptionReseller>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CreatedSubscriptionReseller>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CreatedSubscriptionReseller>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreatedSubscriptionReseller>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreatedSubscriptionReseller)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ResellerId != null)
            {
                writer.WritePropertyName("resellerId"u8);
                writer.WriteStringValue(ResellerId);
            }
            if (options.Format != "W" && Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        CreatedSubscriptionReseller IJsonModel<CreatedSubscriptionReseller>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreatedSubscriptionReseller>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreatedSubscriptionReseller)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCreatedSubscriptionReseller(document.RootElement, options);
        }

        internal static CreatedSubscriptionReseller DeserializeCreatedSubscriptionReseller(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resellerId = default;
            Optional<string> description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resellerId"u8))
                {
                    resellerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CreatedSubscriptionReseller(resellerId.Value, description.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CreatedSubscriptionReseller>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreatedSubscriptionReseller>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CreatedSubscriptionReseller)} does not support '{options.Format}' format.");
            }
        }

        CreatedSubscriptionReseller IPersistableModel<CreatedSubscriptionReseller>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreatedSubscriptionReseller>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCreatedSubscriptionReseller(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CreatedSubscriptionReseller)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CreatedSubscriptionReseller>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
