// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformServiceNetworkProfile : IUtf8JsonSerializable, IJsonModel<AppPlatformServiceNetworkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformServiceNetworkProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformServiceNetworkProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformServiceNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformServiceNetworkProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ServiceRuntimeSubnetId != null)
            {
                writer.WritePropertyName("serviceRuntimeSubnetId"u8);
                writer.WriteStringValue(ServiceRuntimeSubnetId);
            }
            if (AppSubnetId != null)
            {
                writer.WritePropertyName("appSubnetId"u8);
                writer.WriteStringValue(AppSubnetId);
            }
            if (ServiceCidr != null)
            {
                writer.WritePropertyName("serviceCidr"u8);
                writer.WriteStringValue(ServiceCidr);
            }
            if (ServiceRuntimeNetworkResourceGroup != null)
            {
                writer.WritePropertyName("serviceRuntimeNetworkResourceGroup"u8);
                writer.WriteStringValue(ServiceRuntimeNetworkResourceGroup);
            }
            if (AppNetworkResourceGroup != null)
            {
                writer.WritePropertyName("appNetworkResourceGroup"u8);
                writer.WriteStringValue(AppNetworkResourceGroup);
            }
            if (options.Format != "W" && OutboundIPs != null)
            {
                writer.WritePropertyName("outboundIPs"u8);
                writer.WriteObjectValue(OutboundIPs);
            }
            if (options.Format != "W" && !(RequiredTraffics is ChangeTrackingList<AppPlatformServiceRequiredTraffic> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("requiredTraffics"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredTraffics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (IngressConfig != null)
            {
                writer.WritePropertyName("ingressConfig"u8);
                writer.WriteObjectValue(IngressConfig);
            }
            if (OutboundType != null)
            {
                writer.WritePropertyName("outboundType"u8);
                writer.WriteStringValue(OutboundType);
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

        AppPlatformServiceNetworkProfile IJsonModel<AppPlatformServiceNetworkProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformServiceNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformServiceNetworkProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformServiceNetworkProfile(document.RootElement, options);
        }

        internal static AppPlatformServiceNetworkProfile DeserializeAppPlatformServiceNetworkProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> serviceRuntimeSubnetId = default;
            Optional<ResourceIdentifier> appSubnetId = default;
            Optional<string> serviceCidr = default;
            Optional<string> serviceRuntimeNetworkResourceGroup = default;
            Optional<string> appNetworkResourceGroup = default;
            Optional<NetworkProfileOutboundIPs> outboundIPs = default;
            IReadOnlyList<AppPlatformServiceRequiredTraffic> requiredTraffics = default;
            Optional<IngressConfig> ingressConfig = default;
            Optional<string> outboundType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceRuntimeSubnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceRuntimeSubnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appSubnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appSubnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceCidr"u8))
                {
                    serviceCidr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceRuntimeNetworkResourceGroup"u8))
                {
                    serviceRuntimeNetworkResourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appNetworkResourceGroup"u8))
                {
                    appNetworkResourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outboundIPs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outboundIPs = NetworkProfileOutboundIPs.DeserializeNetworkProfileOutboundIPs(property.Value, options);
                    continue;
                }
                if (property.NameEquals("requiredTraffics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformServiceRequiredTraffic> array = new List<AppPlatformServiceRequiredTraffic>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformServiceRequiredTraffic.DeserializeAppPlatformServiceRequiredTraffic(item, options));
                    }
                    requiredTraffics = array;
                    continue;
                }
                if (property.NameEquals("ingressConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ingressConfig = IngressConfig.DeserializeIngressConfig(property.Value, options);
                    continue;
                }
                if (property.NameEquals("outboundType"u8))
                {
                    outboundType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformServiceNetworkProfile(serviceRuntimeSubnetId.Value, appSubnetId.Value, serviceCidr.Value, serviceRuntimeNetworkResourceGroup.Value, appNetworkResourceGroup.Value, outboundIPs.Value, requiredTraffics ?? new ChangeTrackingList<AppPlatformServiceRequiredTraffic>(), ingressConfig.Value, outboundType.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformServiceNetworkProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformServiceNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformServiceNetworkProfile)} does not support '{options.Format}' format.");
            }
        }

        AppPlatformServiceNetworkProfile IPersistableModel<AppPlatformServiceNetworkProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformServiceNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformServiceNetworkProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformServiceNetworkProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformServiceNetworkProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
