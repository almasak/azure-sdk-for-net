// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties of the source code repository. </summary>
    public partial class SourceCodeRepoProperties
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

        /// <summary> Initializes a new instance of <see cref="SourceCodeRepoProperties"/>. </summary>
        /// <param name="sourceControlType"> The type of source control service. </param>
        /// <param name="repositoryUri"> The full URL to the source code repository. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="repositoryUri"/> is null. </exception>
        public SourceCodeRepoProperties(SourceControlType sourceControlType, Uri repositoryUri)
        {
            if (repositoryUri == null)
            {
                throw new ArgumentNullException(nameof(repositoryUri));
            }

            SourceControlType = sourceControlType;
            RepositoryUri = repositoryUri;
        }

        /// <summary> Initializes a new instance of <see cref="SourceCodeRepoProperties"/>. </summary>
        /// <param name="sourceControlType"> The type of source control service. </param>
        /// <param name="repositoryUri"> The full URL to the source code repository. </param>
        /// <param name="branch"> The branch name of the source code. </param>
        /// <param name="sourceControlAuthProperties">
        /// The authorization properties for accessing the source code repository and to set up
        /// webhooks for notifications.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SourceCodeRepoProperties(SourceControlType sourceControlType, Uri repositoryUri, string branch, SourceCodeRepoAuthInfo sourceControlAuthProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceControlType = sourceControlType;
            RepositoryUri = repositoryUri;
            Branch = branch;
            SourceControlAuthProperties = sourceControlAuthProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SourceCodeRepoProperties"/> for deserialization. </summary>
        internal SourceCodeRepoProperties()
        {
        }

        /// <summary> The type of source control service. </summary>
        public SourceControlType SourceControlType { get; set; }
        /// <summary> The full URL to the source code repository. </summary>
        public Uri RepositoryUri { get; set; }
        /// <summary> The branch name of the source code. </summary>
        public string Branch { get; set; }
        /// <summary>
        /// The authorization properties for accessing the source code repository and to set up
        /// webhooks for notifications.
        /// </summary>
        public SourceCodeRepoAuthInfo SourceControlAuthProperties { get; set; }
    }
}
