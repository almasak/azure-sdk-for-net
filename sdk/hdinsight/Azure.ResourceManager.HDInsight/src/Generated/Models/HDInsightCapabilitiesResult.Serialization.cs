// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightCapabilitiesResult : IUtf8JsonSerializable, IJsonModel<HDInsightCapabilitiesResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightCapabilitiesResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HDInsightCapabilitiesResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightCapabilitiesResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightCapabilitiesResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Versions is ChangeTrackingDictionary<string, HDInsightVersionsCapability> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("versions"u8);
                writer.WriteStartObject();
                foreach (var item in Versions)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(Regions is ChangeTrackingDictionary<string, RegionsCapability> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("regions"u8);
                writer.WriteStartObject();
                foreach (var item in Regions)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(Features is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("features"u8);
                writer.WriteStartArray();
                foreach (var item in Features)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Quota != null)
            {
                writer.WritePropertyName("quota"u8);
                writer.WriteObjectValue(Quota);
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

        HDInsightCapabilitiesResult IJsonModel<HDInsightCapabilitiesResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightCapabilitiesResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightCapabilitiesResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightCapabilitiesResult(document.RootElement, options);
        }

        internal static HDInsightCapabilitiesResult DeserializeHDInsightCapabilitiesResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyDictionary<string, HDInsightVersionsCapability> versions = default;
            IReadOnlyDictionary<string, RegionsCapability> regions = default;
            IReadOnlyList<string> features = default;
            Optional<QuotaCapability> quota = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("versions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, HDInsightVersionsCapability> dictionary = new Dictionary<string, HDInsightVersionsCapability>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, HDInsightVersionsCapability.DeserializeHDInsightVersionsCapability(property0.Value, options));
                    }
                    versions = dictionary;
                    continue;
                }
                if (property.NameEquals("regions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, RegionsCapability> dictionary = new Dictionary<string, RegionsCapability>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, RegionsCapability.DeserializeRegionsCapability(property0.Value, options));
                    }
                    regions = dictionary;
                    continue;
                }
                if (property.NameEquals("features"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    features = array;
                    continue;
                }
                if (property.NameEquals("quota"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quota = QuotaCapability.DeserializeQuotaCapability(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HDInsightCapabilitiesResult(versions ?? new ChangeTrackingDictionary<string, HDInsightVersionsCapability>(), regions ?? new ChangeTrackingDictionary<string, RegionsCapability>(), features ?? new ChangeTrackingList<string>(), quota.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightCapabilitiesResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightCapabilitiesResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightCapabilitiesResult)} does not support '{options.Format}' format.");
            }
        }

        HDInsightCapabilitiesResult IPersistableModel<HDInsightCapabilitiesResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightCapabilitiesResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightCapabilitiesResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightCapabilitiesResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightCapabilitiesResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
