// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the ManagedLedgerDigestUpload data model.
    /// Azure SQL Database ledger digest upload settings.
    /// </summary>
    public partial class ManagedLedgerDigestUploadData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ManagedLedgerDigestUploadData"/>. </summary>
        public ManagedLedgerDigestUploadData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedLedgerDigestUploadData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="digestStorageEndpoint"> The digest storage endpoint, which must be either an Azure blob storage endpoint or an URI for Azure Confidential Ledger. </param>
        /// <param name="state"> Specifies the state of ledger digest upload. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedLedgerDigestUploadData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string digestStorageEndpoint, ManagedLedgerDigestUploadsState? state, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            DigestStorageEndpoint = digestStorageEndpoint;
            State = state;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The digest storage endpoint, which must be either an Azure blob storage endpoint or an URI for Azure Confidential Ledger. </summary>
        public string DigestStorageEndpoint { get; set; }
        /// <summary> Specifies the state of ledger digest upload. </summary>
        public ManagedLedgerDigestUploadsState? State { get; }
    }
}
