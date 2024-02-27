// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DataLakeAnalytics.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataLakeAnalytics
{
    /// <summary>
    /// A Class representing a DataLakeAnalyticsAccount along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DataLakeAnalyticsAccountResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDataLakeAnalyticsAccountResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource"/> using the GetDataLakeAnalyticsAccount method.
    /// </summary>
    public partial class DataLakeAnalyticsAccountResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataLakeAnalyticsAccountResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="accountName"> The accountName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataLakeAnalyticsAccountAccountsClientDiagnostics;
        private readonly AccountsRestOperations _dataLakeAnalyticsAccountAccountsRestClient;
        private readonly DataLakeAnalyticsAccountData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataLakeAnalytics/accounts";

        /// <summary> Initializes a new instance of the <see cref="DataLakeAnalyticsAccountResource"/> class for mocking. </summary>
        protected DataLakeAnalyticsAccountResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataLakeAnalyticsAccountResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataLakeAnalyticsAccountResource(ArmClient client, DataLakeAnalyticsAccountData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataLakeAnalyticsAccountResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataLakeAnalyticsAccountResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataLakeAnalyticsAccountAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataLakeAnalytics", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dataLakeAnalyticsAccountAccountsApiVersion);
            _dataLakeAnalyticsAccountAccountsRestClient = new AccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataLakeAnalyticsAccountAccountsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataLakeAnalyticsAccountData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of DataLakeStoreAccountInformationResources in the DataLakeAnalyticsAccount. </summary>
        /// <returns> An object representing collection of DataLakeStoreAccountInformationResources and their operations over a DataLakeStoreAccountInformationResource. </returns>
        public virtual DataLakeStoreAccountInformationCollection GetAllDataLakeStoreAccountInformation()
        {
            return GetCachedClient(client => new DataLakeStoreAccountInformationCollection(client, Id));
        }

        /// <summary>
        /// Gets the specified Data Lake Store account details in the specified Data Lake Analytics account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/dataLakeStoreAccounts/{dataLakeStoreAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataLakeStoreAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeStoreAccountInformationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataLakeStoreAccountName"> The name of the Data Lake Store account to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataLakeStoreAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="dataLakeStoreAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DataLakeStoreAccountInformationResource>> GetDataLakeStoreAccountInformationAsync(string dataLakeStoreAccountName, CancellationToken cancellationToken = default)
        {
            return await GetAllDataLakeStoreAccountInformation().GetAsync(dataLakeStoreAccountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Data Lake Store account details in the specified Data Lake Analytics account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/dataLakeStoreAccounts/{dataLakeStoreAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataLakeStoreAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeStoreAccountInformationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataLakeStoreAccountName"> The name of the Data Lake Store account to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataLakeStoreAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="dataLakeStoreAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DataLakeStoreAccountInformationResource> GetDataLakeStoreAccountInformation(string dataLakeStoreAccountName, CancellationToken cancellationToken = default)
        {
            return GetAllDataLakeStoreAccountInformation().Get(dataLakeStoreAccountName, cancellationToken);
        }

        /// <summary> Gets a collection of DataLakeAnalyticsStorageAccountInformationResources in the DataLakeAnalyticsAccount. </summary>
        /// <returns> An object representing collection of DataLakeAnalyticsStorageAccountInformationResources and their operations over a DataLakeAnalyticsStorageAccountInformationResource. </returns>
        public virtual DataLakeAnalyticsStorageAccountInformationCollection GetAllDataLakeAnalyticsStorageAccountInformation()
        {
            return GetCachedClient(client => new DataLakeAnalyticsStorageAccountInformationCollection(client, Id));
        }

        /// <summary>
        /// Gets the specified Azure Storage account linked to the given Data Lake Analytics account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeAnalyticsStorageAccountInformationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageAccountName"> The name of the Azure Storage account for which to retrieve the details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DataLakeAnalyticsStorageAccountInformationResource>> GetDataLakeAnalyticsStorageAccountInformationAsync(string storageAccountName, CancellationToken cancellationToken = default)
        {
            return await GetAllDataLakeAnalyticsStorageAccountInformation().GetAsync(storageAccountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Azure Storage account linked to the given Data Lake Analytics account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeAnalyticsStorageAccountInformationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageAccountName"> The name of the Azure Storage account for which to retrieve the details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="storageAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DataLakeAnalyticsStorageAccountInformationResource> GetDataLakeAnalyticsStorageAccountInformation(string storageAccountName, CancellationToken cancellationToken = default)
        {
            return GetAllDataLakeAnalyticsStorageAccountInformation().Get(storageAccountName, cancellationToken);
        }

        /// <summary> Gets a collection of DataLakeAnalyticsComputePolicyResources in the DataLakeAnalyticsAccount. </summary>
        /// <returns> An object representing collection of DataLakeAnalyticsComputePolicyResources and their operations over a DataLakeAnalyticsComputePolicyResource. </returns>
        public virtual DataLakeAnalyticsComputePolicyCollection GetDataLakeAnalyticsComputePolicies()
        {
            return GetCachedClient(client => new DataLakeAnalyticsComputePolicyCollection(client, Id));
        }

        /// <summary>
        /// Gets the specified Data Lake Analytics compute policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComputePolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeAnalyticsComputePolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="computePolicyName"> The name of the compute policy to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="computePolicyName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="computePolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DataLakeAnalyticsComputePolicyResource>> GetDataLakeAnalyticsComputePolicyAsync(string computePolicyName, CancellationToken cancellationToken = default)
        {
            return await GetDataLakeAnalyticsComputePolicies().GetAsync(computePolicyName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Data Lake Analytics compute policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/computePolicies/{computePolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComputePolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeAnalyticsComputePolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="computePolicyName"> The name of the compute policy to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="computePolicyName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="computePolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DataLakeAnalyticsComputePolicyResource> GetDataLakeAnalyticsComputePolicy(string computePolicyName, CancellationToken cancellationToken = default)
        {
            return GetDataLakeAnalyticsComputePolicies().Get(computePolicyName, cancellationToken);
        }

        /// <summary> Gets a collection of DataLakeAnalyticsFirewallRuleResources in the DataLakeAnalyticsAccount. </summary>
        /// <returns> An object representing collection of DataLakeAnalyticsFirewallRuleResources and their operations over a DataLakeAnalyticsFirewallRuleResource. </returns>
        public virtual DataLakeAnalyticsFirewallRuleCollection GetDataLakeAnalyticsFirewallRules()
        {
            return GetCachedClient(client => new DataLakeAnalyticsFirewallRuleCollection(client, Id));
        }

        /// <summary>
        /// Gets the specified Data Lake Analytics firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeAnalyticsFirewallRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DataLakeAnalyticsFirewallRuleResource>> GetDataLakeAnalyticsFirewallRuleAsync(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            return await GetDataLakeAnalyticsFirewallRules().GetAsync(firewallRuleName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Data Lake Analytics firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeAnalyticsFirewallRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DataLakeAnalyticsFirewallRuleResource> GetDataLakeAnalyticsFirewallRule(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            return GetDataLakeAnalyticsFirewallRules().Get(firewallRuleName, cancellationToken);
        }

        /// <summary>
        /// Gets details of the specified Data Lake Analytics account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeAnalyticsAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataLakeAnalyticsAccountResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataLakeAnalyticsAccountAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsAccountResource.Get");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsAccountAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeAnalyticsAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details of the specified Data Lake Analytics account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeAnalyticsAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataLakeAnalyticsAccountResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dataLakeAnalyticsAccountAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsAccountResource.Get");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsAccountAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeAnalyticsAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Begins the delete process for the Data Lake Analytics account object specified by the account name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeAnalyticsAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataLakeAnalyticsAccountAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsAccountResource.Delete");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsAccountAccountsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DataLakeAnalyticsArmOperation(_dataLakeAnalyticsAccountAccountsClientDiagnostics, Pipeline, _dataLakeAnalyticsAccountAccountsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Begins the delete process for the Data Lake Analytics account object specified by the account name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeAnalyticsAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataLakeAnalyticsAccountAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsAccountResource.Delete");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsAccountAccountsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new DataLakeAnalyticsArmOperation(_dataLakeAnalyticsAccountAccountsClientDiagnostics, Pipeline, _dataLakeAnalyticsAccountAccountsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the Data Lake Analytics account object specified by the accountName with the contents of the account object.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeAnalyticsAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Parameters supplied to the update Data Lake Analytics account operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<DataLakeAnalyticsAccountResource>> UpdateAsync(WaitUntil waitUntil, DataLakeAnalyticsAccountPatch patch, CancellationToken cancellationToken = default)
        {
            if (patch == null)
            {
                throw new ArgumentNullException(nameof(patch));
            }

            using var scope = _dataLakeAnalyticsAccountAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsAccountResource.Update");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsAccountAccountsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new DataLakeAnalyticsArmOperation<DataLakeAnalyticsAccountResource>(new DataLakeAnalyticsAccountOperationSource(Client), _dataLakeAnalyticsAccountAccountsClientDiagnostics, Pipeline, _dataLakeAnalyticsAccountAccountsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the Data Lake Analytics account object specified by the accountName with the contents of the account object.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeAnalyticsAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Parameters supplied to the update Data Lake Analytics account operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<DataLakeAnalyticsAccountResource> Update(WaitUntil waitUntil, DataLakeAnalyticsAccountPatch patch, CancellationToken cancellationToken = default)
        {
            if (patch == null)
            {
                throw new ArgumentNullException(nameof(patch));
            }

            using var scope = _dataLakeAnalyticsAccountAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsAccountResource.Update");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsAccountAccountsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch, cancellationToken);
                var operation = new DataLakeAnalyticsArmOperation<DataLakeAnalyticsAccountResource>(new DataLakeAnalyticsAccountOperationSource(Client), _dataLakeAnalyticsAccountAccountsClientDiagnostics, Pipeline, _dataLakeAnalyticsAccountAccountsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
