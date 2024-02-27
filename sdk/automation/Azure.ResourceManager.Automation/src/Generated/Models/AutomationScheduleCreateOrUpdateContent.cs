// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create or update schedule operation. </summary>
    public partial class AutomationScheduleCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="AutomationScheduleCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> Gets or sets the name of the Schedule. </param>
        /// <param name="startOn"> Gets or sets the start time of the schedule. </param>
        /// <param name="frequency"> Gets or sets the frequency of the schedule. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public AutomationScheduleCreateOrUpdateContent(string name, DateTimeOffset startOn, AutomationScheduleFrequency frequency)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            StartOn = startOn;
            Frequency = frequency;
        }

        /// <summary> Initializes a new instance of <see cref="AutomationScheduleCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> Gets or sets the name of the Schedule. </param>
        /// <param name="description"> Gets or sets the description of the schedule. </param>
        /// <param name="startOn"> Gets or sets the start time of the schedule. </param>
        /// <param name="expireOn"> Gets or sets the end time of the schedule. </param>
        /// <param name="interval"> Gets or sets the interval of the schedule. </param>
        /// <param name="frequency"> Gets or sets the frequency of the schedule. </param>
        /// <param name="timeZone"> Gets or sets the time zone of the schedule. </param>
        /// <param name="advancedSchedule"> Gets or sets the AdvancedSchedule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationScheduleCreateOrUpdateContent(string name, string description, DateTimeOffset startOn, DateTimeOffset? expireOn, BinaryData interval, AutomationScheduleFrequency frequency, string timeZone, AutomationAdvancedSchedule advancedSchedule, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Description = description;
            StartOn = startOn;
            ExpireOn = expireOn;
            Interval = interval;
            Frequency = frequency;
            TimeZone = timeZone;
            AdvancedSchedule = advancedSchedule;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AutomationScheduleCreateOrUpdateContent"/> for deserialization. </summary>
        internal AutomationScheduleCreateOrUpdateContent()
        {
        }

        /// <summary> Gets or sets the name of the Schedule. </summary>
        public string Name { get; }
        /// <summary> Gets or sets the description of the schedule. </summary>
        public string Description { get; set; }
        /// <summary> Gets or sets the start time of the schedule. </summary>
        public DateTimeOffset StartOn { get; }
        /// <summary> Gets or sets the end time of the schedule. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary>
        /// Gets or sets the interval of the schedule.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData Interval { get; set; }
        /// <summary> Gets or sets the frequency of the schedule. </summary>
        public AutomationScheduleFrequency Frequency { get; }
        /// <summary> Gets or sets the time zone of the schedule. </summary>
        public string TimeZone { get; set; }
        /// <summary> Gets or sets the AdvancedSchedule. </summary>
        public AutomationAdvancedSchedule AdvancedSchedule { get; set; }
    }
}
