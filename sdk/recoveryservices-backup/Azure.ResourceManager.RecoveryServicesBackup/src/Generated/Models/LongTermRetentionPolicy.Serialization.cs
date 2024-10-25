// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class LongTermRetentionPolicy : IUtf8JsonSerializable, IJsonModel<LongTermRetentionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LongTermRetentionPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LongTermRetentionPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LongTermRetentionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LongTermRetentionPolicy)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(DailySchedule))
            {
                writer.WritePropertyName("dailySchedule"u8);
                writer.WriteObjectValue(DailySchedule, options);
            }
            if (Optional.IsDefined(WeeklySchedule))
            {
                writer.WritePropertyName("weeklySchedule"u8);
                writer.WriteObjectValue(WeeklySchedule, options);
            }
            if (Optional.IsDefined(MonthlySchedule))
            {
                writer.WritePropertyName("monthlySchedule"u8);
                writer.WriteObjectValue(MonthlySchedule, options);
            }
            if (Optional.IsDefined(YearlySchedule))
            {
                writer.WritePropertyName("yearlySchedule"u8);
                writer.WriteObjectValue(YearlySchedule, options);
            }
        }

        LongTermRetentionPolicy IJsonModel<LongTermRetentionPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LongTermRetentionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LongTermRetentionPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLongTermRetentionPolicy(document.RootElement, options);
        }

        internal static LongTermRetentionPolicy DeserializeLongTermRetentionPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DailyRetentionSchedule dailySchedule = default;
            WeeklyRetentionSchedule weeklySchedule = default;
            MonthlyRetentionSchedule monthlySchedule = default;
            YearlyRetentionSchedule yearlySchedule = default;
            string retentionPolicyType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dailySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dailySchedule = DailyRetentionSchedule.DeserializeDailyRetentionSchedule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("weeklySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    weeklySchedule = WeeklyRetentionSchedule.DeserializeWeeklyRetentionSchedule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("monthlySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monthlySchedule = MonthlyRetentionSchedule.DeserializeMonthlyRetentionSchedule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("yearlySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    yearlySchedule = YearlyRetentionSchedule.DeserializeYearlyRetentionSchedule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("retentionPolicyType"u8))
                {
                    retentionPolicyType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LongTermRetentionPolicy(
                retentionPolicyType,
                serializedAdditionalRawData,
                dailySchedule,
                weeklySchedule,
                monthlySchedule,
                yearlySchedule);
        }

        BinaryData IPersistableModel<LongTermRetentionPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LongTermRetentionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LongTermRetentionPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        LongTermRetentionPolicy IPersistableModel<LongTermRetentionPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LongTermRetentionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLongTermRetentionPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LongTermRetentionPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LongTermRetentionPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
