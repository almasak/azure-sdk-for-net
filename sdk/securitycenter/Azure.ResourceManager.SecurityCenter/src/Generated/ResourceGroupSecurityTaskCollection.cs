// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="ResourceGroupSecurityTaskResource"/> and their operations.
    /// Each <see cref="ResourceGroupSecurityTaskResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="ResourceGroupSecurityTaskCollection"/> instance call the GetResourceGroupSecurityTasks method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class ResourceGroupSecurityTaskCollection : ArmCollection, IEnumerable<ResourceGroupSecurityTaskResource>, IAsyncEnumerable<ResourceGroupSecurityTaskResource>
    {
        private readonly ClientDiagnostics _resourceGroupSecurityTaskTasksClientDiagnostics;
        private readonly TasksRestOperations _resourceGroupSecurityTaskTasksRestClient;
        private readonly AzureLocation _ascLocation;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupSecurityTaskCollection"/> class for mocking. </summary>
        protected ResourceGroupSecurityTaskCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupSecurityTaskCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="ascLocation"> The location where ASC stores the data of the subscription. can be retrieved from Get locations. </param>
        internal ResourceGroupSecurityTaskCollection(ArmClient client, ResourceIdentifier id, AzureLocation ascLocation) : base(client, id)
        {
            _ascLocation = ascLocation;
            _resourceGroupSecurityTaskTasksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceGroupSecurityTaskResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceGroupSecurityTaskResource.ResourceType, out string resourceGroupSecurityTaskTasksApiVersion);
            _resourceGroupSecurityTaskTasksRestClient = new TasksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceGroupSecurityTaskTasksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Recommended tasks that will help improve the security of the subscription proactively
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_GetResourceGroupLevelTask</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2015-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGroupSecurityTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskName"> Name of the task object, will be a GUID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        public virtual async Task<Response<ResourceGroupSecurityTaskResource>> GetAsync(string taskName, CancellationToken cancellationToken = default)
        {
            if (taskName == null)
            {
                throw new ArgumentNullException(nameof(taskName));
            }
            if (taskName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(taskName));
            }

            using var scope = _resourceGroupSecurityTaskTasksClientDiagnostics.CreateScope("ResourceGroupSecurityTaskCollection.Get");
            scope.Start();
            try
            {
                var response = await _resourceGroupSecurityTaskTasksRestClient.GetResourceGroupLevelTaskAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_ascLocation), taskName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupSecurityTaskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Recommended tasks that will help improve the security of the subscription proactively
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_GetResourceGroupLevelTask</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2015-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGroupSecurityTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskName"> Name of the task object, will be a GUID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        public virtual Response<ResourceGroupSecurityTaskResource> Get(string taskName, CancellationToken cancellationToken = default)
        {
            if (taskName == null)
            {
                throw new ArgumentNullException(nameof(taskName));
            }
            if (taskName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(taskName));
            }

            using var scope = _resourceGroupSecurityTaskTasksClientDiagnostics.CreateScope("ResourceGroupSecurityTaskCollection.Get");
            scope.Start();
            try
            {
                var response = _resourceGroupSecurityTaskTasksRestClient.GetResourceGroupLevelTask(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_ascLocation), taskName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupSecurityTaskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Recommended tasks that will help improve the security of the subscription proactively
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/tasks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2015-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGroupSecurityTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceGroupSecurityTaskResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceGroupSecurityTaskResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceGroupSecurityTaskTasksRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_ascLocation), filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourceGroupSecurityTaskTasksRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_ascLocation), filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ResourceGroupSecurityTaskResource(Client, SecurityTaskData.DeserializeSecurityTaskData(e)), _resourceGroupSecurityTaskTasksClientDiagnostics, Pipeline, "ResourceGroupSecurityTaskCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Recommended tasks that will help improve the security of the subscription proactively
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/tasks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2015-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGroupSecurityTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceGroupSecurityTaskResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceGroupSecurityTaskResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceGroupSecurityTaskTasksRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_ascLocation), filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourceGroupSecurityTaskTasksRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_ascLocation), filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ResourceGroupSecurityTaskResource(Client, SecurityTaskData.DeserializeSecurityTaskData(e)), _resourceGroupSecurityTaskTasksClientDiagnostics, Pipeline, "ResourceGroupSecurityTaskCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_GetResourceGroupLevelTask</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2015-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGroupSecurityTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskName"> Name of the task object, will be a GUID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string taskName, CancellationToken cancellationToken = default)
        {
            if (taskName == null)
            {
                throw new ArgumentNullException(nameof(taskName));
            }
            if (taskName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(taskName));
            }

            using var scope = _resourceGroupSecurityTaskTasksClientDiagnostics.CreateScope("ResourceGroupSecurityTaskCollection.Exists");
            scope.Start();
            try
            {
                var response = await _resourceGroupSecurityTaskTasksRestClient.GetResourceGroupLevelTaskAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_ascLocation), taskName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_GetResourceGroupLevelTask</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2015-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGroupSecurityTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskName"> Name of the task object, will be a GUID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        public virtual Response<bool> Exists(string taskName, CancellationToken cancellationToken = default)
        {
            if (taskName == null)
            {
                throw new ArgumentNullException(nameof(taskName));
            }
            if (taskName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(taskName));
            }

            using var scope = _resourceGroupSecurityTaskTasksClientDiagnostics.CreateScope("ResourceGroupSecurityTaskCollection.Exists");
            scope.Start();
            try
            {
                var response = _resourceGroupSecurityTaskTasksRestClient.GetResourceGroupLevelTask(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_ascLocation), taskName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_GetResourceGroupLevelTask</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2015-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGroupSecurityTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskName"> Name of the task object, will be a GUID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        public virtual async Task<NullableResponse<ResourceGroupSecurityTaskResource>> GetIfExistsAsync(string taskName, CancellationToken cancellationToken = default)
        {
            if (taskName == null)
            {
                throw new ArgumentNullException(nameof(taskName));
            }
            if (taskName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(taskName));
            }

            using var scope = _resourceGroupSecurityTaskTasksClientDiagnostics.CreateScope("ResourceGroupSecurityTaskCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _resourceGroupSecurityTaskTasksRestClient.GetResourceGroupLevelTaskAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_ascLocation), taskName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ResourceGroupSecurityTaskResource>(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupSecurityTaskResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/tasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tasks_GetResourceGroupLevelTask</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2015-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGroupSecurityTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskName"> Name of the task object, will be a GUID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        public virtual NullableResponse<ResourceGroupSecurityTaskResource> GetIfExists(string taskName, CancellationToken cancellationToken = default)
        {
            if (taskName == null)
            {
                throw new ArgumentNullException(nameof(taskName));
            }
            if (taskName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(taskName));
            }

            using var scope = _resourceGroupSecurityTaskTasksClientDiagnostics.CreateScope("ResourceGroupSecurityTaskCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _resourceGroupSecurityTaskTasksRestClient.GetResourceGroupLevelTask(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_ascLocation), taskName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ResourceGroupSecurityTaskResource>(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupSecurityTaskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResourceGroupSecurityTaskResource> IEnumerable<ResourceGroupSecurityTaskResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResourceGroupSecurityTaskResource> IAsyncEnumerable<ResourceGroupSecurityTaskResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
