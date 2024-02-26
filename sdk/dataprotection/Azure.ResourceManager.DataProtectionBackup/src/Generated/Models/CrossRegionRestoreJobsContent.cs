// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Details of Backup Vault for which CRR Jobs are to be fetched. </summary>
    public partial class CrossRegionRestoreJobsContent
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

        /// <summary> Initializes a new instance of <see cref="CrossRegionRestoreJobsContent"/>. </summary>
        /// <param name="sourceRegion"></param>
        /// <param name="sourceBackupVaultId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceBackupVaultId"/> is null. </exception>
        public CrossRegionRestoreJobsContent(AzureLocation sourceRegion, ResourceIdentifier sourceBackupVaultId)
        {
            if (sourceBackupVaultId == null)
            {
                throw new ArgumentNullException(nameof(sourceBackupVaultId));
            }

            SourceRegion = sourceRegion;
            SourceBackupVaultId = sourceBackupVaultId;
        }

        /// <summary> Initializes a new instance of <see cref="CrossRegionRestoreJobsContent"/>. </summary>
        /// <param name="sourceRegion"></param>
        /// <param name="sourceBackupVaultId"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CrossRegionRestoreJobsContent(AzureLocation sourceRegion, ResourceIdentifier sourceBackupVaultId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceRegion = sourceRegion;
            SourceBackupVaultId = sourceBackupVaultId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CrossRegionRestoreJobsContent"/> for deserialization. </summary>
        internal CrossRegionRestoreJobsContent()
        {
        }

        /// <summary> Gets the source region. </summary>
        public AzureLocation SourceRegion { get; }
        /// <summary> Gets the source backup vault id. </summary>
        public ResourceIdentifier SourceBackupVaultId { get; }
    }
}
