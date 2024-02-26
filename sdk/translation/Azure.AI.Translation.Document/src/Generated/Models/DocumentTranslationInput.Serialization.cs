// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Translation.Document
{
    public partial class DocumentTranslationInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("source"u8);
            writer.WriteObjectValue(Source);
            writer.WritePropertyName("targets"u8);
            writer.WriteStartArray();
            foreach (var item in Targets)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (StorageUriKind.HasValue)
            {
                writer.WritePropertyName("storageType"u8);
                writer.WriteStringValue(StorageUriKind.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }
    }
}
