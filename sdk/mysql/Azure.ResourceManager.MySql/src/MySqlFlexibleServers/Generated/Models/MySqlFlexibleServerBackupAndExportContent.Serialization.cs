// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerBackupAndExportContent : IUtf8JsonSerializable, IJsonModel<MySqlFlexibleServerBackupAndExportContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlFlexibleServerBackupAndExportContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MySqlFlexibleServerBackupAndExportContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerBackupAndExportContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerBackupAndExportContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("targetDetails"u8);
            writer.WriteObjectValue(TargetDetails);
            writer.WritePropertyName("backupSettings"u8);
            writer.WriteObjectValue(BackupSettings);
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

        MySqlFlexibleServerBackupAndExportContent IJsonModel<MySqlFlexibleServerBackupAndExportContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerBackupAndExportContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerBackupAndExportContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlFlexibleServerBackupAndExportContent(document.RootElement, options);
        }

        internal static MySqlFlexibleServerBackupAndExportContent DeserializeMySqlFlexibleServerBackupAndExportContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MySqlFlexibleServerBackupStoreDetails targetDetails = default;
            MySqlFlexibleServerBackupSettings backupSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetDetails"u8))
                {
                    targetDetails = MySqlFlexibleServerBackupStoreDetails.DeserializeMySqlFlexibleServerBackupStoreDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("backupSettings"u8))
                {
                    backupSettings = MySqlFlexibleServerBackupSettings.DeserializeMySqlFlexibleServerBackupSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MySqlFlexibleServerBackupAndExportContent(backupSettings, serializedAdditionalRawData, targetDetails);
        }

        BinaryData IPersistableModel<MySqlFlexibleServerBackupAndExportContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerBackupAndExportContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerBackupAndExportContent)} does not support '{options.Format}' format.");
            }
        }

        MySqlFlexibleServerBackupAndExportContent IPersistableModel<MySqlFlexibleServerBackupAndExportContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerBackupAndExportContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMySqlFlexibleServerBackupAndExportContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerBackupAndExportContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MySqlFlexibleServerBackupAndExportContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
