// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class AllSavingsBenefitDetails : IUtf8JsonSerializable, IJsonModel<AllSavingsBenefitDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AllSavingsBenefitDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AllSavingsBenefitDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AllSavingsBenefitDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AllSavingsBenefitDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && OverageCost.HasValue)
            {
                writer.WritePropertyName("overageCost"u8);
                writer.WriteNumberValue(OverageCost.Value);
            }
            if (options.Format != "W" && BenefitCost.HasValue)
            {
                writer.WritePropertyName("benefitCost"u8);
                writer.WriteNumberValue(BenefitCost.Value);
            }
            if (options.Format != "W" && TotalCost.HasValue)
            {
                writer.WritePropertyName("totalCost"u8);
                writer.WriteNumberValue(TotalCost.Value);
            }
            if (options.Format != "W" && SavingsAmount.HasValue)
            {
                writer.WritePropertyName("savingsAmount"u8);
                writer.WriteNumberValue(SavingsAmount.Value);
            }
            if (options.Format != "W" && SavingsPercentage.HasValue)
            {
                writer.WritePropertyName("savingsPercentage"u8);
                writer.WriteNumberValue(SavingsPercentage.Value);
            }
            if (options.Format != "W" && CoveragePercentage.HasValue)
            {
                writer.WritePropertyName("coveragePercentage"u8);
                writer.WriteNumberValue(CoveragePercentage.Value);
            }
            if (options.Format != "W" && CommitmentAmount.HasValue)
            {
                writer.WritePropertyName("commitmentAmount"u8);
                writer.WriteNumberValue(CommitmentAmount.Value);
            }
            if (options.Format != "W" && AverageUtilizationPercentage.HasValue)
            {
                writer.WritePropertyName("averageUtilizationPercentage"u8);
                writer.WriteNumberValue(AverageUtilizationPercentage.Value);
            }
            if (options.Format != "W" && WastageCost.HasValue)
            {
                writer.WritePropertyName("wastageCost"u8);
                writer.WriteNumberValue(WastageCost.Value);
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

        AllSavingsBenefitDetails IJsonModel<AllSavingsBenefitDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AllSavingsBenefitDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AllSavingsBenefitDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAllSavingsBenefitDetails(document.RootElement, options);
        }

        internal static AllSavingsBenefitDetails DeserializeAllSavingsBenefitDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<decimal> overageCost = default;
            Optional<decimal> benefitCost = default;
            Optional<decimal> totalCost = default;
            Optional<decimal> savingsAmount = default;
            Optional<decimal> savingsPercentage = default;
            Optional<decimal> coveragePercentage = default;
            Optional<decimal> commitmentAmount = default;
            Optional<decimal> averageUtilizationPercentage = default;
            Optional<decimal> wastageCost = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("overageCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    overageCost = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("benefitCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    benefitCost = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("totalCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalCost = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("savingsAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    savingsAmount = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("savingsPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    savingsPercentage = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("coveragePercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    coveragePercentage = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("commitmentAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    commitmentAmount = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("averageUtilizationPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    averageUtilizationPercentage = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("wastageCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wastageCost = property.Value.GetDecimal();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AllSavingsBenefitDetails(Optional.ToNullable(overageCost), Optional.ToNullable(benefitCost), Optional.ToNullable(totalCost), Optional.ToNullable(savingsAmount), Optional.ToNullable(savingsPercentage), Optional.ToNullable(coveragePercentage), Optional.ToNullable(commitmentAmount), Optional.ToNullable(averageUtilizationPercentage), Optional.ToNullable(wastageCost), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AllSavingsBenefitDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AllSavingsBenefitDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AllSavingsBenefitDetails)} does not support '{options.Format}' format.");
            }
        }

        AllSavingsBenefitDetails IPersistableModel<AllSavingsBenefitDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AllSavingsBenefitDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAllSavingsBenefitDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AllSavingsBenefitDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AllSavingsBenefitDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
