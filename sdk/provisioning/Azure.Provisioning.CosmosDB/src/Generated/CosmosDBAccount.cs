// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Authorization;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using Azure.Provisioning.Roles;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// CosmosDBAccount.
/// </summary>
public partial class CosmosDBAccount : ProvisionableResource
{
    /// <summary>
    /// Cosmos DB database account name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// An array that contains the georeplication locations enabled for the
    /// Cosmos DB account.
    /// </summary>
    public BicepList<CosmosDBAccountLocation> Locations { get => _locations; set => _locations.Assign(value); }
    private readonly BicepList<CosmosDBAccountLocation> _locations;

    /// <summary>
    /// Describes the types of schema for analytical storage.
    /// </summary>
    public BicepValue<AnalyticalStorageSchemaType> AnalyticalStorageSchemaType { get => _analyticalStorageSchemaType; set => _analyticalStorageSchemaType.Assign(value); }
    private readonly BicepValue<AnalyticalStorageSchemaType> _analyticalStorageSchemaType;

    /// <summary>
    /// Describes the ServerVersion of an a MongoDB account.
    /// </summary>
    public BicepValue<CosmosDBServerVersion> ApiServerVersion { get => _apiServerVersion; set => _apiServerVersion.Assign(value); }
    private readonly BicepValue<CosmosDBServerVersion> _apiServerVersion;

    /// <summary>
    /// The object representing the policy for taking backups on an account.
    /// Please note
    /// Azure.ResourceManager.CosmosDB.Models.CosmosDBAccountBackupPolicy is
    /// the base class. According to the scenario, a derived class of the base
    /// class might need to be assigned here, or this property needs to be
    /// casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.CosmosDB.Models.ContinuousModeBackupPolicy and
    /// Azure.ResourceManager.CosmosDB.Models.PeriodicModeBackupPolicy.
    /// </summary>
    public BicepValue<CosmosDBAccountBackupPolicy> BackupPolicy { get => _backupPolicy; set => _backupPolicy.Assign(value); }
    private readonly BicepValue<CosmosDBAccountBackupPolicy> _backupPolicy;

    /// <summary>
    /// List of Cosmos DB capabilities for the account.
    /// </summary>
    public BicepList<CosmosDBAccountCapability> Capabilities { get => _capabilities; set => _capabilities.Assign(value); }
    private readonly BicepList<CosmosDBAccountCapability> _capabilities;

    /// <summary>
    /// The total throughput limit imposed on the account. A
    /// totalThroughputLimit of 2000 imposes a strict limit of max throughput
    /// that can be provisioned on that account to be 2000. A
    /// totalThroughputLimit of -1 indicates no limits on provisioning of
    /// throughput.
    /// </summary>
    public BicepValue<int> CapacityTotalThroughputLimit { get => _capacityTotalThroughputLimit; set => _capacityTotalThroughputLimit.Assign(value); }
    private readonly BicepValue<int> _capacityTotalThroughputLimit;

    /// <summary>
    /// The cassandra connector offer type for the Cosmos DB database C*
    /// account.
    /// </summary>
    public BicepValue<ConnectorOffer> ConnectorOffer { get => _connectorOffer; set => _connectorOffer.Assign(value); }
    private readonly BicepValue<ConnectorOffer> _connectorOffer;

    /// <summary>
    /// The consistency policy for the Cosmos DB account.
    /// </summary>
    public BicepValue<ConsistencyPolicy> ConsistencyPolicy { get => _consistencyPolicy; set => _consistencyPolicy.Assign(value); }
    private readonly BicepValue<ConsistencyPolicy> _consistencyPolicy;

    /// <summary>
    /// The CORS policy for the Cosmos DB database account.
    /// </summary>
    public BicepList<CosmosDBAccountCorsPolicy> Cors { get => _cors; set => _cors.Assign(value); }
    private readonly BicepList<CosmosDBAccountCorsPolicy> _cors;

    /// <summary>
    /// Enum to indicate the mode of account creation.
    /// </summary>
    public BicepValue<CosmosDBAccountCreateMode> CreateMode { get => _createMode; set => _createMode.Assign(value); }
    private readonly BicepValue<CosmosDBAccountCreateMode> _createMode;

    /// <summary>
    /// Indicates the status of the Customer Managed Key feature on the
    /// account. In case there are errors, the property provides
    /// troubleshooting guidance.
    /// </summary>
    public BicepValue<string> CustomerManagedKeyStatus { get => _customerManagedKeyStatus; set => _customerManagedKeyStatus.Assign(value); }
    private readonly BicepValue<string> _customerManagedKeyStatus;

    /// <summary>
    /// The offer type for the database.
    /// </summary>
    public BicepValue<CosmosDBAccountOfferType> DatabaseAccountOfferType { get => _databaseAccountOfferType; set => _databaseAccountOfferType.Assign(value); }
    private readonly BicepValue<CosmosDBAccountOfferType> _databaseAccountOfferType;

    /// <summary>
    /// The default identity for accessing key vault used in features like
    /// customer managed keys. The default identity needs to be explicitly set
    /// by the users. It can be &quot;FirstPartyIdentity&quot;,
    /// &quot;SystemAssignedIdentity&quot; and more.
    /// </summary>
    public BicepValue<string> DefaultIdentity { get => _defaultIdentity; set => _defaultIdentity.Assign(value); }
    private readonly BicepValue<string> _defaultIdentity;

    /// <summary>
    /// Enum to indicate default Priority Level of request for Priority Based
    /// Execution.
    /// </summary>
    public BicepValue<DefaultPriorityLevel> DefaultPriorityLevel { get => _defaultPriorityLevel; set => _defaultPriorityLevel.Assign(value); }
    private readonly BicepValue<DefaultPriorityLevel> _defaultPriorityLevel;

    /// <summary>
    /// Describe the level of detail with which queries are to be logged.
    /// </summary>
    public BicepValue<EnableFullTextQuery> DiagnosticLogEnableFullTextQuery { get => _diagnosticLogEnableFullTextQuery; set => _diagnosticLogEnableFullTextQuery.Assign(value); }
    private readonly BicepValue<EnableFullTextQuery> _diagnosticLogEnableFullTextQuery;

    /// <summary>
    /// Disable write operations on metadata resources (databases, containers,
    /// throughput) via account keys.
    /// </summary>
    public BicepValue<bool> DisableKeyBasedMetadataWriteAccess { get => _disableKeyBasedMetadataWriteAccess; set => _disableKeyBasedMetadataWriteAccess.Assign(value); }
    private readonly BicepValue<bool> _disableKeyBasedMetadataWriteAccess;

    /// <summary>
    /// Opt-out of local authentication and ensure only MSI and AAD can be used
    /// exclusively for authentication.
    /// </summary>
    public BicepValue<bool> DisableLocalAuth { get => _disableLocalAuth; set => _disableLocalAuth.Assign(value); }
    private readonly BicepValue<bool> _disableLocalAuth;

    /// <summary>
    /// Enables automatic failover of the write region in the rare event that
    /// the region is unavailable due to an outage. Automatic failover will
    /// result in a new write region for the account and is chosen based on
    /// the failover priorities configured for the account.
    /// </summary>
    public BicepValue<bool> EnableAutomaticFailover { get => _enableAutomaticFailover; set => _enableAutomaticFailover.Assign(value); }
    private readonly BicepValue<bool> _enableAutomaticFailover;

    /// <summary>
    /// Flag to indicate enabling/disabling of Burst Capacity Preview feature
    /// on the account.
    /// </summary>
    public BicepValue<bool> EnableBurstCapacity { get => _enableBurstCapacity; set => _enableBurstCapacity.Assign(value); }
    private readonly BicepValue<bool> _enableBurstCapacity;

    /// <summary>
    /// Enables the cassandra connector on the Cosmos DB C* account.
    /// </summary>
    public BicepValue<bool> EnableCassandraConnector { get => _enableCassandraConnector; set => _enableCassandraConnector.Assign(value); }
    private readonly BicepValue<bool> _enableCassandraConnector;

    /// <summary>
    /// Flag to indicate whether to enable MaterializedViews on the Cosmos DB
    /// account.
    /// </summary>
    public BicepValue<bool> EnableMaterializedViews { get => _enableMaterializedViews; set => _enableMaterializedViews.Assign(value); }
    private readonly BicepValue<bool> _enableMaterializedViews;

    /// <summary>
    /// Enables the account to write in multiple locations.
    /// </summary>
    public BicepValue<bool> EnableMultipleWriteLocations { get => _enableMultipleWriteLocations; set => _enableMultipleWriteLocations.Assign(value); }
    private readonly BicepValue<bool> _enableMultipleWriteLocations;

    /// <summary>
    /// Flag to indicate enabling/disabling of Partition Merge feature on the
    /// account.
    /// </summary>
    public BicepValue<bool> EnablePartitionMerge { get => _enablePartitionMerge; set => _enablePartitionMerge.Assign(value); }
    private readonly BicepValue<bool> _enablePartitionMerge;

    /// <summary>
    /// Flag to indicate enabling/disabling of Per-Region Per-partition
    /// autoscale Preview feature on the account.
    /// </summary>
    public BicepValue<bool> EnablePerRegionPerPartitionAutoscale { get => _enablePerRegionPerPartitionAutoscale; set => _enablePerRegionPerPartitionAutoscale.Assign(value); }
    private readonly BicepValue<bool> _enablePerRegionPerPartitionAutoscale;

    /// <summary>
    /// Flag to indicate enabling/disabling of Priority Based Execution Preview
    /// feature on the account.
    /// </summary>
    public BicepValue<bool> EnablePriorityBasedExecution { get => _enablePriorityBasedExecution; set => _enablePriorityBasedExecution.Assign(value); }
    private readonly BicepValue<bool> _enablePriorityBasedExecution;

    /// <summary>
    /// Identity for the resource.
    /// </summary>
    public BicepValue<ManagedServiceIdentity> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<ManagedServiceIdentity> _identity;

    /// <summary>
    /// List of IpRules.
    /// </summary>
    public BicepList<CosmosDBIPAddressOrRange> IPRules { get => _iPRules; set => _iPRules.Assign(value); }
    private readonly BicepList<CosmosDBIPAddressOrRange> _iPRules;

    /// <summary>
    /// Flag to indicate whether to enable storage analytics.
    /// </summary>
    public BicepValue<bool> IsAnalyticalStorageEnabled { get => _isAnalyticalStorageEnabled; set => _isAnalyticalStorageEnabled.Assign(value); }
    private readonly BicepValue<bool> _isAnalyticalStorageEnabled;

    /// <summary>
    /// Flag to indicate whether Free Tier is enabled.
    /// </summary>
    public BicepValue<bool> IsFreeTierEnabled { get => _isFreeTierEnabled; set => _isFreeTierEnabled.Assign(value); }
    private readonly BicepValue<bool> _isFreeTierEnabled;

    /// <summary>
    /// Flag to indicate whether to enable/disable Virtual Network ACL rules.
    /// </summary>
    public BicepValue<bool> IsVirtualNetworkFilterEnabled { get => _isVirtualNetworkFilterEnabled; set => _isVirtualNetworkFilterEnabled.Assign(value); }
    private readonly BicepValue<bool> _isVirtualNetworkFilterEnabled;

    /// <summary>
    /// The URI of the key vault.
    /// </summary>
    public BicepValue<Uri> KeyVaultKeyUri { get => _keyVaultKeyUri; set => _keyVaultKeyUri.Assign(value); }
    private readonly BicepValue<Uri> _keyVaultKeyUri;

    /// <summary>
    /// Indicates the type of database account. This can only be set at
    /// database account creation.
    /// </summary>
    public BicepValue<CosmosDBAccountKind> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<CosmosDBAccountKind> _kind;

    /// <summary>
    /// Indicates the minimum allowed Tls version. The default is Tls 1.0,
    /// except for Cassandra and Mongo API&apos;s, which only work with Tls
    /// 1.2.
    /// </summary>
    public BicepValue<CosmosDBMinimalTlsVersion> MinimalTlsVersion { get => _minimalTlsVersion; set => _minimalTlsVersion.Assign(value); }
    private readonly BicepValue<CosmosDBMinimalTlsVersion> _minimalTlsVersion;

    /// <summary>
    /// Indicates what services are allowed to bypass firewall checks.
    /// </summary>
    public BicepValue<NetworkAclBypass> NetworkAclBypass { get => _networkAclBypass; set => _networkAclBypass.Assign(value); }
    private readonly BicepValue<NetworkAclBypass> _networkAclBypass;

    /// <summary>
    /// An array that contains the Resource Ids for Network Acl Bypass for the
    /// Cosmos DB account.
    /// </summary>
    public BicepList<ResourceIdentifier> NetworkAclBypassResourceIds { get => _networkAclBypassResourceIds; set => _networkAclBypassResourceIds.Assign(value); }
    private readonly BicepList<ResourceIdentifier> _networkAclBypassResourceIds;

    /// <summary>
    /// Whether requests from Public Network are allowed.
    /// </summary>
    public BicepValue<CosmosDBPublicNetworkAccess> PublicNetworkAccess { get => _publicNetworkAccess; set => _publicNetworkAccess.Assign(value); }
    private readonly BicepValue<CosmosDBPublicNetworkAccess> _publicNetworkAccess;

    /// <summary>
    /// Parameters to indicate the information about the restore.
    /// </summary>
    public BicepValue<CosmosDBAccountRestoreParameters> RestoreParameters { get => _restoreParameters; set => _restoreParameters.Assign(value); }
    private readonly BicepValue<CosmosDBAccountRestoreParameters> _restoreParameters;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// List of Virtual Network ACL rules configured for the Cosmos DB account.
    /// </summary>
    public BicepList<CosmosDBVirtualNetworkRule> VirtualNetworkRules { get => _virtualNetworkRules; set => _virtualNetworkRules.Assign(value); }
    private readonly BicepList<CosmosDBVirtualNetworkRule> _virtualNetworkRules;

    /// <summary>
    /// The connection endpoint for the Cosmos DB database account.
    /// </summary>
    public BicepValue<string> DocumentEndpoint { get => _documentEndpoint; }
    private readonly BicepValue<string> _documentEndpoint;

    /// <summary>
    /// An array that contains the regions ordered by their failover priorities.
    /// </summary>
    public BicepList<CosmosDBFailoverPolicy> FailoverPolicies { get => _failoverPolicies; }
    private readonly BicepList<CosmosDBFailoverPolicy> _failoverPolicies;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// A unique identifier assigned to the database account.
    /// </summary>
    public BicepValue<Guid> InstanceId { get => _instanceId; }
    private readonly BicepValue<Guid> _instanceId;

    /// <summary>
    /// This property is ignored during the update/create operation, as the
    /// metadata is read-only. The object represents the metadata for the
    /// Account Keys of the Cosmos DB account.
    /// </summary>
    public BicepValue<DatabaseAccountKeysMetadata> KeysMetadata { get => _keysMetadata; }
    private readonly BicepValue<DatabaseAccountKeysMetadata> _keysMetadata;

    /// <summary>
    /// List of Private Endpoint Connections configured for the Cosmos DB
    /// account.
    /// </summary>
    public BicepList<CosmosDBPrivateEndpointConnectionData> PrivateEndpointConnections { get => _privateEndpointConnections; }
    private readonly BicepList<CosmosDBPrivateEndpointConnectionData> _privateEndpointConnections;

    /// <summary>
    /// The status of the Cosmos DB account at the time the operation was
    /// called. The status can be one of following. &apos;Creating&apos; – the
    /// Cosmos DB account is being created. When an account is in Creating
    /// state, only properties that are specified as input for the Create
    /// Cosmos DB account operation are returned. &apos;Succeeded&apos; – the
    /// Cosmos DB account is active for use. &apos;Updating&apos; – the Cosmos
    /// DB account is being updated. &apos;Deleting&apos; – the Cosmos DB
    /// account is being deleted. &apos;Failed&apos; – the Cosmos DB account
    /// failed creation. &apos;DeletionFailed&apos; – the Cosmos DB account
    /// deletion failed.
    /// </summary>
    public BicepValue<string> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<string> _provisioningState;

    /// <summary>
    /// An array that contains of the read locations enabled for the Cosmos DB
    /// account.
    /// </summary>
    public BicepList<CosmosDBAccountLocation> ReadLocations { get => _readLocations; }
    private readonly BicepList<CosmosDBAccountLocation> _readLocations;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// An array that contains the write location for the Cosmos DB account.
    /// </summary>
    public BicepList<CosmosDBAccountLocation> WriteLocations { get => _writeLocations; }
    private readonly BicepList<CosmosDBAccountLocation> _writeLocations;

    /// <summary>
    /// Creates a new CosmosDBAccount.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the CosmosDBAccount resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the CosmosDBAccount.</param>
    public CosmosDBAccount(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.DocumentDB/databaseAccounts", resourceVersion ?? "2024-08-15")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _locations = BicepList<CosmosDBAccountLocation>.DefineProperty(this, "Locations", ["properties", "locations"], isRequired: true);
        _analyticalStorageSchemaType = BicepValue<AnalyticalStorageSchemaType>.DefineProperty(this, "AnalyticalStorageSchemaType", ["properties", "analyticalStorageConfiguration", "schemaType"]);
        _apiServerVersion = BicepValue<CosmosDBServerVersion>.DefineProperty(this, "ApiServerVersion", ["properties", "apiProperties", "serverVersion"]);
        _backupPolicy = BicepValue<CosmosDBAccountBackupPolicy>.DefineProperty(this, "BackupPolicy", ["properties", "backupPolicy"]);
        _capabilities = BicepList<CosmosDBAccountCapability>.DefineProperty(this, "Capabilities", ["properties", "capabilities"]);
        _capacityTotalThroughputLimit = BicepValue<int>.DefineProperty(this, "CapacityTotalThroughputLimit", ["properties", "capacity", "totalThroughputLimit"]);
        _connectorOffer = BicepValue<ConnectorOffer>.DefineProperty(this, "ConnectorOffer", ["properties", "connectorOffer"]);
        _consistencyPolicy = BicepValue<ConsistencyPolicy>.DefineProperty(this, "ConsistencyPolicy", ["properties", "consistencyPolicy"]);
        _cors = BicepList<CosmosDBAccountCorsPolicy>.DefineProperty(this, "Cors", ["properties", "cors"]);
        _createMode = BicepValue<CosmosDBAccountCreateMode>.DefineProperty(this, "CreateMode", ["properties", "createMode"]);
        _customerManagedKeyStatus = BicepValue<string>.DefineProperty(this, "CustomerManagedKeyStatus", ["properties", "customerManagedKeyStatus"]);
        _databaseAccountOfferType = BicepValue<CosmosDBAccountOfferType>.DefineProperty(this, "DatabaseAccountOfferType", ["properties", "databaseAccountOfferType"]);
        _defaultIdentity = BicepValue<string>.DefineProperty(this, "DefaultIdentity", ["properties", "defaultIdentity"]);
        _defaultPriorityLevel = BicepValue<DefaultPriorityLevel>.DefineProperty(this, "DefaultPriorityLevel", ["properties", "defaultPriorityLevel"]);
        _diagnosticLogEnableFullTextQuery = BicepValue<EnableFullTextQuery>.DefineProperty(this, "DiagnosticLogEnableFullTextQuery", ["properties", "diagnosticLogSettings", "enableFullTextQuery"]);
        _disableKeyBasedMetadataWriteAccess = BicepValue<bool>.DefineProperty(this, "DisableKeyBasedMetadataWriteAccess", ["properties", "disableKeyBasedMetadataWriteAccess"]);
        _disableLocalAuth = BicepValue<bool>.DefineProperty(this, "DisableLocalAuth", ["properties", "disableLocalAuth"]);
        _enableAutomaticFailover = BicepValue<bool>.DefineProperty(this, "EnableAutomaticFailover", ["properties", "enableAutomaticFailover"]);
        _enableBurstCapacity = BicepValue<bool>.DefineProperty(this, "EnableBurstCapacity", ["properties", "enableBurstCapacity"]);
        _enableCassandraConnector = BicepValue<bool>.DefineProperty(this, "EnableCassandraConnector", ["properties", "enableCassandraConnector"]);
        _enableMaterializedViews = BicepValue<bool>.DefineProperty(this, "EnableMaterializedViews", ["properties", "enableMaterializedViews"]);
        _enableMultipleWriteLocations = BicepValue<bool>.DefineProperty(this, "EnableMultipleWriteLocations", ["properties", "enableMultipleWriteLocations"]);
        _enablePartitionMerge = BicepValue<bool>.DefineProperty(this, "EnablePartitionMerge", ["properties", "enablePartitionMerge"]);
        _enablePerRegionPerPartitionAutoscale = BicepValue<bool>.DefineProperty(this, "EnablePerRegionPerPartitionAutoscale", ["properties", "enablePerRegionPerPartitionAutoscale"]);
        _enablePriorityBasedExecution = BicepValue<bool>.DefineProperty(this, "EnablePriorityBasedExecution", ["properties", "enablePriorityBasedExecution"]);
        _identity = BicepValue<ManagedServiceIdentity>.DefineProperty(this, "Identity", ["identity"]);
        _iPRules = BicepList<CosmosDBIPAddressOrRange>.DefineProperty(this, "IPRules", ["properties", "ipRules"]);
        _isAnalyticalStorageEnabled = BicepValue<bool>.DefineProperty(this, "IsAnalyticalStorageEnabled", ["properties", "enableAnalyticalStorage"]);
        _isFreeTierEnabled = BicepValue<bool>.DefineProperty(this, "IsFreeTierEnabled", ["properties", "enableFreeTier"]);
        _isVirtualNetworkFilterEnabled = BicepValue<bool>.DefineProperty(this, "IsVirtualNetworkFilterEnabled", ["properties", "isVirtualNetworkFilterEnabled"]);
        _keyVaultKeyUri = BicepValue<Uri>.DefineProperty(this, "KeyVaultKeyUri", ["properties", "keyVaultKeyUri"]);
        _kind = BicepValue<CosmosDBAccountKind>.DefineProperty(this, "Kind", ["kind"]);
        _minimalTlsVersion = BicepValue<CosmosDBMinimalTlsVersion>.DefineProperty(this, "MinimalTlsVersion", ["properties", "minimalTlsVersion"]);
        _networkAclBypass = BicepValue<NetworkAclBypass>.DefineProperty(this, "NetworkAclBypass", ["properties", "networkAclBypass"]);
        _networkAclBypassResourceIds = BicepList<ResourceIdentifier>.DefineProperty(this, "NetworkAclBypassResourceIds", ["properties", "networkAclBypassResourceIds"]);
        _publicNetworkAccess = BicepValue<CosmosDBPublicNetworkAccess>.DefineProperty(this, "PublicNetworkAccess", ["properties", "publicNetworkAccess"]);
        _restoreParameters = BicepValue<CosmosDBAccountRestoreParameters>.DefineProperty(this, "RestoreParameters", ["properties", "restoreParameters"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _virtualNetworkRules = BicepList<CosmosDBVirtualNetworkRule>.DefineProperty(this, "VirtualNetworkRules", ["properties", "virtualNetworkRules"]);
        _documentEndpoint = BicepValue<string>.DefineProperty(this, "DocumentEndpoint", ["properties", "documentEndpoint"], isOutput: true);
        _failoverPolicies = BicepList<CosmosDBFailoverPolicy>.DefineProperty(this, "FailoverPolicies", ["properties", "failoverPolicies"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _instanceId = BicepValue<Guid>.DefineProperty(this, "InstanceId", ["properties", "instanceId"], isOutput: true);
        _keysMetadata = BicepValue<DatabaseAccountKeysMetadata>.DefineProperty(this, "KeysMetadata", ["properties", "keysMetadata"], isOutput: true);
        _privateEndpointConnections = BicepList<CosmosDBPrivateEndpointConnectionData>.DefineProperty(this, "PrivateEndpointConnections", ["properties", "privateEndpointConnections"], isOutput: true);
        _provisioningState = BicepValue<string>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _readLocations = BicepList<CosmosDBAccountLocation>.DefineProperty(this, "ReadLocations", ["properties", "readLocations"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _writeLocations = BicepList<CosmosDBAccountLocation>.DefineProperty(this, "WriteLocations", ["properties", "writeLocations"], isOutput: true);
    }

    /// <summary>
    /// Supported CosmosDBAccount resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-08-15.
        /// </summary>
        public static readonly string V2024_08_15 = "2024-08-15";

        /// <summary>
        /// 2024-05-15.
        /// </summary>
        public static readonly string V2024_05_15 = "2024-05-15";

        /// <summary>
        /// 2023-11-15.
        /// </summary>
        public static readonly string V2023_11_15 = "2023-11-15";

        /// <summary>
        /// 2023-09-15.
        /// </summary>
        public static readonly string V2023_09_15 = "2023-09-15";

        /// <summary>
        /// 2023-04-15.
        /// </summary>
        public static readonly string V2023_04_15 = "2023-04-15";

        /// <summary>
        /// 2023-03-15.
        /// </summary>
        public static readonly string V2023_03_15 = "2023-03-15";

        /// <summary>
        /// 2022-11-15.
        /// </summary>
        public static readonly string V2022_11_15 = "2022-11-15";

        /// <summary>
        /// 2022-08-15.
        /// </summary>
        public static readonly string V2022_08_15 = "2022-08-15";

        /// <summary>
        /// 2022-05-15.
        /// </summary>
        public static readonly string V2022_05_15 = "2022-05-15";

        /// <summary>
        /// 2021-10-15.
        /// </summary>
        public static readonly string V2021_10_15 = "2021-10-15";

        /// <summary>
        /// 2021-06-15.
        /// </summary>
        public static readonly string V2021_06_15 = "2021-06-15";

        /// <summary>
        /// 2021-05-15.
        /// </summary>
        public static readonly string V2021_05_15 = "2021-05-15";

        /// <summary>
        /// 2021-04-15.
        /// </summary>
        public static readonly string V2021_04_15 = "2021-04-15";

        /// <summary>
        /// 2021-03-15.
        /// </summary>
        public static readonly string V2021_03_15 = "2021-03-15";

        /// <summary>
        /// 2021-01-15.
        /// </summary>
        public static readonly string V2021_01_15 = "2021-01-15";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-04-01.
        /// </summary>
        public static readonly string V2020_04_01 = "2020-04-01";

        /// <summary>
        /// 2020-03-01.
        /// </summary>
        public static readonly string V2020_03_01 = "2020-03-01";

        /// <summary>
        /// 2019-12-12.
        /// </summary>
        public static readonly string V2019_12_12 = "2019-12-12";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";

        /// <summary>
        /// 2016-03-31.
        /// </summary>
        public static readonly string V2016_03_31 = "2016-03-31";

        /// <summary>
        /// 2016-03-19.
        /// </summary>
        public static readonly string V2016_03_19 = "2016-03-19";

        /// <summary>
        /// 2015-11-06.
        /// </summary>
        public static readonly string V2015_11_06 = "2015-11-06";

        /// <summary>
        /// 2015-04-08.
        /// </summary>
        public static readonly string V2015_04_08 = "2015-04-08";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing CosmosDBAccount.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the CosmosDBAccount resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the CosmosDBAccount.</param>
    /// <returns>The existing CosmosDBAccount resource.</returns>
    public static CosmosDBAccount FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this CosmosDBAccount resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 3, maxLength: 44, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);

    /// <summary>
    /// Get access keys for this CosmosDBAccount resource.
    /// </summary>
    /// <returns>The keys for this CosmosDBAccount resource.</returns>
    public CosmosDBAccountKeyList GetKeys() =>
        CosmosDBAccountKeyList.FromExpression(
            new FunctionCallExpression(new MemberExpression(new IdentifierExpression(BicepIdentifier), "listKeys")));

    /// <summary>
    /// Creates a role assignment for a user-assigned identity that grants
    /// access to this CosmosDBAccount.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="identity">The <see cref="UserAssignedIdentity"/>.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(CosmosDBBuiltInRole role, UserAssignedIdentity identity) =>
        new($"{BicepIdentifier}_{identity.BicepIdentifier}_{CosmosDBBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, identity.PrincipalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = RoleManagementPrincipalType.ServicePrincipal,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = identity.PrincipalId
        };

    /// <summary>
    /// Creates a role assignment for a principal that grants access to this
    /// CosmosDBAccount.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="principalType">The type of the principal to assign to.</param>
    /// <param name="principalId">The principal to assign to.</param>
    /// <param name="bicepIdentifierSuffix">Optional role assignment identifier name suffix.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(CosmosDBBuiltInRole role, BicepValue<RoleManagementPrincipalType> principalType, BicepValue<Guid> principalId, string? bicepIdentifierSuffix = default) =>
        new($"{BicepIdentifier}_{CosmosDBBuiltInRole.GetBuiltInRoleName(role)}{(bicepIdentifierSuffix is null ? "" : "_")}{bicepIdentifierSuffix}")
        {
            Name = BicepFunction.CreateGuid(Id, principalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = principalType,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = principalId
        };
}
