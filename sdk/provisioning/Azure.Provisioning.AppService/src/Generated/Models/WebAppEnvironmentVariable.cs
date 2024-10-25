// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// The WebAppEnvironmentVariable.
/// </summary>
public partial class WebAppEnvironmentVariable : ProvisionableConstruct
{
    /// <summary>
    /// Environment variable name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Environment variable value.
    /// </summary>
    public BicepValue<string> Value { get => _value; set => _value.Assign(value); }
    private readonly BicepValue<string> _value;

    /// <summary>
    /// Creates a new WebAppEnvironmentVariable.
    /// </summary>
    public WebAppEnvironmentVariable()
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"]);
        _value = BicepValue<string>.DefineProperty(this, "Value", ["value"]);
    }
}
