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
    public partial class IntegrationAccountKeyVaultKey : IUtf8JsonSerializable, IJsonModel<IntegrationAccountKeyVaultKey>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationAccountKeyVaultKey>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IntegrationAccountKeyVaultKey>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountKeyVaultKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationAccountKeyVaultKey)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (KeyId != null)
            {
                writer.WritePropertyName("kid"u8);
                writer.WriteStringValue(KeyId.AbsoluteUri);
            }
            writer.WritePropertyName("attributes"u8);
            writer.WriteStartObject();
            if (IsEnabled.HasValue)
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (CreatedOn.HasValue)
            {
                writer.WritePropertyName("created"u8);
                writer.WriteNumberValue(CreatedOn.Value, "U");
            }
            if (UpdatedOn.HasValue)
            {
                writer.WritePropertyName("updated"u8);
                writer.WriteNumberValue(UpdatedOn.Value, "U");
            }
            writer.WriteEndObject();
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

        IntegrationAccountKeyVaultKey IJsonModel<IntegrationAccountKeyVaultKey>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountKeyVaultKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationAccountKeyVaultKey)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationAccountKeyVaultKey(document.RootElement, options);
        }

        internal static IntegrationAccountKeyVaultKey DeserializeIntegrationAccountKeyVaultKey(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> kid = default;
            Optional<bool> enabled = default;
            Optional<DateTimeOffset> created = default;
            Optional<DateTimeOffset> updated = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kid = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("attributes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("created"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            created = DateTimeOffset.FromUnixTimeSeconds(property0.Value.GetInt64());
                            continue;
                        }
                        if (property0.NameEquals("updated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updated = DateTimeOffset.FromUnixTimeSeconds(property0.Value.GetInt64());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IntegrationAccountKeyVaultKey(kid.Value, Optional.ToNullable(enabled), Optional.ToNullable(created), Optional.ToNullable(updated), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IntegrationAccountKeyVaultKey>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountKeyVaultKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IntegrationAccountKeyVaultKey)} does not support '{options.Format}' format.");
            }
        }

        IntegrationAccountKeyVaultKey IPersistableModel<IntegrationAccountKeyVaultKey>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountKeyVaultKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIntegrationAccountKeyVaultKey(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IntegrationAccountKeyVaultKey)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationAccountKeyVaultKey>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
