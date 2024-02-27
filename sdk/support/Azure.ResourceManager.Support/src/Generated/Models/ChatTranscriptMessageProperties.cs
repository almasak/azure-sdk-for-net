// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> Describes the properties of a Message Details resource. </summary>
    public partial class ChatTranscriptMessageProperties
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

        /// <summary> Initializes a new instance of <see cref="ChatTranscriptMessageProperties"/>. </summary>
        /// <param name="body"> Body of the communication. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public ChatTranscriptMessageProperties(string body)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            Body = body;
        }

        /// <summary> Initializes a new instance of <see cref="ChatTranscriptMessageProperties"/>. </summary>
        /// <param name="contentType"> Content type. </param>
        /// <param name="communicationDirection"> Direction of communication. </param>
        /// <param name="sender"> Name of the sender. </param>
        /// <param name="body"> Body of the communication. </param>
        /// <param name="createdOn"> Time in UTC (ISO 8601 format) when the communication was created. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChatTranscriptMessageProperties(TranscriptContentType? contentType, SupportTicketCommunicationDirection? communicationDirection, string sender, string body, DateTimeOffset? createdOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ContentType = contentType;
            CommunicationDirection = communicationDirection;
            Sender = sender;
            Body = body;
            CreatedOn = createdOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ChatTranscriptMessageProperties"/> for deserialization. </summary>
        internal ChatTranscriptMessageProperties()
        {
        }

        /// <summary> Content type. </summary>
        public TranscriptContentType? ContentType { get; }
        /// <summary> Direction of communication. </summary>
        public SupportTicketCommunicationDirection? CommunicationDirection { get; }
        /// <summary> Name of the sender. </summary>
        public string Sender { get; set; }
        /// <summary> Body of the communication. </summary>
        public string Body { get; set; }
        /// <summary> Time in UTC (ISO 8601 format) when the communication was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
    }
}
