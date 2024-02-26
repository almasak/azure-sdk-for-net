// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> BareMetalMachineRunCommandParameters represents the body of the request to execute a script on the bare metal machine. </summary>
    public partial class BareMetalMachineRunCommandContent
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

        /// <summary> Initializes a new instance of <see cref="BareMetalMachineRunCommandContent"/>. </summary>
        /// <param name="limitTimeSeconds">
        /// The maximum time the script is allowed to run.
        /// If the execution time exceeds the maximum, the script will be stopped, any output produced until then will be captured, and the exit code matching a timeout will be returned (252).
        /// </param>
        /// <param name="script"> The base64 encoded script to execute on the bare metal machine. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="script"/> is null. </exception>
        public BareMetalMachineRunCommandContent(long limitTimeSeconds, string script)
        {
            if (script == null)
            {
                throw new ArgumentNullException(nameof(script));
            }

            Arguments = new ChangeTrackingList<string>();
            LimitTimeSeconds = limitTimeSeconds;
            Script = script;
        }

        /// <summary> Initializes a new instance of <see cref="BareMetalMachineRunCommandContent"/>. </summary>
        /// <param name="arguments"> The list of string arguments that will be passed to the script in order as separate arguments. </param>
        /// <param name="limitTimeSeconds">
        /// The maximum time the script is allowed to run.
        /// If the execution time exceeds the maximum, the script will be stopped, any output produced until then will be captured, and the exit code matching a timeout will be returned (252).
        /// </param>
        /// <param name="script"> The base64 encoded script to execute on the bare metal machine. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BareMetalMachineRunCommandContent(IList<string> arguments, long limitTimeSeconds, string script, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Arguments = arguments;
            LimitTimeSeconds = limitTimeSeconds;
            Script = script;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BareMetalMachineRunCommandContent"/> for deserialization. </summary>
        internal BareMetalMachineRunCommandContent()
        {
        }

        /// <summary> The list of string arguments that will be passed to the script in order as separate arguments. </summary>
        public IList<string> Arguments { get; }
        /// <summary>
        /// The maximum time the script is allowed to run.
        /// If the execution time exceeds the maximum, the script will be stopped, any output produced until then will be captured, and the exit code matching a timeout will be returned (252).
        /// </summary>
        public long LimitTimeSeconds { get; }
        /// <summary> The base64 encoded script to execute on the bare metal machine. </summary>
        public string Script { get; }
    }
}
