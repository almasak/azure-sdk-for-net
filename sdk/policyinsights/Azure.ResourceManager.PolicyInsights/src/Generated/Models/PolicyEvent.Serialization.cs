// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class PolicyEvent : IUtf8JsonSerializable, IJsonModel<PolicyEvent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyEvent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicyEvent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEvent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyEvent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ODataId != null)
            {
                writer.WritePropertyName("@odata.id"u8);
                writer.WriteStringValue(ODataId);
            }
            if (ODataContext != null)
            {
                writer.WritePropertyName("@odata.context"u8);
                writer.WriteStringValue(ODataContext);
            }
            if (Timestamp.HasValue)
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            if (ResourceId != null)
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (PolicyAssignmentId != null)
            {
                writer.WritePropertyName("policyAssignmentId"u8);
                writer.WriteStringValue(PolicyAssignmentId);
            }
            if (PolicyDefinitionId != null)
            {
                writer.WritePropertyName("policyDefinitionId"u8);
                writer.WriteStringValue(PolicyDefinitionId);
            }
            if (EffectiveParameters != null)
            {
                writer.WritePropertyName("effectiveParameters"u8);
                writer.WriteStringValue(EffectiveParameters);
            }
            if (IsCompliant.HasValue)
            {
                writer.WritePropertyName("isCompliant"u8);
                writer.WriteBooleanValue(IsCompliant.Value);
            }
            if (SubscriptionId != null)
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (ResourceTypeString != null)
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceTypeString);
            }
            if (ResourceLocation.HasValue)
            {
                writer.WritePropertyName("resourceLocation"u8);
                writer.WriteStringValue(ResourceLocation.Value);
            }
            if (ResourceGroup != null)
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
            if (ResourceTags != null)
            {
                writer.WritePropertyName("resourceTags"u8);
                writer.WriteStringValue(ResourceTags);
            }
            if (PolicyAssignmentName != null)
            {
                writer.WritePropertyName("policyAssignmentName"u8);
                writer.WriteStringValue(PolicyAssignmentName);
            }
            if (PolicyAssignmentOwner != null)
            {
                writer.WritePropertyName("policyAssignmentOwner"u8);
                writer.WriteStringValue(PolicyAssignmentOwner);
            }
            if (PolicyAssignmentParameters != null)
            {
                writer.WritePropertyName("policyAssignmentParameters"u8);
                writer.WriteStringValue(PolicyAssignmentParameters);
            }
            if (PolicyAssignmentScope != null)
            {
                writer.WritePropertyName("policyAssignmentScope"u8);
                writer.WriteStringValue(PolicyAssignmentScope);
            }
            if (PolicyDefinitionName != null)
            {
                writer.WritePropertyName("policyDefinitionName"u8);
                writer.WriteStringValue(PolicyDefinitionName);
            }
            if (PolicyDefinitionAction != null)
            {
                writer.WritePropertyName("policyDefinitionAction"u8);
                writer.WriteStringValue(PolicyDefinitionAction);
            }
            if (PolicyDefinitionCategory != null)
            {
                writer.WritePropertyName("policyDefinitionCategory"u8);
                writer.WriteStringValue(PolicyDefinitionCategory);
            }
            if (PolicySetDefinitionId != null)
            {
                writer.WritePropertyName("policySetDefinitionId"u8);
                writer.WriteStringValue(PolicySetDefinitionId);
            }
            if (PolicySetDefinitionName != null)
            {
                writer.WritePropertyName("policySetDefinitionName"u8);
                writer.WriteStringValue(PolicySetDefinitionName);
            }
            if (PolicySetDefinitionOwner != null)
            {
                writer.WritePropertyName("policySetDefinitionOwner"u8);
                writer.WriteStringValue(PolicySetDefinitionOwner);
            }
            if (PolicySetDefinitionCategory != null)
            {
                writer.WritePropertyName("policySetDefinitionCategory"u8);
                writer.WriteStringValue(PolicySetDefinitionCategory);
            }
            if (PolicySetDefinitionParameters != null)
            {
                writer.WritePropertyName("policySetDefinitionParameters"u8);
                writer.WriteStringValue(PolicySetDefinitionParameters);
            }
            if (ManagementGroupIds != null)
            {
                writer.WritePropertyName("managementGroupIds"u8);
                writer.WriteStringValue(ManagementGroupIds);
            }
            if (PolicyDefinitionReferenceId != null)
            {
                writer.WritePropertyName("policyDefinitionReferenceId"u8);
                writer.WriteStringValue(PolicyDefinitionReferenceId);
            }
            if (ComplianceState != null)
            {
                writer.WritePropertyName("complianceState"u8);
                writer.WriteStringValue(ComplianceState);
            }
            if (TenantId.HasValue)
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (PrincipalOid != null)
            {
                writer.WritePropertyName("principalOid"u8);
                writer.WriteStringValue(PrincipalOid);
            }
            if (!(Components is ChangeTrackingList<ComponentEventDetails> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("components"u8);
                writer.WriteStartArray();
                foreach (var item in Components)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        PolicyEvent IJsonModel<PolicyEvent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEvent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyEvent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyEvent(document.RootElement, options);
        }

        internal static PolicyEvent DeserializePolicyEvent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> odataId = default;
            Optional<string> odataContext = default;
            Optional<DateTimeOffset> timestamp = default;
            Optional<ResourceIdentifier> resourceId = default;
            Optional<ResourceIdentifier> policyAssignmentId = default;
            Optional<ResourceIdentifier> policyDefinitionId = default;
            Optional<string> effectiveParameters = default;
            Optional<bool> isCompliant = default;
            Optional<string> subscriptionId = default;
            Optional<string> resourceType = default;
            Optional<AzureLocation> resourceLocation = default;
            Optional<string> resourceGroup = default;
            Optional<string> resourceTags = default;
            Optional<string> policyAssignmentName = default;
            Optional<string> policyAssignmentOwner = default;
            Optional<string> policyAssignmentParameters = default;
            Optional<string> policyAssignmentScope = default;
            Optional<string> policyDefinitionName = default;
            Optional<string> policyDefinitionAction = default;
            Optional<string> policyDefinitionCategory = default;
            Optional<ResourceIdentifier> policySetDefinitionId = default;
            Optional<string> policySetDefinitionName = default;
            Optional<string> policySetDefinitionOwner = default;
            Optional<string> policySetDefinitionCategory = default;
            Optional<string> policySetDefinitionParameters = default;
            Optional<string> managementGroupIds = default;
            Optional<string> policyDefinitionReferenceId = default;
            Optional<string> complianceState = default;
            Optional<Guid> tenantId = default;
            Optional<string> principalOid = default;
            IReadOnlyList<ComponentEventDetails> components = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.id"u8))
                {
                    odataId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.context"u8))
                {
                    odataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyAssignmentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    policyAssignmentId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyDefinitionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    policyDefinitionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("effectiveParameters"u8))
                {
                    effectiveParameters = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isCompliant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCompliant = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceTags"u8))
                {
                    resourceTags = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyAssignmentName"u8))
                {
                    policyAssignmentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyAssignmentOwner"u8))
                {
                    policyAssignmentOwner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyAssignmentParameters"u8))
                {
                    policyAssignmentParameters = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyAssignmentScope"u8))
                {
                    policyAssignmentScope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionName"u8))
                {
                    policyDefinitionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionAction"u8))
                {
                    policyDefinitionAction = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionCategory"u8))
                {
                    policyDefinitionCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policySetDefinitionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    policySetDefinitionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policySetDefinitionName"u8))
                {
                    policySetDefinitionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policySetDefinitionOwner"u8))
                {
                    policySetDefinitionOwner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policySetDefinitionCategory"u8))
                {
                    policySetDefinitionCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policySetDefinitionParameters"u8))
                {
                    policySetDefinitionParameters = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managementGroupIds"u8))
                {
                    managementGroupIds = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionReferenceId"u8))
                {
                    policyDefinitionReferenceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("complianceState"u8))
                {
                    complianceState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("principalOid"u8))
                {
                    principalOid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("components"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ComponentEventDetails> array = new List<ComponentEventDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComponentEventDetails.DeserializeComponentEventDetails(item, options));
                    }
                    components = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new PolicyEvent(
                odataId.Value,
                odataContext.Value,
                Optional.ToNullable(timestamp),
                resourceId.Value,
                policyAssignmentId.Value,
                policyDefinitionId.Value,
                effectiveParameters.Value,
                Optional.ToNullable(isCompliant),
                subscriptionId.Value,
                resourceType.Value,
                Optional.ToNullable(resourceLocation),
                resourceGroup.Value,
                resourceTags.Value,
                policyAssignmentName.Value,
                policyAssignmentOwner.Value,
                policyAssignmentParameters.Value,
                policyAssignmentScope.Value,
                policyDefinitionName.Value,
                policyDefinitionAction.Value,
                policyDefinitionCategory.Value,
                policySetDefinitionId.Value,
                policySetDefinitionName.Value,
                policySetDefinitionOwner.Value,
                policySetDefinitionCategory.Value,
                policySetDefinitionParameters.Value,
                managementGroupIds.Value,
                policyDefinitionReferenceId.Value,
                complianceState.Value,
                Optional.ToNullable(tenantId),
                principalOid.Value,
                components ?? new ChangeTrackingList<ComponentEventDetails>(),
                additionalProperties);
        }

        BinaryData IPersistableModel<PolicyEvent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEvent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicyEvent)} does not support '{options.Format}' format.");
            }
        }

        PolicyEvent IPersistableModel<PolicyEvent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEvent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicyEvent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicyEvent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyEvent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
