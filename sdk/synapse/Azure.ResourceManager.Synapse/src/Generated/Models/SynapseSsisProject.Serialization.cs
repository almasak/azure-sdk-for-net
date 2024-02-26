// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseSsisProject : IUtf8JsonSerializable, IJsonModel<SynapseSsisProject>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseSsisProject>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseSsisProject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSsisProject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSsisProject)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (FolderId.HasValue)
            {
                writer.WritePropertyName("folderId"u8);
                writer.WriteNumberValue(FolderId.Value);
            }
            if (Version.HasValue)
            {
                writer.WritePropertyName("version"u8);
                writer.WriteNumberValue(Version.Value);
            }
            if (!(EnvironmentRefs is ChangeTrackingList<SynapseSsisEnvironmentReference> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("environmentRefs"u8);
                writer.WriteStartArray();
                foreach (var item in EnvironmentRefs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Parameters is ChangeTrackingList<SynapseSsisParameter> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(MetadataType.ToString());
            if (Id.HasValue)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteNumberValue(Id.Value);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        SynapseSsisProject IJsonModel<SynapseSsisProject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSsisProject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSsisProject)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseSsisProject(document.RootElement, options);
        }

        internal static SynapseSsisProject DeserializeSynapseSsisProject(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> folderId = default;
            Optional<long> version = default;
            IReadOnlyList<SynapseSsisEnvironmentReference> environmentRefs = default;
            IReadOnlyList<SynapseSsisParameter> parameters = default;
            SynapseSsisObjectMetadataType type = default;
            Optional<long> id = default;
            Optional<string> name = default;
            Optional<string> description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("folderId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    folderId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("environmentRefs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseSsisEnvironmentReference> array = new List<SynapseSsisEnvironmentReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseSsisEnvironmentReference.DeserializeSynapseSsisEnvironmentReference(item, options));
                    }
                    environmentRefs = array;
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseSsisParameter> array = new List<SynapseSsisParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseSsisParameter.DeserializeSynapseSsisParameter(item, options));
                    }
                    parameters = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new SynapseSsisObjectMetadataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseSsisProject(type, Optional.ToNullable(id), name.Value, description.Value, serializedAdditionalRawData, Optional.ToNullable(folderId), Optional.ToNullable(version), environmentRefs ?? new ChangeTrackingList<SynapseSsisEnvironmentReference>(), parameters ?? new ChangeTrackingList<SynapseSsisParameter>());
        }

        BinaryData IPersistableModel<SynapseSsisProject>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSsisProject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseSsisProject)} does not support '{options.Format}' format.");
            }
        }

        SynapseSsisProject IPersistableModel<SynapseSsisProject>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSsisProject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseSsisProject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseSsisProject)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseSsisProject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
