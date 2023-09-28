// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SqlServerPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AdministratorLogin))
            {
                writer.WritePropertyName("administratorLogin"u8);
                writer.WriteStringValue(AdministratorLogin);
            }
            if (Optional.IsDefined(AdministratorLoginPassword))
            {
                writer.WritePropertyName("administratorLoginPassword"u8);
                writer.WriteStringValue(AdministratorLoginPassword);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(MinimalTlsVersion))
            {
                writer.WritePropertyName("minimalTlsVersion"u8);
                writer.WriteStringValue(MinimalTlsVersion);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(PrimaryUserAssignedIdentityId))
            {
                writer.WritePropertyName("primaryUserAssignedIdentityId"u8);
                writer.WriteStringValue(PrimaryUserAssignedIdentityId);
            }
            if (Optional.IsDefined(FederatedClientId))
            {
                writer.WritePropertyName("federatedClientId"u8);
                writer.WriteStringValue(FederatedClientId.Value);
            }
            if (Optional.IsDefined(KeyId))
            {
                writer.WritePropertyName("keyId"u8);
                writer.WriteStringValue(KeyId.AbsoluteUri);
            }
            if (Optional.IsDefined(Administrators))
            {
                writer.WritePropertyName("administrators"u8);
                writer.WriteObjectValue(Administrators);
            }
            if (Optional.IsDefined(RestrictOutboundNetworkAccess))
            {
                writer.WritePropertyName("restrictOutboundNetworkAccess"u8);
                writer.WriteStringValue(RestrictOutboundNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(IsIPv6Enabled))
            {
                writer.WritePropertyName("isIPv6Enabled"u8);
                writer.WriteStringValue(IsIPv6Enabled.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
