// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Subscription.Models
{
    public partial class SubscriptionAliasCreateOrUpdateContent : IUtf8JsonSerializable, IJsonModel<SubscriptionAliasCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SubscriptionAliasCreateOrUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SubscriptionAliasCreateOrUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionAliasCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubscriptionAliasCreateOrUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Workload.HasValue)
            {
                writer.WritePropertyName("workload"u8);
                writer.WriteStringValue(Workload.Value.ToString());
            }
            if (BillingScope != null)
            {
                writer.WritePropertyName("billingScope"u8);
                writer.WriteStringValue(BillingScope);
            }
            if (SubscriptionId != null)
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (ResellerId != null)
            {
                writer.WritePropertyName("resellerId"u8);
                writer.WriteStringValue(ResellerId);
            }
            if (AdditionalProperties != null)
            {
                writer.WritePropertyName("additionalProperties"u8);
                writer.WriteObjectValue(AdditionalProperties);
            }
            writer.WriteEndObject();
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

        SubscriptionAliasCreateOrUpdateContent IJsonModel<SubscriptionAliasCreateOrUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionAliasCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubscriptionAliasCreateOrUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSubscriptionAliasCreateOrUpdateContent(document.RootElement, options);
        }

        internal static SubscriptionAliasCreateOrUpdateContent DeserializeSubscriptionAliasCreateOrUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayName = default;
            Optional<SubscriptionWorkload> workload = default;
            Optional<string> billingScope = default;
            Optional<string> subscriptionId = default;
            Optional<string> resellerId = default;
            Optional<SubscriptionAliasAdditionalProperties> additionalProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("workload"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workload = new SubscriptionWorkload(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingScope"u8))
                        {
                            billingScope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subscriptionId"u8))
                        {
                            subscriptionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resellerId"u8))
                        {
                            resellerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("additionalProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            additionalProperties = SubscriptionAliasAdditionalProperties.DeserializeSubscriptionAliasAdditionalProperties(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SubscriptionAliasCreateOrUpdateContent(displayName.Value, Optional.ToNullable(workload), billingScope.Value, subscriptionId.Value, resellerId.Value, additionalProperties.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SubscriptionAliasCreateOrUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionAliasCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SubscriptionAliasCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        SubscriptionAliasCreateOrUpdateContent IPersistableModel<SubscriptionAliasCreateOrUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionAliasCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSubscriptionAliasCreateOrUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SubscriptionAliasCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SubscriptionAliasCreateOrUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
