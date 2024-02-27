// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.LoadTesting.Models
{
    /// <summary> A domain name and connection details used to access a dependency. </summary>
    public partial class LoadTestingEndpointDependency
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

        /// <summary> Initializes a new instance of <see cref="LoadTestingEndpointDependency"/>. </summary>
        internal LoadTestingEndpointDependency()
        {
            EndpointDetails = new ChangeTrackingList<LoadTestingEndpointDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="LoadTestingEndpointDependency"/>. </summary>
        /// <param name="domainName"> The domain name of the dependency. Domain names may be fully qualified or may contain a * wildcard. </param>
        /// <param name="description"> Human-readable supplemental information about the dependency and when it is applicable. </param>
        /// <param name="endpointDetails"> The list of connection details for this endpoint. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LoadTestingEndpointDependency(string domainName, string description, IReadOnlyList<LoadTestingEndpointDetail> endpointDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DomainName = domainName;
            Description = description;
            EndpointDetails = endpointDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The domain name of the dependency. Domain names may be fully qualified or may contain a * wildcard. </summary>
        public string DomainName { get; }
        /// <summary> Human-readable supplemental information about the dependency and when it is applicable. </summary>
        public string Description { get; }
        /// <summary> The list of connection details for this endpoint. </summary>
        public IReadOnlyList<LoadTestingEndpointDetail> EndpointDetails { get; }
    }
}
