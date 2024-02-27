// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SparkServicePluginConverter))]
    public partial class SparkServicePlugin
    {
        internal static SparkServicePlugin DeserializeSparkServicePlugin(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset?> preparationStartedAt = default;
            Optional<DateTimeOffset?> resourceAcquisitionStartedAt = default;
            Optional<DateTimeOffset?> submissionStartedAt = default;
            Optional<DateTimeOffset?> monitoringStartedAt = default;
            Optional<DateTimeOffset?> cleanupStartedAt = default;
            Optional<PluginCurrentState> currentState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preparationStartedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        preparationStartedAt = null;
                        continue;
                    }
                    preparationStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("resourceAcquisitionStartedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceAcquisitionStartedAt = null;
                        continue;
                    }
                    resourceAcquisitionStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("submissionStartedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        submissionStartedAt = null;
                        continue;
                    }
                    submissionStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("monitoringStartedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        monitoringStartedAt = null;
                        continue;
                    }
                    monitoringStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cleanupStartedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cleanupStartedAt = null;
                        continue;
                    }
                    cleanupStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentState = new PluginCurrentState(property.Value.GetString());
                    continue;
                }
            }
            return new SparkServicePlugin(
                Optional.ToNullable(preparationStartedAt),
                Optional.ToNullable(resourceAcquisitionStartedAt),
                Optional.ToNullable(submissionStartedAt),
                Optional.ToNullable(monitoringStartedAt),
                Optional.ToNullable(cleanupStartedAt),
                Optional.ToNullable(currentState));
        }

        internal partial class SparkServicePluginConverter : JsonConverter<SparkServicePlugin>
        {
            public override void Write(Utf8JsonWriter writer, SparkServicePlugin model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override SparkServicePlugin Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSparkServicePlugin(document.RootElement);
            }
        }
    }
}
