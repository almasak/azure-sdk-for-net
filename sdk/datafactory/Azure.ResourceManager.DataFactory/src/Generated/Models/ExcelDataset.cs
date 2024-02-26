// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Excel dataset. </summary>
    public partial class ExcelDataset : DataFactoryDatasetProperties
    {
        /// <summary> Initializes a new instance of <see cref="ExcelDataset"/>. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public ExcelDataset(DataFactoryLinkedServiceReference linkedServiceName) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            DatasetType = "Excel";
        }

        /// <summary> Initializes a new instance of <see cref="ExcelDataset"/>. </summary>
        /// <param name="datasetType"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="dataLocation">
        /// The location of the excel storage.
        /// Please note <see cref="DatasetLocation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonS3CompatibleLocation"/>, <see cref="AmazonS3Location"/>, <see cref="AzureBlobFSLocation"/>, <see cref="AzureBlobStorageLocation"/>, <see cref="AzureDataLakeStoreLocation"/>, <see cref="AzureFileStorageLocation"/>, <see cref="FileServerLocation"/>, <see cref="FtpServerLocation"/>, <see cref="GoogleCloudStorageLocation"/>, <see cref="HdfsLocation"/>, <see cref="HttpServerLocation"/>, <see cref="LakeHouseLocation"/>, <see cref="OracleCloudStorageLocation"/> and <see cref="SftpLocation"/>.
        /// </param>
        /// <param name="sheetName"> The sheet name of excel file. Type: string (or Expression with resultType string). </param>
        /// <param name="sheetIndex"> The sheet index of excel file and default value is 0. Type: integer (or Expression with resultType integer). </param>
        /// <param name="range"> The partial data of one sheet. Type: string (or Expression with resultType string). </param>
        /// <param name="firstRowAsHeader"> When used as input, treat the first row of data as headers. When used as output,write the headers into the output as the first row of data. The default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="compression"> The data compression method used for the json dataset. </param>
        /// <param name="nullValue"> The null value string. Type: string (or Expression with resultType string). </param>
        internal ExcelDataset(string datasetType, string description, DataFactoryElement<IList<DatasetDataElement>> structure, DataFactoryElement<IList<DatasetSchemaDataElement>> schema, DataFactoryLinkedServiceReference linkedServiceName, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, DatasetFolder folder, IDictionary<string, BinaryData> additionalProperties, DatasetLocation dataLocation, DataFactoryElement<string> sheetName, DataFactoryElement<int> sheetIndex, DataFactoryElement<string> range, DataFactoryElement<bool> firstRowAsHeader, DatasetCompression compression, DataFactoryElement<string> nullValue) : base(datasetType, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            DataLocation = dataLocation;
            SheetName = sheetName;
            SheetIndex = sheetIndex;
            Range = range;
            FirstRowAsHeader = firstRowAsHeader;
            Compression = compression;
            NullValue = nullValue;
            DatasetType = datasetType ?? "Excel";
        }

        /// <summary> Initializes a new instance of <see cref="ExcelDataset"/> for deserialization. </summary>
        internal ExcelDataset()
        {
        }

        /// <summary>
        /// The location of the excel storage.
        /// Please note <see cref="DatasetLocation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonS3CompatibleLocation"/>, <see cref="AmazonS3Location"/>, <see cref="AzureBlobFSLocation"/>, <see cref="AzureBlobStorageLocation"/>, <see cref="AzureDataLakeStoreLocation"/>, <see cref="AzureFileStorageLocation"/>, <see cref="FileServerLocation"/>, <see cref="FtpServerLocation"/>, <see cref="GoogleCloudStorageLocation"/>, <see cref="HdfsLocation"/>, <see cref="HttpServerLocation"/>, <see cref="LakeHouseLocation"/>, <see cref="OracleCloudStorageLocation"/> and <see cref="SftpLocation"/>.
        /// </summary>
        public DatasetLocation DataLocation { get; set; }
        /// <summary> The sheet name of excel file. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SheetName { get; set; }
        /// <summary> The sheet index of excel file and default value is 0. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> SheetIndex { get; set; }
        /// <summary> The partial data of one sheet. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Range { get; set; }
        /// <summary> When used as input, treat the first row of data as headers. When used as output,write the headers into the output as the first row of data. The default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> FirstRowAsHeader { get; set; }
        /// <summary> The data compression method used for the json dataset. </summary>
        public DatasetCompression Compression { get; set; }
        /// <summary> The null value string. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> NullValue { get; set; }
    }
}
