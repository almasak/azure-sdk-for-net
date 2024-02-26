// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformSkuRestrictions : IUtf8JsonSerializable, IJsonModel<AppPlatformSkuRestrictions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformSkuRestrictions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformSkuRestrictions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformSkuRestrictions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformSkuRestrictions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (RestrictionsType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(RestrictionsType.Value.ToString());
            }
            if (!(Values is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("values"u8);
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (RestrictionInfo != null)
            {
                writer.WritePropertyName("restrictionInfo"u8);
                writer.WriteObjectValue(RestrictionInfo);
            }
            if (ReasonCode.HasValue)
            {
                writer.WritePropertyName("reasonCode"u8);
                writer.WriteStringValue(ReasonCode.Value.ToString());
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

        AppPlatformSkuRestrictions IJsonModel<AppPlatformSkuRestrictions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformSkuRestrictions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformSkuRestrictions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformSkuRestrictions(document.RootElement, options);
        }

        internal static AppPlatformSkuRestrictions DeserializeAppPlatformSkuRestrictions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppPlatformSkuRestrictionsType> type = default;
            IReadOnlyList<string> values = default;
            Optional<AppPlatformSkuRestrictionInfo> restrictionInfo = default;
            Optional<AppPlatformSkuRestrictionsReasonCode> reasonCode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new AppPlatformSkuRestrictionsType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("restrictionInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restrictionInfo = AppPlatformSkuRestrictionInfo.DeserializeAppPlatformSkuRestrictionInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("reasonCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reasonCode = new AppPlatformSkuRestrictionsReasonCode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformSkuRestrictions(Optional.ToNullable(type), values ?? new ChangeTrackingList<string>(), restrictionInfo.Value, Optional.ToNullable(reasonCode), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformSkuRestrictions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformSkuRestrictions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformSkuRestrictions)} does not support '{options.Format}' format.");
            }
        }

        AppPlatformSkuRestrictions IPersistableModel<AppPlatformSkuRestrictions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformSkuRestrictions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformSkuRestrictions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformSkuRestrictions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformSkuRestrictions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
