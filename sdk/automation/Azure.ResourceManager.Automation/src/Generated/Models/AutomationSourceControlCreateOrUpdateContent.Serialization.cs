// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class AutomationSourceControlCreateOrUpdateContent : IUtf8JsonSerializable, IJsonModel<AutomationSourceControlCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomationSourceControlCreateOrUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutomationSourceControlCreateOrUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationSourceControlCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationSourceControlCreateOrUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (RepoUri != null)
            {
                writer.WritePropertyName("repoUrl"u8);
                writer.WriteStringValue(RepoUri.AbsoluteUri);
            }
            if (Branch != null)
            {
                writer.WritePropertyName("branch"u8);
                writer.WriteStringValue(Branch);
            }
            if (FolderPath != null)
            {
                writer.WritePropertyName("folderPath"u8);
                writer.WriteStringValue(FolderPath);
            }
            if (IsAutoSyncEnabled.HasValue)
            {
                writer.WritePropertyName("autoSync"u8);
                writer.WriteBooleanValue(IsAutoSyncEnabled.Value);
            }
            if (IsAutoPublishRunbookEnabled.HasValue)
            {
                writer.WritePropertyName("publishRunbook"u8);
                writer.WriteBooleanValue(IsAutoPublishRunbookEnabled.Value);
            }
            if (SourceType.HasValue)
            {
                writer.WritePropertyName("sourceType"u8);
                writer.WriteStringValue(SourceType.Value.ToString());
            }
            if (SecurityToken != null)
            {
                writer.WritePropertyName("securityToken"u8);
                writer.WriteObjectValue(SecurityToken);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        AutomationSourceControlCreateOrUpdateContent IJsonModel<AutomationSourceControlCreateOrUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationSourceControlCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationSourceControlCreateOrUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationSourceControlCreateOrUpdateContent(document.RootElement, options);
        }

        internal static AutomationSourceControlCreateOrUpdateContent DeserializeAutomationSourceControlCreateOrUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> repoUrl = default;
            Optional<string> branch = default;
            Optional<string> folderPath = default;
            Optional<bool> autoSync = default;
            Optional<bool> publishRunbook = default;
            Optional<SourceControlSourceType> sourceType = default;
            Optional<SourceControlSecurityTokenProperties> securityToken = default;
            Optional<string> description = default;
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
                        if (property0.NameEquals("repoUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            repoUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("branch"u8))
                        {
                            branch = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("folderPath"u8))
                        {
                            folderPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("autoSync"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoSync = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publishRunbook"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publishRunbook = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("sourceType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceType = new SourceControlSourceType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("securityToken"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityToken = SourceControlSecurityTokenProperties.DeserializeSourceControlSecurityTokenProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
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
            return new AutomationSourceControlCreateOrUpdateContent(
                repoUrl.Value,
                branch.Value,
                folderPath.Value,
                Optional.ToNullable(autoSync),
                Optional.ToNullable(publishRunbook),
                Optional.ToNullable(sourceType),
                securityToken.Value,
                description.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutomationSourceControlCreateOrUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationSourceControlCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutomationSourceControlCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        AutomationSourceControlCreateOrUpdateContent IPersistableModel<AutomationSourceControlCreateOrUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationSourceControlCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutomationSourceControlCreateOrUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutomationSourceControlCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomationSourceControlCreateOrUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
