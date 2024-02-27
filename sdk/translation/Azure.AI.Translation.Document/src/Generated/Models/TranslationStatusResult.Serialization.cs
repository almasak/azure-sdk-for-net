// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.AI.Translation.Document.Models;
using Azure.Core;

namespace Azure.AI.Translation.Document
{
    public partial class TranslationStatusResult
    {
        internal static TranslationStatusResult DeserializeTranslationStatusResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            DateTimeOffset createdDateTimeUtc = default;
            DateTimeOffset lastActionDateTimeUtc = default;
            DocumentTranslationStatus status = default;
            Optional<JsonElement> error = default;
            StatusSummary summary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTimeUtc"u8))
                {
                    createdDateTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastActionDateTimeUtc"u8))
                {
                    lastActionDateTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new DocumentTranslationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.Clone();
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    summary = StatusSummary.DeserializeStatusSummary(property.Value);
                    continue;
                }
            }
            return new TranslationStatusResult(
                id,
                createdDateTimeUtc,
                lastActionDateTimeUtc,
                status,
                error,
                summary);
        }
    }
}
