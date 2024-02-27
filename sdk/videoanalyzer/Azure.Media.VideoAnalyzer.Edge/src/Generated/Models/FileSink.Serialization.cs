// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class FileSink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("baseDirectoryPath"u8);
            writer.WriteStringValue(BaseDirectoryPath);
            writer.WritePropertyName("fileNamePattern"u8);
            writer.WriteStringValue(FileNamePattern);
            writer.WritePropertyName("maximumSizeMiB"u8);
            writer.WriteStringValue(MaximumSizeMiB);
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("inputs"u8);
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static FileSink DeserializeFileSink(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string baseDirectoryPath = default;
            string fileNamePattern = default;
            string maximumSizeMiB = default;
            string type = default;
            string name = default;
            IList<NodeInput> inputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("baseDirectoryPath"u8))
                {
                    baseDirectoryPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileNamePattern"u8))
                {
                    fileNamePattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maximumSizeMiB"u8))
                {
                    maximumSizeMiB = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    List<NodeInput> array = new List<NodeInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NodeInput.DeserializeNodeInput(item));
                    }
                    inputs = array;
                    continue;
                }
            }
            return new FileSink(
                type,
                name,
                inputs,
                baseDirectoryPath,
                fileNamePattern,
                maximumSizeMiB);
        }
    }
}
