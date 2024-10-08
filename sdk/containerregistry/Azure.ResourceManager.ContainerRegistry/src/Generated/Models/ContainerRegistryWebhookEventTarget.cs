// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The target of the event. </summary>
    public partial class ContainerRegistryWebhookEventTarget
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

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryWebhookEventTarget"/>. </summary>
        internal ContainerRegistryWebhookEventTarget()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryWebhookEventTarget"/>. </summary>
        /// <param name="mediaType"> The MIME type of the referenced object. </param>
        /// <param name="size"> The number of bytes of the content. Same as Length field. </param>
        /// <param name="digest"> The digest of the content, as defined by the Registry V2 HTTP API Specification. </param>
        /// <param name="length"> The number of bytes of the content. Same as Size field. </param>
        /// <param name="repository"> The repository name. </param>
        /// <param name="uri"> The direct URL to the content. </param>
        /// <param name="tag"> The tag name. </param>
        /// <param name="name"> The name of the artifact. </param>
        /// <param name="version"> The version of the artifact. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryWebhookEventTarget(string mediaType, long? size, string digest, long? length, string repository, Uri uri, string tag, string name, string version, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MediaType = mediaType;
            Size = size;
            Digest = digest;
            Length = length;
            Repository = repository;
            Uri = uri;
            Tag = tag;
            Name = name;
            Version = version;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The MIME type of the referenced object. </summary>
        [WirePath("mediaType")]
        public string MediaType { get; }
        /// <summary> The number of bytes of the content. Same as Length field. </summary>
        [WirePath("size")]
        public long? Size { get; }
        /// <summary> The digest of the content, as defined by the Registry V2 HTTP API Specification. </summary>
        [WirePath("digest")]
        public string Digest { get; }
        /// <summary> The number of bytes of the content. Same as Size field. </summary>
        [WirePath("length")]
        public long? Length { get; }
        /// <summary> The repository name. </summary>
        [WirePath("repository")]
        public string Repository { get; }
        /// <summary> The direct URL to the content. </summary>
        [WirePath("url")]
        public Uri Uri { get; }
        /// <summary> The tag name. </summary>
        [WirePath("tag")]
        public string Tag { get; }
        /// <summary> The name of the artifact. </summary>
        [WirePath("name")]
        public string Name { get; }
        /// <summary> The version of the artifact. </summary>
        [WirePath("version")]
        public string Version { get; }
    }
}
