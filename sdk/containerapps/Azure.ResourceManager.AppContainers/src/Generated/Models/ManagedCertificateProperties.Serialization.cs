// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ManagedCertificateProperties : IUtf8JsonSerializable, IJsonModel<ManagedCertificateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedCertificateProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedCertificateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedCertificateProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (SubjectName != null)
            {
                writer.WritePropertyName("subjectName"u8);
                writer.WriteStringValue(SubjectName);
            }
            if (options.Format != "W" && Error != null)
            {
                writer.WritePropertyName("error"u8);
                writer.WriteStringValue(Error);
            }
            if (DomainControlValidation.HasValue)
            {
                writer.WritePropertyName("domainControlValidation"u8);
                writer.WriteStringValue(DomainControlValidation.Value.ToString());
            }
            if (options.Format != "W" && ValidationToken != null)
            {
                writer.WritePropertyName("validationToken"u8);
                writer.WriteStringValue(ValidationToken);
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

        ManagedCertificateProperties IJsonModel<ManagedCertificateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedCertificateProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedCertificateProperties(document.RootElement, options);
        }

        internal static ManagedCertificateProperties DeserializeManagedCertificateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerAppCertificateProvisioningState> provisioningState = default;
            Optional<string> subjectName = default;
            Optional<string> error = default;
            Optional<ManagedCertificateDomainControlValidation> domainControlValidation = default;
            Optional<string> validationToken = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ContainerAppCertificateProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subjectName"u8))
                {
                    subjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainControlValidation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    domainControlValidation = new ManagedCertificateDomainControlValidation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("validationToken"u8))
                {
                    validationToken = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedCertificateProperties(
                Optional.ToNullable(provisioningState),
                subjectName.Value,
                error.Value,
                Optional.ToNullable(domainControlValidation),
                validationToken.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedCertificateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedCertificateProperties)} does not support '{options.Format}' format.");
            }
        }

        ManagedCertificateProperties IPersistableModel<ManagedCertificateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedCertificateProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedCertificateProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedCertificateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
