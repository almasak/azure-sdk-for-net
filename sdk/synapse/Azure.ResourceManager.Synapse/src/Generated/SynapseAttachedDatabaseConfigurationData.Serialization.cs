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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseAttachedDatabaseConfigurationData : IUtf8JsonSerializable, IJsonModel<SynapseAttachedDatabaseConfigurationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseAttachedDatabaseConfigurationData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseAttachedDatabaseConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseAttachedDatabaseConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseAttachedDatabaseConfigurationData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Location.HasValue)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
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
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (DatabaseName != null)
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (KustoPoolResourceId != null)
            {
                writer.WritePropertyName("clusterResourceId"u8);
                writer.WriteStringValue(KustoPoolResourceId);
            }
            if (options.Format != "W" && !(AttachedDatabaseNames is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("attachedDatabaseNames"u8);
                writer.WriteStartArray();
                foreach (var item in AttachedDatabaseNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (DefaultPrincipalsModificationKind.HasValue)
            {
                writer.WritePropertyName("defaultPrincipalsModificationKind"u8);
                writer.WriteStringValue(DefaultPrincipalsModificationKind.Value.ToString());
            }
            if (TableLevelSharingProperties != null)
            {
                writer.WritePropertyName("tableLevelSharingProperties"u8);
                writer.WriteObjectValue(TableLevelSharingProperties);
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

        SynapseAttachedDatabaseConfigurationData IJsonModel<SynapseAttachedDatabaseConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseAttachedDatabaseConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseAttachedDatabaseConfigurationData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseAttachedDatabaseConfigurationData(document.RootElement, options);
        }

        internal static SynapseAttachedDatabaseConfigurationData DeserializeSynapseAttachedDatabaseConfigurationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ResourceProvisioningState> provisioningState = default;
            Optional<string> databaseName = default;
            Optional<ResourceIdentifier> clusterResourceId = default;
            IReadOnlyList<string> attachedDatabaseNames = default;
            Optional<SynapseDefaultPrincipalsModificationKind> defaultPrincipalsModificationKind = default;
            Optional<SynapseTableLevelSharingProperties> tableLevelSharingProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ResourceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("databaseName"u8))
                        {
                            databaseName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("attachedDatabaseNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            attachedDatabaseNames = array;
                            continue;
                        }
                        if (property0.NameEquals("defaultPrincipalsModificationKind"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultPrincipalsModificationKind = new SynapseDefaultPrincipalsModificationKind(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tableLevelSharingProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tableLevelSharingProperties = SynapseTableLevelSharingProperties.DeserializeSynapseTableLevelSharingProperties(property0.Value, options);
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
            return new SynapseAttachedDatabaseConfigurationData(
                id,
                name,
                type,
                systemData.Value,
                Optional.ToNullable(location),
                Optional.ToNullable(provisioningState),
                databaseName.Value,
                clusterResourceId.Value,
                attachedDatabaseNames ?? new ChangeTrackingList<string>(),
                Optional.ToNullable(defaultPrincipalsModificationKind),
                tableLevelSharingProperties.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseAttachedDatabaseConfigurationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseAttachedDatabaseConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseAttachedDatabaseConfigurationData)} does not support '{options.Format}' format.");
            }
        }

        SynapseAttachedDatabaseConfigurationData IPersistableModel<SynapseAttachedDatabaseConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseAttachedDatabaseConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseAttachedDatabaseConfigurationData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseAttachedDatabaseConfigurationData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseAttachedDatabaseConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
