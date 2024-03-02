﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary>
    /// This class definition overrides serialization and deserialization implementation in
    /// order to turn Time Series Ids from a strongly typed object to an list of objects that
    /// the service can understand, and vice versa.
    /// </summary>
    internal partial class AggregateSeries : IUtf8JsonSerializable
    {
        // The use of fully qualified name for IUtf8JsonSerializable is a work around until this
        // issue is fixed: https://github.com/Azure/autorest.csharp/issues/793
        void global::Azure.Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("timeSeriesId");
            writer.WriteStartArray();
            foreach (var item in TimeSeriesId.ToStringArray())
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("searchSpan");
            writer.WriteObjectValue(SearchSpan);
            if (Filter != null)
            {
                writer.WritePropertyName("filter");
                writer.WriteObjectValue(Filter);
            }
            writer.WritePropertyName("interval");
            writer.WriteStringValue(Interval, "P");
            if (!(ProjectedVariables is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("projectedVariables");
                writer.WriteStartArray();
                foreach (var item in ProjectedVariables)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(InlineVariables is ChangeTrackingDictionary<string, TimeSeriesVariable> dictionary && dictionary.IsUndefined))
            {
                writer.WritePropertyName("inlineVariables");
                writer.WriteStartObject();
                foreach (var item in InlineVariables)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }
    }
}
