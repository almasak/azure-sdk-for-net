// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Status of the shared private link resource. Valid values are Pending, Approved, Rejected or Disconnected. </summary>
    public readonly partial struct SearchServiceSharedPrivateLinkResourceStatus : IEquatable<SearchServiceSharedPrivateLinkResourceStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SearchServiceSharedPrivateLinkResourceStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SearchServiceSharedPrivateLinkResourceStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> The shared private link resource has been created and is pending approval. </summary>
        public static SearchServiceSharedPrivateLinkResourceStatus Pending { get; } = new SearchServiceSharedPrivateLinkResourceStatus(PendingValue);
        /// <summary> The shared private link resource is approved and is ready for use. </summary>
        public static SearchServiceSharedPrivateLinkResourceStatus Approved { get; } = new SearchServiceSharedPrivateLinkResourceStatus(ApprovedValue);
        /// <summary> The shared private link resource has been rejected and cannot be used. </summary>
        public static SearchServiceSharedPrivateLinkResourceStatus Rejected { get; } = new SearchServiceSharedPrivateLinkResourceStatus(RejectedValue);
        /// <summary> The shared private link resource has been removed from the service. </summary>
        public static SearchServiceSharedPrivateLinkResourceStatus Disconnected { get; } = new SearchServiceSharedPrivateLinkResourceStatus(DisconnectedValue);
        /// <summary> Determines if two <see cref="SearchServiceSharedPrivateLinkResourceStatus"/> values are the same. </summary>
        public static bool operator ==(SearchServiceSharedPrivateLinkResourceStatus left, SearchServiceSharedPrivateLinkResourceStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SearchServiceSharedPrivateLinkResourceStatus"/> values are not the same. </summary>
        public static bool operator !=(SearchServiceSharedPrivateLinkResourceStatus left, SearchServiceSharedPrivateLinkResourceStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SearchServiceSharedPrivateLinkResourceStatus"/>. </summary>
        public static implicit operator SearchServiceSharedPrivateLinkResourceStatus(string value) => new SearchServiceSharedPrivateLinkResourceStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SearchServiceSharedPrivateLinkResourceStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SearchServiceSharedPrivateLinkResourceStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
