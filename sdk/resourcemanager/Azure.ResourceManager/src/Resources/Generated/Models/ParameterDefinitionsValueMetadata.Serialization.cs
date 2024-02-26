// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ParameterDefinitionsValueMetadata : IUtf8JsonSerializable, IJsonModel<ParameterDefinitionsValueMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ParameterDefinitionsValueMetadata>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ParameterDefinitionsValueMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ParameterDefinitionsValueMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ParameterDefinitionsValueMetadata)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (StrongType != null)
            {
                writer.WritePropertyName("strongType"u8);
                writer.WriteStringValue(StrongType);
            }
            if (AssignPermissions.HasValue)
            {
                writer.WritePropertyName("assignPermissions"u8);
                writer.WriteBooleanValue(AssignPermissions.Value);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        ParameterDefinitionsValueMetadata IJsonModel<ParameterDefinitionsValueMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ParameterDefinitionsValueMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ParameterDefinitionsValueMetadata)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeParameterDefinitionsValueMetadata(document.RootElement, options);
        }

        internal static ParameterDefinitionsValueMetadata DeserializeParameterDefinitionsValueMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<string> strongType = default;
            Optional<bool> assignPermissions = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("strongType"u8))
                {
                    strongType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assignPermissions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assignPermissions = property.Value.GetBoolean();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ParameterDefinitionsValueMetadata(displayName.Value, description.Value, strongType.Value, Optional.ToNullable(assignPermissions), additionalProperties);
        }

        BinaryData IPersistableModel<ParameterDefinitionsValueMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ParameterDefinitionsValueMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ParameterDefinitionsValueMetadata)} does not support '{options.Format}' format.");
            }
        }

        ParameterDefinitionsValueMetadata IPersistableModel<ParameterDefinitionsValueMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ParameterDefinitionsValueMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeParameterDefinitionsValueMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ParameterDefinitionsValueMetadata)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ParameterDefinitionsValueMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
