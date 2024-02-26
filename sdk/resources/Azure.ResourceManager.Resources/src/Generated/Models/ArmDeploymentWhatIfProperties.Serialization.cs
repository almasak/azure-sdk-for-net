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
    public partial class ArmDeploymentWhatIfProperties : IUtf8JsonSerializable, IJsonModel<ArmDeploymentWhatIfProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmDeploymentWhatIfProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ArmDeploymentWhatIfProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmDeploymentWhatIfProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmDeploymentWhatIfProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (WhatIfSettings != null)
            {
                writer.WritePropertyName("whatIfSettings"u8);
                writer.WriteObjectValue(WhatIfSettings);
            }
            if (Template != null)
            {
                writer.WritePropertyName("template"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Template);
#else
                using (JsonDocument document = JsonDocument.Parse(Template))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (TemplateLink != null)
            {
                writer.WritePropertyName("templateLink"u8);
                writer.WriteObjectValue(TemplateLink);
            }
            if (Parameters != null)
            {
                writer.WritePropertyName("parameters"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Parameters);
#else
                using (JsonDocument document = JsonDocument.Parse(Parameters))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (ParametersLink != null)
            {
                writer.WritePropertyName("parametersLink"u8);
                writer.WriteObjectValue(ParametersLink);
            }
            writer.WritePropertyName("mode"u8);
            writer.WriteStringValue(Mode.ToSerialString());
            if (DebugSetting != null)
            {
                writer.WritePropertyName("debugSetting"u8);
                writer.WriteObjectValue(DebugSetting);
            }
            if (ErrorDeployment != null)
            {
                writer.WritePropertyName("onErrorDeployment"u8);
                writer.WriteObjectValue(ErrorDeployment);
            }
            if (ExpressionEvaluation != null)
            {
                writer.WritePropertyName("expressionEvaluationOptions"u8);
                writer.WriteObjectValue(ExpressionEvaluation);
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

        ArmDeploymentWhatIfProperties IJsonModel<ArmDeploymentWhatIfProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmDeploymentWhatIfProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmDeploymentWhatIfProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmDeploymentWhatIfProperties(document.RootElement, options);
        }

        internal static ArmDeploymentWhatIfProperties DeserializeArmDeploymentWhatIfProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ArmDeploymentWhatIfSettings> whatIfSettings = default;
            Optional<BinaryData> template = default;
            Optional<ArmDeploymentTemplateLink> templateLink = default;
            Optional<BinaryData> parameters = default;
            Optional<ArmDeploymentParametersLink> parametersLink = default;
            ArmDeploymentMode mode = default;
            Optional<DebugSetting> debugSetting = default;
            Optional<ErrorDeployment> onErrorDeployment = default;
            Optional<ExpressionEvaluationOptions> expressionEvaluationOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("whatIfSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    whatIfSettings = ArmDeploymentWhatIfSettings.DeserializeArmDeploymentWhatIfSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("template"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    template = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("templateLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateLink = ArmDeploymentTemplateLink.DeserializeArmDeploymentTemplateLink(property.Value, options);
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("parametersLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parametersLink = ArmDeploymentParametersLink.DeserializeArmDeploymentParametersLink(property.Value, options);
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    mode = property.Value.GetString().ToArmDeploymentMode();
                    continue;
                }
                if (property.NameEquals("debugSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    debugSetting = DebugSetting.DeserializeDebugSetting(property.Value, options);
                    continue;
                }
                if (property.NameEquals("onErrorDeployment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onErrorDeployment = ErrorDeployment.DeserializeErrorDeployment(property.Value, options);
                    continue;
                }
                if (property.NameEquals("expressionEvaluationOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expressionEvaluationOptions = ExpressionEvaluationOptions.DeserializeExpressionEvaluationOptions(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ArmDeploymentWhatIfProperties(template.Value, templateLink.Value, parameters.Value, parametersLink.Value, mode, debugSetting.Value, onErrorDeployment.Value, expressionEvaluationOptions.Value, serializedAdditionalRawData, whatIfSettings.Value);
        }

        BinaryData IPersistableModel<ArmDeploymentWhatIfProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmDeploymentWhatIfProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ArmDeploymentWhatIfProperties)} does not support '{options.Format}' format.");
            }
        }

        ArmDeploymentWhatIfProperties IPersistableModel<ArmDeploymentWhatIfProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmDeploymentWhatIfProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeArmDeploymentWhatIfProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArmDeploymentWhatIfProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArmDeploymentWhatIfProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
