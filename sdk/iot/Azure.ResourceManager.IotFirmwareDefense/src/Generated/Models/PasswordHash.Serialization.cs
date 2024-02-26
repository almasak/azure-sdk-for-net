// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class PasswordHash : IUtf8JsonSerializable, IJsonModel<PasswordHash>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PasswordHash>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PasswordHash>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PasswordHash>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PasswordHash)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (PasswordHashId != null)
            {
                if (PasswordHashId != null)
                {
                    writer.WritePropertyName("passwordHashId"u8);
                    writer.WriteStringValue(PasswordHashId);
                }
                else
                {
                    writer.WriteNull("passwordHashId");
                }
            }
            if (FilePath != null)
            {
                if (FilePath != null)
                {
                    writer.WritePropertyName("filePath"u8);
                    writer.WriteStringValue(FilePath);
                }
                else
                {
                    writer.WriteNull("filePath");
                }
            }
            if (Salt != null)
            {
                if (Salt != null)
                {
                    writer.WritePropertyName("salt"u8);
                    writer.WriteStringValue(Salt);
                }
                else
                {
                    writer.WriteNull("salt");
                }
            }
            if (Hash != null)
            {
                if (Hash != null)
                {
                    writer.WritePropertyName("hash"u8);
                    writer.WriteStringValue(Hash);
                }
                else
                {
                    writer.WriteNull("hash");
                }
            }
            if (Context != null)
            {
                if (Context != null)
                {
                    writer.WritePropertyName("context"u8);
                    writer.WriteStringValue(Context);
                }
                else
                {
                    writer.WriteNull("context");
                }
            }
            if (Username != null)
            {
                if (Username != null)
                {
                    writer.WritePropertyName("username"u8);
                    writer.WriteStringValue(Username);
                }
                else
                {
                    writer.WriteNull("username");
                }
            }
            if (Algorithm != null)
            {
                if (Algorithm != null)
                {
                    writer.WritePropertyName("algorithm"u8);
                    writer.WriteStringValue(Algorithm);
                }
                else
                {
                    writer.WriteNull("algorithm");
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

        PasswordHash IJsonModel<PasswordHash>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PasswordHash>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PasswordHash)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePasswordHash(document.RootElement, options);
        }

        internal static PasswordHash DeserializePasswordHash(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> passwordHashId = default;
            Optional<string> filePath = default;
            Optional<string> salt = default;
            Optional<string> hash = default;
            Optional<string> context = default;
            Optional<string> username = default;
            Optional<string> algorithm = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("passwordHashId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        passwordHashId = null;
                        continue;
                    }
                    passwordHashId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filePath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        filePath = null;
                        continue;
                    }
                    filePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("salt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        salt = null;
                        continue;
                    }
                    salt = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hash"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        hash = null;
                        continue;
                    }
                    hash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("context"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        context = null;
                        continue;
                    }
                    context = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("username"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        username = null;
                        continue;
                    }
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("algorithm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        algorithm = null;
                        continue;
                    }
                    algorithm = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PasswordHash(passwordHashId.Value, filePath.Value, salt.Value, hash.Value, context.Value, username.Value, algorithm.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PasswordHash>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PasswordHash>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PasswordHash)} does not support '{options.Format}' format.");
            }
        }

        PasswordHash IPersistableModel<PasswordHash>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PasswordHash>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePasswordHash(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PasswordHash)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PasswordHash>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
