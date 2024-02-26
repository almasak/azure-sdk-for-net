// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class WorkloadAutoProtectionIntent : IUtf8JsonSerializable, IJsonModel<WorkloadAutoProtectionIntent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkloadAutoProtectionIntent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WorkloadAutoProtectionIntent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadAutoProtectionIntent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadAutoProtectionIntent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("protectionIntentItemType"u8);
            writer.WriteStringValue(ProtectionIntentItemType.ToString());
            if (BackupManagementType.HasValue)
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (SourceResourceId != null)
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (ItemId != null)
            {
                writer.WritePropertyName("itemId"u8);
                writer.WriteStringValue(ItemId);
            }
            if (PolicyId != null)
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (ProtectionState.HasValue)
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState.Value.ToString());
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

        WorkloadAutoProtectionIntent IJsonModel<WorkloadAutoProtectionIntent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadAutoProtectionIntent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadAutoProtectionIntent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadAutoProtectionIntent(document.RootElement, options);
        }

        internal static WorkloadAutoProtectionIntent DeserializeWorkloadAutoProtectionIntent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("protectionIntentItemType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureWorkloadSQLAutoProtectionIntent": return WorkloadSqlAutoProtectionIntent.DeserializeWorkloadSqlAutoProtectionIntent(element, options);
                }
            }
            ProtectionIntentItemType protectionIntentItemType = "AutoRest.CSharp.Output.Models.Types.EnumTypeValue";
            Optional<BackupManagementType> backupManagementType = default;
            Optional<ResourceIdentifier> sourceResourceId = default;
            Optional<ResourceIdentifier> itemId = default;
            Optional<ResourceIdentifier> policyId = default;
            Optional<BackupProtectionStatus> protectionState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectionIntentItemType"u8))
                {
                    protectionIntentItemType = new ProtectionIntentItemType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupManagementType = new BackupManagementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("itemId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    itemId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionState = new BackupProtectionStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WorkloadAutoProtectionIntent(protectionIntentItemType, Optional.ToNullable(backupManagementType), sourceResourceId.Value, itemId.Value, policyId.Value, Optional.ToNullable(protectionState), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WorkloadAutoProtectionIntent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadAutoProtectionIntent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkloadAutoProtectionIntent)} does not support '{options.Format}' format.");
            }
        }

        WorkloadAutoProtectionIntent IPersistableModel<WorkloadAutoProtectionIntent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadAutoProtectionIntent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkloadAutoProtectionIntent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkloadAutoProtectionIntent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkloadAutoProtectionIntent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
