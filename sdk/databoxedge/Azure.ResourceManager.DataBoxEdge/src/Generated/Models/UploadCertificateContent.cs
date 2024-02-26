// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The upload certificate request. </summary>
    public partial class UploadCertificateContent
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

        /// <summary> Initializes a new instance of <see cref="UploadCertificateContent"/>. </summary>
        /// <param name="certificate"> The base64 encoded certificate raw data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificate"/> is null. </exception>
        public UploadCertificateContent(string certificate)
        {
            if (certificate == null)
            {
                throw new ArgumentNullException(nameof(certificate));
            }

            Certificate = certificate;
        }

        /// <summary> Initializes a new instance of <see cref="UploadCertificateContent"/>. </summary>
        /// <param name="authenticationType"> The authentication type. </param>
        /// <param name="certificate"> The base64 encoded certificate raw data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UploadCertificateContent(DataBoxEdgeAuthenticationType? authenticationType, string certificate, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AuthenticationType = authenticationType;
            Certificate = certificate;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UploadCertificateContent"/> for deserialization. </summary>
        internal UploadCertificateContent()
        {
        }

        /// <summary> The authentication type. </summary>
        public DataBoxEdgeAuthenticationType? AuthenticationType { get; set; }
        /// <summary> The base64 encoded certificate raw data. </summary>
        public string Certificate { get; }
    }
}
