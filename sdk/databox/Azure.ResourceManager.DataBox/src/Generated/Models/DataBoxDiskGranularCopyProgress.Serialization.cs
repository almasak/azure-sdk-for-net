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

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxDiskGranularCopyProgress : IUtf8JsonSerializable, IJsonModel<DataBoxDiskGranularCopyProgress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxDiskGranularCopyProgress>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxDiskGranularCopyProgress>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxDiskGranularCopyProgress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxDiskGranularCopyProgress)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && SerialNumber != null)
            {
                writer.WritePropertyName("serialNumber"u8);
                writer.WriteStringValue(SerialNumber);
            }
            if (options.Format != "W" && CopyStatus.HasValue)
            {
                writer.WritePropertyName("copyStatus"u8);
                writer.WriteStringValue(CopyStatus.Value.ToString());
            }
            if (options.Format != "W" && StorageAccountName != null)
            {
                writer.WritePropertyName("storageAccountName"u8);
                writer.WriteStringValue(StorageAccountName);
            }
            if (options.Format != "W" && TransferType.HasValue)
            {
                writer.WritePropertyName("transferType"u8);
                writer.WriteStringValue(TransferType.Value.ToSerialString());
            }
            if (options.Format != "W" && DataAccountType.HasValue)
            {
                writer.WritePropertyName("dataAccountType"u8);
                writer.WriteStringValue(DataAccountType.Value.ToSerialString());
            }
            if (options.Format != "W" && AccountId != null)
            {
                writer.WritePropertyName("accountId"u8);
                writer.WriteStringValue(AccountId);
            }
            if (options.Format != "W" && BytesProcessed.HasValue)
            {
                writer.WritePropertyName("bytesProcessed"u8);
                writer.WriteNumberValue(BytesProcessed.Value);
            }
            if (options.Format != "W" && TotalBytesToProcess.HasValue)
            {
                writer.WritePropertyName("totalBytesToProcess"u8);
                writer.WriteNumberValue(TotalBytesToProcess.Value);
            }
            if (options.Format != "W" && FilesProcessed.HasValue)
            {
                writer.WritePropertyName("filesProcessed"u8);
                writer.WriteNumberValue(FilesProcessed.Value);
            }
            if (options.Format != "W" && TotalFilesToProcess.HasValue)
            {
                writer.WritePropertyName("totalFilesToProcess"u8);
                writer.WriteNumberValue(TotalFilesToProcess.Value);
            }
            if (options.Format != "W" && InvalidFilesProcessed.HasValue)
            {
                writer.WritePropertyName("invalidFilesProcessed"u8);
                writer.WriteNumberValue(InvalidFilesProcessed.Value);
            }
            if (options.Format != "W" && InvalidFileBytesUploaded.HasValue)
            {
                writer.WritePropertyName("invalidFileBytesUploaded"u8);
                writer.WriteNumberValue(InvalidFileBytesUploaded.Value);
            }
            if (options.Format != "W" && RenamedContainerCount.HasValue)
            {
                writer.WritePropertyName("renamedContainerCount"u8);
                writer.WriteNumberValue(RenamedContainerCount.Value);
            }
            if (options.Format != "W" && FilesErroredOut.HasValue)
            {
                writer.WritePropertyName("filesErroredOut"u8);
                writer.WriteNumberValue(FilesErroredOut.Value);
            }
            if (options.Format != "W" && DirectoriesErroredOut.HasValue)
            {
                writer.WritePropertyName("directoriesErroredOut"u8);
                writer.WriteNumberValue(DirectoriesErroredOut.Value);
            }
            if (options.Format != "W" && InvalidDirectoriesProcessed.HasValue)
            {
                writer.WritePropertyName("invalidDirectoriesProcessed"u8);
                writer.WriteNumberValue(InvalidDirectoriesProcessed.Value);
            }
            if (options.Format != "W" && IsEnumerationInProgress.HasValue)
            {
                writer.WritePropertyName("isEnumerationInProgress"u8);
                writer.WriteBooleanValue(IsEnumerationInProgress.Value);
            }
            if (options.Format != "W" && Error != null)
            {
                writer.WritePropertyName("error"u8);
                JsonSerializer.Serialize(writer, Error);
            }
            if (options.Format != "W" && !(Actions is ChangeTrackingList<CustomerResolutionCode> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("actions"u8);
                writer.WriteStartArray();
                foreach (var item in Actions)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
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

        DataBoxDiskGranularCopyProgress IJsonModel<DataBoxDiskGranularCopyProgress>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxDiskGranularCopyProgress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxDiskGranularCopyProgress)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxDiskGranularCopyProgress(document.RootElement, options);
        }

        internal static DataBoxDiskGranularCopyProgress DeserializeDataBoxDiskGranularCopyProgress(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> serialNumber = default;
            Optional<DataBoxCopyStatus> copyStatus = default;
            Optional<string> storageAccountName = default;
            Optional<DataBoxJobTransferType> transferType = default;
            Optional<DataAccountType> dataAccountType = default;
            Optional<ResourceIdentifier> accountId = default;
            Optional<long> bytesProcessed = default;
            Optional<long> totalBytesToProcess = default;
            Optional<long> filesProcessed = default;
            Optional<long> totalFilesToProcess = default;
            Optional<long> invalidFilesProcessed = default;
            Optional<long> invalidFileBytesUploaded = default;
            Optional<long> renamedContainerCount = default;
            Optional<long> filesErroredOut = default;
            Optional<long> directoriesErroredOut = default;
            Optional<long> invalidDirectoriesProcessed = default;
            Optional<bool> isEnumerationInProgress = default;
            Optional<ResponseError> error = default;
            IReadOnlyList<CustomerResolutionCode> actions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serialNumber"u8))
                {
                    serialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("copyStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copyStatus = new DataBoxCopyStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountName"u8))
                {
                    storageAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transferType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transferType = property.Value.GetString().ToDataBoxJobTransferType();
                    continue;
                }
                if (property.NameEquals("dataAccountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataAccountType = property.Value.GetString().ToDataAccountType();
                    continue;
                }
                if (property.NameEquals("accountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("bytesProcessed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bytesProcessed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalBytesToProcess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalBytesToProcess = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("filesProcessed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filesProcessed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalFilesToProcess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalFilesToProcess = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("invalidFilesProcessed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    invalidFilesProcessed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("invalidFileBytesUploaded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    invalidFileBytesUploaded = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("renamedContainerCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    renamedContainerCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("filesErroredOut"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filesErroredOut = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("directoriesErroredOut"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    directoriesErroredOut = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("invalidDirectoriesProcessed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    invalidDirectoriesProcessed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("isEnumerationInProgress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEnumerationInProgress = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("actions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CustomerResolutionCode> array = new List<CustomerResolutionCode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToCustomerResolutionCode());
                    }
                    actions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxDiskGranularCopyProgress(storageAccountName.Value, Optional.ToNullable(transferType), Optional.ToNullable(dataAccountType), accountId.Value, Optional.ToNullable(bytesProcessed), Optional.ToNullable(totalBytesToProcess), Optional.ToNullable(filesProcessed), Optional.ToNullable(totalFilesToProcess), Optional.ToNullable(invalidFilesProcessed), Optional.ToNullable(invalidFileBytesUploaded), Optional.ToNullable(renamedContainerCount), Optional.ToNullable(filesErroredOut), Optional.ToNullable(directoriesErroredOut), Optional.ToNullable(invalidDirectoriesProcessed), Optional.ToNullable(isEnumerationInProgress), error.Value, actions ?? new ChangeTrackingList<CustomerResolutionCode>(), serializedAdditionalRawData, serialNumber.Value, Optional.ToNullable(copyStatus));
        }

        BinaryData IPersistableModel<DataBoxDiskGranularCopyProgress>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxDiskGranularCopyProgress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxDiskGranularCopyProgress)} does not support '{options.Format}' format.");
            }
        }

        DataBoxDiskGranularCopyProgress IPersistableModel<DataBoxDiskGranularCopyProgress>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxDiskGranularCopyProgress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxDiskGranularCopyProgress(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxDiskGranularCopyProgress)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxDiskGranularCopyProgress>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
