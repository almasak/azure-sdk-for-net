// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class MarketplaceGalleryImageStatus : IUtf8JsonSerializable, IJsonModel<MarketplaceGalleryImageStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MarketplaceGalleryImageStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MarketplaceGalleryImageStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceGalleryImageStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MarketplaceGalleryImageStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ErrorCode != null)
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteStringValue(ErrorCode);
            }
            if (ErrorMessage != null)
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (ProvisioningStatus != null)
            {
                writer.WritePropertyName("provisioningStatus"u8);
                writer.WriteObjectValue(ProvisioningStatus);
            }
            if (DownloadStatus != null)
            {
                writer.WritePropertyName("downloadStatus"u8);
                writer.WriteObjectValue(DownloadStatus);
            }
            if (ProgressPercentage.HasValue)
            {
                writer.WritePropertyName("progressPercentage"u8);
                writer.WriteNumberValue(ProgressPercentage.Value);
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

        MarketplaceGalleryImageStatus IJsonModel<MarketplaceGalleryImageStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceGalleryImageStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MarketplaceGalleryImageStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMarketplaceGalleryImageStatus(document.RootElement, options);
        }

        internal static MarketplaceGalleryImageStatus DeserializeMarketplaceGalleryImageStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> errorCode = default;
            Optional<string> errorMessage = default;
            Optional<MarketplaceGalleryImageStatusProvisioningStatus> provisioningStatus = default;
            Optional<MarketplaceGalleryImageStatusDownloadStatus> downloadStatus = default;
            Optional<long> progressPercentage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorCode"u8))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningStatus = MarketplaceGalleryImageStatusProvisioningStatus.DeserializeMarketplaceGalleryImageStatusProvisioningStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("downloadStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    downloadStatus = MarketplaceGalleryImageStatusDownloadStatus.DeserializeMarketplaceGalleryImageStatusDownloadStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("progressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    progressPercentage = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MarketplaceGalleryImageStatus(
                errorCode.Value,
                errorMessage.Value,
                provisioningStatus.Value,
                downloadStatus.Value,
                Optional.ToNullable(progressPercentage),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MarketplaceGalleryImageStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceGalleryImageStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MarketplaceGalleryImageStatus)} does not support '{options.Format}' format.");
            }
        }

        MarketplaceGalleryImageStatus IPersistableModel<MarketplaceGalleryImageStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceGalleryImageStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMarketplaceGalleryImageStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MarketplaceGalleryImageStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MarketplaceGalleryImageStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
