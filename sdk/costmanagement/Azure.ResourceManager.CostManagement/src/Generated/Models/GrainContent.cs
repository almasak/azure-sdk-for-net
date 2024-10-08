// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The GrainContent. </summary>
    public readonly partial struct GrainContent : IEquatable<GrainContent>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GrainContent"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GrainContent(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HourlyValue = "Hourly";
        private const string DailyValue = "Daily";
        private const string MonthlyValue = "Monthly";

        /// <summary> Hourly grain corresponds to value per hour. </summary>
        public static GrainContent Hourly { get; } = new GrainContent(HourlyValue);
        /// <summary> Hourly grain corresponds to value per day. </summary>
        public static GrainContent Daily { get; } = new GrainContent(DailyValue);
        /// <summary> Hourly grain corresponds to value per month. </summary>
        public static GrainContent Monthly { get; } = new GrainContent(MonthlyValue);
        /// <summary> Determines if two <see cref="GrainContent"/> values are the same. </summary>
        public static bool operator ==(GrainContent left, GrainContent right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GrainContent"/> values are not the same. </summary>
        public static bool operator !=(GrainContent left, GrainContent right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="GrainContent"/>. </summary>
        public static implicit operator GrainContent(string value) => new GrainContent(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GrainContent other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GrainContent other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
