// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The access level allowed for the users in this key set. </summary>
    public readonly partial struct BmcKeySetPrivilegeLevel : IEquatable<BmcKeySetPrivilegeLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BmcKeySetPrivilegeLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BmcKeySetPrivilegeLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReadOnlyValue = "ReadOnly";
        private const string AdministratorValue = "Administrator";

        /// <summary> ReadOnly. </summary>
        public static BmcKeySetPrivilegeLevel ReadOnly { get; } = new BmcKeySetPrivilegeLevel(ReadOnlyValue);
        /// <summary> Administrator. </summary>
        public static BmcKeySetPrivilegeLevel Administrator { get; } = new BmcKeySetPrivilegeLevel(AdministratorValue);
        /// <summary> Determines if two <see cref="BmcKeySetPrivilegeLevel"/> values are the same. </summary>
        public static bool operator ==(BmcKeySetPrivilegeLevel left, BmcKeySetPrivilegeLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BmcKeySetPrivilegeLevel"/> values are not the same. </summary>
        public static bool operator !=(BmcKeySetPrivilegeLevel left, BmcKeySetPrivilegeLevel right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BmcKeySetPrivilegeLevel"/>. </summary>
        public static implicit operator BmcKeySetPrivilegeLevel(string value) => new BmcKeySetPrivilegeLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BmcKeySetPrivilegeLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BmcKeySetPrivilegeLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
