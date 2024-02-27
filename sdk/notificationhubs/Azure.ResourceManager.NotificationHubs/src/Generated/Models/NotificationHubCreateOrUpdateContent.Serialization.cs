// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    public partial class NotificationHubCreateOrUpdateContent : IUtf8JsonSerializable, IJsonModel<NotificationHubCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NotificationHubCreateOrUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NotificationHubCreateOrUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationHubCreateOrUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (NotificationHubName != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(NotificationHubName);
            }
            if (RegistrationTtl.HasValue)
            {
                writer.WritePropertyName("registrationTtl"u8);
                writer.WriteStringValue(RegistrationTtl.Value, "c");
            }
            if (!(AuthorizationRules is ChangeTrackingList<SharedAccessAuthorizationRuleProperties> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("authorizationRules"u8);
                writer.WriteStartArray();
                foreach (var item in AuthorizationRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ApnsCredential != null)
            {
                writer.WritePropertyName("apnsCredential"u8);
                writer.WriteObjectValue(ApnsCredential);
            }
            if (WnsCredential != null)
            {
                writer.WritePropertyName("wnsCredential"u8);
                writer.WriteObjectValue(WnsCredential);
            }
            if (GcmCredential != null)
            {
                writer.WritePropertyName("gcmCredential"u8);
                writer.WriteObjectValue(GcmCredential);
            }
            if (MpnsCredential != null)
            {
                writer.WritePropertyName("mpnsCredential"u8);
                writer.WriteObjectValue(MpnsCredential);
            }
            if (AdmCredential != null)
            {
                writer.WritePropertyName("admCredential"u8);
                writer.WriteObjectValue(AdmCredential);
            }
            if (BaiduCredential != null)
            {
                writer.WritePropertyName("baiduCredential"u8);
                writer.WriteObjectValue(BaiduCredential);
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

        NotificationHubCreateOrUpdateContent IJsonModel<NotificationHubCreateOrUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationHubCreateOrUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNotificationHubCreateOrUpdateContent(document.RootElement, options);
        }

        internal static NotificationHubCreateOrUpdateContent DeserializeNotificationHubCreateOrUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NotificationHubSku> sku = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> name0 = default;
            Optional<TimeSpan> registrationTtl = default;
            IList<SharedAccessAuthorizationRuleProperties> authorizationRules = default;
            Optional<NotificationHubApnsCredential> apnsCredential = default;
            Optional<NotificationHubWnsCredential> wnsCredential = default;
            Optional<NotificationHubGcmCredential> gcmCredential = default;
            Optional<NotificationHubMpnsCredential> mpnsCredential = default;
            Optional<NotificationHubAdmCredential> admCredential = default;
            Optional<NotificationHubBaiduCredential> baiduCredential = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = NotificationHubSku.DeserializeNotificationHubSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("name"u8))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("registrationTtl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            registrationTtl = property0.Value.GetTimeSpan("c");
                            continue;
                        }
                        if (property0.NameEquals("authorizationRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SharedAccessAuthorizationRuleProperties> array = new List<SharedAccessAuthorizationRuleProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SharedAccessAuthorizationRuleProperties.DeserializeSharedAccessAuthorizationRuleProperties(item, options));
                            }
                            authorizationRules = array;
                            continue;
                        }
                        if (property0.NameEquals("apnsCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            apnsCredential = NotificationHubApnsCredential.DeserializeNotificationHubApnsCredential(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("wnsCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            wnsCredential = NotificationHubWnsCredential.DeserializeNotificationHubWnsCredential(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("gcmCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            gcmCredential = NotificationHubGcmCredential.DeserializeNotificationHubGcmCredential(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("mpnsCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mpnsCredential = NotificationHubMpnsCredential.DeserializeNotificationHubMpnsCredential(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("admCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            admCredential = NotificationHubAdmCredential.DeserializeNotificationHubAdmCredential(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("baiduCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            baiduCredential = NotificationHubBaiduCredential.DeserializeNotificationHubBaiduCredential(property0.Value, options);
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
            return new NotificationHubCreateOrUpdateContent(
                id,
                name,
                type,
                systemData.Value,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                name0.Value,
                Optional.ToNullable(registrationTtl),
                authorizationRules ?? new ChangeTrackingList<SharedAccessAuthorizationRuleProperties>(),
                apnsCredential.Value,
                wnsCredential.Value,
                gcmCredential.Value,
                mpnsCredential.Value,
                admCredential.Value,
                baiduCredential.Value,
                sku.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NotificationHubCreateOrUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NotificationHubCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        NotificationHubCreateOrUpdateContent IPersistableModel<NotificationHubCreateOrUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNotificationHubCreateOrUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NotificationHubCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NotificationHubCreateOrUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
