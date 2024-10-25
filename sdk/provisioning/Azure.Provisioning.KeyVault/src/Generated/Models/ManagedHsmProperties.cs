// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.KeyVault;

/// <summary>
/// Properties of the managed HSM Pool.
/// </summary>
public partial class ManagedHsmProperties : ProvisionableConstruct
{
    /// <summary>
    /// The Azure Active Directory tenant ID that should be used for
    /// authenticating requests to the managed HSM pool.
    /// </summary>
    public BicepValue<Guid> TenantId { get => _tenantId; set => _tenantId.Assign(value); }
    private readonly BicepValue<Guid> _tenantId;

    /// <summary>
    /// Array of initial administrators object ids for this managed hsm pool.
    /// </summary>
    public BicepList<string> InitialAdminObjectIds { get => _initialAdminObjectIds; set => _initialAdminObjectIds.Assign(value); }
    private readonly BicepList<string> _initialAdminObjectIds;

    /// <summary>
    /// The URI of the managed hsm pool for performing operations on keys.
    /// </summary>
    public BicepValue<Uri> HsmUri { get => _hsmUri; }
    private readonly BicepValue<Uri> _hsmUri;

    /// <summary>
    /// Property to specify whether the &apos;soft delete&apos; functionality
    /// is enabled for this managed HSM pool. Soft delete is enabled by
    /// default for all managed HSMs and is immutable.
    /// </summary>
    public BicepValue<bool> EnableSoftDelete { get => _enableSoftDelete; set => _enableSoftDelete.Assign(value); }
    private readonly BicepValue<bool> _enableSoftDelete;

    /// <summary>
    /// Soft deleted data retention days. When you delete an HSM or a key, it
    /// will remain recoverable for the configured retention period or for a
    /// default period of 90 days. It accepts values between 7 and 90.
    /// </summary>
    public BicepValue<int> SoftDeleteRetentionInDays { get => _softDeleteRetentionInDays; set => _softDeleteRetentionInDays.Assign(value); }
    private readonly BicepValue<int> _softDeleteRetentionInDays;

    /// <summary>
    /// Property specifying whether protection against purge is enabled for
    /// this managed HSM pool. Setting this property to true activates
    /// protection against purge for this managed HSM pool and its content -
    /// only the Managed HSM service may initiate a hard, irrecoverable
    /// deletion. Enabling this functionality is irreversible.
    /// </summary>
    public BicepValue<bool> EnablePurgeProtection { get => _enablePurgeProtection; set => _enablePurgeProtection.Assign(value); }
    private readonly BicepValue<bool> _enablePurgeProtection;

    /// <summary>
    /// The create mode to indicate whether the resource is being created or is
    /// being recovered from a deleted resource.
    /// </summary>
    public BicepValue<ManagedHsmCreateMode> CreateMode { get => _createMode; set => _createMode.Assign(value); }
    private readonly BicepValue<ManagedHsmCreateMode> _createMode;

    /// <summary>
    /// Resource Status Message.
    /// </summary>
    public BicepValue<string> StatusMessage { get => _statusMessage; }
    private readonly BicepValue<string> _statusMessage;

    /// <summary>
    /// Provisioning state.
    /// </summary>
    public BicepValue<ManagedHsmProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<ManagedHsmProvisioningState> _provisioningState;

    /// <summary>
    /// Rules governing the accessibility of the key vault from specific
    /// network locations.
    /// </summary>
    public BicepValue<ManagedHsmNetworkRuleSet> NetworkRuleSet { get => _networkRuleSet; set => _networkRuleSet.Assign(value); }
    private readonly BicepValue<ManagedHsmNetworkRuleSet> _networkRuleSet;

    /// <summary>
    /// List of all regions associated with the managed hsm pool.
    /// </summary>
    public BicepList<ManagedHsmGeoReplicatedRegion> Regions { get => _regions; set => _regions.Assign(value); }
    private readonly BicepList<ManagedHsmGeoReplicatedRegion> _regions;

    /// <summary>
    /// List of private endpoint connections associated with the managed hsm
    /// pool.
    /// </summary>
    public BicepList<ManagedHsmPrivateEndpointConnectionItemData> PrivateEndpointConnections { get => _privateEndpointConnections; }
    private readonly BicepList<ManagedHsmPrivateEndpointConnectionItemData> _privateEndpointConnections;

    /// <summary>
    /// Control permission to the managed HSM from public networks.
    /// </summary>
    public BicepValue<ManagedHsmPublicNetworkAccess> PublicNetworkAccess { get => _publicNetworkAccess; set => _publicNetworkAccess.Assign(value); }
    private readonly BicepValue<ManagedHsmPublicNetworkAccess> _publicNetworkAccess;

    /// <summary>
    /// The scheduled purge date in UTC.
    /// </summary>
    public BicepValue<DateTimeOffset> ScheduledPurgeOn { get => _scheduledPurgeOn; }
    private readonly BicepValue<DateTimeOffset> _scheduledPurgeOn;

    /// <summary>
    /// Managed HSM security domain properties.
    /// </summary>
    public BicepValue<ManagedHSMSecurityDomainProperties> SecurityDomainProperties { get => _securityDomainProperties; }
    private readonly BicepValue<ManagedHSMSecurityDomainProperties> _securityDomainProperties;

    /// <summary>
    /// Creates a new ManagedHsmProperties.
    /// </summary>
    public ManagedHsmProperties()
    {
        _tenantId = BicepValue<Guid>.DefineProperty(this, "TenantId", ["tenantId"]);
        _initialAdminObjectIds = BicepList<string>.DefineProperty(this, "InitialAdminObjectIds", ["initialAdminObjectIds"]);
        _hsmUri = BicepValue<Uri>.DefineProperty(this, "HsmUri", ["hsmUri"], isOutput: true);
        _enableSoftDelete = BicepValue<bool>.DefineProperty(this, "EnableSoftDelete", ["enableSoftDelete"]);
        _softDeleteRetentionInDays = BicepValue<int>.DefineProperty(this, "SoftDeleteRetentionInDays", ["softDeleteRetentionInDays"]);
        _enablePurgeProtection = BicepValue<bool>.DefineProperty(this, "EnablePurgeProtection", ["enablePurgeProtection"]);
        _createMode = BicepValue<ManagedHsmCreateMode>.DefineProperty(this, "CreateMode", ["createMode"]);
        _statusMessage = BicepValue<string>.DefineProperty(this, "StatusMessage", ["statusMessage"], isOutput: true);
        _provisioningState = BicepValue<ManagedHsmProvisioningState>.DefineProperty(this, "ProvisioningState", ["provisioningState"], isOutput: true);
        _networkRuleSet = BicepValue<ManagedHsmNetworkRuleSet>.DefineProperty(this, "NetworkRuleSet", ["networkAcls"]);
        _regions = BicepList<ManagedHsmGeoReplicatedRegion>.DefineProperty(this, "Regions", ["regions"]);
        _privateEndpointConnections = BicepList<ManagedHsmPrivateEndpointConnectionItemData>.DefineProperty(this, "PrivateEndpointConnections", ["privateEndpointConnections"], isOutput: true);
        _publicNetworkAccess = BicepValue<ManagedHsmPublicNetworkAccess>.DefineProperty(this, "PublicNetworkAccess", ["publicNetworkAccess"]);
        _scheduledPurgeOn = BicepValue<DateTimeOffset>.DefineProperty(this, "ScheduledPurgeOn", ["scheduledPurgeDate"], isOutput: true);
        _securityDomainProperties = BicepValue<ManagedHSMSecurityDomainProperties>.DefineProperty(this, "SecurityDomainProperties", ["securityDomainProperties"], isOutput: true);
    }
}
