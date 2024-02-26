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
    public partial class VpnConfigurationOptionAProperties : IUtf8JsonSerializable, IJsonModel<VpnConfigurationOptionAProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnConfigurationOptionAProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VpnConfigurationOptionAProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnConfigurationOptionAProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnConfigurationOptionAProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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

        VpnConfigurationOptionAProperties IJsonModel<VpnConfigurationOptionAProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnConfigurationOptionAProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnConfigurationOptionAProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnConfigurationOptionAProperties(document.RootElement, options);
        }

        internal static VpnConfigurationOptionAProperties DeserializeVpnConfigurationOptionAProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primaryIPv4Prefix = default;
            Optional<string> primaryIPv6Prefix = default;
            Optional<string> secondaryIPv4Prefix = default;
            Optional<string> secondaryIPv6Prefix = default;
            Optional<int> mtu = default;
            Optional<int> vlanId = default;
            Optional<long> peerAsn = default;
            Optional<BfdConfiguration> bfdConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VpnConfigurationOptionAProperties(Optional.ToNullable(mtu), Optional.ToNullable(vlanId), Optional.ToNullable(peerAsn), bfdConfiguration.Value, serializedAdditionalRawData, primaryIPv4Prefix.Value, primaryIPv6Prefix.Value, secondaryIPv4Prefix.Value, secondaryIPv6Prefix.Value);
        }

        BinaryData IPersistableModel<VpnConfigurationOptionAProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnConfigurationOptionAProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VpnConfigurationOptionAProperties)} does not support '{options.Format}' format.");
            }
        }

        VpnConfigurationOptionAProperties IPersistableModel<VpnConfigurationOptionAProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnConfigurationOptionAProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVpnConfigurationOptionAProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VpnConfigurationOptionAProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VpnConfigurationOptionAProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
