// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.AppConfiguration;

namespace Azure.ResourceManager.AppConfiguration.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableAppConfigurationResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableAppConfigurationResourceGroupResource"/> class for mocking. </summary>
        protected MockableAppConfigurationResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAppConfigurationResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAppConfigurationResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of AppConfigurationStoreResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of AppConfigurationStoreResources and their operations over a AppConfigurationStoreResource. </returns>
        public virtual AppConfigurationStoreCollection GetAppConfigurationStores()
        {
            return GetCachedClient(client => new AppConfigurationStoreCollection(client, Id));
        }

        /// <summary>
        /// Gets the properties of the specified configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationStoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AppConfigurationStoreResource>> GetAppConfigurationStoreAsync(string configStoreName, CancellationToken cancellationToken = default)
        {
            return await GetAppConfigurationStores().GetAsync(configStoreName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the properties of the specified configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationStoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AppConfigurationStoreResource> GetAppConfigurationStore(string configStoreName, CancellationToken cancellationToken = default)
        {
            return GetAppConfigurationStores().Get(configStoreName, cancellationToken);
        }
    }
}
