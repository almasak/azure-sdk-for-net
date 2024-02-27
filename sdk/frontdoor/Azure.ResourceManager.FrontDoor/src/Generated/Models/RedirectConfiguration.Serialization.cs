// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class RedirectConfiguration : IUtf8JsonSerializable, IJsonModel<RedirectConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedirectConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RedirectConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedirectConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedirectConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (RedirectType.HasValue)
            {
                writer.WritePropertyName("redirectType"u8);
                writer.WriteStringValue(RedirectType.Value.ToString());
            }
            if (RedirectProtocol.HasValue)
            {
                writer.WritePropertyName("redirectProtocol"u8);
                writer.WriteStringValue(RedirectProtocol.Value.ToString());
            }
            if (CustomHost != null)
            {
                writer.WritePropertyName("customHost"u8);
                writer.WriteStringValue(CustomHost);
            }
            if (CustomPath != null)
            {
                writer.WritePropertyName("customPath"u8);
                writer.WriteStringValue(CustomPath);
            }
            if (CustomFragment != null)
            {
                writer.WritePropertyName("customFragment"u8);
                writer.WriteStringValue(CustomFragment);
            }
            if (CustomQueryString != null)
            {
                writer.WritePropertyName("customQueryString"u8);
                writer.WriteStringValue(CustomQueryString);
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        RedirectConfiguration IJsonModel<RedirectConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedirectConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedirectConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedirectConfiguration(document.RootElement, options);
        }

        internal static RedirectConfiguration DeserializeRedirectConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<FrontDoorRedirectType> redirectType = default;
            Optional<FrontDoorRedirectProtocol> redirectProtocol = default;
            Optional<string> customHost = default;
            Optional<string> customPath = default;
            Optional<string> customFragment = default;
            Optional<string> customQueryString = default;
            string odataType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("redirectType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    redirectType = new FrontDoorRedirectType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("redirectProtocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    redirectProtocol = new FrontDoorRedirectProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customHost"u8))
                {
                    customHost = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customPath"u8))
                {
                    customPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customFragment"u8))
                {
                    customFragment = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customQueryString"u8))
                {
                    customQueryString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RedirectConfiguration(
                odataType,
                serializedAdditionalRawData,
                Optional.ToNullable(redirectType),
                Optional.ToNullable(redirectProtocol),
                customHost.Value,
                customPath.Value,
                customFragment.Value,
                customQueryString.Value);
        }

        BinaryData IPersistableModel<RedirectConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedirectConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RedirectConfiguration)} does not support '{options.Format}' format.");
            }
        }

        RedirectConfiguration IPersistableModel<RedirectConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedirectConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRedirectConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RedirectConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RedirectConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
