// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A single file or multiple files to be downloaded to a compute node.
    /// </summary>
    public partial class ResourceFile
    {
        /// <summary>
        /// Initializes a new instance of the ResourceFile class.
        /// </summary>
        public ResourceFile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceFile class.
        /// </summary>
        /// <param name="autoStorageContainerName">The storage container name
        /// in the auto storage account.</param>
        /// <param name="storageContainerUrl">The URL of the blob container
        /// within Azure Blob Storage.</param>
        /// <param name="httpUrl">The URL of the file to download.</param>
        /// <param name="blobPrefix">The blob prefix to use when downloading
        /// blobs from an Azure Storage container. Only the blobs whose names
        /// begin with the specified prefix will be downloaded.</param>
        /// <param name="filePath">The location on the compute node to which to
        /// download the file, relative to the task's working
        /// directory.</param>
        /// <param name="fileMode">The file permission mode attribute in octal
        /// format.</param>
        /// <param name="identityReference">The reference to the user assigned
        /// identity to use to access Azure Blob Storage specified by
        /// storageContainerUrl or httpUrl</param>
        public ResourceFile(string autoStorageContainerName = default(string), string storageContainerUrl = default(string), string httpUrl = default(string), string blobPrefix = default(string), string filePath = default(string), string fileMode = default(string), ComputeNodeIdentityReference identityReference = default(ComputeNodeIdentityReference))
        {
            AutoStorageContainerName = autoStorageContainerName;
            StorageContainerUrl = storageContainerUrl;
            HttpUrl = httpUrl;
            BlobPrefix = blobPrefix;
            FilePath = filePath;
            FileMode = fileMode;
            IdentityReference = identityReference;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the storage container name in the auto storage
        /// account.
        /// </summary>
        /// <remarks>
        /// The autoStorageContainerName, storageContainerUrl and httpUrl
        /// properties are mutually exclusive and one of them must be
        /// specified.
        /// </remarks>
        [JsonProperty(PropertyName = "autoStorageContainerName")]
        public string AutoStorageContainerName { get; set; }

        /// <summary>
        /// Gets or sets the URL of the blob container within Azure Blob
        /// Storage.
        /// </summary>
        /// <remarks>
        /// The autoStorageContainerName, storageContainerUrl and httpUrl
        /// properties are mutually exclusive and one of them must be
        /// specified. This URL must be readable and listable from compute
        /// nodes. There are three ways to get such a URL for a container in
        /// Azure storage: include a Shared Access Signature (SAS) granting
        /// read and list permissions on the container, use a managed identity
        /// with read and list permissions, or set the ACL for the container to
        /// allow public access.
        /// </remarks>
        [JsonProperty(PropertyName = "storageContainerUrl")]
        public string StorageContainerUrl { get; set; }

        /// <summary>
        /// Gets or sets the URL of the file to download.
        /// </summary>
        /// <remarks>
        /// The autoStorageContainerName, storageContainerUrl and httpUrl
        /// properties are mutually exclusive and one of them must be
        /// specified. If the URL points to Azure Blob Storage, it must be
        /// readable from compute nodes. There are three ways to get such a URL
        /// for a blob in Azure storage: include a Shared Access Signature
        /// (SAS) granting read permissions on the blob, use a managed identity
        /// with read permission, or set the ACL for the blob or its container
        /// to allow public access.
        /// </remarks>
        [JsonProperty(PropertyName = "httpUrl")]
        public string HttpUrl { get; set; }

        /// <summary>
        /// Gets or sets the blob prefix to use when downloading blobs from an
        /// Azure Storage container. Only the blobs whose names begin with the
        /// specified prefix will be downloaded.
        /// </summary>
        /// <remarks>
        /// The property is valid only when autoStorageContainerName or
        /// storageContainerUrl is used. This prefix can be a partial filename
        /// or a subdirectory. If a prefix is not specified, all the files in
        /// the container will be downloaded.
        /// </remarks>
        [JsonProperty(PropertyName = "blobPrefix")]
        public string BlobPrefix { get; set; }

        /// <summary>
        /// Gets or sets the location on the compute node to which to download
        /// the file, relative to the task's working directory.
        /// </summary>
        /// <remarks>
        /// If the httpUrl property is specified, the filePath is required and
        /// describes the path which the file will be downloaded to, including
        /// the filename. Otherwise, if the autoStorageContainerName or
        /// storageContainerUrl property is specified, filePath is optional and
        /// is the directory to download the files to. In the case where
        /// filePath is used as a directory, any directory structure already
        /// associated with the input data will be retained in full and
        /// appended to the specified filePath directory. The specified
        /// relative path cannot break out of the task's working directory (for
        /// example by using '..').
        /// </remarks>
        [JsonProperty(PropertyName = "filePath")]
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the file permission mode attribute in octal format.
        /// </summary>
        /// <remarks>
        /// This property applies only to files being downloaded to Linux
        /// compute nodes. It will be ignored if it is specified for a
        /// resourceFile which will be downloaded to a Windows node. If this
        /// property is not specified for a Linux node, then a default value of
        /// 0770 is applied to the file.
        /// </remarks>
        [JsonProperty(PropertyName = "fileMode")]
        public string FileMode { get; set; }

        /// <summary>
        /// Gets or sets the reference to the user assigned identity to use to
        /// access Azure Blob Storage specified by storageContainerUrl or
        /// httpUrl
        /// </summary>
        [JsonProperty(PropertyName = "identityReference")]
        public ComputeNodeIdentityReference IdentityReference { get; set; }

    }
}
