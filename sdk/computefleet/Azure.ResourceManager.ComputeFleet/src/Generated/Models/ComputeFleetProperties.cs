// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary> Details of the Compute Fleet. </summary>
    public partial class ComputeFleetProperties
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

        /// <summary> Initializes a new instance of <see cref="ComputeFleetProperties"/>. </summary>
        /// <param name="vmSizesProfile"> List of VM sizes supported for Compute Fleet. </param>
        /// <param name="computeProfile"> Compute Profile to use for running user's workloads. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmSizesProfile"/> or <paramref name="computeProfile"/> is null. </exception>
        public ComputeFleetProperties(IEnumerable<ComputeFleetVmSizeProfile> vmSizesProfile, ComputeFleetComputeProfile computeProfile)
        {
            Argument.AssertNotNull(vmSizesProfile, nameof(vmSizesProfile));
            Argument.AssertNotNull(computeProfile, nameof(computeProfile));

            VmSizesProfile = vmSizesProfile.ToList();
            ComputeProfile = computeProfile;
        }

        /// <summary> Initializes a new instance of <see cref="ComputeFleetProperties"/>. </summary>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="spotPriorityProfile"> Configuration Options for Spot instances in Compute Fleet. </param>
        /// <param name="regularPriorityProfile"> Configuration Options for Regular instances in Compute Fleet. </param>
        /// <param name="vmSizesProfile"> List of VM sizes supported for Compute Fleet. </param>
        /// <param name="vmAttributes"> Attribute based Fleet. </param>
        /// <param name="additionalLocationsProfile"> Represents the configuration for additional locations where Fleet resources may be deployed. </param>
        /// <param name="computeProfile"> Compute Profile to use for running user's workloads. </param>
        /// <param name="createdOn"> Specifies the time at which the Compute Fleet is created. </param>
        /// <param name="uniqueId"> Specifies the ID which uniquely identifies a Compute Fleet. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComputeFleetProperties(ComputeFleetProvisioningState? provisioningState, SpotPriorityProfile spotPriorityProfile, RegularPriorityProfile regularPriorityProfile, IList<ComputeFleetVmSizeProfile> vmSizesProfile, ComputeFleetVmAttributes vmAttributes, AdditionalLocationsProfile additionalLocationsProfile, ComputeFleetComputeProfile computeProfile, DateTimeOffset? createdOn, string uniqueId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            SpotPriorityProfile = spotPriorityProfile;
            RegularPriorityProfile = regularPriorityProfile;
            VmSizesProfile = vmSizesProfile;
            VmAttributes = vmAttributes;
            AdditionalLocationsProfile = additionalLocationsProfile;
            ComputeProfile = computeProfile;
            CreatedOn = createdOn;
            UniqueId = uniqueId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ComputeFleetProperties"/> for deserialization. </summary>
        internal ComputeFleetProperties()
        {
        }

        /// <summary> The status of the last operation. </summary>
        public ComputeFleetProvisioningState? ProvisioningState { get; }
        /// <summary> Configuration Options for Spot instances in Compute Fleet. </summary>
        public SpotPriorityProfile SpotPriorityProfile { get; set; }
        /// <summary> Configuration Options for Regular instances in Compute Fleet. </summary>
        public RegularPriorityProfile RegularPriorityProfile { get; set; }
        /// <summary> List of VM sizes supported for Compute Fleet. </summary>
        public IList<ComputeFleetVmSizeProfile> VmSizesProfile { get; }
        /// <summary> Attribute based Fleet. </summary>
        public ComputeFleetVmAttributes VmAttributes { get; set; }
        /// <summary> Represents the configuration for additional locations where Fleet resources may be deployed. </summary>
        internal AdditionalLocationsProfile AdditionalLocationsProfile { get; set; }
        /// <summary> The list of location profiles. </summary>
        public IList<LocationProfile> AdditionalLocationsLocationProfiles
        {
            get => AdditionalLocationsProfile is null ? default : AdditionalLocationsProfile.LocationProfiles;
            set => AdditionalLocationsProfile = new AdditionalLocationsProfile(value);
        }

        /// <summary> Compute Profile to use for running user's workloads. </summary>
        public ComputeFleetComputeProfile ComputeProfile { get; set; }
        /// <summary> Specifies the time at which the Compute Fleet is created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Specifies the ID which uniquely identifies a Compute Fleet. </summary>
        public string UniqueId { get; }
    }
}
