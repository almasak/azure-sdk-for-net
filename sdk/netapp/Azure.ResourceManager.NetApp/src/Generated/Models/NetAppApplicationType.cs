// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary>
    /// Application Type
    /// Serialized Name: ApplicationType
    /// </summary>
    public readonly partial struct NetAppApplicationType : IEquatable<NetAppApplicationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetAppApplicationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetAppApplicationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SapHanaValue = "SAP-HANA";
        private const string OracleValue = "ORACLE";

        /// <summary>
        /// SAP-HANA
        /// Serialized Name: ApplicationType.SAP-HANA
        /// </summary>
        public static NetAppApplicationType SapHana { get; } = new NetAppApplicationType(SapHanaValue);
        /// <summary>
        /// ORACLE
        /// Serialized Name: ApplicationType.ORACLE
        /// </summary>
        public static NetAppApplicationType Oracle { get; } = new NetAppApplicationType(OracleValue);
        /// <summary> Determines if two <see cref="NetAppApplicationType"/> values are the same. </summary>
        public static bool operator ==(NetAppApplicationType left, NetAppApplicationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetAppApplicationType"/> values are not the same. </summary>
        public static bool operator !=(NetAppApplicationType left, NetAppApplicationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetAppApplicationType"/>. </summary>
        public static implicit operator NetAppApplicationType(string value) => new NetAppApplicationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetAppApplicationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetAppApplicationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
