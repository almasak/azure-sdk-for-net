// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureArcKubernetesArtifactProfile : IUtf8JsonSerializable, IJsonModel<AzureArcKubernetesArtifactProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureArcKubernetesArtifactProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureArcKubernetesArtifactProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureArcKubernetesArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureArcKubernetesArtifactProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (HelmArtifactProfile != null)
            {
                writer.WritePropertyName("helmArtifactProfile"u8);
                writer.WriteObjectValue(HelmArtifactProfile);
            }
            if (ArtifactStore != null)
            {
                writer.WritePropertyName("artifactStore"u8);
                JsonSerializer.Serialize(writer, ArtifactStore);
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

        AzureArcKubernetesArtifactProfile IJsonModel<AzureArcKubernetesArtifactProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureArcKubernetesArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureArcKubernetesArtifactProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureArcKubernetesArtifactProfile(document.RootElement, options);
        }

        internal static AzureArcKubernetesArtifactProfile DeserializeAzureArcKubernetesArtifactProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HelmArtifactProfile> helmArtifactProfile = default;
            Optional<WritableSubResource> artifactStore = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("helmArtifactProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    helmArtifactProfile = HelmArtifactProfile.DeserializeHelmArtifactProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("artifactStore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactStore = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureArcKubernetesArtifactProfile(artifactStore, serializedAdditionalRawData, helmArtifactProfile.Value);
        }

        BinaryData IPersistableModel<AzureArcKubernetesArtifactProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureArcKubernetesArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureArcKubernetesArtifactProfile)} does not support '{options.Format}' format.");
            }
        }

        AzureArcKubernetesArtifactProfile IPersistableModel<AzureArcKubernetesArtifactProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureArcKubernetesArtifactProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureArcKubernetesArtifactProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureArcKubernetesArtifactProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureArcKubernetesArtifactProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
