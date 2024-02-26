// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(ActivityPolicyConverter))]
    public partial class ActivityPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Timeout != null)
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteObjectValue(Timeout);
            }
            if (Retry != null)
            {
                writer.WritePropertyName("retry"u8);
                writer.WriteObjectValue(Retry);
            }
            if (RetryIntervalInSeconds.HasValue)
            {
                writer.WritePropertyName("retryIntervalInSeconds"u8);
                writer.WriteNumberValue(RetryIntervalInSeconds.Value);
            }
            if (SecureInput.HasValue)
            {
                writer.WritePropertyName("secureInput"u8);
                writer.WriteBooleanValue(SecureInput.Value);
            }
            if (SecureOutput.HasValue)
            {
                writer.WritePropertyName("secureOutput"u8);
                writer.WriteBooleanValue(SecureOutput.Value);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static ActivityPolicy DeserializeActivityPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> timeout = default;
            Optional<object> retry = default;
            Optional<int> retryIntervalInSeconds = default;
            Optional<bool> secureInput = default;
            Optional<bool> secureOutput = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("retry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retry = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("retryIntervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retryIntervalInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("secureInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secureInput = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("secureOutput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secureOutput = property.Value.GetBoolean();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ActivityPolicy(timeout.Value, retry.Value, Optional.ToNullable(retryIntervalInSeconds), Optional.ToNullable(secureInput), Optional.ToNullable(secureOutput), additionalProperties);
        }

        internal partial class ActivityPolicyConverter : JsonConverter<ActivityPolicy>
        {
            public override void Write(Utf8JsonWriter writer, ActivityPolicy model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ActivityPolicy Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeActivityPolicy(document.RootElement);
            }
        }
    }
}
