// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstanceDtcSecuritySettings : IUtf8JsonSerializable, IJsonModel<ManagedInstanceDtcSecuritySettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedInstanceDtcSecuritySettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedInstanceDtcSecuritySettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceDtcSecuritySettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstanceDtcSecuritySettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (TransactionManagerCommunicationSettings != null)
            {
                writer.WritePropertyName("transactionManagerCommunicationSettings"u8);
                writer.WriteObjectValue(TransactionManagerCommunicationSettings);
            }
            if (IsXATransactionsEnabled.HasValue)
            {
                writer.WritePropertyName("xaTransactionsEnabled"u8);
                writer.WriteBooleanValue(IsXATransactionsEnabled.Value);
            }
            if (SnaLu6Point2TransactionsEnabled.HasValue)
            {
                writer.WritePropertyName("snaLu6point2TransactionsEnabled"u8);
                writer.WriteBooleanValue(SnaLu6Point2TransactionsEnabled.Value);
            }
            if (XATransactionsDefaultTimeoutInSeconds.HasValue)
            {
                writer.WritePropertyName("xaTransactionsDefaultTimeout"u8);
                writer.WriteNumberValue(XATransactionsDefaultTimeoutInSeconds.Value);
            }
            if (XATransactionsMaximumTimeoutInSeconds.HasValue)
            {
                writer.WritePropertyName("xaTransactionsMaximumTimeout"u8);
                writer.WriteNumberValue(XATransactionsMaximumTimeoutInSeconds.Value);
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

        ManagedInstanceDtcSecuritySettings IJsonModel<ManagedInstanceDtcSecuritySettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceDtcSecuritySettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstanceDtcSecuritySettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedInstanceDtcSecuritySettings(document.RootElement, options);
        }

        internal static ManagedInstanceDtcSecuritySettings DeserializeManagedInstanceDtcSecuritySettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedInstanceDtcTransactionManagerCommunicationSettings> transactionManagerCommunicationSettings = default;
            Optional<bool> xaTransactionsEnabled = default;
            Optional<bool> snaLu6point2TransactionsEnabled = default;
            Optional<int> xaTransactionsDefaultTimeout = default;
            Optional<int> xaTransactionsMaximumTimeout = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("transactionManagerCommunicationSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transactionManagerCommunicationSettings = ManagedInstanceDtcTransactionManagerCommunicationSettings.DeserializeManagedInstanceDtcTransactionManagerCommunicationSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("xaTransactionsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    xaTransactionsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("snaLu6point2TransactionsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    snaLu6point2TransactionsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("xaTransactionsDefaultTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    xaTransactionsDefaultTimeout = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("xaTransactionsMaximumTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    xaTransactionsMaximumTimeout = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedInstanceDtcSecuritySettings(transactionManagerCommunicationSettings.Value, Optional.ToNullable(xaTransactionsEnabled), Optional.ToNullable(snaLu6point2TransactionsEnabled), Optional.ToNullable(xaTransactionsDefaultTimeout), Optional.ToNullable(xaTransactionsMaximumTimeout), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedInstanceDtcSecuritySettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceDtcSecuritySettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedInstanceDtcSecuritySettings)} does not support '{options.Format}' format.");
            }
        }

        ManagedInstanceDtcSecuritySettings IPersistableModel<ManagedInstanceDtcSecuritySettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceDtcSecuritySettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedInstanceDtcSecuritySettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedInstanceDtcSecuritySettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedInstanceDtcSecuritySettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
