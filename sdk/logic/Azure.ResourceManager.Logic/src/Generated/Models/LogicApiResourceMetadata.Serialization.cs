// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicApiResourceMetadata : IUtf8JsonSerializable, IJsonModel<LogicApiResourceMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicApiResourceMetadata>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogicApiResourceMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiResourceMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicApiResourceMetadata)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Source != null)
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (BrandColor != null)
            {
                writer.WritePropertyName("brandColor"u8);
                writer.WriteStringValue(BrandColor);
            }
            if (HideKey != null)
            {
                writer.WritePropertyName("hideKey"u8);
                writer.WriteStringValue(HideKey);
            }
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
            if (ApiType.HasValue)
            {
                writer.WritePropertyName("ApiType"u8);
                writer.WriteStringValue(ApiType.Value.ToString());
            }
            if (WsdlService != null)
            {
                writer.WritePropertyName("wsdlService"u8);
                writer.WriteObjectValue(WsdlService);
            }
            if (WsdlImportMethod.HasValue)
            {
                writer.WritePropertyName("wsdlImportMethod"u8);
                writer.WriteStringValue(WsdlImportMethod.Value.ToString());
            }
            if (ConnectionType != null)
            {
                writer.WritePropertyName("connectionType"u8);
                writer.WriteStringValue(ConnectionType);
            }
            if (ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (DeploymentParameters != null)
            {
                writer.WritePropertyName("deploymentParameters"u8);
                writer.WriteObjectValue(DeploymentParameters);
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

        LogicApiResourceMetadata IJsonModel<LogicApiResourceMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiResourceMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicApiResourceMetadata)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicApiResourceMetadata(document.RootElement, options);
        }

        internal static LogicApiResourceMetadata DeserializeLogicApiResourceMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> source = default;
            Optional<string> brandColor = default;
            Optional<string> hideKey = default;
            IReadOnlyDictionary<string, string> tags = default;
            Optional<LogicApiType> apiType = default;
            Optional<LogicWsdlService> wsdlService = default;
            Optional<LogicWsdlImportMethod> wsdlImportMethod = default;
            Optional<string> connectionType = default;
            Optional<LogicWorkflowProvisioningState> provisioningState = default;
            Optional<LogicApiDeploymentParameterMetadataSet> deploymentParameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("brandColor"u8))
                {
                    brandColor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hideKey"u8))
                {
                    hideKey = property.Value.GetString();
                    continue;
                }
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
                if (property.NameEquals("ApiType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    apiType = new LogicApiType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("wsdlService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wsdlService = LogicWsdlService.DeserializeLogicWsdlService(property.Value, options);
                    continue;
                }
                if (property.NameEquals("wsdlImportMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wsdlImportMethod = new LogicWsdlImportMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("connectionType"u8))
                {
                    connectionType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new LogicWorkflowProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deploymentParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deploymentParameters = LogicApiDeploymentParameterMetadataSet.DeserializeLogicApiDeploymentParameterMetadataSet(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogicApiResourceMetadata(source.Value, brandColor.Value, hideKey.Value, tags ?? new ChangeTrackingDictionary<string, string>(), Optional.ToNullable(apiType), wsdlService.Value, Optional.ToNullable(wsdlImportMethod), connectionType.Value, Optional.ToNullable(provisioningState), deploymentParameters.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LogicApiResourceMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiResourceMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogicApiResourceMetadata)} does not support '{options.Format}' format.");
            }
        }

        LogicApiResourceMetadata IPersistableModel<LogicApiResourceMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiResourceMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogicApiResourceMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogicApiResourceMetadata)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogicApiResourceMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
