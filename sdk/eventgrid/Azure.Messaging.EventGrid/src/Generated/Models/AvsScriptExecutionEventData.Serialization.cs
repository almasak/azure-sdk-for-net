// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AvsScriptExecutionEventDataConverter))]
    public partial class AvsScriptExecutionEventData
    {
        internal static AvsScriptExecutionEventData DeserializeAvsScriptExecutionEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> operationId = default;
            Optional<string> cmdletId = default;
            IReadOnlyList<string> output = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cmdletId"u8))
                {
                    cmdletId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    output = array;
                    continue;
                }
            }
            return new AvsScriptExecutionEventData(operationId.Value, cmdletId.Value, output ?? new ChangeTrackingList<string>());
        }

        internal partial class AvsScriptExecutionEventDataConverter : JsonConverter<AvsScriptExecutionEventData>
        {
            public override void Write(Utf8JsonWriter writer, AvsScriptExecutionEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override AvsScriptExecutionEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAvsScriptExecutionEventData(document.RootElement);
            }
        }
    }
}
