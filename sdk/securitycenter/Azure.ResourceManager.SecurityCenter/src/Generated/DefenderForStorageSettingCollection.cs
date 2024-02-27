// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="DefenderForStorageSettingResource"/> and their operations.
    /// Each <see cref="DefenderForStorageSettingResource"/> in the collection will belong to the same instance of <see cref="ArmResource"/>.
    /// To get a <see cref="DefenderForStorageSettingCollection"/> instance call the GetDefenderForStorageSettings method from an instance of <see cref="ArmResource"/>.
    /// </summary>
    public partial class DefenderForStorageSettingCollection : ArmCollection
    {
        private readonly ClientDiagnostics _defenderForStorageSettingDefenderForStorageClientDiagnostics;
        private readonly DefenderForStorageRestOperations _defenderForStorageSettingDefenderForStorageRestClient;

        /// <summary> Initializes a new instance of the <see cref="DefenderForStorageSettingCollection"/> class for mocking. </summary>
        protected DefenderForStorageSettingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DefenderForStorageSettingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DefenderForStorageSettingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _defenderForStorageSettingDefenderForStorageClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", DefenderForStorageSettingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DefenderForStorageSettingResource.ResourceType, out string defenderForStorageSettingDefenderForStorageApiVersion);
            _defenderForStorageSettingDefenderForStorageRestClient = new DefenderForStorageRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, defenderForStorageSettingDefenderForStorageApiVersion);
        }

        /// <summary>
        /// Creates or updates the Defender for Storage settings on a specified storage account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.Security/defenderForStorageSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefenderForStorage_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DefenderForStorageSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="settingName"> Defender for Storage setting name. </param>
        /// <param name="data"> Defender for Storage Settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DefenderForStorageSettingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, DefenderForStorageSettingName settingName, DefenderForStorageSettingData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _defenderForStorageSettingDefenderForStorageClientDiagnostics.CreateScope("DefenderForStorageSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _defenderForStorageSettingDefenderForStorageRestClient.CreateAsync(Id, settingName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<DefenderForStorageSettingResource>(Response.FromValue(new DefenderForStorageSettingResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates the Defender for Storage settings on a specified storage account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.Security/defenderForStorageSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefenderForStorage_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DefenderForStorageSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="settingName"> Defender for Storage setting name. </param>
        /// <param name="data"> Defender for Storage Settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DefenderForStorageSettingResource> CreateOrUpdate(WaitUntil waitUntil, DefenderForStorageSettingName settingName, DefenderForStorageSettingData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _defenderForStorageSettingDefenderForStorageClientDiagnostics.CreateScope("DefenderForStorageSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _defenderForStorageSettingDefenderForStorageRestClient.Create(Id, settingName, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<DefenderForStorageSettingResource>(Response.FromValue(new DefenderForStorageSettingResource(Client, response), response.GetRawResponse()));
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

        /// <summary>
        /// Gets the Defender for Storage settings for the specified storage account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.Security/defenderForStorageSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefenderForStorage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DefenderForStorageSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="settingName"> Defender for Storage setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DefenderForStorageSettingResource>> GetAsync(DefenderForStorageSettingName settingName, CancellationToken cancellationToken = default)
        {
            using var scope = _defenderForStorageSettingDefenderForStorageClientDiagnostics.CreateScope("DefenderForStorageSettingCollection.Get");
            scope.Start();
            try
            {
                var response = await _defenderForStorageSettingDefenderForStorageRestClient.GetAsync(Id, settingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DefenderForStorageSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Defender for Storage settings for the specified storage account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.Security/defenderForStorageSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefenderForStorage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DefenderForStorageSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="settingName"> Defender for Storage setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DefenderForStorageSettingResource> Get(DefenderForStorageSettingName settingName, CancellationToken cancellationToken = default)
        {
            using var scope = _defenderForStorageSettingDefenderForStorageClientDiagnostics.CreateScope("DefenderForStorageSettingCollection.Get");
            scope.Start();
            try
            {
                var response = _defenderForStorageSettingDefenderForStorageRestClient.Get(Id, settingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DefenderForStorageSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.Security/defenderForStorageSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefenderForStorage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DefenderForStorageSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="settingName"> Defender for Storage setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(DefenderForStorageSettingName settingName, CancellationToken cancellationToken = default)
        {
            using var scope = _defenderForStorageSettingDefenderForStorageClientDiagnostics.CreateScope("DefenderForStorageSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _defenderForStorageSettingDefenderForStorageRestClient.GetAsync(Id, settingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.Security/defenderForStorageSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefenderForStorage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DefenderForStorageSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="settingName"> Defender for Storage setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(DefenderForStorageSettingName settingName, CancellationToken cancellationToken = default)
        {
            using var scope = _defenderForStorageSettingDefenderForStorageClientDiagnostics.CreateScope("DefenderForStorageSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = _defenderForStorageSettingDefenderForStorageRestClient.Get(Id, settingName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.Security/defenderForStorageSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefenderForStorage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DefenderForStorageSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="settingName"> Defender for Storage setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<DefenderForStorageSettingResource>> GetIfExistsAsync(DefenderForStorageSettingName settingName, CancellationToken cancellationToken = default)
        {
            using var scope = _defenderForStorageSettingDefenderForStorageClientDiagnostics.CreateScope("DefenderForStorageSettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _defenderForStorageSettingDefenderForStorageRestClient.GetAsync(Id, settingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DefenderForStorageSettingResource>(response.GetRawResponse());
                return Response.FromValue(new DefenderForStorageSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.Security/defenderForStorageSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefenderForStorage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DefenderForStorageSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="settingName"> Defender for Storage setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<DefenderForStorageSettingResource> GetIfExists(DefenderForStorageSettingName settingName, CancellationToken cancellationToken = default)
        {
            using var scope = _defenderForStorageSettingDefenderForStorageClientDiagnostics.CreateScope("DefenderForStorageSettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _defenderForStorageSettingDefenderForStorageRestClient.Get(Id, settingName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DefenderForStorageSettingResource>(response.GetRawResponse());
                return Response.FromValue(new DefenderForStorageSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
