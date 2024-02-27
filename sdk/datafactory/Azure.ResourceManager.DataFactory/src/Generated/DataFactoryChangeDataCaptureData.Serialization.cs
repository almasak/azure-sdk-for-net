// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataFactory.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataFactory
{
    public partial class DataFactoryChangeDataCaptureData : IUtf8JsonSerializable, IJsonModel<DataFactoryChangeDataCaptureData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryChangeDataCaptureData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataFactoryChangeDataCaptureData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryChangeDataCaptureData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryChangeDataCaptureData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
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
            if (Folder != null)
            {
                writer.WritePropertyName("folder"u8);
                writer.WriteObjectValue(Folder);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("sourceConnectionsInfo"u8);
            writer.WriteStartArray();
            foreach (var item in SourceConnectionsInfo)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("targetConnectionsInfo"u8);
            writer.WriteStartArray();
            foreach (var item in TargetConnectionsInfo)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("policy"u8);
            writer.WriteObjectValue(Policy);
            if (AllowVnetOverride.HasValue)
            {
                writer.WritePropertyName("allowVNetOverride"u8);
                writer.WriteBooleanValue(AllowVnetOverride.Value);
            }
            if (Status != null)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        DataFactoryChangeDataCaptureData IJsonModel<DataFactoryChangeDataCaptureData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryChangeDataCaptureData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryChangeDataCaptureData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryChangeDataCaptureData(document.RootElement, options);
        }

        internal static DataFactoryChangeDataCaptureData DeserializeDataFactoryChangeDataCaptureData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ChangeDataCaptureFolder> folder = default;
            Optional<string> description = default;
            IList<MapperSourceConnectionsInfo> sourceConnectionsInfo = default;
            IList<MapperTargetConnectionsInfo> targetConnectionsInfo = default;
            MapperPolicy policy = default;
            Optional<bool> allowVnetOverride = default;
            Optional<string> status = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("folder"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            folder = ChangeDataCaptureFolder.DeserializeChangeDataCaptureFolder(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceConnectionsInfo"u8))
                        {
                            List<MapperSourceConnectionsInfo> array = new List<MapperSourceConnectionsInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MapperSourceConnectionsInfo.DeserializeMapperSourceConnectionsInfo(item, options));
                            }
                            sourceConnectionsInfo = array;
                            continue;
                        }
                        if (property0.NameEquals("targetConnectionsInfo"u8))
                        {
                            List<MapperTargetConnectionsInfo> array = new List<MapperTargetConnectionsInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MapperTargetConnectionsInfo.DeserializeMapperTargetConnectionsInfo(item, options));
                            }
                            targetConnectionsInfo = array;
                            continue;
                        }
                        if (property0.NameEquals("policy"u8))
                        {
                            policy = MapperPolicy.DeserializeMapperPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("allowVNetOverride"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowVnetOverride = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            status = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFactoryChangeDataCaptureData(
                id,
                name,
                type,
                systemData.Value,
                folder.Value,
                description.Value,
                sourceConnectionsInfo,
                targetConnectionsInfo,
                policy,
                Optional.ToNullable(allowVnetOverride),
                status.Value,
                Optional.ToNullable(etag),
                additionalProperties);
        }

        BinaryData IPersistableModel<DataFactoryChangeDataCaptureData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryChangeDataCaptureData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFactoryChangeDataCaptureData)} does not support '{options.Format}' format.");
            }
        }

        DataFactoryChangeDataCaptureData IPersistableModel<DataFactoryChangeDataCaptureData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryChangeDataCaptureData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFactoryChangeDataCaptureData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFactoryChangeDataCaptureData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryChangeDataCaptureData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
