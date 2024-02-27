// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class PccRuleConfiguration : IUtf8JsonSerializable, IJsonModel<PccRuleConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PccRuleConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PccRuleConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PccRuleConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PccRuleConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("ruleName"u8);
            writer.WriteStringValue(RuleName);
            writer.WritePropertyName("rulePrecedence"u8);
            writer.WriteNumberValue(RulePrecedence);
            if (RuleQosPolicy != null)
            {
                writer.WritePropertyName("ruleQosPolicy"u8);
                writer.WriteObjectValue(RuleQosPolicy);
            }
            if (TrafficControl.HasValue)
            {
                writer.WritePropertyName("trafficControl"u8);
                writer.WriteStringValue(TrafficControl.Value.ToString());
            }
            writer.WritePropertyName("serviceDataFlowTemplates"u8);
            writer.WriteStartArray();
            foreach (var item in ServiceDataFlowTemplates)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        PccRuleConfiguration IJsonModel<PccRuleConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PccRuleConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PccRuleConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePccRuleConfiguration(document.RootElement, options);
        }

        internal static PccRuleConfiguration DeserializePccRuleConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ruleName = default;
            int rulePrecedence = default;
            Optional<PccRuleQosPolicy> ruleQosPolicy = default;
            Optional<MobileNetworkTrafficControlPermission> trafficControl = default;
            IList<MobileNetworkServiceDataFlowTemplate> serviceDataFlowTemplates = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleName"u8))
                {
                    ruleName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rulePrecedence"u8))
                {
                    rulePrecedence = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("ruleQosPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ruleQosPolicy = PccRuleQosPolicy.DeserializePccRuleQosPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("trafficControl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trafficControl = new MobileNetworkTrafficControlPermission(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceDataFlowTemplates"u8))
                {
                    List<MobileNetworkServiceDataFlowTemplate> array = new List<MobileNetworkServiceDataFlowTemplate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MobileNetworkServiceDataFlowTemplate.DeserializeMobileNetworkServiceDataFlowTemplate(item, options));
                    }
                    serviceDataFlowTemplates = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PccRuleConfiguration(
                ruleName,
                rulePrecedence,
                ruleQosPolicy.Value,
                Optional.ToNullable(trafficControl),
                serviceDataFlowTemplates,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PccRuleConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PccRuleConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PccRuleConfiguration)} does not support '{options.Format}' format.");
            }
        }

        PccRuleConfiguration IPersistableModel<PccRuleConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PccRuleConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePccRuleConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PccRuleConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PccRuleConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
