// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class GoogleAdWordsSource : IUtf8JsonSerializable, IJsonModel<GoogleAdWordsSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GoogleAdWordsSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GoogleAdWordsSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GoogleAdWordsSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GoogleAdWordsSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Query != null)
            {
                writer.WritePropertyName("query"u8);
                JsonSerializer.Serialize(writer, Query);
            }
            if (QueryTimeout != null)
            {
                writer.WritePropertyName("queryTimeout"u8);
                JsonSerializer.Serialize(writer, QueryTimeout);
            }
            if (AdditionalColumns != null)
            {
                writer.WritePropertyName("additionalColumns"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(AdditionalColumns);
#else
                using (JsonDocument document = JsonDocument.Parse(AdditionalColumns))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CopySourceType);
            if (SourceRetryCount != null)
            {
                writer.WritePropertyName("sourceRetryCount"u8);
                JsonSerializer.Serialize(writer, SourceRetryCount);
            }
            if (SourceRetryWait != null)
            {
                writer.WritePropertyName("sourceRetryWait"u8);
                JsonSerializer.Serialize(writer, SourceRetryWait);
            }
            if (MaxConcurrentConnections != null)
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                JsonSerializer.Serialize(writer, MaxConcurrentConnections);
            }
            if (DisableMetricsCollection != null)
            {
                writer.WritePropertyName("disableMetricsCollection"u8);
                JsonSerializer.Serialize(writer, DisableMetricsCollection);
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

        GoogleAdWordsSource IJsonModel<GoogleAdWordsSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GoogleAdWordsSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GoogleAdWordsSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGoogleAdWordsSource(document.RootElement, options);
        }

        internal static GoogleAdWordsSource DeserializeGoogleAdWordsSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<string>> query = default;
            Optional<DataFactoryElement<string>> queryTimeout = default;
            Optional<BinaryData> additionalColumns = default;
            string type = default;
            Optional<DataFactoryElement<int>> sourceRetryCount = default;
            Optional<DataFactoryElement<string>> sourceRetryWait = default;
            Optional<DataFactoryElement<int>> maxConcurrentConnections = default;
            Optional<DataFactoryElement<bool>> disableMetricsCollection = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    query = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("queryTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryTimeout = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("additionalColumns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalColumns = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryCount = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sourceRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryWait = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableMetricsCollection = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new GoogleAdWordsSource(type, sourceRetryCount.Value, sourceRetryWait.Value, maxConcurrentConnections.Value, disableMetricsCollection.Value, additionalProperties, queryTimeout.Value, additionalColumns.Value, query.Value);
        }

        BinaryData IPersistableModel<GoogleAdWordsSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GoogleAdWordsSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GoogleAdWordsSource)} does not support '{options.Format}' format.");
            }
        }

        GoogleAdWordsSource IPersistableModel<GoogleAdWordsSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GoogleAdWordsSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGoogleAdWordsSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GoogleAdWordsSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GoogleAdWordsSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
