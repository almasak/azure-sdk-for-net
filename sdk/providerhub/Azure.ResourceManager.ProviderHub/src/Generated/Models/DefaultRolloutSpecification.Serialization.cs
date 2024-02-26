// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ProviderHub;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class DefaultRolloutSpecification : IUtf8JsonSerializable, IJsonModel<DefaultRolloutSpecification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefaultRolloutSpecification>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DefaultRolloutSpecification>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefaultRolloutSpecification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefaultRolloutSpecification)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Canary != null)
            {
                writer.WritePropertyName("canary"u8);
                writer.WriteObjectValue(Canary);
            }
            if (LowTraffic != null)
            {
                writer.WritePropertyName("lowTraffic"u8);
                writer.WriteObjectValue(LowTraffic);
            }
            if (MediumTraffic != null)
            {
                writer.WritePropertyName("mediumTraffic"u8);
                writer.WriteObjectValue(MediumTraffic);
            }
            if (HighTraffic != null)
            {
                writer.WritePropertyName("highTraffic"u8);
                writer.WriteObjectValue(HighTraffic);
            }
            if (RestOfTheWorldGroupOne != null)
            {
                writer.WritePropertyName("restOfTheWorldGroupOne"u8);
                writer.WriteObjectValue(RestOfTheWorldGroupOne);
            }
            if (RestOfTheWorldGroupTwo != null)
            {
                writer.WritePropertyName("restOfTheWorldGroupTwo"u8);
                writer.WriteObjectValue(RestOfTheWorldGroupTwo);
            }
            if (ProviderRegistration != null)
            {
                writer.WritePropertyName("providerRegistration"u8);
                writer.WriteObjectValue(ProviderRegistration);
            }
            if (!(ResourceTypeRegistrations is ChangeTrackingList<ResourceTypeRegistrationData> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("resourceTypeRegistrations"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceTypeRegistrations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        DefaultRolloutSpecification IJsonModel<DefaultRolloutSpecification>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefaultRolloutSpecification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefaultRolloutSpecification)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefaultRolloutSpecification(document.RootElement, options);
        }

        internal static DefaultRolloutSpecification DeserializeDefaultRolloutSpecification(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CanaryTrafficRegionRolloutConfiguration> canary = default;
            Optional<TrafficRegionRolloutConfiguration> lowTraffic = default;
            Optional<TrafficRegionRolloutConfiguration> mediumTraffic = default;
            Optional<TrafficRegionRolloutConfiguration> highTraffic = default;
            Optional<TrafficRegionRolloutConfiguration> restOfTheWorldGroupOne = default;
            Optional<TrafficRegionRolloutConfiguration> restOfTheWorldGroupTwo = default;
            Optional<ProviderRegistrationData> providerRegistration = default;
            IList<ResourceTypeRegistrationData> resourceTypeRegistrations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("canary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    canary = CanaryTrafficRegionRolloutConfiguration.DeserializeCanaryTrafficRegionRolloutConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("lowTraffic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lowTraffic = TrafficRegionRolloutConfiguration.DeserializeTrafficRegionRolloutConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("mediumTraffic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mediumTraffic = TrafficRegionRolloutConfiguration.DeserializeTrafficRegionRolloutConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("highTraffic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    highTraffic = TrafficRegionRolloutConfiguration.DeserializeTrafficRegionRolloutConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("restOfTheWorldGroupOne"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restOfTheWorldGroupOne = TrafficRegionRolloutConfiguration.DeserializeTrafficRegionRolloutConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("restOfTheWorldGroupTwo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restOfTheWorldGroupTwo = TrafficRegionRolloutConfiguration.DeserializeTrafficRegionRolloutConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("providerRegistration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerRegistration = ProviderRegistrationData.DeserializeProviderRegistrationData(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resourceTypeRegistrations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceTypeRegistrationData> array = new List<ResourceTypeRegistrationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceTypeRegistrationData.DeserializeResourceTypeRegistrationData(item, options));
                    }
                    resourceTypeRegistrations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DefaultRolloutSpecification(canary.Value, lowTraffic.Value, mediumTraffic.Value, highTraffic.Value, restOfTheWorldGroupOne.Value, restOfTheWorldGroupTwo.Value, providerRegistration.Value, resourceTypeRegistrations ?? new ChangeTrackingList<ResourceTypeRegistrationData>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefaultRolloutSpecification>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefaultRolloutSpecification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefaultRolloutSpecification)} does not support '{options.Format}' format.");
            }
        }

        DefaultRolloutSpecification IPersistableModel<DefaultRolloutSpecification>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefaultRolloutSpecification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefaultRolloutSpecification(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefaultRolloutSpecification)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefaultRolloutSpecification>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
