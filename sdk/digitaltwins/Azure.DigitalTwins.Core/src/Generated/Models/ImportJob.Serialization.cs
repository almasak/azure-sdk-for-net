// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.DigitalTwins.Core
{
    public partial class ImportJob : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("inputBlobUri"u8);
            writer.WriteStringValue(InputBlobUri.AbsoluteUri);
            writer.WritePropertyName("outputBlobUri"u8);
            writer.WriteStringValue(OutputBlobUri.AbsoluteUri);
            if (Error != null)
            {
                writer.WritePropertyName("error"u8);
                SerializeErrorValue(writer);
            }
            writer.WriteEndObject();
        }

        internal static ImportJob DeserializeImportJob(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Uri inputBlobUri = default;
            Uri outputBlobUri = default;
            Optional<ImportJobStatus> status = default;
            Optional<DateTimeOffset> createdDateTime = default;
            Optional<DateTimeOffset> lastActionDateTime = default;
            Optional<DateTimeOffset> finishedDateTime = default;
            Optional<DateTimeOffset> purgeDateTime = default;
            Optional<ResponseError> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputBlobUri"u8))
                {
                    inputBlobUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("outputBlobUri"u8))
                {
                    outputBlobUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ImportJobStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastActionDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastActionDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("finishedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    finishedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("purgeDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    purgeDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
            }
            return new ImportJob(
                id.Value,
                inputBlobUri,
                outputBlobUri,
                Optional.ToNullable(status),
                Optional.ToNullable(createdDateTime),
                Optional.ToNullable(lastActionDateTime),
                Optional.ToNullable(finishedDateTime),
                Optional.ToNullable(purgeDateTime),
                error.Value);
        }
    }
}
