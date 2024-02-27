// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Advisor.Models
{
    public partial class DigestConfig : IUtf8JsonSerializable, IJsonModel<DigestConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DigestConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DigestConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigestConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DigestConfig)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (ActionGroupResourceId != null)
            {
                writer.WritePropertyName("actionGroupResourceId"u8);
                writer.WriteStringValue(ActionGroupResourceId);
            }
            if (Frequency.HasValue)
            {
                writer.WritePropertyName("frequency"u8);
                writer.WriteNumberValue(Frequency.Value);
            }
            if (!(Categories is ChangeTrackingList<Category> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("categories"u8);
                writer.WriteStartArray();
                foreach (var item in Categories)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Language != null)
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            if (State.HasValue)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
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

        DigestConfig IJsonModel<DigestConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigestConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DigestConfig)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDigestConfig(document.RootElement, options);
        }

        internal static DigestConfig DeserializeDigestConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> actionGroupResourceId = default;
            Optional<int> frequency = default;
            IList<Category> categories = default;
            Optional<string> language = default;
            Optional<DigestConfigState> state = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionGroupResourceId"u8))
                {
                    actionGroupResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("frequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frequency = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("categories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Category> array = new List<Category>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new Category(item.GetString()));
                    }
                    categories = array;
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new DigestConfigState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DigestConfig(
                name.Value,
                actionGroupResourceId.Value,
                Optional.ToNullable(frequency),
                categories ?? new ChangeTrackingList<Category>(),
                language.Value,
                Optional.ToNullable(state),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DigestConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigestConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DigestConfig)} does not support '{options.Format}' format.");
            }
        }

        DigestConfig IPersistableModel<DigestConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DigestConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDigestConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DigestConfig)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DigestConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
