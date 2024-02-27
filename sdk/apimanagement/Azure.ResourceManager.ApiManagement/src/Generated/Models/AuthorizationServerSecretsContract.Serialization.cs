// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class AuthorizationServerSecretsContract : IUtf8JsonSerializable, IJsonModel<AuthorizationServerSecretsContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AuthorizationServerSecretsContract>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AuthorizationServerSecretsContract>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthorizationServerSecretsContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AuthorizationServerSecretsContract)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ClientSecret != null)
            {
                writer.WritePropertyName("clientSecret"u8);
                writer.WriteStringValue(ClientSecret);
            }
            if (ResourceOwnerUsername != null)
            {
                writer.WritePropertyName("resourceOwnerUsername"u8);
                writer.WriteStringValue(ResourceOwnerUsername);
            }
            if (ResourceOwnerPassword != null)
            {
                writer.WritePropertyName("resourceOwnerPassword"u8);
                writer.WriteStringValue(ResourceOwnerPassword);
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

        AuthorizationServerSecretsContract IJsonModel<AuthorizationServerSecretsContract>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthorizationServerSecretsContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AuthorizationServerSecretsContract)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAuthorizationServerSecretsContract(document.RootElement, options);
        }

        internal static AuthorizationServerSecretsContract DeserializeAuthorizationServerSecretsContract(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> clientSecret = default;
            Optional<string> resourceOwnerUsername = default;
            Optional<string> resourceOwnerPassword = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientSecret"u8))
                {
                    clientSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceOwnerUsername"u8))
                {
                    resourceOwnerUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceOwnerPassword"u8))
                {
                    resourceOwnerPassword = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AuthorizationServerSecretsContract(clientSecret.Value, resourceOwnerUsername.Value, resourceOwnerPassword.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AuthorizationServerSecretsContract>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthorizationServerSecretsContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AuthorizationServerSecretsContract)} does not support '{options.Format}' format.");
            }
        }

        AuthorizationServerSecretsContract IPersistableModel<AuthorizationServerSecretsContract>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthorizationServerSecretsContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAuthorizationServerSecretsContract(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AuthorizationServerSecretsContract)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AuthorizationServerSecretsContract>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
