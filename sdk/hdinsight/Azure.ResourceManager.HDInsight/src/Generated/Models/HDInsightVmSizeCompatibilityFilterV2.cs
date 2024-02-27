// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> This class represent a single filter object that defines a multidimensional set. The dimensions of this set are Regions, ClusterFlavors, NodeTypes and ClusterVersions. The constraint should be defined based on the following: FilterMode (Exclude vs Include), VMSizes (the vm sizes in affect of exclusion/inclusion) and the ordering of the Filters. Later filters override previous settings if conflicted. </summary>
    public partial class HDInsightVmSizeCompatibilityFilterV2
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

        /// <summary> Initializes a new instance of <see cref="HDInsightVmSizeCompatibilityFilterV2"/>. </summary>
        internal HDInsightVmSizeCompatibilityFilterV2()
        {
            Regions = new ChangeTrackingList<string>();
            ClusterFlavors = new ChangeTrackingList<string>();
            NodeTypes = new ChangeTrackingList<string>();
            ClusterVersions = new ChangeTrackingList<string>();
            OSType = new ChangeTrackingList<HDInsightOSType>();
            VmSizes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightVmSizeCompatibilityFilterV2"/>. </summary>
        /// <param name="filterMode"> The filtering mode. Effectively this can enabling or disabling the VM sizes in a particular set. </param>
        /// <param name="regions"> The list of regions under the effect of the filter. </param>
        /// <param name="clusterFlavors"> The list of cluster flavors under the effect of the filter. </param>
        /// <param name="nodeTypes"> The list of node types affected by the filter. </param>
        /// <param name="clusterVersions"> The list of cluster versions affected in Major.Minor format. </param>
        /// <param name="osType"> The OSType affected, Windows or Linux. </param>
        /// <param name="vmSizes"> The list of virtual machine sizes to include or exclude. </param>
        /// <param name="espApplied"> Whether apply for ESP cluster. 'true' means only for ESP, 'false' means only for non-ESP, null or empty string or others mean for both. </param>
        /// <param name="isComputeIsolationSupported"> Whether support compute isolation. 'true' means only for ComputeIsolationEnabled, 'false' means only for regular cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightVmSizeCompatibilityFilterV2(HDInsightFilterMode? filterMode, IReadOnlyList<string> regions, IReadOnlyList<string> clusterFlavors, IReadOnlyList<string> nodeTypes, IReadOnlyList<string> clusterVersions, IReadOnlyList<HDInsightOSType> osType, IReadOnlyList<string> vmSizes, string espApplied, string isComputeIsolationSupported, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FilterMode = filterMode;
            Regions = regions;
            ClusterFlavors = clusterFlavors;
            NodeTypes = nodeTypes;
            ClusterVersions = clusterVersions;
            OSType = osType;
            VmSizes = vmSizes;
            EspApplied = espApplied;
            IsComputeIsolationSupported = isComputeIsolationSupported;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The filtering mode. Effectively this can enabling or disabling the VM sizes in a particular set. </summary>
        public HDInsightFilterMode? FilterMode { get; }
        /// <summary> The list of regions under the effect of the filter. </summary>
        public IReadOnlyList<string> Regions { get; }
        /// <summary> The list of cluster flavors under the effect of the filter. </summary>
        public IReadOnlyList<string> ClusterFlavors { get; }
        /// <summary> The list of node types affected by the filter. </summary>
        public IReadOnlyList<string> NodeTypes { get; }
        /// <summary> The list of cluster versions affected in Major.Minor format. </summary>
        public IReadOnlyList<string> ClusterVersions { get; }
        /// <summary> The OSType affected, Windows or Linux. </summary>
        public IReadOnlyList<HDInsightOSType> OSType { get; }
        /// <summary> The list of virtual machine sizes to include or exclude. </summary>
        public IReadOnlyList<string> VmSizes { get; }
        /// <summary> Whether apply for ESP cluster. 'true' means only for ESP, 'false' means only for non-ESP, null or empty string or others mean for both. </summary>
        public string EspApplied { get; }
        /// <summary> Whether support compute isolation. 'true' means only for ComputeIsolationEnabled, 'false' means only for regular cluster. </summary>
        public string IsComputeIsolationSupported { get; }
    }
}
