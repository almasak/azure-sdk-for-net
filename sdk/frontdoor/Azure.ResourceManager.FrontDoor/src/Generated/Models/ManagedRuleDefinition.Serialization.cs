// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class ManagedRuleDefinition : IUtf8JsonSerializable, IJsonModel<ManagedRuleDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedRuleDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedRuleDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedRuleDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedRuleDefinition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && RuleId != null)
            {
                writer.WritePropertyName("ruleId"u8);
                writer.WriteStringValue(RuleId);
            }
            if (options.Format != "W" && DefaultState.HasValue)
            {
                writer.WritePropertyName("defaultState"u8);
                writer.WriteStringValue(DefaultState.Value.ToString());
            }
            if (options.Format != "W" && DefaultAction.HasValue)
            {
                writer.WritePropertyName("defaultAction"u8);
                writer.WriteStringValue(DefaultAction.Value.ToString());
            }
            if (options.Format != "W" && Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        ManagedRuleDefinition IJsonModel<ManagedRuleDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedRuleDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedRuleDefinition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedRuleDefinition(document.RootElement, options);
        }

        internal static ManagedRuleDefinition DeserializeManagedRuleDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ruleId = default;
            Optional<ManagedRuleEnabledState> defaultState = default;
            Optional<RuleMatchActionType> defaultAction = default;
            Optional<string> description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleId"u8))
                {
                    ruleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultState = new ManagedRuleEnabledState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("defaultAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultAction = new RuleMatchActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedRuleDefinition(ruleId.Value, Optional.ToNullable(defaultState), Optional.ToNullable(defaultAction), description.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedRuleDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedRuleDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedRuleDefinition)} does not support '{options.Format}' format.");
            }
        }

        ManagedRuleDefinition IPersistableModel<ManagedRuleDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedRuleDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedRuleDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedRuleDefinition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedRuleDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
