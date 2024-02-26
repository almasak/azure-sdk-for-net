// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class StorageSyncServerEndpointPatch : IUtf8JsonSerializable, IJsonModel<StorageSyncServerEndpointPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageSyncServerEndpointPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageSyncServerEndpointPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncServerEndpointPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageSyncServerEndpointPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (CloudTiering.HasValue)
            {
                writer.WritePropertyName("cloudTiering"u8);
                writer.WriteStringValue(CloudTiering.Value.ToString());
            }
            if (VolumeFreeSpacePercent.HasValue)
            {
                writer.WritePropertyName("volumeFreeSpacePercent"u8);
                writer.WriteNumberValue(VolumeFreeSpacePercent.Value);
            }
            if (TierFilesOlderThanDays.HasValue)
            {
                writer.WritePropertyName("tierFilesOlderThanDays"u8);
                writer.WriteNumberValue(TierFilesOlderThanDays.Value);
            }
            if (OfflineDataTransfer.HasValue)
            {
                writer.WritePropertyName("offlineDataTransfer"u8);
                writer.WriteStringValue(OfflineDataTransfer.Value.ToString());
            }
            if (OfflineDataTransferShareName != null)
            {
                writer.WritePropertyName("offlineDataTransferShareName"u8);
                writer.WriteStringValue(OfflineDataTransferShareName);
            }
            if (LocalCacheMode.HasValue)
            {
                writer.WritePropertyName("localCacheMode"u8);
                writer.WriteStringValue(LocalCacheMode.Value.ToString());
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

        StorageSyncServerEndpointPatch IJsonModel<StorageSyncServerEndpointPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncServerEndpointPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageSyncServerEndpointPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageSyncServerEndpointPatch(document.RootElement, options);
        }

        internal static StorageSyncServerEndpointPatch DeserializeStorageSyncServerEndpointPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StorageSyncFeatureStatus> cloudTiering = default;
            Optional<int> volumeFreeSpacePercent = default;
            Optional<int> tierFilesOlderThanDays = default;
            Optional<StorageSyncFeatureStatus> offlineDataTransfer = default;
            Optional<string> offlineDataTransferShareName = default;
            Optional<LocalCacheMode> localCacheMode = default;
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
                        if (property0.NameEquals("cloudTiering"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cloudTiering = new StorageSyncFeatureStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("volumeFreeSpacePercent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            volumeFreeSpacePercent = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("tierFilesOlderThanDays"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tierFilesOlderThanDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("offlineDataTransfer"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            offlineDataTransfer = new StorageSyncFeatureStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("offlineDataTransferShareName"u8))
                        {
                            offlineDataTransferShareName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("localCacheMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            localCacheMode = new LocalCacheMode(property0.Value.GetString());
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
            return new StorageSyncServerEndpointPatch(Optional.ToNullable(cloudTiering), Optional.ToNullable(volumeFreeSpacePercent), Optional.ToNullable(tierFilesOlderThanDays), Optional.ToNullable(offlineDataTransfer), offlineDataTransferShareName.Value, Optional.ToNullable(localCacheMode), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageSyncServerEndpointPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncServerEndpointPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageSyncServerEndpointPatch)} does not support '{options.Format}' format.");
            }
        }

        StorageSyncServerEndpointPatch IPersistableModel<StorageSyncServerEndpointPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncServerEndpointPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageSyncServerEndpointPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageSyncServerEndpointPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageSyncServerEndpointPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
