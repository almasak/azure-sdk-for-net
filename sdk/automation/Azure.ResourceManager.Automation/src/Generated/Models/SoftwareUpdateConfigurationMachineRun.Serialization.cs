// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class SoftwareUpdateConfigurationMachineRun : IUtf8JsonSerializable, IJsonModel<SoftwareUpdateConfigurationMachineRun>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SoftwareUpdateConfigurationMachineRun>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SoftwareUpdateConfigurationMachineRun>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationMachineRun>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationMachineRun)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && TargetComputerId != null)
            {
                writer.WritePropertyName("targetComputer"u8);
                writer.WriteStringValue(TargetComputerId);
            }
            if (options.Format != "W" && TargetComputerType != null)
            {
                writer.WritePropertyName("targetComputerType"u8);
                writer.WriteStringValue(TargetComputerType);
            }
            if (SoftwareUpdateConfiguration != null)
            {
                writer.WritePropertyName("softwareUpdateConfiguration"u8);
                writer.WriteObjectValue(SoftwareUpdateConfiguration);
            }
            if (options.Format != "W" && Status != null)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (options.Format != "W" && OSType != null)
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (options.Format != "W" && CorrelationId.HasValue)
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId.Value);
            }
            if (options.Format != "W" && SourceComputerId.HasValue)
            {
                writer.WritePropertyName("sourceComputerId"u8);
                writer.WriteStringValue(SourceComputerId.Value);
            }
            if (options.Format != "W" && StartOn.HasValue)
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && EndOn.HasValue)
            {
                if (EndOn != null)
                {
                    writer.WritePropertyName("endTime"u8);
                    writer.WriteStringValue(EndOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("endTime");
                }
            }
            if (options.Format != "W" && ConfiguredDuration.HasValue)
            {
                writer.WritePropertyName("configuredDuration"u8);
                writer.WriteStringValue(ConfiguredDuration.Value, "P");
            }
            if (Job != null)
            {
                writer.WritePropertyName("job"u8);
                writer.WriteObjectValue(Job);
            }
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && CreatedBy != null)
            {
                writer.WritePropertyName("createdBy"u8);
                writer.WriteStringValue(CreatedBy);
            }
            if (options.Format != "W" && LastModifiedOn.HasValue)
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (options.Format != "W" && LastModifiedBy != null)
            {
                writer.WritePropertyName("lastModifiedBy"u8);
                writer.WriteStringValue(LastModifiedBy);
            }
            if (Error != null)
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
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

        SoftwareUpdateConfigurationMachineRun IJsonModel<SoftwareUpdateConfigurationMachineRun>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationMachineRun>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationMachineRun)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSoftwareUpdateConfigurationMachineRun(document.RootElement, options);
        }

        internal static SoftwareUpdateConfigurationMachineRun DeserializeSoftwareUpdateConfigurationMachineRun(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<ResourceIdentifier> id = default;
            Optional<ResourceIdentifier> targetComputer = default;
            Optional<string> targetComputerType = default;
            Optional<SoftwareUpdateConfigurationNavigation> softwareUpdateConfiguration = default;
            Optional<string> status = default;
            Optional<string> osType = default;
            Optional<Guid> correlationId = default;
            Optional<Guid> sourceComputerId = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset?> endTime = default;
            Optional<TimeSpan> configuredDuration = default;
            Optional<JobNavigation> job = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<string> createdBy = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<string> lastModifiedBy = default;
            Optional<AutomationResponseError> error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
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
                        if (property0.NameEquals("targetComputer"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetComputer = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetComputerType"u8))
                        {
                            targetComputerType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("softwareUpdateConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            softwareUpdateConfiguration = SoftwareUpdateConfigurationNavigation.DeserializeSoftwareUpdateConfigurationNavigation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            status = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("osType"u8))
                        {
                            osType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("correlationId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            correlationId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("sourceComputerId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceComputerId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                endTime = null;
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("configuredDuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configuredDuration = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("job"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            job = JobNavigation.DeserializeJobNavigation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("createdBy"u8))
                        {
                            createdBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedBy"u8))
                        {
                            lastModifiedBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("error"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            error = AutomationResponseError.DeserializeAutomationResponseError(property0.Value, options);
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
            return new SoftwareUpdateConfigurationMachineRun(name.Value, id.Value, targetComputer.Value, targetComputerType.Value, softwareUpdateConfiguration.Value, status.Value, osType.Value, Optional.ToNullable(correlationId), Optional.ToNullable(sourceComputerId), Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(configuredDuration), job.Value, Optional.ToNullable(creationTime), createdBy.Value, Optional.ToNullable(lastModifiedTime), lastModifiedBy.Value, error.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SoftwareUpdateConfigurationMachineRun>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationMachineRun>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationMachineRun)} does not support '{options.Format}' format.");
            }
        }

        SoftwareUpdateConfigurationMachineRun IPersistableModel<SoftwareUpdateConfigurationMachineRun>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationMachineRun>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSoftwareUpdateConfigurationMachineRun(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationMachineRun)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SoftwareUpdateConfigurationMachineRun>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
