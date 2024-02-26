// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Monitoring input data base definition.
    /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
    /// </summary>
    public abstract partial class MonitoringInputDataBase
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MonitoringInputDataBase"/>. </summary>
        /// <param name="jobInputType"> [Required] Specifies the type of job. </param>
        /// <param name="uri"> [Required] Input Asset URI. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        protected MonitoringInputDataBase(JobInputType jobInputType, Uri uri)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            Columns = new ChangeTrackingDictionary<string, string>();
            JobInputType = jobInputType;
            Uri = uri;
        }

        /// <summary> Initializes a new instance of <see cref="MonitoringInputDataBase"/>. </summary>
        /// <param name="columns"> Mapping of column names to special uses. </param>
        /// <param name="dataContext"> The context metadata of the data source. </param>
        /// <param name="inputDataType"> [Required] Specifies the type of signal to monitor. </param>
        /// <param name="jobInputType"> [Required] Specifies the type of job. </param>
        /// <param name="uri"> [Required] Input Asset URI. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitoringInputDataBase(IDictionary<string, string> columns, string dataContext, MonitoringInputDataType inputDataType, JobInputType jobInputType, Uri uri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Columns = columns;
            DataContext = dataContext;
            InputDataType = inputDataType;
            JobInputType = jobInputType;
            Uri = uri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MonitoringInputDataBase"/> for deserialization. </summary>
        internal MonitoringInputDataBase()
        {
        }

        /// <summary> Mapping of column names to special uses. </summary>
        public IDictionary<string, string> Columns { get; set; }
        /// <summary> The context metadata of the data source. </summary>
        public string DataContext { get; set; }
        /// <summary> [Required] Specifies the type of signal to monitor. </summary>
        internal MonitoringInputDataType InputDataType { get; set; }
        /// <summary> [Required] Specifies the type of job. </summary>
        public JobInputType JobInputType { get; set; }
        /// <summary> [Required] Input Asset URI. </summary>
        public Uri Uri { get; set; }
    }
}
