// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class NfsAccessRule : IUtf8JsonSerializable, IJsonModel<NfsAccessRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NfsAccessRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NfsAccessRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NfsAccessRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NfsAccessRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("scope"u8);
            writer.WriteStringValue(Scope.ToString());
            if (Filter != null)
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteStringValue(Filter);
            }
            writer.WritePropertyName("access"u8);
            writer.WriteStringValue(Access.ToString());
            if (AllowSuid.HasValue)
            {
                writer.WritePropertyName("suid"u8);
                writer.WriteBooleanValue(AllowSuid.Value);
            }
            if (AllowSubmountAccess.HasValue)
            {
                writer.WritePropertyName("submountAccess"u8);
                writer.WriteBooleanValue(AllowSubmountAccess.Value);
            }
            if (EnableRootSquash.HasValue)
            {
                writer.WritePropertyName("rootSquash"u8);
                writer.WriteBooleanValue(EnableRootSquash.Value);
            }
            if (AnonymousUID != null)
            {
                writer.WritePropertyName("anonymousUID"u8);
                writer.WriteStringValue(AnonymousUID);
            }
            if (AnonymousGID != null)
            {
                writer.WritePropertyName("anonymousGID"u8);
                writer.WriteStringValue(AnonymousGID);
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

        NfsAccessRule IJsonModel<NfsAccessRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NfsAccessRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NfsAccessRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNfsAccessRule(document.RootElement, options);
        }

        internal static NfsAccessRule DeserializeNfsAccessRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NfsAccessRuleScope scope = default;
            Optional<string> filter = default;
            NfsAccessRuleAccess access = default;
            Optional<bool> suid = default;
            Optional<bool> submountAccess = default;
            Optional<bool> rootSquash = default;
            Optional<string> anonymousUID = default;
            Optional<string> anonymousGID = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scope"u8))
                {
                    scope = new NfsAccessRuleScope(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    filter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("access"u8))
                {
                    access = new NfsAccessRuleAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("suid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    suid = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("submountAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    submountAccess = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("rootSquash"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rootSquash = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("anonymousUID"u8))
                {
                    anonymousUID = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("anonymousGID"u8))
                {
                    anonymousGID = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NfsAccessRule(scope, filter.Value, access, Optional.ToNullable(suid), Optional.ToNullable(submountAccess), Optional.ToNullable(rootSquash), anonymousUID.Value, anonymousGID.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NfsAccessRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NfsAccessRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NfsAccessRule)} does not support '{options.Format}' format.");
            }
        }

        NfsAccessRule IPersistableModel<NfsAccessRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NfsAccessRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNfsAccessRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NfsAccessRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NfsAccessRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
