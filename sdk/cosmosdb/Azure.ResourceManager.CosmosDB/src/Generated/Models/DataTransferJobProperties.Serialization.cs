// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class DataTransferJobProperties : IUtf8JsonSerializable, IJsonModel<DataTransferJobProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataTransferJobProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataTransferJobProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataTransferJobProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataTransferJobProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && JobName != null)
            {
                writer.WritePropertyName("jobName"u8);
                writer.WriteStringValue(JobName);
            }
            writer.WritePropertyName("source"u8);
            writer.WriteObjectValue(Source);
            writer.WritePropertyName("destination"u8);
            writer.WriteObjectValue(Destination);
            if (options.Format != "W" && Status != null)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (options.Format != "W" && ProcessedCount.HasValue)
            {
                writer.WritePropertyName("processedCount"u8);
                writer.WriteNumberValue(ProcessedCount.Value);
            }
            if (options.Format != "W" && TotalCount.HasValue)
            {
                writer.WritePropertyName("totalCount"u8);
                writer.WriteNumberValue(TotalCount.Value);
            }
            if (options.Format != "W" && LastUpdatedUtcOn.HasValue)
            {
                writer.WritePropertyName("lastUpdatedUtcTime"u8);
                writer.WriteStringValue(LastUpdatedUtcOn.Value, "O");
            }
            if (WorkerCount.HasValue)
            {
                writer.WritePropertyName("workerCount"u8);
                writer.WriteNumberValue(WorkerCount.Value);
            }
            if (options.Format != "W" && Error != null)
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
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

        DataTransferJobProperties IJsonModel<DataTransferJobProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataTransferJobProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataTransferJobProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataTransferJobProperties(document.RootElement, options);
        }

        internal static DataTransferJobProperties DeserializeDataTransferJobProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> jobName = default;
            DataTransferDataSourceSink source = default;
            DataTransferDataSourceSink destination = default;
            Optional<string> status = default;
            Optional<long> processedCount = default;
            Optional<long> totalCount = default;
            Optional<DateTimeOffset> lastUpdatedUtcTime = default;
            Optional<int> workerCount = default;
            Optional<ErrorResponse> error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobName"u8))
                {
                    jobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = DataTransferDataSourceSink.DeserializeDataTransferDataSourceSink(property.Value, options);
                    continue;
                }
                if (property.NameEquals("destination"u8))
                {
                    destination = DataTransferDataSourceSink.DeserializeDataTransferDataSourceSink(property.Value, options);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("processedCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processedCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastUpdatedUtcTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedUtcTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("workerCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workerCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = ErrorResponse.DeserializeErrorResponse(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataTransferJobProperties(
                jobName.Value,
                source,
                destination,
                status.Value,
                Optional.ToNullable(processedCount),
                Optional.ToNullable(totalCount),
                Optional.ToNullable(lastUpdatedUtcTime),
                Optional.ToNullable(workerCount),
                error.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataTransferJobProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataTransferJobProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataTransferJobProperties)} does not support '{options.Format}' format.");
            }
        }

        DataTransferJobProperties IPersistableModel<DataTransferJobProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataTransferJobProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataTransferJobProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataTransferJobProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataTransferJobProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
