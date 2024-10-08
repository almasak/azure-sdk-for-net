// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Gets the plan status. </summary>
    public readonly partial struct PrivateStorePlanStatus : IEquatable<PrivateStorePlanStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PrivateStorePlanStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PrivateStorePlanStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string RejectedValue = "Rejected";
        private const string ApprovedValue = "Approved";
        private const string NoneValue = "None";

        /// <summary> Pending. </summary>
        public static PrivateStorePlanStatus Pending { get; } = new PrivateStorePlanStatus(PendingValue);
        /// <summary> Rejected. </summary>
        public static PrivateStorePlanStatus Rejected { get; } = new PrivateStorePlanStatus(RejectedValue);
        /// <summary> Approved. </summary>
        public static PrivateStorePlanStatus Approved { get; } = new PrivateStorePlanStatus(ApprovedValue);
        /// <summary> None. </summary>
        public static PrivateStorePlanStatus None { get; } = new PrivateStorePlanStatus(NoneValue);
        /// <summary> Determines if two <see cref="PrivateStorePlanStatus"/> values are the same. </summary>
        public static bool operator ==(PrivateStorePlanStatus left, PrivateStorePlanStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PrivateStorePlanStatus"/> values are not the same. </summary>
        public static bool operator !=(PrivateStorePlanStatus left, PrivateStorePlanStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PrivateStorePlanStatus"/>. </summary>
        public static implicit operator PrivateStorePlanStatus(string value) => new PrivateStorePlanStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PrivateStorePlanStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PrivateStorePlanStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
