// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class AccessControlListMatchConfiguration : IUtf8JsonSerializable, IJsonModel<AccessControlListMatchConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AccessControlListMatchConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AccessControlListMatchConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessControlListMatchConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AccessControlListMatchConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (MatchConfigurationName != null)
            {
                writer.WritePropertyName("matchConfigurationName"u8);
                writer.WriteStringValue(MatchConfigurationName);
            }
            if (SequenceNumber.HasValue)
            {
                writer.WritePropertyName("sequenceNumber"u8);
                writer.WriteNumberValue(SequenceNumber.Value);
            }
            if (IPAddressType.HasValue)
            {
                writer.WritePropertyName("ipAddressType"u8);
                writer.WriteStringValue(IPAddressType.Value.ToString());
            }
            if (!(MatchConditions is ChangeTrackingList<AccessControlListMatchCondition> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("matchConditions"u8);
                writer.WriteStartArray();
                foreach (var item in MatchConditions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Actions is ChangeTrackingList<AccessControlListAction> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("actions"u8);
                writer.WriteStartArray();
                foreach (var item in Actions)
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

        AccessControlListMatchConfiguration IJsonModel<AccessControlListMatchConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessControlListMatchConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AccessControlListMatchConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAccessControlListMatchConfiguration(document.RootElement, options);
        }

        internal static AccessControlListMatchConfiguration DeserializeAccessControlListMatchConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> matchConfigurationName = default;
            Optional<long> sequenceNumber = default;
            Optional<NetworkFabricIPAddressType> ipAddressType = default;
            IList<AccessControlListMatchCondition> matchConditions = default;
            IList<AccessControlListAction> actions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("matchConfigurationName"u8))
                {
                    matchConfigurationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequenceNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sequenceNumber = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("ipAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddressType = new NetworkFabricIPAddressType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("matchConditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AccessControlListMatchCondition> array = new List<AccessControlListMatchCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AccessControlListMatchCondition.DeserializeAccessControlListMatchCondition(item, options));
                    }
                    matchConditions = array;
                    continue;
                }
                if (property.NameEquals("actions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AccessControlListAction> array = new List<AccessControlListAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AccessControlListAction.DeserializeAccessControlListAction(item, options));
                    }
                    actions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AccessControlListMatchConfiguration(matchConfigurationName.Value, Optional.ToNullable(sequenceNumber), Optional.ToNullable(ipAddressType), matchConditions ?? new ChangeTrackingList<AccessControlListMatchCondition>(), actions ?? new ChangeTrackingList<AccessControlListAction>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AccessControlListMatchConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessControlListMatchConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AccessControlListMatchConfiguration)} does not support '{options.Format}' format.");
            }
        }

        AccessControlListMatchConfiguration IPersistableModel<AccessControlListMatchConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessControlListMatchConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAccessControlListMatchConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AccessControlListMatchConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AccessControlListMatchConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
