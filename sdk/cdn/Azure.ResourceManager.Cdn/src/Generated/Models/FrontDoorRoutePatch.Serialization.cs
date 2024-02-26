// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class FrontDoorRoutePatch : IUtf8JsonSerializable, IJsonModel<FrontDoorRoutePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FrontDoorRoutePatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FrontDoorRoutePatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorRoutePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorRoutePatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && EndpointName != null)
            {
                writer.WritePropertyName("endpointName"u8);
                writer.WriteStringValue(EndpointName);
            }
            if (!(CustomDomains is ChangeTrackingList<FrontDoorActivatedResourceInfo> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("customDomains"u8);
                writer.WriteStartArray();
                foreach (var item in CustomDomains)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (OriginGroup != null)
            {
                writer.WritePropertyName("originGroup"u8);
                JsonSerializer.Serialize(writer, OriginGroup);
            }
            if (OriginPath != null)
            {
                writer.WritePropertyName("originPath"u8);
                writer.WriteStringValue(OriginPath);
            }
            if (!(RuleSets is ChangeTrackingList<WritableSubResource> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("ruleSets"u8);
                writer.WriteStartArray();
                foreach (var item in RuleSets)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (!(SupportedProtocols is ChangeTrackingList<FrontDoorEndpointProtocol> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("supportedProtocols"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (!(PatternsToMatch is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("patternsToMatch"u8);
                writer.WriteStartArray();
                foreach (var item in PatternsToMatch)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (CacheConfiguration != null)
            {
                if (CacheConfiguration != null)
                {
                    writer.WritePropertyName("cacheConfiguration"u8);
                    writer.WriteObjectValue(CacheConfiguration);
                }
                else
                {
                    writer.WriteNull("cacheConfiguration");
                }
            }
            if (ForwardingProtocol.HasValue)
            {
                writer.WritePropertyName("forwardingProtocol"u8);
                writer.WriteStringValue(ForwardingProtocol.Value.ToString());
            }
            if (LinkToDefaultDomain.HasValue)
            {
                writer.WritePropertyName("linkToDefaultDomain"u8);
                writer.WriteStringValue(LinkToDefaultDomain.Value.ToString());
            }
            if (HttpsRedirect.HasValue)
            {
                writer.WritePropertyName("httpsRedirect"u8);
                writer.WriteStringValue(HttpsRedirect.Value.ToString());
            }
            if (EnabledState.HasValue)
            {
                writer.WritePropertyName("enabledState"u8);
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        FrontDoorRoutePatch IJsonModel<FrontDoorRoutePatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorRoutePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorRoutePatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFrontDoorRoutePatch(document.RootElement, options);
        }

        internal static FrontDoorRoutePatch DeserializeFrontDoorRoutePatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> endpointName = default;
            IList<FrontDoorActivatedResourceInfo> customDomains = default;
            Optional<WritableSubResource> originGroup = default;
            Optional<string> originPath = default;
            IList<WritableSubResource> ruleSets = default;
            IList<FrontDoorEndpointProtocol> supportedProtocols = default;
            IList<string> patternsToMatch = default;
            Optional<FrontDoorRouteCacheConfiguration> cacheConfiguration = default;
            Optional<ForwardingProtocol> forwardingProtocol = default;
            Optional<LinkToDefaultDomain> linkToDefaultDomain = default;
            Optional<HttpsRedirect> httpsRedirect = default;
            Optional<EnabledState> enabledState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("endpointName"u8))
                        {
                            endpointName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customDomains"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FrontDoorActivatedResourceInfo> array = new List<FrontDoorActivatedResourceInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FrontDoorActivatedResourceInfo.DeserializeFrontDoorActivatedResourceInfo(item, options));
                            }
                            customDomains = array;
                            continue;
                        }
                        if (property0.NameEquals("originGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            originGroup = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("originPath"u8))
                        {
                            originPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleSets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            ruleSets = array;
                            continue;
                        }
                        if (property0.NameEquals("supportedProtocols"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FrontDoorEndpointProtocol> array = new List<FrontDoorEndpointProtocol>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new FrontDoorEndpointProtocol(item.GetString()));
                            }
                            supportedProtocols = array;
                            continue;
                        }
                        if (property0.NameEquals("patternsToMatch"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            patternsToMatch = array;
                            continue;
                        }
                        if (property0.NameEquals("cacheConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                cacheConfiguration = null;
                                continue;
                            }
                            cacheConfiguration = FrontDoorRouteCacheConfiguration.DeserializeFrontDoorRouteCacheConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("forwardingProtocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            forwardingProtocol = new ForwardingProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("linkToDefaultDomain"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            linkToDefaultDomain = new LinkToDefaultDomain(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("httpsRedirect"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            httpsRedirect = new HttpsRedirect(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enabledState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabledState = new EnabledState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FrontDoorRoutePatch(endpointName.Value, customDomains ?? new ChangeTrackingList<FrontDoorActivatedResourceInfo>(), originGroup, originPath.Value, ruleSets ?? new ChangeTrackingList<WritableSubResource>(), supportedProtocols ?? new ChangeTrackingList<FrontDoorEndpointProtocol>(), patternsToMatch ?? new ChangeTrackingList<string>(), cacheConfiguration.Value, Optional.ToNullable(forwardingProtocol), Optional.ToNullable(linkToDefaultDomain), Optional.ToNullable(httpsRedirect), Optional.ToNullable(enabledState), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FrontDoorRoutePatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorRoutePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FrontDoorRoutePatch)} does not support '{options.Format}' format.");
            }
        }

        FrontDoorRoutePatch IPersistableModel<FrontDoorRoutePatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorRoutePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFrontDoorRoutePatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FrontDoorRoutePatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FrontDoorRoutePatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
