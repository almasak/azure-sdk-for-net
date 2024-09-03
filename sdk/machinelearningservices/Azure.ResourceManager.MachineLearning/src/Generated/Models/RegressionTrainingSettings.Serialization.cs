// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class RegressionTrainingSettings : IUtf8JsonSerializable, IJsonModel<RegressionTrainingSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RegressionTrainingSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RegressionTrainingSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegressionTrainingSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RegressionTrainingSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AllowedTrainingAlgorithms))
            {
                if (AllowedTrainingAlgorithms != null)
                {
                    writer.WritePropertyName("allowedTrainingAlgorithms"u8);
                    writer.WriteStartArray();
                    foreach (var item in AllowedTrainingAlgorithms)
                    {
                        writer.WriteStringValue(item.ToString());
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("allowedTrainingAlgorithms");
                }
            }
            if (Optional.IsCollectionDefined(BlockedTrainingAlgorithms))
            {
                if (BlockedTrainingAlgorithms != null)
                {
                    writer.WritePropertyName("blockedTrainingAlgorithms"u8);
                    writer.WriteStartArray();
                    foreach (var item in BlockedTrainingAlgorithms)
                    {
                        writer.WriteStringValue(item.ToString());
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("blockedTrainingAlgorithms");
                }
            }
            if (Optional.IsDefined(IsDnnTrainingEnabled))
            {
                writer.WritePropertyName("enableDnnTraining"u8);
                writer.WriteBooleanValue(IsDnnTrainingEnabled.Value);
            }
            if (Optional.IsDefined(IsModelExplainabilityEnabled))
            {
                writer.WritePropertyName("enableModelExplainability"u8);
                writer.WriteBooleanValue(IsModelExplainabilityEnabled.Value);
            }
            if (Optional.IsDefined(IsOnnxCompatibleModelsEnabled))
            {
                writer.WritePropertyName("enableOnnxCompatibleModels"u8);
                writer.WriteBooleanValue(IsOnnxCompatibleModelsEnabled.Value);
            }
            if (Optional.IsDefined(IsStackEnsembleEnabled))
            {
                writer.WritePropertyName("enableStackEnsemble"u8);
                writer.WriteBooleanValue(IsStackEnsembleEnabled.Value);
            }
            if (Optional.IsDefined(IsVoteEnsembleEnabled))
            {
                writer.WritePropertyName("enableVoteEnsemble"u8);
                writer.WriteBooleanValue(IsVoteEnsembleEnabled.Value);
            }
            if (Optional.IsDefined(EnsembleModelDownloadTimeout))
            {
                writer.WritePropertyName("ensembleModelDownloadTimeout"u8);
                writer.WriteStringValue(EnsembleModelDownloadTimeout.Value, "P");
            }
            if (Optional.IsDefined(StackEnsembleSettings))
            {
                if (StackEnsembleSettings != null)
                {
                    writer.WritePropertyName("stackEnsembleSettings"u8);
                    writer.WriteObjectValue(StackEnsembleSettings, options);
                }
                else
                {
                    writer.WriteNull("stackEnsembleSettings");
                }
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

        RegressionTrainingSettings IJsonModel<RegressionTrainingSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegressionTrainingSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RegressionTrainingSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRegressionTrainingSettings(document.RootElement, options);
        }

        internal static RegressionTrainingSettings DeserializeRegressionTrainingSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<AutoMLVerticalRegressionModel> allowedTrainingAlgorithms = default;
            IList<AutoMLVerticalRegressionModel> blockedTrainingAlgorithms = default;
            bool? enableDnnTraining = default;
            bool? enableModelExplainability = default;
            bool? enableOnnxCompatibleModels = default;
            bool? enableStackEnsemble = default;
            bool? enableVoteEnsemble = default;
            TimeSpan? ensembleModelDownloadTimeout = default;
            MachineLearningStackEnsembleSettings stackEnsembleSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedTrainingAlgorithms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        allowedTrainingAlgorithms = null;
                        continue;
                    }
                    List<AutoMLVerticalRegressionModel> array = new List<AutoMLVerticalRegressionModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AutoMLVerticalRegressionModel(item.GetString()));
                    }
                    allowedTrainingAlgorithms = array;
                    continue;
                }
                if (property.NameEquals("blockedTrainingAlgorithms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        blockedTrainingAlgorithms = null;
                        continue;
                    }
                    List<AutoMLVerticalRegressionModel> array = new List<AutoMLVerticalRegressionModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AutoMLVerticalRegressionModel(item.GetString()));
                    }
                    blockedTrainingAlgorithms = array;
                    continue;
                }
                if (property.NameEquals("enableDnnTraining"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableDnnTraining = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableModelExplainability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableModelExplainability = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableOnnxCompatibleModels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableOnnxCompatibleModels = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableStackEnsemble"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableStackEnsemble = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableVoteEnsemble"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableVoteEnsemble = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ensembleModelDownloadTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ensembleModelDownloadTimeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("stackEnsembleSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stackEnsembleSettings = null;
                        continue;
                    }
                    stackEnsembleSettings = MachineLearningStackEnsembleSettings.DeserializeMachineLearningStackEnsembleSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RegressionTrainingSettings(
                enableDnnTraining,
                enableModelExplainability,
                enableOnnxCompatibleModels,
                enableStackEnsemble,
                enableVoteEnsemble,
                ensembleModelDownloadTimeout,
                stackEnsembleSettings,
                serializedAdditionalRawData,
                allowedTrainingAlgorithms ?? new ChangeTrackingList<AutoMLVerticalRegressionModel>(),
                blockedTrainingAlgorithms ?? new ChangeTrackingList<AutoMLVerticalRegressionModel>());
        }

        BinaryData IPersistableModel<RegressionTrainingSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegressionTrainingSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RegressionTrainingSettings)} does not support writing '{options.Format}' format.");
            }
        }

        RegressionTrainingSettings IPersistableModel<RegressionTrainingSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegressionTrainingSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRegressionTrainingSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RegressionTrainingSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RegressionTrainingSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
