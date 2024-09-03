// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningDatastoreProperties : IUtf8JsonSerializable, IJsonModel<MachineLearningDatastoreProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningDatastoreProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningDatastoreProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDatastoreProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningDatastoreProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("credentials"u8);
            writer.WriteObjectValue(Credentials, options);
            writer.WritePropertyName("datastoreType"u8);
            writer.WriteStringValue(DatastoreType.ToString());
            if (options.Format != "W" && Optional.IsDefined(IsDefault))
            {
                writer.WritePropertyName("isDefault"u8);
                writer.WriteBooleanValue(IsDefault.Value);
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags != null)
                {
                    writer.WritePropertyName("tags"u8);
                    writer.WriteStartObject();
                    foreach (var item in Tags)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("tags");
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

        MachineLearningDatastoreProperties IJsonModel<MachineLearningDatastoreProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDatastoreProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningDatastoreProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningDatastoreProperties(document.RootElement, options);
        }

        internal static MachineLearningDatastoreProperties DeserializeMachineLearningDatastoreProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("datastoreType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureBlob": return MachineLearningAzureBlobDatastore.DeserializeMachineLearningAzureBlobDatastore(element, options);
                    case "AzureDataLakeGen1": return MachineLearningAzureDataLakeGen1Datastore.DeserializeMachineLearningAzureDataLakeGen1Datastore(element, options);
                    case "AzureDataLakeGen2": return MachineLearningAzureDataLakeGen2Datastore.DeserializeMachineLearningAzureDataLakeGen2Datastore(element, options);
                    case "AzureFile": return MachineLearningAzureFileDatastore.DeserializeMachineLearningAzureFileDatastore(element, options);
                    case "OneLake": return OneLakeDatastore.DeserializeOneLakeDatastore(element, options);
                }
            }
            return UnknownDatastore.DeserializeUnknownDatastore(element, options);
        }

        BinaryData IPersistableModel<MachineLearningDatastoreProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDatastoreProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningDatastoreProperties)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningDatastoreProperties IPersistableModel<MachineLearningDatastoreProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDatastoreProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningDatastoreProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningDatastoreProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningDatastoreProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
