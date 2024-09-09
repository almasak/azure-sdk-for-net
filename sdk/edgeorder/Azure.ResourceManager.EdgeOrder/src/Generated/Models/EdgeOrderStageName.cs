// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Stage name. </summary>
    public readonly partial struct EdgeOrderStageName : IEquatable<EdgeOrderStageName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EdgeOrderStageName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EdgeOrderStageName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PlacedValue = "Placed";
        private const string InReviewValue = "InReview";
        private const string ConfirmedValue = "Confirmed";
        private const string ReadyToShipValue = "ReadyToShip";
        private const string ShippedValue = "Shipped";
        private const string DeliveredValue = "Delivered";
        private const string ReadyToSetupValue = "ReadyToSetup";
        private const string InUseValue = "InUse";
        private const string ReturnInitiatedValue = "ReturnInitiated";
        private const string ReturnPickedUpValue = "ReturnPickedUp";
        private const string ReturnedToMicrosoftValue = "ReturnedToMicrosoft";
        private const string ReturnCompletedValue = "ReturnCompleted";
        private const string CancelledValue = "Cancelled";

        /// <summary> Currently in draft mode and can still be cancelled. </summary>
        public static EdgeOrderStageName Placed { get; } = new EdgeOrderStageName(PlacedValue);
        /// <summary> Order is currently in draft mode and can still be cancelled. </summary>
        public static EdgeOrderStageName InReview { get; } = new EdgeOrderStageName(InReviewValue);
        /// <summary> Order is confirmed. </summary>
        public static EdgeOrderStageName Confirmed { get; } = new EdgeOrderStageName(ConfirmedValue);
        /// <summary> Order is ready to ship. </summary>
        public static EdgeOrderStageName ReadyToShip { get; } = new EdgeOrderStageName(ReadyToShipValue);
        /// <summary> Order is in transit to customer. </summary>
        public static EdgeOrderStageName Shipped { get; } = new EdgeOrderStageName(ShippedValue);
        /// <summary> Order is delivered to customer. </summary>
        public static EdgeOrderStageName Delivered { get; } = new EdgeOrderStageName(DeliveredValue);
        /// <summary> Order is ready to get cloud connected. </summary>
        public static EdgeOrderStageName ReadyToSetup { get; } = new EdgeOrderStageName(ReadyToSetupValue);
        /// <summary> Order is in use at customer site. </summary>
        public static EdgeOrderStageName InUse { get; } = new EdgeOrderStageName(InUseValue);
        /// <summary> Return has been initiated by customer. </summary>
        public static EdgeOrderStageName ReturnInitiated { get; } = new EdgeOrderStageName(ReturnInitiatedValue);
        /// <summary> Order is in transit from customer to Microsoft. </summary>
        public static EdgeOrderStageName ReturnPickedUp { get; } = new EdgeOrderStageName(ReturnPickedUpValue);
        /// <summary> Order has been received back to Microsoft. </summary>
        public static EdgeOrderStageName ReturnedToMicrosoft { get; } = new EdgeOrderStageName(ReturnedToMicrosoftValue);
        /// <summary> Return has now completed. </summary>
        public static EdgeOrderStageName ReturnCompleted { get; } = new EdgeOrderStageName(ReturnCompletedValue);
        /// <summary> Order has been cancelled. </summary>
        public static EdgeOrderStageName Cancelled { get; } = new EdgeOrderStageName(CancelledValue);
        /// <summary> Determines if two <see cref="EdgeOrderStageName"/> values are the same. </summary>
        public static bool operator ==(EdgeOrderStageName left, EdgeOrderStageName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EdgeOrderStageName"/> values are not the same. </summary>
        public static bool operator !=(EdgeOrderStageName left, EdgeOrderStageName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EdgeOrderStageName"/>. </summary>
        public static implicit operator EdgeOrderStageName(string value) => new EdgeOrderStageName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EdgeOrderStageName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EdgeOrderStageName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
