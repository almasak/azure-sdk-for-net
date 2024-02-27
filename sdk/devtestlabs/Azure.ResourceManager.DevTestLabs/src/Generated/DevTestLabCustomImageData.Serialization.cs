// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabCustomImageData : IUtf8JsonSerializable, IJsonModel<DevTestLabCustomImageData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabCustomImageData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevTestLabCustomImageData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCustomImageData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabCustomImageData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Vm != null)
            {
                writer.WritePropertyName("vm"u8);
                writer.WriteObjectValue(Vm);
            }
            if (Vhd != null)
            {
                writer.WritePropertyName("vhd"u8);
                writer.WriteObjectValue(Vhd);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Author != null)
            {
                writer.WritePropertyName("author"u8);
                writer.WriteStringValue(Author);
            }
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                writer.WritePropertyName("creationDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (ManagedImageId != null)
            {
                writer.WritePropertyName("managedImageId"u8);
                writer.WriteStringValue(ManagedImageId);
            }
            if (ManagedSnapshotId != null)
            {
                writer.WritePropertyName("managedSnapshotId"u8);
                writer.WriteStringValue(ManagedSnapshotId);
            }
            if (!(DataDiskStorageInfo is ChangeTrackingList<DevTestLabDataDiskStorageTypeInfo> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("dataDiskStorageInfo"u8);
                writer.WriteStartArray();
                foreach (var item in DataDiskStorageInfo)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (CustomImagePlan != null)
            {
                writer.WritePropertyName("customImagePlan"u8);
                writer.WriteObjectValue(CustomImagePlan);
            }
            if (IsPlanAuthorized.HasValue)
            {
                writer.WritePropertyName("isPlanAuthorized"u8);
                writer.WriteBooleanValue(IsPlanAuthorized.Value);
            }
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && UniqueIdentifier.HasValue)
            {
                writer.WritePropertyName("uniqueIdentifier"u8);
                writer.WriteStringValue(UniqueIdentifier.Value);
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

        DevTestLabCustomImageData IJsonModel<DevTestLabCustomImageData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCustomImageData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabCustomImageData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabCustomImageData(document.RootElement, options);
        }

        internal static DevTestLabCustomImageData DeserializeDevTestLabCustomImageData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DevTestLabCustomImageVm> vm = default;
            Optional<DevTestLabCustomImageVhd> vhd = default;
            Optional<string> description = default;
            Optional<string> author = default;
            Optional<DateTimeOffset> creationDate = default;
            Optional<string> managedImageId = default;
            Optional<string> managedSnapshotId = default;
            IList<DevTestLabDataDiskStorageTypeInfo> dataDiskStorageInfo = default;
            Optional<DevTestLabCustomImagePlan> customImagePlan = default;
            Optional<bool> isPlanAuthorized = default;
            Optional<string> provisioningState = default;
            Optional<Guid> uniqueIdentifier = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("vm"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vm = DevTestLabCustomImageVm.DeserializeDevTestLabCustomImageVm(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("vhd"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vhd = DevTestLabCustomImageVhd.DeserializeDevTestLabCustomImageVhd(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("author"u8))
                        {
                            author = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("managedImageId"u8))
                        {
                            managedImageId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedSnapshotId"u8))
                        {
                            managedSnapshotId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataDiskStorageInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DevTestLabDataDiskStorageTypeInfo> array = new List<DevTestLabDataDiskStorageTypeInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabDataDiskStorageTypeInfo.DeserializeDevTestLabDataDiskStorageTypeInfo(item, options));
                            }
                            dataDiskStorageInfo = array;
                            continue;
                        }
                        if (property0.NameEquals("customImagePlan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customImagePlan = DevTestLabCustomImagePlan.DeserializeDevTestLabCustomImagePlan(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("isPlanAuthorized"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isPlanAuthorized = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uniqueIdentifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uniqueIdentifier = property0.Value.GetGuid();
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
            return new DevTestLabCustomImageData(
                id,
                name,
                type,
                systemData.Value,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                vm.Value,
                vhd.Value,
                description.Value,
                author.Value,
                Optional.ToNullable(creationDate),
                managedImageId.Value,
                managedSnapshotId.Value,
                dataDiskStorageInfo ?? new ChangeTrackingList<DevTestLabDataDiskStorageTypeInfo>(),
                customImagePlan.Value,
                Optional.ToNullable(isPlanAuthorized),
                provisioningState.Value,
                Optional.ToNullable(uniqueIdentifier),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabCustomImageData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCustomImageData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabCustomImageData)} does not support '{options.Format}' format.");
            }
        }

        DevTestLabCustomImageData IPersistableModel<DevTestLabCustomImageData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCustomImageData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabCustomImageData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabCustomImageData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabCustomImageData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
