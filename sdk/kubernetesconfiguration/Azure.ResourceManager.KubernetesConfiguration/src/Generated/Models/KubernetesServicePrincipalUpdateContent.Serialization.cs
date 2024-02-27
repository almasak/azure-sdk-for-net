// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KubernetesServicePrincipalUpdateContent : IUtf8JsonSerializable, IJsonModel<KubernetesServicePrincipalUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesServicePrincipalUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KubernetesServicePrincipalUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesServicePrincipalUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesServicePrincipalUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ClientId.HasValue)
            {
                if (ClientId != null)
                {
                    writer.WritePropertyName("clientId"u8);
                    writer.WriteStringValue(ClientId.Value);
                }
                else
                {
                    writer.WriteNull("clientId");
                }
            }
            if (TenantId.HasValue)
            {
                if (TenantId != null)
                {
                    writer.WritePropertyName("tenantId"u8);
                    writer.WriteStringValue(TenantId.Value);
                }
                else
                {
                    writer.WriteNull("tenantId");
                }
            }
            if (ClientSecret != null)
            {
                if (ClientSecret != null)
                {
                    writer.WritePropertyName("clientSecret"u8);
                    writer.WriteStringValue(ClientSecret);
                }
                else
                {
                    writer.WriteNull("clientSecret");
                }
            }
            if (ClientCertificate != null)
            {
                if (ClientCertificate != null)
                {
                    writer.WritePropertyName("clientCertificate"u8);
                    writer.WriteStringValue(ClientCertificate);
                }
                else
                {
                    writer.WriteNull("clientCertificate");
                }
            }
            if (ClientCertificatePassword != null)
            {
                if (ClientCertificatePassword != null)
                {
                    writer.WritePropertyName("clientCertificatePassword"u8);
                    writer.WriteStringValue(ClientCertificatePassword);
                }
                else
                {
                    writer.WriteNull("clientCertificatePassword");
                }
            }
            if (ClientCertificateSendChain.HasValue)
            {
                writer.WritePropertyName("clientCertificateSendChain"u8);
                writer.WriteBooleanValue(ClientCertificateSendChain.Value);
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

        KubernetesServicePrincipalUpdateContent IJsonModel<KubernetesServicePrincipalUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesServicePrincipalUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesServicePrincipalUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesServicePrincipalUpdateContent(document.RootElement, options);
        }

        internal static KubernetesServicePrincipalUpdateContent DeserializeKubernetesServicePrincipalUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid?> clientId = default;
            Optional<Guid?> tenantId = default;
            Optional<string> clientSecret = default;
            Optional<string> clientCertificate = default;
            Optional<string> clientCertificatePassword = default;
            Optional<bool> clientCertificateSendChain = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clientId = null;
                        continue;
                    }
                    clientId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tenantId = null;
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("clientSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clientSecret = null;
                        continue;
                    }
                    clientSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientCertificate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clientCertificate = null;
                        continue;
                    }
                    clientCertificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientCertificatePassword"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clientCertificatePassword = null;
                        continue;
                    }
                    clientCertificatePassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientCertificateSendChain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientCertificateSendChain = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KubernetesServicePrincipalUpdateContent(
                Optional.ToNullable(clientId),
                Optional.ToNullable(tenantId),
                clientSecret.Value,
                clientCertificate.Value,
                clientCertificatePassword.Value,
                Optional.ToNullable(clientCertificateSendChain),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KubernetesServicePrincipalUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesServicePrincipalUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesServicePrincipalUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        KubernetesServicePrincipalUpdateContent IPersistableModel<KubernetesServicePrincipalUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesServicePrincipalUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubernetesServicePrincipalUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KubernetesServicePrincipalUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesServicePrincipalUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
