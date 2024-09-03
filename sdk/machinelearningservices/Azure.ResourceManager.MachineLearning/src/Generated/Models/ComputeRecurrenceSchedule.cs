// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The ComputeRecurrenceSchedule. </summary>
    public partial class ComputeRecurrenceSchedule
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

        /// <summary> Initializes a new instance of <see cref="ComputeRecurrenceSchedule"/>. </summary>
        /// <param name="hours"> [Required] List of hours for the schedule. </param>
        /// <param name="minutes"> [Required] List of minutes for the schedule. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hours"/> or <paramref name="minutes"/> is null. </exception>
        public ComputeRecurrenceSchedule(IEnumerable<int> hours, IEnumerable<int> minutes)
        {
            Argument.AssertNotNull(hours, nameof(hours));
            Argument.AssertNotNull(minutes, nameof(minutes));

            Hours = hours.ToList();
            Minutes = minutes.ToList();
            MonthDays = new ChangeTrackingList<int>();
            WeekDays = new ChangeTrackingList<ComputeWeekDay>();
        }

        /// <summary> Initializes a new instance of <see cref="ComputeRecurrenceSchedule"/>. </summary>
        /// <param name="hours"> [Required] List of hours for the schedule. </param>
        /// <param name="minutes"> [Required] List of minutes for the schedule. </param>
        /// <param name="monthDays"> List of month days for the schedule. </param>
        /// <param name="weekDays"> List of days for the schedule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComputeRecurrenceSchedule(IList<int> hours, IList<int> minutes, IList<int> monthDays, IList<ComputeWeekDay> weekDays, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Hours = hours;
            Minutes = minutes;
            MonthDays = monthDays;
            WeekDays = weekDays;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ComputeRecurrenceSchedule"/> for deserialization. </summary>
        internal ComputeRecurrenceSchedule()
        {
        }

        /// <summary> [Required] List of hours for the schedule. </summary>
        public IList<int> Hours { get; }
        /// <summary> [Required] List of minutes for the schedule. </summary>
        public IList<int> Minutes { get; }
        /// <summary> List of month days for the schedule. </summary>
        public IList<int> MonthDays { get; set; }
        /// <summary> List of days for the schedule. </summary>
        public IList<ComputeWeekDay> WeekDays { get; set; }
    }
}
