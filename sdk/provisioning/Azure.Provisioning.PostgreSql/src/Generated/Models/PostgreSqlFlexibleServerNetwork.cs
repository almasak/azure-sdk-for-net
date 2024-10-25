// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// Network properties of a server.
/// </summary>
public partial class PostgreSqlFlexibleServerNetwork : ProvisionableConstruct
{
    /// <summary>
    /// public network access is enabled or not.
    /// </summary>
    public BicepValue<PostgreSqlFlexibleServerPublicNetworkAccessState> PublicNetworkAccess { get => _publicNetworkAccess; }
    private readonly BicepValue<PostgreSqlFlexibleServerPublicNetworkAccessState> _publicNetworkAccess;

    /// <summary>
    /// Delegated subnet arm resource id. This is required to be passed during
    /// create, in case we want the server to be VNET injected, i.e. Private
    /// access server. During update, pass this only if we want to update the
    /// value for Private DNS zone.
    /// </summary>
    public BicepValue<ResourceIdentifier> DelegatedSubnetResourceId { get => _delegatedSubnetResourceId; set => _delegatedSubnetResourceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _delegatedSubnetResourceId;

    /// <summary>
    /// Private dns zone arm resource id. This is required to be passed during
    /// create, in case we want the server to be VNET injected, i.e. Private
    /// access server. During update, pass this only if we want to update the
    /// value for Private DNS zone.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrivateDnsZoneArmResourceId { get => _privateDnsZoneArmResourceId; set => _privateDnsZoneArmResourceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _privateDnsZoneArmResourceId;

    /// <summary>
    /// Creates a new PostgreSqlFlexibleServerNetwork.
    /// </summary>
    public PostgreSqlFlexibleServerNetwork()
    {
        _publicNetworkAccess = BicepValue<PostgreSqlFlexibleServerPublicNetworkAccessState>.DefineProperty(this, "PublicNetworkAccess", ["publicNetworkAccess"], isOutput: true);
        _delegatedSubnetResourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "DelegatedSubnetResourceId", ["delegatedSubnetResourceId"]);
        _privateDnsZoneArmResourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "PrivateDnsZoneArmResourceId", ["privateDnsZoneArmResourceId"]);
    }
}
