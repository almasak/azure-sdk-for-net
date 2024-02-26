// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create or update configuration operation. </summary>
    public partial class DscConfigurationCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="DscConfigurationCreateOrUpdateContent"/>. </summary>
        /// <param name="source"> Gets or sets the source. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> is null. </exception>
        public DscConfigurationCreateOrUpdateContent(AutomationContentSource source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            Tags = new ChangeTrackingDictionary<string, string>();
            Source = source;
            Parameters = new ChangeTrackingDictionary<string, DscConfigurationParameterDefinition>();
        }

        /// <summary> Initializes a new instance of <see cref="DscConfigurationCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> Gets or sets name of the resource. </param>
        /// <param name="location"> Gets or sets the location of the resource. </param>
        /// <param name="tags"> Gets or sets the tags attached to the resource. </param>
        /// <param name="isLogVerboseEnabled"> Gets or sets verbose log option. </param>
        /// <param name="isLogProgressEnabled"> Gets or sets progress log option. </param>
        /// <param name="source"> Gets or sets the source. </param>
        /// <param name="parameters"> Gets or sets the configuration parameters. </param>
        /// <param name="description"> Gets or sets the description of the configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DscConfigurationCreateOrUpdateContent(string name, AzureLocation? location, IDictionary<string, string> tags, bool? isLogVerboseEnabled, bool? isLogProgressEnabled, AutomationContentSource source, IDictionary<string, DscConfigurationParameterDefinition> parameters, string description, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Location = location;
            Tags = tags;
            IsLogVerboseEnabled = isLogVerboseEnabled;
            IsLogProgressEnabled = isLogProgressEnabled;
            Source = source;
            Parameters = parameters;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DscConfigurationCreateOrUpdateContent"/> for deserialization. </summary>
        internal DscConfigurationCreateOrUpdateContent()
        {
        }

        /// <summary> Gets or sets name of the resource. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the location of the resource. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Gets or sets the tags attached to the resource. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets verbose log option. </summary>
        public bool? IsLogVerboseEnabled { get; set; }
        /// <summary> Gets or sets progress log option. </summary>
        public bool? IsLogProgressEnabled { get; set; }
        /// <summary> Gets or sets the source. </summary>
        public AutomationContentSource Source { get; }
        /// <summary> Gets or sets the configuration parameters. </summary>
        public IDictionary<string, DscConfigurationParameterDefinition> Parameters { get; }
        /// <summary> Gets or sets the description of the configuration. </summary>
        public string Description { get; set; }
    }
}
