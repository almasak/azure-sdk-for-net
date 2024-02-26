// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class FirewallRuleResetConter : IUtf8JsonSerializable, IJsonModel<FirewallRuleResetConter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallRuleResetConter>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FirewallRuleResetConter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallRuleResetConter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallRuleResetConter)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Priority != null)
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteStringValue(Priority);
            }
            if (RuleStackName != null)
            {
                writer.WritePropertyName("ruleStackName"u8);
                writer.WriteStringValue(RuleStackName);
            }
            if (RuleListName != null)
            {
                writer.WritePropertyName("ruleListName"u8);
                writer.WriteStringValue(RuleListName);
            }
            if (FirewallName != null)
            {
                writer.WritePropertyName("firewallName"u8);
                writer.WriteStringValue(FirewallName);
            }
            if (RuleName != null)
            {
                writer.WritePropertyName("ruleName"u8);
                writer.WriteStringValue(RuleName);
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

        FirewallRuleResetConter IJsonModel<FirewallRuleResetConter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallRuleResetConter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallRuleResetConter)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallRuleResetConter(document.RootElement, options);
        }

        internal static FirewallRuleResetConter DeserializeFirewallRuleResetConter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> priority = default;
            Optional<string> ruleStackName = default;
            Optional<string> ruleListName = default;
            Optional<string> firewallName = default;
            Optional<string> ruleName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("priority"u8))
                {
                    priority = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleStackName"u8))
                {
                    ruleStackName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleListName"u8))
                {
                    ruleListName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("firewallName"u8))
                {
                    firewallName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleName"u8))
                {
                    ruleName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FirewallRuleResetConter(priority.Value, ruleStackName.Value, ruleListName.Value, firewallName.Value, ruleName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirewallRuleResetConter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallRuleResetConter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirewallRuleResetConter)} does not support '{options.Format}' format.");
            }
        }

        FirewallRuleResetConter IPersistableModel<FirewallRuleResetConter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallRuleResetConter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFirewallRuleResetConter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirewallRuleResetConter)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirewallRuleResetConter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
