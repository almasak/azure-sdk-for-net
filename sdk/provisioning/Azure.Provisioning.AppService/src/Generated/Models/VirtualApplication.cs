// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Virtual application in an app.
/// </summary>
public partial class VirtualApplication : ProvisionableConstruct
{
    /// <summary>
    /// Virtual path.
    /// </summary>
    public BicepValue<string> VirtualPath 
    {
        get { Initialize(); return _virtualPath!; }
        set { Initialize(); _virtualPath!.Assign(value); }
    }
    private BicepValue<string>? _virtualPath;

    /// <summary>
    /// Physical path.
    /// </summary>
    public BicepValue<string> PhysicalPath 
    {
        get { Initialize(); return _physicalPath!; }
        set { Initialize(); _physicalPath!.Assign(value); }
    }
    private BicepValue<string>? _physicalPath;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; if preloading is enabled; otherwise,
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsPreloadEnabled 
    {
        get { Initialize(); return _isPreloadEnabled!; }
        set { Initialize(); _isPreloadEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isPreloadEnabled;

    /// <summary>
    /// Virtual directories for virtual application.
    /// </summary>
    public BicepList<VirtualDirectory> VirtualDirectories 
    {
        get { Initialize(); return _virtualDirectories!; }
        set { Initialize(); _virtualDirectories!.Assign(value); }
    }
    private BicepList<VirtualDirectory>? _virtualDirectories;

    /// <summary>
    /// Creates a new VirtualApplication.
    /// </summary>
    public VirtualApplication()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of VirtualApplication.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _virtualPath = DefineProperty<string>("VirtualPath", ["virtualPath"]);
        _physicalPath = DefineProperty<string>("PhysicalPath", ["physicalPath"]);
        _isPreloadEnabled = DefineProperty<bool>("IsPreloadEnabled", ["preloadEnabled"]);
        _virtualDirectories = DefineListProperty<VirtualDirectory>("VirtualDirectories", ["virtualDirectories"]);
    }
}
