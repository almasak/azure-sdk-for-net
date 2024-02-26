// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class ExternalNetworkOptionAProperties : IUtf8JsonSerializable, IJsonModel<ExternalNetworkOptionAProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExternalNetworkOptionAProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExternalNetworkOptionAProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExternalNetworkOptionAProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExternalNetworkOptionAProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Mtu.HasValue)
            {
                writer.WritePropertyName("mtu"u8);
                writer.WriteNumberValue(Mtu.Value);
            }
            if (VlanId.HasValue)
            {
                writer.WritePropertyName("vlanId"u8);
                writer.WriteNumberValue(VlanId.Value);
            }
            if (options.Format != "W" && FabricAsn.HasValue)
            {
                writer.WritePropertyName("fabricASN"u8);
                writer.WriteNumberValue(FabricAsn.Value);
            }
            if (PeerAsn.HasValue)
            {
                writer.WritePropertyName("peerASN"u8);
                writer.WriteNumberValue(PeerAsn.Value);
            }
            if (BfdConfiguration != null)
            {
                writer.WritePropertyName("bfdConfiguration"u8);
                writer.WriteObjectValue(BfdConfiguration);
            }
            if (IngressAclId != null)
            {
                writer.WritePropertyName("ingressAclId"u8);
                writer.WriteStringValue(IngressAclId);
            }
            if (EgressAclId != null)
            {
                writer.WritePropertyName("egressAclId"u8);
                writer.WriteStringValue(EgressAclId);
            }
            if (PrimaryIPv4Prefix != null)
            {
                writer.WritePropertyName("primaryIpv4Prefix"u8);
                writer.WriteStringValue(PrimaryIPv4Prefix);
            }
            if (PrimaryIPv6Prefix != null)
            {
                writer.WritePropertyName("primaryIpv6Prefix"u8);
                writer.WriteStringValue(PrimaryIPv6Prefix);
            }
            if (SecondaryIPv4Prefix != null)
            {
                writer.WritePropertyName("secondaryIpv4Prefix"u8);
                writer.WriteStringValue(SecondaryIPv4Prefix);
            }
            if (SecondaryIPv6Prefix != null)
            {
                writer.WritePropertyName("secondaryIpv6Prefix"u8);
                writer.WriteStringValue(SecondaryIPv6Prefix);
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

        ExternalNetworkOptionAProperties IJsonModel<ExternalNetworkOptionAProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExternalNetworkOptionAProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExternalNetworkOptionAProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExternalNetworkOptionAProperties(document.RootElement, options);
        }

        internal static ExternalNetworkOptionAProperties DeserializeExternalNetworkOptionAProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> mtu = default;
            Optional<int> vlanId = default;
            Optional<long> fabricAsn = default;
            Optional<long> peerAsn = default;
            Optional<BfdConfiguration> bfdConfiguration = default;
            Optional<ResourceIdentifier> ingressAclId = default;
            Optional<ResourceIdentifier> egressAclId = default;
            Optional<string> primaryIPv4Prefix = default;
            Optional<string> primaryIPv6Prefix = default;
            Optional<string> secondaryIPv4Prefix = default;
            Optional<string> secondaryIPv6Prefix = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mtu"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mtu = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("vlanId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vlanId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("fabricASN"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricAsn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("peerASN"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peerAsn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("bfdConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bfdConfiguration = BfdConfiguration.DeserializeBfdConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("ingressAclId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ingressAclId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("egressAclId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    egressAclId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryIpv4Prefix"u8))
                {
                    primaryIPv4Prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryIpv6Prefix"u8))
                {
                    primaryIPv6Prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryIpv4Prefix"u8))
                {
                    secondaryIPv4Prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryIpv6Prefix"u8))
                {
                    secondaryIPv6Prefix = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExternalNetworkOptionAProperties(primaryIPv4Prefix.Value, primaryIPv6Prefix.Value, secondaryIPv4Prefix.Value, secondaryIPv6Prefix.Value, serializedAdditionalRawData, Optional.ToNullable(mtu), Optional.ToNullable(vlanId), Optional.ToNullable(fabricAsn), Optional.ToNullable(peerAsn), bfdConfiguration.Value, ingressAclId.Value, egressAclId.Value);
        }

        BinaryData IPersistableModel<ExternalNetworkOptionAProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExternalNetworkOptionAProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExternalNetworkOptionAProperties)} does not support '{options.Format}' format.");
            }
        }

        ExternalNetworkOptionAProperties IPersistableModel<ExternalNetworkOptionAProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExternalNetworkOptionAProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExternalNetworkOptionAProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExternalNetworkOptionAProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExternalNetworkOptionAProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
