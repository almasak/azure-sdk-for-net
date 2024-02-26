// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class ResourceSharingProfile : IUtf8JsonSerializable, IJsonModel<ResourceSharingProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceSharingProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceSharingProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceSharingProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceSharingProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(SubscriptionIds is ChangeTrackingList<WritableSubResource> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("subscriptionIds"u8);
                writer.WriteStartArray();
                foreach (var item in SubscriptionIds)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
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

        ResourceSharingProfile IJsonModel<ResourceSharingProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceSharingProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceSharingProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceSharingProfile(document.RootElement, options);
        }

        internal static ResourceSharingProfile DeserializeResourceSharingProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<WritableSubResource> subscriptionIds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subscriptionIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    subscriptionIds = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceSharingProfile(subscriptionIds ?? new ChangeTrackingList<WritableSubResource>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceSharingProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceSharingProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceSharingProfile)} does not support '{options.Format}' format.");
            }
        }

        ResourceSharingProfile IPersistableModel<ResourceSharingProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceSharingProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceSharingProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceSharingProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceSharingProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
