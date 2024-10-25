// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// The ContainerRegistryKeyVaultProperties.
/// </summary>
public partial class ContainerRegistryKeyVaultProperties : ProvisionableConstruct
{
    /// <summary>
    /// Key vault uri to access the encryption key.
    /// </summary>
    public BicepValue<string> KeyIdentifier { get => _keyIdentifier; set => _keyIdentifier.Assign(value); }
    private readonly BicepValue<string> _keyIdentifier;

    /// <summary>
    /// The fully qualified key identifier that includes the version of the key
    /// that is actually used for encryption.
    /// </summary>
    public BicepValue<string> VersionedKeyIdentifier { get => _versionedKeyIdentifier; }
    private readonly BicepValue<string> _versionedKeyIdentifier;

    /// <summary>
    /// The client id of the identity which will be used to access key vault.
    /// </summary>
    public BicepValue<string> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<string> _identity;

    /// <summary>
    /// Auto key rotation status for a CMK enabled registry.
    /// </summary>
    public BicepValue<bool> IsKeyRotationEnabled { get => _isKeyRotationEnabled; }
    private readonly BicepValue<bool> _isKeyRotationEnabled;

    /// <summary>
    /// Timestamp of the last successful key rotation.
    /// </summary>
    public BicepValue<DateTimeOffset> LastKeyRotationTimestamp { get => _lastKeyRotationTimestamp; }
    private readonly BicepValue<DateTimeOffset> _lastKeyRotationTimestamp;

    /// <summary>
    /// Creates a new ContainerRegistryKeyVaultProperties.
    /// </summary>
    public ContainerRegistryKeyVaultProperties()
    {
        _keyIdentifier = BicepValue<string>.DefineProperty(this, "KeyIdentifier", ["keyIdentifier"]);
        _versionedKeyIdentifier = BicepValue<string>.DefineProperty(this, "VersionedKeyIdentifier", ["versionedKeyIdentifier"], isOutput: true);
        _identity = BicepValue<string>.DefineProperty(this, "Identity", ["identity"]);
        _isKeyRotationEnabled = BicepValue<bool>.DefineProperty(this, "IsKeyRotationEnabled", ["keyRotationEnabled"], isOutput: true);
        _lastKeyRotationTimestamp = BicepValue<DateTimeOffset>.DefineProperty(this, "LastKeyRotationTimestamp", ["lastKeyRotationTimestamp"], isOutput: true);
    }
}
