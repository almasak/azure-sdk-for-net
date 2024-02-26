// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMwareCbt specific enable migration input. </summary>
    public partial class VMwareCbtEnableMigrationContent : EnableMigrationProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="VMwareCbtEnableMigrationContent"/>. </summary>
        /// <param name="vmwareMachineId"> The ARM Id of the VM discovered in VMware. </param>
        /// <param name="disksToInclude"> The disks to include list. </param>
        /// <param name="dataMoverRunAsAccountId"> The data mover run as account Id. </param>
        /// <param name="snapshotRunAsAccountId"> The snapshot run as account Id. </param>
        /// <param name="targetResourceGroupId"> The target resource group ARM Id. </param>
        /// <param name="targetNetworkId"> The target network ARM Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmwareMachineId"/>, <paramref name="disksToInclude"/>, <paramref name="dataMoverRunAsAccountId"/>, <paramref name="snapshotRunAsAccountId"/>, <paramref name="targetResourceGroupId"/> or <paramref name="targetNetworkId"/> is null. </exception>
        public VMwareCbtEnableMigrationContent(ResourceIdentifier vmwareMachineId, IEnumerable<VMwareCbtDiskContent> disksToInclude, ResourceIdentifier dataMoverRunAsAccountId, ResourceIdentifier snapshotRunAsAccountId, ResourceIdentifier targetResourceGroupId, ResourceIdentifier targetNetworkId)
        {
            if (vmwareMachineId == null)
            {
                throw new ArgumentNullException(nameof(vmwareMachineId));
            }
            if (disksToInclude == null)
            {
                throw new ArgumentNullException(nameof(disksToInclude));
            }
            if (dataMoverRunAsAccountId == null)
            {
                throw new ArgumentNullException(nameof(dataMoverRunAsAccountId));
            }
            if (snapshotRunAsAccountId == null)
            {
                throw new ArgumentNullException(nameof(snapshotRunAsAccountId));
            }
            if (targetResourceGroupId == null)
            {
                throw new ArgumentNullException(nameof(targetResourceGroupId));
            }
            if (targetNetworkId == null)
            {
                throw new ArgumentNullException(nameof(targetNetworkId));
            }

            VMwareMachineId = vmwareMachineId;
            DisksToInclude = disksToInclude.ToList();
            DataMoverRunAsAccountId = dataMoverRunAsAccountId;
            SnapshotRunAsAccountId = snapshotRunAsAccountId;
            TargetResourceGroupId = targetResourceGroupId;
            TargetNetworkId = targetNetworkId;
            TargetVmTags = new ChangeTrackingDictionary<string, string>();
            SeedDiskTags = new ChangeTrackingDictionary<string, string>();
            TargetDiskTags = new ChangeTrackingDictionary<string, string>();
            TargetNicTags = new ChangeTrackingDictionary<string, string>();
            InstanceType = "VMwareCbt";
        }

        /// <summary> Initializes a new instance of <see cref="VMwareCbtEnableMigrationContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="vmwareMachineId"> The ARM Id of the VM discovered in VMware. </param>
        /// <param name="disksToInclude"> The disks to include list. </param>
        /// <param name="licenseType"> License type. </param>
        /// <param name="sqlServerLicenseType"> The SQL Server license type. </param>
        /// <param name="performSqlBulkRegistration"> A value indicating whether bulk SQL RP registration to be done. </param>
        /// <param name="dataMoverRunAsAccountId"> The data mover run as account Id. </param>
        /// <param name="snapshotRunAsAccountId"> The snapshot run as account Id. </param>
        /// <param name="targetVmName"> The target VM name. </param>
        /// <param name="targetVmSize"> The target VM size. </param>
        /// <param name="targetResourceGroupId"> The target resource group ARM Id. </param>
        /// <param name="targetNetworkId"> The target network ARM Id. </param>
        /// <param name="testNetworkId"> The selected test network ARM Id. </param>
        /// <param name="targetSubnetName"> The target subnet name. </param>
        /// <param name="testSubnetName"> The selected test subnet name. </param>
        /// <param name="targetAvailabilitySetId"> The target availability set ARM Id. </param>
        /// <param name="targetAvailabilityZone"> The target availability zone. </param>
        /// <param name="targetProximityPlacementGroupId"> The target proximity placement group ARM Id. </param>
        /// <param name="confidentialVmKeyVaultId"> The confidential VM key vault Id for ADE installation. </param>
        /// <param name="targetVmSecurityProfile"> The target VM security profile. </param>
        /// <param name="targetBootDiagnosticsStorageAccountId"> The target boot diagnostics storage account ARM Id. </param>
        /// <param name="performAutoResync"> A value indicating whether auto resync is to be done. </param>
        /// <param name="targetVmTags"> The target VM tags. </param>
        /// <param name="seedDiskTags"> The tags for the seed disks. </param>
        /// <param name="targetDiskTags"> The tags for the target disks. </param>
        /// <param name="targetNicTags"> The tags for the target NICs. </param>
        internal VMwareCbtEnableMigrationContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier vmwareMachineId, IList<VMwareCbtDiskContent> disksToInclude, SiteRecoveryLicenseType? licenseType, SiteRecoverySqlServerLicenseType? sqlServerLicenseType, string performSqlBulkRegistration, ResourceIdentifier dataMoverRunAsAccountId, ResourceIdentifier snapshotRunAsAccountId, string targetVmName, string targetVmSize, ResourceIdentifier targetResourceGroupId, ResourceIdentifier targetNetworkId, ResourceIdentifier testNetworkId, string targetSubnetName, string testSubnetName, ResourceIdentifier targetAvailabilitySetId, string targetAvailabilityZone, ResourceIdentifier targetProximityPlacementGroupId, ResourceIdentifier confidentialVmKeyVaultId, VMwareCbtSecurityProfileProperties targetVmSecurityProfile, ResourceIdentifier targetBootDiagnosticsStorageAccountId, string performAutoResync, IDictionary<string, string> targetVmTags, IDictionary<string, string> seedDiskTags, IDictionary<string, string> targetDiskTags, IDictionary<string, string> targetNicTags) : base(instanceType, serializedAdditionalRawData)
        {
            VMwareMachineId = vmwareMachineId;
            DisksToInclude = disksToInclude;
            LicenseType = licenseType;
            SqlServerLicenseType = sqlServerLicenseType;
            PerformSqlBulkRegistration = performSqlBulkRegistration;
            DataMoverRunAsAccountId = dataMoverRunAsAccountId;
            SnapshotRunAsAccountId = snapshotRunAsAccountId;
            TargetVmName = targetVmName;
            TargetVmSize = targetVmSize;
            TargetResourceGroupId = targetResourceGroupId;
            TargetNetworkId = targetNetworkId;
            TestNetworkId = testNetworkId;
            TargetSubnetName = targetSubnetName;
            TestSubnetName = testSubnetName;
            TargetAvailabilitySetId = targetAvailabilitySetId;
            TargetAvailabilityZone = targetAvailabilityZone;
            TargetProximityPlacementGroupId = targetProximityPlacementGroupId;
            ConfidentialVmKeyVaultId = confidentialVmKeyVaultId;
            TargetVmSecurityProfile = targetVmSecurityProfile;
            TargetBootDiagnosticsStorageAccountId = targetBootDiagnosticsStorageAccountId;
            PerformAutoResync = performAutoResync;
            TargetVmTags = targetVmTags;
            SeedDiskTags = seedDiskTags;
            TargetDiskTags = targetDiskTags;
            TargetNicTags = targetNicTags;
            InstanceType = instanceType ?? "VMwareCbt";
        }

        /// <summary> Initializes a new instance of <see cref="VMwareCbtEnableMigrationContent"/> for deserialization. </summary>
        internal VMwareCbtEnableMigrationContent()
        {
        }

        /// <summary> The ARM Id of the VM discovered in VMware. </summary>
        public ResourceIdentifier VMwareMachineId { get; }
        /// <summary> The disks to include list. </summary>
        public IList<VMwareCbtDiskContent> DisksToInclude { get; }
        /// <summary> License type. </summary>
        public SiteRecoveryLicenseType? LicenseType { get; set; }
        /// <summary> The SQL Server license type. </summary>
        public SiteRecoverySqlServerLicenseType? SqlServerLicenseType { get; set; }
        /// <summary> A value indicating whether bulk SQL RP registration to be done. </summary>
        public string PerformSqlBulkRegistration { get; set; }
        /// <summary> The data mover run as account Id. </summary>
        public ResourceIdentifier DataMoverRunAsAccountId { get; }
        /// <summary> The snapshot run as account Id. </summary>
        public ResourceIdentifier SnapshotRunAsAccountId { get; }
        /// <summary> The target VM name. </summary>
        public string TargetVmName { get; set; }
        /// <summary> The target VM size. </summary>
        public string TargetVmSize { get; set; }
        /// <summary> The target resource group ARM Id. </summary>
        public ResourceIdentifier TargetResourceGroupId { get; }
        /// <summary> The target network ARM Id. </summary>
        public ResourceIdentifier TargetNetworkId { get; }
        /// <summary> The selected test network ARM Id. </summary>
        public ResourceIdentifier TestNetworkId { get; set; }
        /// <summary> The target subnet name. </summary>
        public string TargetSubnetName { get; set; }
        /// <summary> The selected test subnet name. </summary>
        public string TestSubnetName { get; set; }
        /// <summary> The target availability set ARM Id. </summary>
        public ResourceIdentifier TargetAvailabilitySetId { get; set; }
        /// <summary> The target availability zone. </summary>
        public string TargetAvailabilityZone { get; set; }
        /// <summary> The target proximity placement group ARM Id. </summary>
        public ResourceIdentifier TargetProximityPlacementGroupId { get; set; }
        /// <summary> The confidential VM key vault Id for ADE installation. </summary>
        public ResourceIdentifier ConfidentialVmKeyVaultId { get; set; }
        /// <summary> The target VM security profile. </summary>
        public VMwareCbtSecurityProfileProperties TargetVmSecurityProfile { get; set; }
        /// <summary> The target boot diagnostics storage account ARM Id. </summary>
        public ResourceIdentifier TargetBootDiagnosticsStorageAccountId { get; set; }
        /// <summary> A value indicating whether auto resync is to be done. </summary>
        public string PerformAutoResync { get; set; }
        /// <summary> The target VM tags. </summary>
        public IDictionary<string, string> TargetVmTags { get; }
        /// <summary> The tags for the seed disks. </summary>
        public IDictionary<string, string> SeedDiskTags { get; }
        /// <summary> The tags for the target disks. </summary>
        public IDictionary<string, string> TargetDiskTags { get; }
        /// <summary> The tags for the target NICs. </summary>
        public IDictionary<string, string> TargetNicTags { get; }
    }
}
