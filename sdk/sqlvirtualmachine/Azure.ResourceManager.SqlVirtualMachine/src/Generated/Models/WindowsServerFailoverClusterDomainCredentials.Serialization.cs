// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class WindowsServerFailoverClusterDomainCredentials : IUtf8JsonSerializable, IJsonModel<WindowsServerFailoverClusterDomainCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WindowsServerFailoverClusterDomainCredentials>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WindowsServerFailoverClusterDomainCredentials>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsServerFailoverClusterDomainCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WindowsServerFailoverClusterDomainCredentials)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ClusterBootstrapAccountPassword != null)
            {
                writer.WritePropertyName("clusterBootstrapAccountPassword"u8);
                writer.WriteStringValue(ClusterBootstrapAccountPassword);
            }
            if (ClusterOperatorAccountPassword != null)
            {
                writer.WritePropertyName("clusterOperatorAccountPassword"u8);
                writer.WriteStringValue(ClusterOperatorAccountPassword);
            }
            if (SqlServiceAccountPassword != null)
            {
                writer.WritePropertyName("sqlServiceAccountPassword"u8);
                writer.WriteStringValue(SqlServiceAccountPassword);
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

        WindowsServerFailoverClusterDomainCredentials IJsonModel<WindowsServerFailoverClusterDomainCredentials>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsServerFailoverClusterDomainCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WindowsServerFailoverClusterDomainCredentials)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWindowsServerFailoverClusterDomainCredentials(document.RootElement, options);
        }

        internal static WindowsServerFailoverClusterDomainCredentials DeserializeWindowsServerFailoverClusterDomainCredentials(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> clusterBootstrapAccountPassword = default;
            Optional<string> clusterOperatorAccountPassword = default;
            Optional<string> sqlServiceAccountPassword = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterBootstrapAccountPassword"u8))
                {
                    clusterBootstrapAccountPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterOperatorAccountPassword"u8))
                {
                    clusterOperatorAccountPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sqlServiceAccountPassword"u8))
                {
                    sqlServiceAccountPassword = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WindowsServerFailoverClusterDomainCredentials(clusterBootstrapAccountPassword.Value, clusterOperatorAccountPassword.Value, sqlServiceAccountPassword.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WindowsServerFailoverClusterDomainCredentials>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsServerFailoverClusterDomainCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WindowsServerFailoverClusterDomainCredentials)} does not support '{options.Format}' format.");
            }
        }

        WindowsServerFailoverClusterDomainCredentials IPersistableModel<WindowsServerFailoverClusterDomainCredentials>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsServerFailoverClusterDomainCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWindowsServerFailoverClusterDomainCredentials(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WindowsServerFailoverClusterDomainCredentials)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WindowsServerFailoverClusterDomainCredentials>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
