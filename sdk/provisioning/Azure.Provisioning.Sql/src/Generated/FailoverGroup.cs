// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Sql;

/// <summary>
/// FailoverGroup.
/// </summary>
public partial class FailoverGroup : ProvisionableResource
{
    /// <summary>
    /// The name of the failover group.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// List of databases in the failover group.
    /// </summary>
    public BicepList<ResourceIdentifier> FailoverDatabases { get => _failoverDatabases; set => _failoverDatabases.Assign(value); }
    private readonly BicepList<ResourceIdentifier> _failoverDatabases;

    /// <summary>
    /// List of partner server information for the failover group.
    /// </summary>
    public BicepList<PartnerServerInfo> PartnerServers { get => _partnerServers; set => _partnerServers.Assign(value); }
    private readonly BicepList<PartnerServerInfo> _partnerServers;

    /// <summary>
    /// Read-only endpoint of the failover group instance.
    /// </summary>
    public BicepValue<FailoverGroupReadOnlyEndpoint> ReadOnlyEndpoint { get => _readOnlyEndpoint; set => _readOnlyEndpoint.Assign(value); }
    private readonly BicepValue<FailoverGroupReadOnlyEndpoint> _readOnlyEndpoint;

    /// <summary>
    /// Read-write endpoint of the failover group instance.
    /// </summary>
    public BicepValue<FailoverGroupReadWriteEndpoint> ReadWriteEndpoint { get => _readWriteEndpoint; set => _readWriteEndpoint.Assign(value); }
    private readonly BicepValue<FailoverGroupReadWriteEndpoint> _readWriteEndpoint;

    /// <summary>
    /// Resource tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Resource location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Local replication role of the failover group instance.
    /// </summary>
    public BicepValue<FailoverGroupReplicationRole> ReplicationRole { get => _replicationRole; }
    private readonly BicepValue<FailoverGroupReplicationRole> _replicationRole;

    /// <summary>
    /// Replication state of the failover group instance.
    /// </summary>
    public BicepValue<string> ReplicationState { get => _replicationState; }
    private readonly BicepValue<string> _replicationState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent SqlServer.
    /// </summary>
    public SqlServer? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<SqlServer> _parent;

    /// <summary>
    /// Creates a new FailoverGroup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the FailoverGroup resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the FailoverGroup.</param>
    public FailoverGroup(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/servers/failoverGroups", resourceVersion ?? "2021-11-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _failoverDatabases = BicepList<ResourceIdentifier>.DefineProperty(this, "FailoverDatabases", ["properties", "databases"]);
        _partnerServers = BicepList<PartnerServerInfo>.DefineProperty(this, "PartnerServers", ["properties", "partnerServers"]);
        _readOnlyEndpoint = BicepValue<FailoverGroupReadOnlyEndpoint>.DefineProperty(this, "ReadOnlyEndpoint", ["properties", "readOnlyEndpoint"]);
        _readWriteEndpoint = BicepValue<FailoverGroupReadWriteEndpoint>.DefineProperty(this, "ReadWriteEndpoint", ["properties", "readWriteEndpoint"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isOutput: true);
        _replicationRole = BicepValue<FailoverGroupReplicationRole>.DefineProperty(this, "ReplicationRole", ["properties", "replicationRole"], isOutput: true);
        _replicationState = BicepValue<string>.DefineProperty(this, "ReplicationState", ["properties", "replicationState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<SqlServer>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported FailoverGroup resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";
    }

    /// <summary>
    /// Creates a reference to an existing FailoverGroup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the FailoverGroup resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the FailoverGroup.</param>
    /// <returns>The existing FailoverGroup resource.</returns>
    public static FailoverGroup FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this FailoverGroup resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 63, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);
}
