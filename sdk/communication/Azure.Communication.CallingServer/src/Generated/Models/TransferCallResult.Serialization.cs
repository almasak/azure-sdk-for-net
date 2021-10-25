// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class TransferCallResult
    {
        internal static TransferCallResult DeserializeTransferCallResult(JsonElement element)
        {
            Optional<string> operationId = default;
            CallingOperationStatus status = default;
            Optional<string> operationContext = default;
            Optional<CallingOperationResultDetails> resultInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new CallingOperationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operationContext"))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resultInfo = CallingOperationResultDetails.DeserializeCallingOperationResultDetails(property.Value);
                    continue;
                }
            }
            return new TransferCallResult(operationId.Value, status, operationContext.Value, resultInfo.Value);
        }
    }
}
