// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class FailoverProtectedItemProperties : IUtf8JsonSerializable, IJsonModel<FailoverProtectedItemProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FailoverProtectedItemProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FailoverProtectedItemProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverProtectedItemProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FailoverProtectedItemProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ProtectedItemName != null)
            {
                writer.WritePropertyName("protectedItemName"u8);
                writer.WriteStringValue(ProtectedItemName);
            }
            if (options.Format != "W" && VmName != null)
            {
                writer.WritePropertyName("vmName"u8);
                writer.WriteStringValue(VmName);
            }
            if (options.Format != "W" && TestVmName != null)
            {
                writer.WritePropertyName("testVmName"u8);
                writer.WriteStringValue(TestVmName);
            }
            if (options.Format != "W" && RecoveryPointId != null)
            {
                writer.WritePropertyName("recoveryPointId"u8);
                writer.WriteStringValue(RecoveryPointId);
            }
            if (options.Format != "W" && RecoveryPointOn.HasValue)
            {
                writer.WritePropertyName("recoveryPointTime"u8);
                writer.WriteStringValue(RecoveryPointOn.Value, "O");
            }
            if (options.Format != "W" && NetworkName != null)
            {
                writer.WritePropertyName("networkName"u8);
                writer.WriteStringValue(NetworkName);
            }
            if (options.Format != "W" && Subnet != null)
            {
                writer.WritePropertyName("subnet"u8);
                writer.WriteStringValue(Subnet);
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

        FailoverProtectedItemProperties IJsonModel<FailoverProtectedItemProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverProtectedItemProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FailoverProtectedItemProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFailoverProtectedItemProperties(document.RootElement, options);
        }

        internal static FailoverProtectedItemProperties DeserializeFailoverProtectedItemProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> protectedItemName = default;
            Optional<string> vmName = default;
            Optional<string> testVmName = default;
            Optional<string> recoveryPointId = default;
            Optional<DateTimeOffset> recoveryPointTime = default;
            Optional<string> networkName = default;
            Optional<string> subnet = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectedItemName"u8))
                {
                    protectedItemName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmName"u8))
                {
                    vmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testVmName"u8))
                {
                    testVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryPointId"u8))
                {
                    recoveryPointId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryPointTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("networkName"u8))
                {
                    networkName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnet"u8))
                {
                    subnet = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FailoverProtectedItemProperties(protectedItemName.Value, vmName.Value, testVmName.Value, recoveryPointId.Value, Optional.ToNullable(recoveryPointTime), networkName.Value, subnet.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FailoverProtectedItemProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverProtectedItemProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FailoverProtectedItemProperties)} does not support '{options.Format}' format.");
            }
        }

        FailoverProtectedItemProperties IPersistableModel<FailoverProtectedItemProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverProtectedItemProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFailoverProtectedItemProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FailoverProtectedItemProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FailoverProtectedItemProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
