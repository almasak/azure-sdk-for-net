// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    public partial class GitHubConnectorStatsProperties : IUtf8JsonSerializable, IJsonModel<GitHubConnectorStatsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GitHubConnectorStatsProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GitHubConnectorStatsProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubConnectorStatsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GitHubConnectorStatsProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (OwnersCount.HasValue)
            {
                writer.WritePropertyName("ownersCount"u8);
                writer.WriteNumberValue(OwnersCount.Value);
            }
            if (ReposCount.HasValue)
            {
                writer.WritePropertyName("reposCount"u8);
                writer.WriteNumberValue(ReposCount.Value);
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

        GitHubConnectorStatsProperties IJsonModel<GitHubConnectorStatsProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubConnectorStatsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GitHubConnectorStatsProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGitHubConnectorStatsProperties(document.RootElement, options);
        }

        internal static GitHubConnectorStatsProperties DeserializeGitHubConnectorStatsProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProvisioningState> provisioningState = default;
            Optional<long> ownersCount = default;
            Optional<long> reposCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ownersCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ownersCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("reposCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reposCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GitHubConnectorStatsProperties(Optional.ToNullable(provisioningState), Optional.ToNullable(ownersCount), Optional.ToNullable(reposCount), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GitHubConnectorStatsProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubConnectorStatsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GitHubConnectorStatsProperties)} does not support '{options.Format}' format.");
            }
        }

        GitHubConnectorStatsProperties IPersistableModel<GitHubConnectorStatsProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubConnectorStatsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGitHubConnectorStatsProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GitHubConnectorStatsProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GitHubConnectorStatsProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
