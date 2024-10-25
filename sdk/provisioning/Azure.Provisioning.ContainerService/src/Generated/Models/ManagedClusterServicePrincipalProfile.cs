// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Information about a service principal identity for the cluster to use for
/// manipulating Azure APIs.
/// </summary>
public partial class ManagedClusterServicePrincipalProfile : ProvisionableConstruct
{
    /// <summary>
    /// The ID for the service principal.
    /// </summary>
    public BicepValue<string> ClientId { get => _clientId; set => _clientId.Assign(value); }
    private readonly BicepValue<string> _clientId;

    /// <summary>
    /// The secret password associated with the service principal in plain text.
    /// </summary>
    public BicepValue<string> Secret { get => _secret; set => _secret.Assign(value); }
    private readonly BicepValue<string> _secret;

    /// <summary>
    /// Creates a new ManagedClusterServicePrincipalProfile.
    /// </summary>
    public ManagedClusterServicePrincipalProfile()
    {
        _clientId = BicepValue<string>.DefineProperty(this, "ClientId", ["clientId"]);
        _secret = BicepValue<string>.DefineProperty(this, "Secret", ["secret"]);
    }
}
