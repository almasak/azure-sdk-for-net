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
    [JsonConverter(typeof(DataFlowDebugQueryResponseConverter))]
    public partial class DataFlowDebugQueryResponse : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (RunId != null)
            {
                writer.WritePropertyName("runId"u8);
                writer.WriteStringValue(RunId);
            }
            writer.WriteEndObject();
        }

        internal static DataFlowDebugQueryResponse DeserializeDataFlowDebugQueryResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> runId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("runId"u8))
                {
                    runId = property.Value.GetString();
                    continue;
                }
            }
            return new DataFlowDebugQueryResponse(runId.Value);
        }

        internal partial class DataFlowDebugQueryResponseConverter : JsonConverter<DataFlowDebugQueryResponse>
        {
            public override void Write(Utf8JsonWriter writer, DataFlowDebugQueryResponse model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DataFlowDebugQueryResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDataFlowDebugQueryResponse(document.RootElement);
            }
        }
    }
}
