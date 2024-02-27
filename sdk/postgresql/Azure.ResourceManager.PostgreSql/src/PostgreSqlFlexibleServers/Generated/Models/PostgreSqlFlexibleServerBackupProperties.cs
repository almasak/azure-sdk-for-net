// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Backup properties of a server. </summary>
    public partial class PostgreSqlFlexibleServerBackupProperties
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

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerBackupProperties"/>. </summary>
        public PostgreSqlFlexibleServerBackupProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerBackupProperties"/>. </summary>
        /// <param name="backupRetentionDays"> Backup retention days for the server. </param>
        /// <param name="geoRedundantBackup"> A value indicating whether Geo-Redundant backup is enabled on the server. </param>
        /// <param name="earliestRestoreOn"> The earliest restore point time (ISO8601 format) for server. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlFlexibleServerBackupProperties(int? backupRetentionDays, PostgreSqlFlexibleServerGeoRedundantBackupEnum? geoRedundantBackup, DateTimeOffset? earliestRestoreOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BackupRetentionDays = backupRetentionDays;
            GeoRedundantBackup = geoRedundantBackup;
            EarliestRestoreOn = earliestRestoreOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Backup retention days for the server. </summary>
        public int? BackupRetentionDays { get; set; }
        /// <summary> A value indicating whether Geo-Redundant backup is enabled on the server. </summary>
        public PostgreSqlFlexibleServerGeoRedundantBackupEnum? GeoRedundantBackup { get; set; }
        /// <summary> The earliest restore point time (ISO8601 format) for server. </summary>
        public DateTimeOffset? EarliestRestoreOn { get; }
    }
}
