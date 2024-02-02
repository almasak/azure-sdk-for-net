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

namespace Azure.Developer.DevCenter.Models
{
    public partial class DevCenterEnvironment : IUtf8JsonSerializable, IJsonModel<DevCenterEnvironment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevCenterEnvironment>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevCenterEnvironment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterEnvironment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevCenterEnvironment)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteBase64StringValue(Parameters.ToArray(), "D");
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("environmentType"u8);
            writer.WriteStringValue(EnvironmentTypeName);
            if (options.Format != "W" && Optional.IsDefined(UserId))
            {
                writer.WritePropertyName("user"u8);
                writer.WriteStringValue(UserId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceGroupId))
            {
                writer.WritePropertyName("resourceGroupId"u8);
                writer.WriteStringValue(ResourceGroupId);
            }
            writer.WritePropertyName("catalogName"u8);
            writer.WriteStringValue(CatalogName);
            writer.WritePropertyName("environmentDefinitionName"u8);
            writer.WriteStringValue(EnvironmentDefinitionName);
            if (options.Format != "W" && Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                JsonSerializer.Serialize(writer, Error);
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

        DevCenterEnvironment IJsonModel<DevCenterEnvironment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterEnvironment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevCenterEnvironment)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevCenterEnvironment(document.RootElement, options);
        }

        internal static DevCenterEnvironment DeserializeDevCenterEnvironment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BinaryData> parameters = default;
            string name = default;
            string environmentType = default;
            Optional<Guid> user = default;
            Optional<EnvironmentProvisioningState> provisioningState = default;
            Optional<ResourceIdentifier> resourceGroupId = default;
            string catalogName = default;
            string environmentDefinitionName = default;
            Optional<ResponseError> error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = BinaryData.FromBytes(property.Value.GetBytesFromBase64("D"));
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentType"u8))
                {
                    environmentType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("user"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    user = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new EnvironmentProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("catalogName"u8))
                {
                    catalogName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentDefinitionName"u8))
                {
                    environmentDefinitionName = property.Value.GetString();
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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevCenterEnvironment(parameters.Value, name, environmentType, Optional.ToNullable(user), Optional.ToNullable(provisioningState), resourceGroupId.Value, catalogName, environmentDefinitionName, error.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevCenterEnvironment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterEnvironment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevCenterEnvironment)} does not support '{options.Format}' format.");
            }
        }

        DevCenterEnvironment IPersistableModel<DevCenterEnvironment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterEnvironment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevCenterEnvironment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevCenterEnvironment)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevCenterEnvironment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DevCenterEnvironment FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDevCenterEnvironment(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
