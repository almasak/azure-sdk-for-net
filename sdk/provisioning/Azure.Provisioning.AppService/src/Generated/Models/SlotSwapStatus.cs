// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// The status of the last successful slot swap operation.
/// </summary>
public partial class SlotSwapStatus : ProvisionableConstruct
{
    /// <summary>
    /// The time the last successful slot swap completed.
    /// </summary>
    public BicepValue<DateTimeOffset> TimestampUtc { get => _timestampUtc; }
    private readonly BicepValue<DateTimeOffset> _timestampUtc;

    /// <summary>
    /// The source slot of the last swap operation.
    /// </summary>
    public BicepValue<string> SourceSlotName { get => _sourceSlotName; }
    private readonly BicepValue<string> _sourceSlotName;

    /// <summary>
    /// The destination slot of the last swap operation.
    /// </summary>
    public BicepValue<string> DestinationSlotName { get => _destinationSlotName; }
    private readonly BicepValue<string> _destinationSlotName;

    /// <summary>
    /// Creates a new SlotSwapStatus.
    /// </summary>
    public SlotSwapStatus()
    {
        _timestampUtc = BicepValue<DateTimeOffset>.DefineProperty(this, "TimestampUtc", ["timestampUtc"], isOutput: true);
        _sourceSlotName = BicepValue<string>.DefineProperty(this, "SourceSlotName", ["sourceSlotName"], isOutput: true);
        _destinationSlotName = BicepValue<string>.DefineProperty(this, "DestinationSlotName", ["destinationSlotName"], isOutput: true);
    }
}
