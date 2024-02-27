// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightClusterAaddsDetail : IUtf8JsonSerializable, IJsonModel<HDInsightClusterAaddsDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightClusterAaddsDetail>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HDInsightClusterAaddsDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterAaddsDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightClusterAaddsDetail)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DomainName != null)
            {
                writer.WritePropertyName("domainName"u8);
                writer.WriteStringValue(DomainName);
            }
            if (IsInitialSyncComplete.HasValue)
            {
                writer.WritePropertyName("initialSyncComplete"u8);
                writer.WriteBooleanValue(IsInitialSyncComplete.Value);
            }
            if (IsLdapsEnabled.HasValue)
            {
                writer.WritePropertyName("ldapsEnabled"u8);
                writer.WriteBooleanValue(IsLdapsEnabled.Value);
            }
            if (LdapsPublicCertificateInBase64 != null)
            {
                writer.WritePropertyName("ldapsPublicCertificateInBase64"u8);
                writer.WriteStringValue(LdapsPublicCertificateInBase64);
            }
            if (ResourceId != null)
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (SubnetId != null)
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (TenantId.HasValue)
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
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

        HDInsightClusterAaddsDetail IJsonModel<HDInsightClusterAaddsDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterAaddsDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightClusterAaddsDetail)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightClusterAaddsDetail(document.RootElement, options);
        }

        internal static HDInsightClusterAaddsDetail DeserializeHDInsightClusterAaddsDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> domainName = default;
            Optional<bool> initialSyncComplete = default;
            Optional<bool> ldapsEnabled = default;
            Optional<string> ldapsPublicCertificateInBase64 = default;
            Optional<ResourceIdentifier> resourceId = default;
            Optional<ResourceIdentifier> subnetId = default;
            Optional<Guid> tenantId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialSyncComplete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialSyncComplete = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ldapsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ldapsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ldapsPublicCertificateInBase64"u8))
                {
                    ldapsPublicCertificateInBase64 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HDInsightClusterAaddsDetail(
                domainName.Value,
                Optional.ToNullable(initialSyncComplete),
                Optional.ToNullable(ldapsEnabled),
                ldapsPublicCertificateInBase64.Value,
                resourceId.Value,
                subnetId.Value,
                Optional.ToNullable(tenantId),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightClusterAaddsDetail>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterAaddsDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightClusterAaddsDetail)} does not support '{options.Format}' format.");
            }
        }

        HDInsightClusterAaddsDetail IPersistableModel<HDInsightClusterAaddsDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterAaddsDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightClusterAaddsDetail(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightClusterAaddsDetail)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightClusterAaddsDetail>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
