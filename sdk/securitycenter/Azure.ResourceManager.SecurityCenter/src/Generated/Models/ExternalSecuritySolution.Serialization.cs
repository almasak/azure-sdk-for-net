// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class ExternalSecuritySolution : IUtf8JsonSerializable, IJsonModel<ExternalSecuritySolution>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExternalSecuritySolution>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExternalSecuritySolution>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExternalSecuritySolution>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExternalSecuritySolution)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Kind != null)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            else
            {
                writer.WriteNull("kind");
            }
            if (options.Format != "W" && Location.HasValue)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
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

        ExternalSecuritySolution IJsonModel<ExternalSecuritySolution>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExternalSecuritySolution>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExternalSecuritySolution)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExternalSecuritySolution(document.RootElement, options);
        }

        internal static ExternalSecuritySolution DeserializeExternalSecuritySolution(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AAD": return AadExternalSecuritySolution.DeserializeAadExternalSecuritySolution(element, options);
                    case "ATA": return AtaExternalSecuritySolution.DeserializeAtaExternalSecuritySolution(element, options);
                    case "CEF": return CefExternalSecuritySolution.DeserializeCefExternalSecuritySolution(element, options);
                }
            }
            return UnknownExternalSecuritySolution.DeserializeUnknownExternalSecuritySolution(element, options);
        }

        BinaryData IPersistableModel<ExternalSecuritySolution>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExternalSecuritySolution>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExternalSecuritySolution)} does not support '{options.Format}' format.");
            }
        }

        ExternalSecuritySolution IPersistableModel<ExternalSecuritySolution>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExternalSecuritySolution>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExternalSecuritySolution(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExternalSecuritySolution)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExternalSecuritySolution>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
