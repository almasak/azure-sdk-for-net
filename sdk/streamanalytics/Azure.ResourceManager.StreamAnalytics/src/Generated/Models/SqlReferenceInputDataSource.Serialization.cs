// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class SqlReferenceInputDataSource : IUtf8JsonSerializable, IJsonModel<SqlReferenceInputDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlReferenceInputDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlReferenceInputDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlReferenceInputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlReferenceInputDataSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ReferenceInputDataSourceType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Server != null)
            {
                writer.WritePropertyName("server"u8);
                writer.WriteStringValue(Server);
            }
            if (Database != null)
            {
                writer.WritePropertyName("database"u8);
                writer.WriteStringValue(Database);
            }
            if (User != null)
            {
                writer.WritePropertyName("user"u8);
                writer.WriteStringValue(User);
            }
            if (Password != null)
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (RefreshType.HasValue)
            {
                writer.WritePropertyName("refreshType"u8);
                writer.WriteStringValue(RefreshType.Value.ToString());
            }
            if (RefreshInterval.HasValue)
            {
                writer.WritePropertyName("refreshRate"u8);
                writer.WriteStringValue(RefreshInterval.Value, "T");
            }
            if (FullSnapshotQuery != null)
            {
                writer.WritePropertyName("fullSnapshotQuery"u8);
                writer.WriteStringValue(FullSnapshotQuery);
            }
            if (DeltaSnapshotQuery != null)
            {
                writer.WritePropertyName("deltaSnapshotQuery"u8);
                writer.WriteStringValue(DeltaSnapshotQuery);
            }
            if (AuthenticationMode.HasValue)
            {
                writer.WritePropertyName("authenticationMode"u8);
                writer.WriteStringValue(AuthenticationMode.Value.ToString());
            }
            writer.WriteEndObject();
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

        SqlReferenceInputDataSource IJsonModel<SqlReferenceInputDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlReferenceInputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlReferenceInputDataSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlReferenceInputDataSource(document.RootElement, options);
        }

        internal static SqlReferenceInputDataSource DeserializeSqlReferenceInputDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> server = default;
            Optional<string> database = default;
            Optional<string> user = default;
            Optional<string> password = default;
            Optional<DataRefreshType> refreshType = default;
            Optional<TimeSpan> refreshRate = default;
            Optional<string> fullSnapshotQuery = default;
            Optional<string> deltaSnapshotQuery = default;
            Optional<StreamAnalyticsAuthenticationMode> authenticationMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("server"u8))
                        {
                            server = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("database"u8))
                        {
                            database = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("user"u8))
                        {
                            user = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            password = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("refreshType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            refreshType = new DataRefreshType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("refreshRate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            refreshRate = property0.Value.GetTimeSpan("T");
                            continue;
                        }
                        if (property0.NameEquals("fullSnapshotQuery"u8))
                        {
                            fullSnapshotQuery = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deltaSnapshotQuery"u8))
                        {
                            deltaSnapshotQuery = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationMode = new StreamAnalyticsAuthenticationMode(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlReferenceInputDataSource(type, serializedAdditionalRawData, server.Value, database.Value, user.Value, password.Value, Optional.ToNullable(refreshType), Optional.ToNullable(refreshRate), fullSnapshotQuery.Value, deltaSnapshotQuery.Value, Optional.ToNullable(authenticationMode));
        }

        BinaryData IPersistableModel<SqlReferenceInputDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlReferenceInputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlReferenceInputDataSource)} does not support '{options.Format}' format.");
            }
        }

        SqlReferenceInputDataSource IPersistableModel<SqlReferenceInputDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlReferenceInputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlReferenceInputDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlReferenceInputDataSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlReferenceInputDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
