// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class PublicLandMobileNetworkHomeNetworkPublicKeys : IUtf8JsonSerializable, IJsonModel<PublicLandMobileNetworkHomeNetworkPublicKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PublicLandMobileNetworkHomeNetworkPublicKeys>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PublicLandMobileNetworkHomeNetworkPublicKeys>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicLandMobileNetworkHomeNetworkPublicKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PublicLandMobileNetworkHomeNetworkPublicKeys)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ProfileA))
            {
                writer.WritePropertyName("profileA"u8);
                writer.WriteStartArray();
                foreach (var item in ProfileA)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ProfileB))
            {
                writer.WritePropertyName("profileB"u8);
                writer.WriteStartArray();
                foreach (var item in ProfileB)
                {
                    writer.WriteObjectValue(item, options);
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

        PublicLandMobileNetworkHomeNetworkPublicKeys IJsonModel<PublicLandMobileNetworkHomeNetworkPublicKeys>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicLandMobileNetworkHomeNetworkPublicKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PublicLandMobileNetworkHomeNetworkPublicKeys)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePublicLandMobileNetworkHomeNetworkPublicKeys(document.RootElement, options);
        }

        internal static PublicLandMobileNetworkHomeNetworkPublicKeys DeserializePublicLandMobileNetworkHomeNetworkPublicKeys(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<HomeNetworkPublicKey> profileA = default;
            IList<HomeNetworkPublicKey> profileB = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profileA"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HomeNetworkPublicKey> array = new List<HomeNetworkPublicKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HomeNetworkPublicKey.DeserializeHomeNetworkPublicKey(item, options));
                    }
                    profileA = array;
                    continue;
                }
                if (property.NameEquals("profileB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HomeNetworkPublicKey> array = new List<HomeNetworkPublicKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HomeNetworkPublicKey.DeserializeHomeNetworkPublicKey(item, options));
                    }
                    profileB = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PublicLandMobileNetworkHomeNetworkPublicKeys(profileA ?? new ChangeTrackingList<HomeNetworkPublicKey>(), profileB ?? new ChangeTrackingList<HomeNetworkPublicKey>(), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProfileA), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  profileA: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ProfileA))
                {
                    if (ProfileA.Any())
                    {
                        builder.Append("  profileA: ");
                        builder.AppendLine("[");
                        foreach (var item in ProfileA)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  profileA: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProfileB), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  profileB: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ProfileB))
                {
                    if (ProfileB.Any())
                    {
                        builder.Append("  profileB: ");
                        builder.AppendLine("[");
                        foreach (var item in ProfileB)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  profileB: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<PublicLandMobileNetworkHomeNetworkPublicKeys>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicLandMobileNetworkHomeNetworkPublicKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PublicLandMobileNetworkHomeNetworkPublicKeys)} does not support writing '{options.Format}' format.");
            }
        }

        PublicLandMobileNetworkHomeNetworkPublicKeys IPersistableModel<PublicLandMobileNetworkHomeNetworkPublicKeys>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicLandMobileNetworkHomeNetworkPublicKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePublicLandMobileNetworkHomeNetworkPublicKeys(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PublicLandMobileNetworkHomeNetworkPublicKeys)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PublicLandMobileNetworkHomeNetworkPublicKeys>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
