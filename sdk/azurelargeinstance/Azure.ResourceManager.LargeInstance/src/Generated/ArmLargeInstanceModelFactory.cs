// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.LargeInstance;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LargeInstance.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmLargeInstanceModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="LargeInstance.LargeInstanceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="hardwareProfile"> Specifies the hardware settings for the Azure Large Instance. </param>
        /// <param name="storageProfile"> Specifies the storage settings for the Azure Large Instance disks. </param>
        /// <param name="osProfile"> Specifies the operating system settings for the Azure Large Instance. </param>
        /// <param name="networkProfile"> Specifies the network settings for the Azure Large Instance. </param>
        /// <param name="azureLargeInstanceId"> Specifies the Azure Large Instance unique ID. </param>
        /// <param name="powerState"> Resource power state. </param>
        /// <param name="proximityPlacementGroup"> Resource proximity placement group. </param>
        /// <param name="hwRevision"> Hardware revision of an Azure Large Instance. </param>
        /// <param name="partnerNodeId">
        /// ARM ID of another AzureLargeInstance that will share a network with this
        /// AzureLargeInstance
        /// </param>
        /// <param name="provisioningState"> State of provisioning of the AzureLargeInstance. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="LargeInstance.LargeInstanceData"/> instance for mocking. </returns>
        public static LargeInstanceData LargeInstanceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, LargeInstanceHardwareProfile hardwareProfile = null, LargeInstanceStorageProfile storageProfile = null, LargeInstanceOSProfile osProfile = null, LargeInstanceNetworkProfile networkProfile = null, string azureLargeInstanceId = null, LargeInstancePowerState? powerState = null, string proximityPlacementGroup = null, string hwRevision = null, string partnerNodeId = null, LargeInstanceProvisioningState? provisioningState = null, IReadOnlyDictionary<string, string> tags = null, AzureLocation location = default)
        {
            tags ??= new Dictionary<string, string>();

            return new LargeInstanceData(
                id,
                name,
                resourceType,
                systemData,
                hardwareProfile,
                storageProfile,
                osProfile,
                networkProfile,
                azureLargeInstanceId,
                powerState,
                proximityPlacementGroup,
                hwRevision,
                partnerNodeId,
                provisioningState,
                tags,
                location,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LargeInstanceHardwareProfile"/>. </summary>
        /// <param name="hardwareType"> Name of the hardware type (vendor and/or their product name). </param>
        /// <param name="azureLargeInstanceSize"> Specifies the Azure Large Instance SKU. </param>
        /// <returns> A new <see cref="Models.LargeInstanceHardwareProfile"/> instance for mocking. </returns>
        public static LargeInstanceHardwareProfile LargeInstanceHardwareProfile(LargeInstanceHardwareTypeName? hardwareType = null, LargeInstanceSizeName? azureLargeInstanceSize = null)
        {
            return new LargeInstanceHardwareProfile(hardwareType, azureLargeInstanceSize, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LargeInstanceStorageProfile"/>. </summary>
        /// <param name="nfsIPAddress"> IP Address to connect to storage. </param>
        /// <param name="osDisks">
        /// Specifies information about the operating system disk used by Azure Large
        /// Instance.
        /// </param>
        /// <returns> A new <see cref="Models.LargeInstanceStorageProfile"/> instance for mocking. </returns>
        public static LargeInstanceStorageProfile LargeInstanceStorageProfile(string nfsIPAddress = null, IEnumerable<LargeInstanceDisk> osDisks = null)
        {
            osDisks ??= new List<LargeInstanceDisk>();

            return new LargeInstanceStorageProfile(nfsIPAddress, osDisks?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LargeInstanceDisk"/>. </summary>
        /// <param name="name"> The disk name. </param>
        /// <param name="diskSizeGB"> Specifies the size of an empty data disk in gigabytes. </param>
        /// <param name="lun">
        /// Specifies the logical unit number of the data disk. This value is used to
        /// identify data disks within the VM and therefore must be unique for each data
        /// disk attached to a VM.
        /// </param>
        /// <returns> A new <see cref="Models.LargeInstanceDisk"/> instance for mocking. </returns>
        public static LargeInstanceDisk LargeInstanceDisk(string name = null, int? diskSizeGB = null, int? lun = null)
        {
            return new LargeInstanceDisk(name, diskSizeGB, lun, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LargeInstanceOSProfile"/>. </summary>
        /// <param name="computerName"> Specifies the host OS name of the Azure Large Instance. </param>
        /// <param name="osType"> This property allows you to specify the type of the OS. </param>
        /// <param name="version"> Specifies version of operating system. </param>
        /// <param name="sshPublicKey"> Specifies the SSH public key used to access the operating system. </param>
        /// <returns> A new <see cref="Models.LargeInstanceOSProfile"/> instance for mocking. </returns>
        public static LargeInstanceOSProfile LargeInstanceOSProfile(string computerName = null, string osType = null, string version = null, string sshPublicKey = null)
        {
            return new LargeInstanceOSProfile(computerName, osType, version, sshPublicKey, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LargeInstanceNetworkProfile"/>. </summary>
        /// <param name="networkInterfaces"> Specifies the network interfaces for the Azure Large Instance. </param>
        /// <param name="circuitId"> Specifies the circuit id for connecting to express route. </param>
        /// <returns> A new <see cref="Models.LargeInstanceNetworkProfile"/> instance for mocking. </returns>
        public static LargeInstanceNetworkProfile LargeInstanceNetworkProfile(IEnumerable<LargeInstanceIPAddress> networkInterfaces = null, string circuitId = null)
        {
            networkInterfaces ??= new List<LargeInstanceIPAddress>();

            return new LargeInstanceNetworkProfile(networkInterfaces?.ToList(), circuitId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LargeInstanceIPAddress"/>. </summary>
        /// <param name="ipAddress"> Specifies the IP address of the network interface. </param>
        /// <returns> A new <see cref="Models.LargeInstanceIPAddress"/> instance for mocking. </returns>
        public static LargeInstanceIPAddress LargeInstanceIPAddress(string ipAddress = null)
        {
            return new LargeInstanceIPAddress(ipAddress, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="LargeInstance.LargeStorageInstanceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="azureLargeStorageInstanceUniqueIdentifier"> Specifies the AzureLargeStorageInstance unique ID. </param>
        /// <param name="storageProperties"> Specifies the storage properties for the AzureLargeStorage instance. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="LargeInstance.LargeStorageInstanceData"/> instance for mocking. </returns>
        public static LargeStorageInstanceData LargeStorageInstanceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string azureLargeStorageInstanceUniqueIdentifier = null, LargeInstanceStorageProperties storageProperties = null, IReadOnlyDictionary<string, string> tags = null, AzureLocation location = default)
        {
            tags ??= new Dictionary<string, string>();

            return new LargeStorageInstanceData(
                id,
                name,
                resourceType,
                systemData,
                azureLargeStorageInstanceUniqueIdentifier,
                storageProperties,
                tags,
                location,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LargeInstanceStorageProperties"/>. </summary>
        /// <param name="provisioningState"> State of provisioning of the AzureLargeStorageInstance. </param>
        /// <param name="offeringType"> the offering type for which the resource is getting provisioned. </param>
        /// <param name="storageType"> the storage protocol for which the resource is getting provisioned. </param>
        /// <param name="generation"> the kind of storage instance. </param>
        /// <param name="hardwareType"> the hardware type of the storage instance. </param>
        /// <param name="workloadType"> the workload for which the resource is getting provisioned. </param>
        /// <param name="storageBillingProperties"> the billing related information for the resource. </param>
        /// <returns> A new <see cref="Models.LargeInstanceStorageProperties"/> instance for mocking. </returns>
        public static LargeInstanceStorageProperties LargeInstanceStorageProperties(LargeInstanceProvisioningState? provisioningState = null, string offeringType = null, string storageType = null, string generation = null, LargeInstanceHardwareTypeName? hardwareType = null, string workloadType = null, LargeInstanceStorageBillingProperties storageBillingProperties = null)
        {
            return new LargeInstanceStorageProperties(
                provisioningState,
                offeringType,
                storageType,
                generation,
                hardwareType,
                workloadType,
                storageBillingProperties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LargeInstanceStorageBillingProperties"/>. </summary>
        /// <param name="billingMode"> the billing mode for the storage instance. </param>
        /// <param name="sku"> the SKU type that is provisioned. </param>
        /// <returns> A new <see cref="Models.LargeInstanceStorageBillingProperties"/> instance for mocking. </returns>
        public static LargeInstanceStorageBillingProperties LargeInstanceStorageBillingProperties(string billingMode = null, string sku = null)
        {
            return new LargeInstanceStorageBillingProperties(billingMode, sku, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.LargeInstanceOperationStatusResult"/>. </summary>
        /// <param name="id"> Fully qualified ID for the async operation. </param>
        /// <param name="resourceId"> Fully qualified ID of the resource against which the original async operation was started. </param>
        /// <param name="name"> Name of the async operation. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="percentComplete"> Percent of the operation that is complete. </param>
        /// <param name="startOn"> The start time of the operation. </param>
        /// <param name="endOn"> The end time of the operation. </param>
        /// <param name="operations"> The operations list. </param>
        /// <param name="error"> If present, details of the operation error. </param>
        /// <returns> A new <see cref="Models.LargeInstanceOperationStatusResult"/> instance for mocking. </returns>
        public static LargeInstanceOperationStatusResult LargeInstanceOperationStatusResult(ResourceIdentifier id = null, ResourceIdentifier resourceId = null, string name = null, string status = null, float? percentComplete = null, DateTimeOffset? startOn = null, DateTimeOffset? endOn = null, IEnumerable<LargeInstanceOperationStatusResult> operations = null, ResponseError error = null)
        {
            operations ??= new List<LargeInstanceOperationStatusResult>();

            return new LargeInstanceOperationStatusResult(
                id,
                resourceId,
                name,
                status,
                percentComplete,
                startOn,
                endOn,
                operations?.ToList(),
                error,
                serializedAdditionalRawData: null);
        }
    }
}
