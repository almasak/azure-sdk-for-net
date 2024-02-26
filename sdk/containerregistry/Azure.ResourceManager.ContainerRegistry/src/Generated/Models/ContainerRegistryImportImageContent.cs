// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The ContainerRegistryImportImageContent. </summary>
    public partial class ContainerRegistryImportImageContent
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

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryImportImageContent"/>. </summary>
        /// <param name="source"> The source of the image. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> is null. </exception>
        public ContainerRegistryImportImageContent(ContainerRegistryImportSource source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            Source = source;
            TargetTags = new ChangeTrackingList<string>();
            UntaggedTargetRepositories = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryImportImageContent"/>. </summary>
        /// <param name="source"> The source of the image. </param>
        /// <param name="targetTags"> List of strings of the form repo[:tag]. When tag is omitted the source will be used (or 'latest' if source tag is also omitted). </param>
        /// <param name="untaggedTargetRepositories"> List of strings of repository names to do a manifest only copy. No tag will be created. </param>
        /// <param name="mode"> When Force, any existing target tags will be overwritten. When NoForce, any existing target tags will fail the operation before any copying begins. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryImportImageContent(ContainerRegistryImportSource source, IList<string> targetTags, IList<string> untaggedTargetRepositories, ContainerRegistryImportMode? mode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Source = source;
            TargetTags = targetTags;
            UntaggedTargetRepositories = untaggedTargetRepositories;
            Mode = mode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryImportImageContent"/> for deserialization. </summary>
        internal ContainerRegistryImportImageContent()
        {
        }

        /// <summary> The source of the image. </summary>
        public ContainerRegistryImportSource Source { get; }
        /// <summary> List of strings of the form repo[:tag]. When tag is omitted the source will be used (or 'latest' if source tag is also omitted). </summary>
        public IList<string> TargetTags { get; }
        /// <summary> List of strings of repository names to do a manifest only copy. No tag will be created. </summary>
        public IList<string> UntaggedTargetRepositories { get; }
        /// <summary> When Force, any existing target tags will be overwritten. When NoForce, any existing target tags will fail the operation before any copying begins. </summary>
        public ContainerRegistryImportMode? Mode { get; set; }
    }
}
