// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Storage;

/// <summary>
/// An access key for the storage account.
/// </summary>
public partial class StorageAccountKey : ProvisionableConstruct
{
    /// <summary>
    /// Name of the key.
    /// </summary>
    public BicepValue<string> KeyName { get => _keyName; }
    private readonly BicepValue<string> _keyName;

    /// <summary>
    /// Base 64-encoded value of the key.
    /// </summary>
    public BicepValue<string> Value { get => _value; }
    private readonly BicepValue<string> _value;

    /// <summary>
    /// Permissions for the key -- read-only or full permissions.
    /// </summary>
    public BicepValue<StorageAccountKeyPermission> Permissions { get => _permissions; }
    private readonly BicepValue<StorageAccountKeyPermission> _permissions;

    /// <summary>
    /// Creation time of the key, in round trip date format.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn { get => _createdOn; }
    private readonly BicepValue<DateTimeOffset> _createdOn;

    /// <summary>
    /// Creates a new StorageAccountKey.
    /// </summary>
    public StorageAccountKey()
    {
        _keyName = BicepValue<string>.DefineProperty(this, "KeyName", ["keyName"], isOutput: true);
        _value = BicepValue<string>.DefineProperty(this, "Value", ["value"], isOutput: true, isSecure: true);
        _permissions = BicepValue<StorageAccountKeyPermission>.DefineProperty(this, "Permissions", ["permissions"], isOutput: true);
        _createdOn = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedOn", ["creationTime"], isOutput: true);
    }

    /// <summary>
    /// Creates a new StorageAccountKey resource from a Bicep expression that
    /// evaluates to a StorageAccountKey.
    /// </summary>
    /// <param name="expression">
    /// A Bicep expression that evaluates to a StorageAccountKey resource.
    /// </param>
    /// <returns>A StorageAccountKey resource.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static StorageAccountKey FromExpression(BicepExpression expression)
    {
        StorageAccountKey resource = new();
        resource.OverrideWithExpression(expression);
        return resource;
    }
}
