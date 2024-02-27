// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class NumberNotInRangeAdvancedFilter : IUtf8JsonSerializable, IJsonModel<NumberNotInRangeAdvancedFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NumberNotInRangeAdvancedFilter>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NumberNotInRangeAdvancedFilter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NumberNotInRangeAdvancedFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NumberNotInRangeAdvancedFilter)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Values is ChangeTrackingList<IList<double>> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("values"u8);
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        writer.WriteNumberValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("operatorType"u8);
            writer.WriteStringValue(OperatorType.ToString());
            if (Key != null)
            {
                writer.WritePropertyName("key"u8);
                writer.WriteStringValue(Key);
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

        NumberNotInRangeAdvancedFilter IJsonModel<NumberNotInRangeAdvancedFilter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NumberNotInRangeAdvancedFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NumberNotInRangeAdvancedFilter)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNumberNotInRangeAdvancedFilter(document.RootElement, options);
        }

        internal static NumberNotInRangeAdvancedFilter DeserializeNumberNotInRangeAdvancedFilter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<IList<double>> values = default;
            AdvancedFilterOperatorType operatorType = default;
            Optional<string> key = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IList<double>> array = new List<IList<double>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<double> array0 = new List<double>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                array0.Add(item0.GetDouble());
                            }
                            array.Add(array0);
                        }
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("operatorType"u8))
                {
                    operatorType = new AdvancedFilterOperatorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NumberNotInRangeAdvancedFilter(operatorType, key.Value, serializedAdditionalRawData, values ?? new ChangeTrackingList<IList<double>>());
        }

        BinaryData IPersistableModel<NumberNotInRangeAdvancedFilter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NumberNotInRangeAdvancedFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NumberNotInRangeAdvancedFilter)} does not support '{options.Format}' format.");
            }
        }

        NumberNotInRangeAdvancedFilter IPersistableModel<NumberNotInRangeAdvancedFilter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NumberNotInRangeAdvancedFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNumberNotInRangeAdvancedFilter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NumberNotInRangeAdvancedFilter)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NumberNotInRangeAdvancedFilter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
