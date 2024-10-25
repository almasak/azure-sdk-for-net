// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Configuration properties that define the mutable settings of a Container
/// App SourceControl.
/// </summary>
public partial class ContainerAppGitHubActionConfiguration : ProvisionableConstruct
{
    /// <summary>
    /// Registry configurations.
    /// </summary>
    public BicepValue<ContainerAppRegistryInfo> RegistryInfo { get => _registryInfo; set => _registryInfo.Assign(value); }
    private readonly BicepValue<ContainerAppRegistryInfo> _registryInfo;

    /// <summary>
    /// AzureCredentials configurations.
    /// </summary>
    public BicepValue<ContainerAppCredentials> AzureCredentials { get => _azureCredentials; set => _azureCredentials.Assign(value); }
    private readonly BicepValue<ContainerAppCredentials> _azureCredentials;

    /// <summary>
    /// Context path.
    /// </summary>
    public BicepValue<string> ContextPath { get => _contextPath; set => _contextPath.Assign(value); }
    private readonly BicepValue<string> _contextPath;

    /// <summary>
    /// One time Github PAT to configure github environment.
    /// </summary>
    public BicepValue<string> GitHubPersonalAccessToken { get => _gitHubPersonalAccessToken; set => _gitHubPersonalAccessToken.Assign(value); }
    private readonly BicepValue<string> _gitHubPersonalAccessToken;

    /// <summary>
    /// Image name.
    /// </summary>
    public BicepValue<string> Image { get => _image; set => _image.Assign(value); }
    private readonly BicepValue<string> _image;

    /// <summary>
    /// Code or Image.
    /// </summary>
    public BicepValue<string> PublishType { get => _publishType; set => _publishType.Assign(value); }
    private readonly BicepValue<string> _publishType;

    /// <summary>
    /// Operation system.
    /// </summary>
    public BicepValue<string> OS { get => _oS; set => _oS.Assign(value); }
    private readonly BicepValue<string> _oS;

    /// <summary>
    /// Runtime stack.
    /// </summary>
    public BicepValue<string> RuntimeStack { get => _runtimeStack; set => _runtimeStack.Assign(value); }
    private readonly BicepValue<string> _runtimeStack;

    /// <summary>
    /// Runtime version.
    /// </summary>
    public BicepValue<string> RuntimeVersion { get => _runtimeVersion; set => _runtimeVersion.Assign(value); }
    private readonly BicepValue<string> _runtimeVersion;

    /// <summary>
    /// Creates a new ContainerAppGitHubActionConfiguration.
    /// </summary>
    public ContainerAppGitHubActionConfiguration()
    {
        _registryInfo = BicepValue<ContainerAppRegistryInfo>.DefineProperty(this, "RegistryInfo", ["registryInfo"]);
        _azureCredentials = BicepValue<ContainerAppCredentials>.DefineProperty(this, "AzureCredentials", ["azureCredentials"]);
        _contextPath = BicepValue<string>.DefineProperty(this, "ContextPath", ["contextPath"]);
        _gitHubPersonalAccessToken = BicepValue<string>.DefineProperty(this, "GitHubPersonalAccessToken", ["githubPersonalAccessToken"]);
        _image = BicepValue<string>.DefineProperty(this, "Image", ["image"]);
        _publishType = BicepValue<string>.DefineProperty(this, "PublishType", ["publishType"]);
        _oS = BicepValue<string>.DefineProperty(this, "OS", ["os"]);
        _runtimeStack = BicepValue<string>.DefineProperty(this, "RuntimeStack", ["runtimeStack"]);
        _runtimeVersion = BicepValue<string>.DefineProperty(this, "RuntimeVersion", ["runtimeVersion"]);
    }
}
