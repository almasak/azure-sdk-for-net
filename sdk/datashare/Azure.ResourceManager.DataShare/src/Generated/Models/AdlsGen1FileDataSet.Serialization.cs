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

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class AdlsGen1FileDataSet : IUtf8JsonSerializable, IJsonModel<AdlsGen1FileDataSet>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AdlsGen1FileDataSet>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AdlsGen1FileDataSet>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdlsGen1FileDataSet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdlsGen1FileDataSet)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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
            writer.WritePropertyName("accountName"u8);
            writer.WriteStringValue(AccountName);
            if (options.Format != "W" && DataSetId.HasValue)
            {
                writer.WritePropertyName("dataSetId"u8);
                writer.WriteStringValue(DataSetId.Value);
            }
            writer.WritePropertyName("fileName"u8);
            writer.WriteStringValue(FileName);
            writer.WritePropertyName("folderPath"u8);
            writer.WriteStringValue(FolderPath);
            writer.WritePropertyName("resourceGroup"u8);
            writer.WriteStringValue(ResourceGroup);
            writer.WritePropertyName("subscriptionId"u8);
            writer.WriteStringValue(SubscriptionId);
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

        AdlsGen1FileDataSet IJsonModel<AdlsGen1FileDataSet>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdlsGen1FileDataSet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdlsGen1FileDataSet)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAdlsGen1FileDataSet(document.RootElement, options);
        }

        internal static AdlsGen1FileDataSet DeserializeAdlsGen1FileDataSet(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataSetKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            string accountName = default;
            Optional<Guid> dataSetId = default;
            string fileName = default;
            string folderPath = default;
            string resourceGroup = default;
            string subscriptionId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new DataSetKind(property.Value.GetString());
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
                        if (property0.NameEquals("accountName"u8))
                        {
                            accountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataSetId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataSetId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("fileName"u8))
                        {
                            fileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("folderPath"u8))
                        {
                            folderPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceGroup"u8))
                        {
                            resourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subscriptionId"u8))
                        {
                            subscriptionId = property0.Value.GetString();
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
            return new AdlsGen1FileDataSet(id, name, type, systemData.Value, kind, serializedAdditionalRawData, accountName, Optional.ToNullable(dataSetId), fileName, folderPath, resourceGroup, subscriptionId);
        }

        BinaryData IPersistableModel<AdlsGen1FileDataSet>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdlsGen1FileDataSet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AdlsGen1FileDataSet)} does not support '{options.Format}' format.");
            }
        }

        AdlsGen1FileDataSet IPersistableModel<AdlsGen1FileDataSet>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdlsGen1FileDataSet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAdlsGen1FileDataSet(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AdlsGen1FileDataSet)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AdlsGen1FileDataSet>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
