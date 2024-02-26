// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> A footnote object describing a table or figure. </summary>
    public partial class DocumentFootnote
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

        /// <summary> Initializes a new instance of <see cref="DocumentFootnote"/>. </summary>
        /// <param name="content"> Content of the footnote. </param>
        /// <param name="spans"> Location of the footnote in the reading order concatenated content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> or <paramref name="spans"/> is null. </exception>
        internal DocumentFootnote(string content, IEnumerable<DocumentSpan> spans)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }
            if (spans == null)
            {
                throw new ArgumentNullException(nameof(spans));
            }

            Content = content;
            BoundingRegions = new ChangeTrackingList<BoundingRegion>();
            Spans = spans.ToList();
            Elements = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentFootnote"/>. </summary>
        /// <param name="content"> Content of the footnote. </param>
        /// <param name="boundingRegions"> Bounding regions covering the footnote. </param>
        /// <param name="spans"> Location of the footnote in the reading order concatenated content. </param>
        /// <param name="elements"> Child elements of the footnote. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentFootnote(string content, IReadOnlyList<BoundingRegion> boundingRegions, IReadOnlyList<DocumentSpan> spans, IReadOnlyList<string> elements, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Content = content;
            BoundingRegions = boundingRegions;
            Spans = spans;
            Elements = elements;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentFootnote"/> for deserialization. </summary>
        internal DocumentFootnote()
        {
        }

        /// <summary> Content of the footnote. </summary>
        public string Content { get; }
        /// <summary> Bounding regions covering the footnote. </summary>
        public IReadOnlyList<BoundingRegion> BoundingRegions { get; }
        /// <summary> Location of the footnote in the reading order concatenated content. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
        /// <summary> Child elements of the footnote. </summary>
        public IReadOnlyList<string> Elements { get; }
    }
}
