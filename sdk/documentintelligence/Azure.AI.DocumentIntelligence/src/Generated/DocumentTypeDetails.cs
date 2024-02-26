// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Document type info. </summary>
    public partial class DocumentTypeDetails
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

        /// <summary> Initializes a new instance of <see cref="DocumentTypeDetails"/>. </summary>
        /// <param name="fieldSchema"> Description of the document semantic schema using a JSON Schema style syntax. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fieldSchema"/> is null. </exception>
        internal DocumentTypeDetails(IReadOnlyDictionary<string, DocumentFieldSchema> fieldSchema)
        {
            if (fieldSchema == null)
            {
                throw new ArgumentNullException(nameof(fieldSchema));
            }

            FieldSchema = fieldSchema;
            FieldConfidence = new ChangeTrackingDictionary<string, float>();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentTypeDetails"/>. </summary>
        /// <param name="description"> Document model description. </param>
        /// <param name="buildMode"> Custom document model build mode. </param>
        /// <param name="fieldSchema"> Description of the document semantic schema using a JSON Schema style syntax. </param>
        /// <param name="fieldConfidence"> Estimated confidence for each field. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentTypeDetails(string description, DocumentBuildMode? buildMode, IReadOnlyDictionary<string, DocumentFieldSchema> fieldSchema, IReadOnlyDictionary<string, float> fieldConfidence, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            BuildMode = buildMode;
            FieldSchema = fieldSchema;
            FieldConfidence = fieldConfidence;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentTypeDetails"/> for deserialization. </summary>
        internal DocumentTypeDetails()
        {
        }

        /// <summary> Document model description. </summary>
        public string Description { get; }
        /// <summary> Custom document model build mode. </summary>
        public DocumentBuildMode? BuildMode { get; }
        /// <summary> Description of the document semantic schema using a JSON Schema style syntax. </summary>
        public IReadOnlyDictionary<string, DocumentFieldSchema> FieldSchema { get; }
        /// <summary> Estimated confidence for each field. </summary>
        public IReadOnlyDictionary<string, float> FieldConfidence { get; }
    }
}
