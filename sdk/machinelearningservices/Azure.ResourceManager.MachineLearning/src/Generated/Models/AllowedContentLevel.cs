// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Level at which content is filtered. </summary>
    public readonly partial struct AllowedContentLevel : IEquatable<AllowedContentLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AllowedContentLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AllowedContentLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LowValue = "Low";
        private const string MediumValue = "Medium";
        private const string HighValue = "High";

        /// <summary> Low. </summary>
        public static AllowedContentLevel Low { get; } = new AllowedContentLevel(LowValue);
        /// <summary> Medium. </summary>
        public static AllowedContentLevel Medium { get; } = new AllowedContentLevel(MediumValue);
        /// <summary> High. </summary>
        public static AllowedContentLevel High { get; } = new AllowedContentLevel(HighValue);
        /// <summary> Determines if two <see cref="AllowedContentLevel"/> values are the same. </summary>
        public static bool operator ==(AllowedContentLevel left, AllowedContentLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AllowedContentLevel"/> values are not the same. </summary>
        public static bool operator !=(AllowedContentLevel left, AllowedContentLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AllowedContentLevel"/>. </summary>
        public static implicit operator AllowedContentLevel(string value) => new AllowedContentLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AllowedContentLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AllowedContentLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
