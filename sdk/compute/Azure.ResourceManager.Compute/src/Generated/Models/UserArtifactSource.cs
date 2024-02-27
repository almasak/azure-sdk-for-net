// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The source image from which the Image Version is going to be created. </summary>
    public partial class UserArtifactSource
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

        /// <summary> Initializes a new instance of <see cref="UserArtifactSource"/>. </summary>
        /// <param name="mediaLink"> Required. The mediaLink of the artifact, must be a readable storage page blob. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mediaLink"/> is null. </exception>
        public UserArtifactSource(string mediaLink)
        {
            if (mediaLink == null)
            {
                throw new ArgumentNullException(nameof(mediaLink));
            }

            MediaLink = mediaLink;
        }

        /// <summary> Initializes a new instance of <see cref="UserArtifactSource"/>. </summary>
        /// <param name="mediaLink"> Required. The mediaLink of the artifact, must be a readable storage page blob. </param>
        /// <param name="defaultConfigurationLink"> Optional. The defaultConfigurationLink of the artifact, must be a readable storage page blob. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UserArtifactSource(string mediaLink, string defaultConfigurationLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MediaLink = mediaLink;
            DefaultConfigurationLink = defaultConfigurationLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UserArtifactSource"/> for deserialization. </summary>
        internal UserArtifactSource()
        {
        }

        /// <summary> Required. The mediaLink of the artifact, must be a readable storage page blob. </summary>
        public string MediaLink { get; set; }
        /// <summary> Optional. The defaultConfigurationLink of the artifact, must be a readable storage page blob. </summary>
        public string DefaultConfigurationLink { get; set; }
    }
}
