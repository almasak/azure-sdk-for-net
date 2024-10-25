// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary>
    /// Result of the post subvolume and action is to get metadata of the subvolume.
    /// Serialized Name: SubvolumeModel
    /// </summary>
    public partial class NetAppSubvolumeMetadata : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="NetAppSubvolumeMetadata"/>. </summary>
        internal NetAppSubvolumeMetadata()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetAppSubvolumeMetadata"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="path">
        /// Path to the subvolume
        /// Serialized Name: SubvolumeModel.properties.path
        /// </param>
        /// <param name="parentPath">
        /// Path to the parent subvolume
        /// Serialized Name: SubvolumeModel.properties.parentPath
        /// </param>
        /// <param name="size">
        /// Size of subvolume
        /// Serialized Name: SubvolumeModel.properties.size
        /// </param>
        /// <param name="bytesUsed">
        /// Bytes used
        /// Serialized Name: SubvolumeModel.properties.bytesUsed
        /// </param>
        /// <param name="permissions">
        /// Permissions of the subvolume
        /// Serialized Name: SubvolumeModel.properties.permissions
        /// </param>
        /// <param name="createdOn">
        /// Creation time and date
        /// Serialized Name: SubvolumeModel.properties.creationTimeStamp
        /// </param>
        /// <param name="accessedOn">
        /// Most recent access time and date
        /// Serialized Name: SubvolumeModel.properties.accessedTimeStamp
        /// </param>
        /// <param name="modifiedOn">
        /// Most recent modification time and date
        /// Serialized Name: SubvolumeModel.properties.modifiedTimeStamp
        /// </param>
        /// <param name="changedOn">
        /// Most recent change time and date
        /// Serialized Name: SubvolumeModel.properties.changedTimeStamp
        /// </param>
        /// <param name="provisioningState">
        /// Azure lifecycle management
        /// Serialized Name: SubvolumeModel.properties.provisioningState
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppSubvolumeMetadata(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string path, string parentPath, long? size, long? bytesUsed, string permissions, DateTimeOffset? createdOn, DateTimeOffset? accessedOn, DateTimeOffset? modifiedOn, DateTimeOffset? changedOn, string provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Path = path;
            ParentPath = parentPath;
            Size = size;
            BytesUsed = bytesUsed;
            Permissions = permissions;
            CreatedOn = createdOn;
            AccessedOn = accessedOn;
            ModifiedOn = modifiedOn;
            ChangedOn = changedOn;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Path to the subvolume
        /// Serialized Name: SubvolumeModel.properties.path
        /// </summary>
        public string Path { get; }
        /// <summary>
        /// Path to the parent subvolume
        /// Serialized Name: SubvolumeModel.properties.parentPath
        /// </summary>
        public string ParentPath { get; }
        /// <summary>
        /// Size of subvolume
        /// Serialized Name: SubvolumeModel.properties.size
        /// </summary>
        public long? Size { get; }
        /// <summary>
        /// Bytes used
        /// Serialized Name: SubvolumeModel.properties.bytesUsed
        /// </summary>
        public long? BytesUsed { get; }
        /// <summary>
        /// Permissions of the subvolume
        /// Serialized Name: SubvolumeModel.properties.permissions
        /// </summary>
        public string Permissions { get; }
        /// <summary>
        /// Creation time and date
        /// Serialized Name: SubvolumeModel.properties.creationTimeStamp
        /// </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary>
        /// Most recent access time and date
        /// Serialized Name: SubvolumeModel.properties.accessedTimeStamp
        /// </summary>
        public DateTimeOffset? AccessedOn { get; }
        /// <summary>
        /// Most recent modification time and date
        /// Serialized Name: SubvolumeModel.properties.modifiedTimeStamp
        /// </summary>
        public DateTimeOffset? ModifiedOn { get; }
        /// <summary>
        /// Most recent change time and date
        /// Serialized Name: SubvolumeModel.properties.changedTimeStamp
        /// </summary>
        public DateTimeOffset? ChangedOn { get; }
        /// <summary>
        /// Azure lifecycle management
        /// Serialized Name: SubvolumeModel.properties.provisioningState
        /// </summary>
        public string ProvisioningState { get; }
    }
}
