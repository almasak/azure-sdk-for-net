// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    public partial class PresentationLayout : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("presenterId"u8);
            writer.WriteStringValue(PresenterId);
            writer.WritePropertyName("audienceIds"u8);
            writer.WriteStartArray();
            foreach (var item in AudienceIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (AudiencePosition.HasValue)
            {
                writer.WritePropertyName("audiencePosition"u8);
                writer.WriteStringValue(AudiencePosition.Value.ToString());
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Resolution != null)
            {
                writer.WritePropertyName("resolution"u8);
                writer.WriteObjectValue(Resolution);
            }
            if (PlaceholderImageUri != null)
            {
                writer.WritePropertyName("placeholderImageUri"u8);
                writer.WriteStringValue(PlaceholderImageUri);
            }
            if (ScalingMode.HasValue)
            {
                writer.WritePropertyName("scalingMode"u8);
                writer.WriteStringValue(ScalingMode.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static PresentationLayout DeserializePresentationLayout(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string presenterId = default;
            IList<string> audienceIds = default;
            Optional<AudiencePosition> audiencePosition = default;
            LayoutType kind = default;
            Optional<LayoutResolution> resolution = default;
            Optional<string> placeholderImageUri = default;
            Optional<ScalingMode> scalingMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("presenterId"u8))
                {
                    presenterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("audienceIds"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    audienceIds = array;
                    continue;
                }
                if (property.NameEquals("audiencePosition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    audiencePosition = new AudiencePosition(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new LayoutType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resolution"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resolution = LayoutResolution.DeserializeLayoutResolution(property.Value);
                    continue;
                }
                if (property.NameEquals("placeholderImageUri"u8))
                {
                    placeholderImageUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scalingMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scalingMode = new ScalingMode(property.Value.GetString());
                    continue;
                }
            }
            return new PresentationLayout(kind, resolution.Value, placeholderImageUri.Value, Optional.ToNullable(scalingMode), presenterId, audienceIds, Optional.ToNullable(audiencePosition));
        }
    }
}
