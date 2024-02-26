// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class AvsPrivateCloudClusterVirtualMachineRestrictMovement : IUtf8JsonSerializable, IJsonModel<AvsPrivateCloudClusterVirtualMachineRestrictMovement>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvsPrivateCloudClusterVirtualMachineRestrictMovement>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AvsPrivateCloudClusterVirtualMachineRestrictMovement>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsPrivateCloudClusterVirtualMachineRestrictMovement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvsPrivateCloudClusterVirtualMachineRestrictMovement)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (RestrictMovement.HasValue)
            {
                writer.WritePropertyName("restrictMovement"u8);
                writer.WriteStringValue(RestrictMovement.Value.ToString());
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

        AvsPrivateCloudClusterVirtualMachineRestrictMovement IJsonModel<AvsPrivateCloudClusterVirtualMachineRestrictMovement>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsPrivateCloudClusterVirtualMachineRestrictMovement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvsPrivateCloudClusterVirtualMachineRestrictMovement)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvsPrivateCloudClusterVirtualMachineRestrictMovement(document.RootElement, options);
        }

        internal static AvsPrivateCloudClusterVirtualMachineRestrictMovement DeserializeAvsPrivateCloudClusterVirtualMachineRestrictMovement(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<VirtualMachineRestrictMovementState> restrictMovement = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("restrictMovement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restrictMovement = new VirtualMachineRestrictMovementState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AvsPrivateCloudClusterVirtualMachineRestrictMovement(Optional.ToNullable(restrictMovement), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvsPrivateCloudClusterVirtualMachineRestrictMovement>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsPrivateCloudClusterVirtualMachineRestrictMovement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AvsPrivateCloudClusterVirtualMachineRestrictMovement)} does not support '{options.Format}' format.");
            }
        }

        AvsPrivateCloudClusterVirtualMachineRestrictMovement IPersistableModel<AvsPrivateCloudClusterVirtualMachineRestrictMovement>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsPrivateCloudClusterVirtualMachineRestrictMovement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAvsPrivateCloudClusterVirtualMachineRestrictMovement(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvsPrivateCloudClusterVirtualMachineRestrictMovement)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvsPrivateCloudClusterVirtualMachineRestrictMovement>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
