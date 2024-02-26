// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class ProvisionedClusterPropertiesAutoScalerProfile : IUtf8JsonSerializable, IJsonModel<ProvisionedClusterPropertiesAutoScalerProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProvisionedClusterPropertiesAutoScalerProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProvisionedClusterPropertiesAutoScalerProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProvisionedClusterPropertiesAutoScalerProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProvisionedClusterPropertiesAutoScalerProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (BalanceSimilarNodeGroups != null)
            {
                writer.WritePropertyName("balance-similar-node-groups"u8);
                writer.WriteStringValue(BalanceSimilarNodeGroups);
            }
            if (Expander.HasValue)
            {
                writer.WritePropertyName("expander"u8);
                writer.WriteStringValue(Expander.Value.ToString());
            }
            if (MaxEmptyBulkDelete != null)
            {
                writer.WritePropertyName("max-empty-bulk-delete"u8);
                writer.WriteStringValue(MaxEmptyBulkDelete);
            }
            if (MaxGracefulTerminationSec != null)
            {
                writer.WritePropertyName("max-graceful-termination-sec"u8);
                writer.WriteStringValue(MaxGracefulTerminationSec);
            }
            if (MaxNodeProvisionTime != null)
            {
                writer.WritePropertyName("max-node-provision-time"u8);
                writer.WriteStringValue(MaxNodeProvisionTime);
            }
            if (MaxTotalUnreadyPercentage != null)
            {
                writer.WritePropertyName("max-total-unready-percentage"u8);
                writer.WriteStringValue(MaxTotalUnreadyPercentage);
            }
            if (NewPodScaleUpDelay != null)
            {
                writer.WritePropertyName("new-pod-scale-up-delay"u8);
                writer.WriteStringValue(NewPodScaleUpDelay);
            }
            if (OkTotalUnreadyCount != null)
            {
                writer.WritePropertyName("ok-total-unready-count"u8);
                writer.WriteStringValue(OkTotalUnreadyCount);
            }
            if (ScanInterval != null)
            {
                writer.WritePropertyName("scan-interval"u8);
                writer.WriteStringValue(ScanInterval);
            }
            if (ScaleDownDelayAfterAdd != null)
            {
                writer.WritePropertyName("scale-down-delay-after-add"u8);
                writer.WriteStringValue(ScaleDownDelayAfterAdd);
            }
            if (ScaleDownDelayAfterDelete != null)
            {
                writer.WritePropertyName("scale-down-delay-after-delete"u8);
                writer.WriteStringValue(ScaleDownDelayAfterDelete);
            }
            if (ScaleDownDelayAfterFailure != null)
            {
                writer.WritePropertyName("scale-down-delay-after-failure"u8);
                writer.WriteStringValue(ScaleDownDelayAfterFailure);
            }
            if (ScaleDownUnneededTime != null)
            {
                writer.WritePropertyName("scale-down-unneeded-time"u8);
                writer.WriteStringValue(ScaleDownUnneededTime);
            }
            if (ScaleDownUnreadyTime != null)
            {
                writer.WritePropertyName("scale-down-unready-time"u8);
                writer.WriteStringValue(ScaleDownUnreadyTime);
            }
            if (ScaleDownUtilizationThreshold != null)
            {
                writer.WritePropertyName("scale-down-utilization-threshold"u8);
                writer.WriteStringValue(ScaleDownUtilizationThreshold);
            }
            if (SkipNodesWithLocalStorage != null)
            {
                writer.WritePropertyName("skip-nodes-with-local-storage"u8);
                writer.WriteStringValue(SkipNodesWithLocalStorage);
            }
            if (SkipNodesWithSystemPods != null)
            {
                writer.WritePropertyName("skip-nodes-with-system-pods"u8);
                writer.WriteStringValue(SkipNodesWithSystemPods);
            }
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

        ProvisionedClusterPropertiesAutoScalerProfile IJsonModel<ProvisionedClusterPropertiesAutoScalerProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProvisionedClusterPropertiesAutoScalerProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProvisionedClusterPropertiesAutoScalerProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProvisionedClusterPropertiesAutoScalerProfile(document.RootElement, options);
        }

        internal static ProvisionedClusterPropertiesAutoScalerProfile DeserializeProvisionedClusterPropertiesAutoScalerProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> balanceSimilarNodeGroups = default;
            Optional<HybridContainerServiceExpander> expander = default;
            Optional<string> maxEmptyBulkDelete = default;
            Optional<string> maxGracefulTerminationSec = default;
            Optional<string> maxNodeProvisionTime = default;
            Optional<string> maxTotalUnreadyPercentage = default;
            Optional<string> newPodScaleUpDelay = default;
            Optional<string> okTotalUnreadyCount = default;
            Optional<string> scanInterval = default;
            Optional<string> scaleDownDelayAfterAdd = default;
            Optional<string> scaleDownDelayAfterDelete = default;
            Optional<string> scaleDownDelayAfterFailure = default;
            Optional<string> scaleDownUnneededTime = default;
            Optional<string> scaleDownUnreadyTime = default;
            Optional<string> scaleDownUtilizationThreshold = default;
            Optional<string> skipNodesWithLocalStorage = default;
            Optional<string> skipNodesWithSystemPods = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("balance-similar-node-groups"u8))
                {
                    balanceSimilarNodeGroups = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expander"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expander = new HybridContainerServiceExpander(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("max-empty-bulk-delete"u8))
                {
                    maxEmptyBulkDelete = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("max-graceful-termination-sec"u8))
                {
                    maxGracefulTerminationSec = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("max-node-provision-time"u8))
                {
                    maxNodeProvisionTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("max-total-unready-percentage"u8))
                {
                    maxTotalUnreadyPercentage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("new-pod-scale-up-delay"u8))
                {
                    newPodScaleUpDelay = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ok-total-unready-count"u8))
                {
                    okTotalUnreadyCount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scan-interval"u8))
                {
                    scanInterval = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-delay-after-add"u8))
                {
                    scaleDownDelayAfterAdd = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-delay-after-delete"u8))
                {
                    scaleDownDelayAfterDelete = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-delay-after-failure"u8))
                {
                    scaleDownDelayAfterFailure = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-unneeded-time"u8))
                {
                    scaleDownUnneededTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-unready-time"u8))
                {
                    scaleDownUnreadyTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-utilization-threshold"u8))
                {
                    scaleDownUtilizationThreshold = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skip-nodes-with-local-storage"u8))
                {
                    skipNodesWithLocalStorage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skip-nodes-with-system-pods"u8))
                {
                    skipNodesWithSystemPods = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProvisionedClusterPropertiesAutoScalerProfile(balanceSimilarNodeGroups.Value, Optional.ToNullable(expander), maxEmptyBulkDelete.Value, maxGracefulTerminationSec.Value, maxNodeProvisionTime.Value, maxTotalUnreadyPercentage.Value, newPodScaleUpDelay.Value, okTotalUnreadyCount.Value, scanInterval.Value, scaleDownDelayAfterAdd.Value, scaleDownDelayAfterDelete.Value, scaleDownDelayAfterFailure.Value, scaleDownUnneededTime.Value, scaleDownUnreadyTime.Value, scaleDownUtilizationThreshold.Value, skipNodesWithLocalStorage.Value, skipNodesWithSystemPods.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProvisionedClusterPropertiesAutoScalerProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProvisionedClusterPropertiesAutoScalerProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProvisionedClusterPropertiesAutoScalerProfile)} does not support '{options.Format}' format.");
            }
        }

        ProvisionedClusterPropertiesAutoScalerProfile IPersistableModel<ProvisionedClusterPropertiesAutoScalerProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProvisionedClusterPropertiesAutoScalerProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProvisionedClusterPropertiesAutoScalerProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProvisionedClusterPropertiesAutoScalerProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProvisionedClusterPropertiesAutoScalerProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
