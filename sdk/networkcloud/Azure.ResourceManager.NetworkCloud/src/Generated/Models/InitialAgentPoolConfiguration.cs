// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> InitialAgentPoolConfiguration specifies the configuration of a pool of virtual machines that are initially defined with a Kubernetes cluster. </summary>
    public partial class InitialAgentPoolConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InitialAgentPoolConfiguration"/>. </summary>
        /// <param name="count"> The number of virtual machines that use this configuration. </param>
        /// <param name="mode"> The selection of how this agent pool is utilized, either as a system pool or a user pool. System pools run the features and critical services for the Kubernetes Cluster, while user pools are dedicated to user workloads. Every Kubernetes cluster must contain at least one system node pool with at least one node. </param>
        /// <param name="name"> The name that will be used for the agent pool resource representing this agent pool. </param>
        /// <param name="vmSkuName"> The name of the VM SKU that determines the size of resources allocated for node VMs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="vmSkuName"/> is null. </exception>
        public InitialAgentPoolConfiguration(long count, NetworkCloudAgentPoolMode mode, string name, string vmSkuName)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (vmSkuName == null)
            {
                throw new ArgumentNullException(nameof(vmSkuName));
            }

            AvailabilityZones = new ChangeTrackingList<string>();
            Count = count;
            Labels = new ChangeTrackingList<KubernetesLabel>();
            Mode = mode;
            Name = name;
            Taints = new ChangeTrackingList<KubernetesLabel>();
            VmSkuName = vmSkuName;
        }

        /// <summary> Initializes a new instance of <see cref="InitialAgentPoolConfiguration"/>. </summary>
        /// <param name="administratorConfiguration"> The administrator credentials to be used for the nodes in this agent pool. </param>
        /// <param name="agentOptions"> The configurations that will be applied to each agent in this agent pool. </param>
        /// <param name="attachedNetworkConfiguration"> The configuration of networks being attached to the agent pool for use by the workloads that run on this Kubernetes cluster. </param>
        /// <param name="availabilityZones"> The list of availability zones of the Network Cloud cluster used for the provisioning of nodes in this agent pool. If not specified, all availability zones will be used. </param>
        /// <param name="count"> The number of virtual machines that use this configuration. </param>
        /// <param name="labels"> The labels applied to the nodes in this agent pool. </param>
        /// <param name="mode"> The selection of how this agent pool is utilized, either as a system pool or a user pool. System pools run the features and critical services for the Kubernetes Cluster, while user pools are dedicated to user workloads. Every Kubernetes cluster must contain at least one system node pool with at least one node. </param>
        /// <param name="name"> The name that will be used for the agent pool resource representing this agent pool. </param>
        /// <param name="taints"> The taints applied to the nodes in this agent pool. </param>
        /// <param name="upgradeSettings"> The configuration of the agent pool. </param>
        /// <param name="vmSkuName"> The name of the VM SKU that determines the size of resources allocated for node VMs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InitialAgentPoolConfiguration(AdministratorConfiguration administratorConfiguration, NetworkCloudAgentConfiguration agentOptions, AttachedNetworkConfiguration attachedNetworkConfiguration, IList<string> availabilityZones, long count, IList<KubernetesLabel> labels, NetworkCloudAgentPoolMode mode, string name, IList<KubernetesLabel> taints, AgentPoolUpgradeSettings upgradeSettings, string vmSkuName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AdministratorConfiguration = administratorConfiguration;
            AgentOptions = agentOptions;
            AttachedNetworkConfiguration = attachedNetworkConfiguration;
            AvailabilityZones = availabilityZones;
            Count = count;
            Labels = labels;
            Mode = mode;
            Name = name;
            Taints = taints;
            UpgradeSettings = upgradeSettings;
            VmSkuName = vmSkuName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InitialAgentPoolConfiguration"/> for deserialization. </summary>
        internal InitialAgentPoolConfiguration()
        {
        }

        /// <summary> The administrator credentials to be used for the nodes in this agent pool. </summary>
        public AdministratorConfiguration AdministratorConfiguration { get; set; }
        /// <summary> The configurations that will be applied to each agent in this agent pool. </summary>
        public NetworkCloudAgentConfiguration AgentOptions { get; set; }
        /// <summary> The configuration of networks being attached to the agent pool for use by the workloads that run on this Kubernetes cluster. </summary>
        public AttachedNetworkConfiguration AttachedNetworkConfiguration { get; set; }
        /// <summary> The list of availability zones of the Network Cloud cluster used for the provisioning of nodes in this agent pool. If not specified, all availability zones will be used. </summary>
        public IList<string> AvailabilityZones { get; }
        /// <summary> The number of virtual machines that use this configuration. </summary>
        public long Count { get; set; }
        /// <summary> The labels applied to the nodes in this agent pool. </summary>
        public IList<KubernetesLabel> Labels { get; }
        /// <summary> The selection of how this agent pool is utilized, either as a system pool or a user pool. System pools run the features and critical services for the Kubernetes Cluster, while user pools are dedicated to user workloads. Every Kubernetes cluster must contain at least one system node pool with at least one node. </summary>
        public NetworkCloudAgentPoolMode Mode { get; set; }
        /// <summary> The name that will be used for the agent pool resource representing this agent pool. </summary>
        public string Name { get; set; }
        /// <summary> The taints applied to the nodes in this agent pool. </summary>
        public IList<KubernetesLabel> Taints { get; }
        /// <summary> The configuration of the agent pool. </summary>
        internal AgentPoolUpgradeSettings UpgradeSettings { get; set; }
        /// <summary> The maximum number or percentage of nodes that are surged during upgrade. This can either be set to an integer (e.g. '5') or a percentage (e.g. '50%'). If a percentage is specified, it is the percentage of the total agent pool size at the time of the upgrade. For percentages, fractional nodes are rounded up. If not specified, the default is 1. </summary>
        public string UpgradeMaxSurge
        {
            get => UpgradeSettings is null ? default : UpgradeSettings.MaxSurge;
            set
            {
                if (UpgradeSettings is null)
                    UpgradeSettings = new AgentPoolUpgradeSettings();
                UpgradeSettings.MaxSurge = value;
            }
        }

        /// <summary> The name of the VM SKU that determines the size of resources allocated for node VMs. </summary>
        public string VmSkuName { get; set; }
    }
}
