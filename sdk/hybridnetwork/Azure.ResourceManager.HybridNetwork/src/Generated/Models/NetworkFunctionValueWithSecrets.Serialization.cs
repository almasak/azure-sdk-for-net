// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class NetworkFunctionValueWithSecrets : IUtf8JsonSerializable, IJsonModel<NetworkFunctionValueWithSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkFunctionValueWithSecrets>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkFunctionValueWithSecrets>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFunctionValueWithSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkFunctionValueWithSecrets)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (SecretDeploymentValues != null)
            {
                writer.WritePropertyName("secretDeploymentValues"u8);
                writer.WriteStringValue(SecretDeploymentValues);
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && PublisherName != null)
            {
                writer.WritePropertyName("publisherName"u8);
                writer.WriteStringValue(PublisherName);
            }
            if (options.Format != "W" && PublisherScope.HasValue)
            {
                writer.WritePropertyName("publisherScope"u8);
                writer.WriteStringValue(PublisherScope.Value.ToString());
            }
            if (options.Format != "W" && NetworkFunctionDefinitionGroupName != null)
            {
                writer.WritePropertyName("networkFunctionDefinitionGroupName"u8);
                writer.WriteStringValue(NetworkFunctionDefinitionGroupName);
            }
            if (options.Format != "W" && NetworkFunctionDefinitionVersion != null)
            {
                writer.WritePropertyName("networkFunctionDefinitionVersion"u8);
                writer.WriteStringValue(NetworkFunctionDefinitionVersion);
            }
            if (options.Format != "W" && NetworkFunctionDefinitionOfferingLocation != null)
            {
                writer.WritePropertyName("networkFunctionDefinitionOfferingLocation"u8);
                writer.WriteStringValue(NetworkFunctionDefinitionOfferingLocation);
            }
            if (NetworkFunctionDefinitionVersionResourceReference != null)
            {
                writer.WritePropertyName("networkFunctionDefinitionVersionResourceReference"u8);
                writer.WriteObjectValue(NetworkFunctionDefinitionVersionResourceReference);
            }
            if (NfviType.HasValue)
            {
                writer.WritePropertyName("nfviType"u8);
                writer.WriteStringValue(NfviType.Value.ToString());
            }
            if (NfviId != null)
            {
                writer.WritePropertyName("nfviId"u8);
                writer.WriteStringValue(NfviId);
            }
            if (AllowSoftwareUpdate.HasValue)
            {
                writer.WritePropertyName("allowSoftwareUpdate"u8);
                writer.WriteBooleanValue(AllowSoftwareUpdate.Value);
            }
            writer.WritePropertyName("configurationType"u8);
            writer.WriteStringValue(ConfigurationType.ToString());
            if (!(RoleOverrideValues is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("roleOverrideValues"u8);
                writer.WriteStartArray();
                foreach (var item in RoleOverrideValues)
                {
                    writer.WriteStringValue(item);
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

        NetworkFunctionValueWithSecrets IJsonModel<NetworkFunctionValueWithSecrets>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFunctionValueWithSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkFunctionValueWithSecrets)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkFunctionValueWithSecrets(document.RootElement, options);
        }

        internal static NetworkFunctionValueWithSecrets DeserializeNetworkFunctionValueWithSecrets(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> secretDeploymentValues = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> publisherName = default;
            Optional<PublisherScope> publisherScope = default;
            Optional<string> networkFunctionDefinitionGroupName = default;
            Optional<string> networkFunctionDefinitionVersion = default;
            Optional<string> networkFunctionDefinitionOfferingLocation = default;
            Optional<DeploymentResourceIdReference> networkFunctionDefinitionVersionResourceReference = default;
            Optional<NfviType> nfviType = default;
            Optional<ResourceIdentifier> nfviId = default;
            Optional<bool> allowSoftwareUpdate = default;
            NetworkFunctionConfigurationType configurationType = default;
            IList<string> roleOverrideValues = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secretDeploymentValues"u8))
                {
                    secretDeploymentValues = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publisherName"u8))
                {
                    publisherName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisherScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publisherScope = new PublisherScope(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkFunctionDefinitionGroupName"u8))
                {
                    networkFunctionDefinitionGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkFunctionDefinitionVersion"u8))
                {
                    networkFunctionDefinitionVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkFunctionDefinitionOfferingLocation"u8))
                {
                    networkFunctionDefinitionOfferingLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkFunctionDefinitionVersionResourceReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkFunctionDefinitionVersionResourceReference = DeploymentResourceIdReference.DeserializeDeploymentResourceIdReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("nfviType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nfviType = new NfviType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nfviId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nfviId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowSoftwareUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowSoftwareUpdate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("configurationType"u8))
                {
                    configurationType = new NetworkFunctionConfigurationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("roleOverrideValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    roleOverrideValues = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkFunctionValueWithSecrets(
                Optional.ToNullable(provisioningState),
                publisherName.Value,
                Optional.ToNullable(publisherScope),
                networkFunctionDefinitionGroupName.Value,
                networkFunctionDefinitionVersion.Value,
                networkFunctionDefinitionOfferingLocation.Value,
                networkFunctionDefinitionVersionResourceReference.Value,
                Optional.ToNullable(nfviType),
                nfviId.Value,
                Optional.ToNullable(allowSoftwareUpdate),
                configurationType,
                roleOverrideValues ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData,
                secretDeploymentValues.Value);
        }

        BinaryData IPersistableModel<NetworkFunctionValueWithSecrets>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFunctionValueWithSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkFunctionValueWithSecrets)} does not support '{options.Format}' format.");
            }
        }

        NetworkFunctionValueWithSecrets IPersistableModel<NetworkFunctionValueWithSecrets>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFunctionValueWithSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkFunctionValueWithSecrets(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkFunctionValueWithSecrets)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkFunctionValueWithSecrets>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
