// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A Class representing a MachineLearningRegistryModelVersion along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="MachineLearningRegistryModelVersionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetMachineLearningRegistryModelVersionResource method.
    /// Otherwise you can get one from its parent resource <see cref="MachineLearningRegistryModelContainerResource"/> using the GetMachineLearningRegistryModelVersion method.
    /// </summary>
    public partial class MachineLearningRegistryModelVersionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MachineLearningRegistryModelVersionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="registryName"> The registryName. </param>
        /// <param name="modelName"> The modelName. </param>
        /// <param name="version"> The version. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string registryName, string modelName, string version)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/models/{modelName}/versions/{version}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _machineLearningRegistryModelVersionRegistryModelVersionsClientDiagnostics;
        private readonly RegistryModelVersionsRestOperations _machineLearningRegistryModelVersionRegistryModelVersionsRestClient;
        private readonly MachineLearningModelVersionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MachineLearningServices/registries/models/versions";

        /// <summary> Initializes a new instance of the <see cref="MachineLearningRegistryModelVersionResource"/> class for mocking. </summary>
        protected MachineLearningRegistryModelVersionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningRegistryModelVersionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MachineLearningRegistryModelVersionResource(ArmClient client, MachineLearningModelVersionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningRegistryModelVersionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MachineLearningRegistryModelVersionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningRegistryModelVersionRegistryModelVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string machineLearningRegistryModelVersionRegistryModelVersionsApiVersion);
            _machineLearningRegistryModelVersionRegistryModelVersionsRestClient = new RegistryModelVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningRegistryModelVersionRegistryModelVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MachineLearningModelVersionData Data
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

        /// <summary>
        /// Get version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/models/{modelName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryModelVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryModelVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MachineLearningRegistryModelVersionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningRegistryModelVersionRegistryModelVersionsClientDiagnostics.CreateScope("MachineLearningRegistryModelVersionResource.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryModelVersionRegistryModelVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryModelVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/models/{modelName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryModelVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryModelVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MachineLearningRegistryModelVersionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningRegistryModelVersionRegistryModelVersionsClientDiagnostics.CreateScope("MachineLearningRegistryModelVersionResource.Get");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryModelVersionRegistryModelVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryModelVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/models/{modelName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryModelVersions_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryModelVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningRegistryModelVersionRegistryModelVersionsClientDiagnostics.CreateScope("MachineLearningRegistryModelVersionResource.Delete");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryModelVersionRegistryModelVersionsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation(_machineLearningRegistryModelVersionRegistryModelVersionsClientDiagnostics, Pipeline, _machineLearningRegistryModelVersionRegistryModelVersionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Delete version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/models/{modelName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryModelVersions_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryModelVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningRegistryModelVersionRegistryModelVersionsClientDiagnostics.CreateScope("MachineLearningRegistryModelVersionResource.Delete");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryModelVersionRegistryModelVersionsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MachineLearningArmOperation(_machineLearningRegistryModelVersionRegistryModelVersionsClientDiagnostics, Pipeline, _machineLearningRegistryModelVersionRegistryModelVersionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/models/{modelName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryModelVersions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryModelVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Version entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningRegistryModelVersionResource>> UpdateAsync(WaitUntil waitUntil, MachineLearningModelVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningRegistryModelVersionRegistryModelVersionsClientDiagnostics.CreateScope("MachineLearningRegistryModelVersionResource.Update");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryModelVersionRegistryModelVersionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningRegistryModelVersionResource>(new MachineLearningRegistryModelVersionOperationSource(Client), _machineLearningRegistryModelVersionRegistryModelVersionsClientDiagnostics, Pipeline, _machineLearningRegistryModelVersionRegistryModelVersionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Create or update version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/models/{modelName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryModelVersions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryModelVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Version entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningRegistryModelVersionResource> Update(WaitUntil waitUntil, MachineLearningModelVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningRegistryModelVersionRegistryModelVersionsClientDiagnostics.CreateScope("MachineLearningRegistryModelVersionResource.Update");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryModelVersionRegistryModelVersionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningRegistryModelVersionResource>(new MachineLearningRegistryModelVersionOperationSource(Client), _machineLearningRegistryModelVersionRegistryModelVersionsClientDiagnostics, Pipeline, _machineLearningRegistryModelVersionRegistryModelVersionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Generate a storage location and credential for the client to upload a model asset to.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/models/{modelName}/versions/{version}/startPendingUpload</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryModelVersions_CreateOrGetStartPendingUpload</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryModelVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="body"> Pending upload request object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual async Task<Response<PendingUploadResponseDto>> CreateOrGetStartPendingUploadAsync(PendingUploadRequestDto body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(body, nameof(body));

            using var scope = _machineLearningRegistryModelVersionRegistryModelVersionsClientDiagnostics.CreateScope("MachineLearningRegistryModelVersionResource.CreateOrGetStartPendingUpload");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryModelVersionRegistryModelVersionsRestClient.CreateOrGetStartPendingUploadAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, body, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Generate a storage location and credential for the client to upload a model asset to.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/models/{modelName}/versions/{version}/startPendingUpload</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryModelVersions_CreateOrGetStartPendingUpload</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryModelVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="body"> Pending upload request object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual Response<PendingUploadResponseDto> CreateOrGetStartPendingUpload(PendingUploadRequestDto body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(body, nameof(body));

            using var scope = _machineLearningRegistryModelVersionRegistryModelVersionsClientDiagnostics.CreateScope("MachineLearningRegistryModelVersionResource.CreateOrGetStartPendingUpload");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryModelVersionRegistryModelVersionsRestClient.CreateOrGetStartPendingUpload(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, body, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
