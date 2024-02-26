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

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing a collection of <see cref="AppPlatformServiceRegistryResource"/> and their operations.
    /// Each <see cref="AppPlatformServiceRegistryResource"/> in the collection will belong to the same instance of <see cref="AppPlatformServiceResource"/>.
    /// To get an <see cref="AppPlatformServiceRegistryCollection"/> instance call the GetAppPlatformServiceRegistries method from an instance of <see cref="AppPlatformServiceResource"/>.
    /// </summary>
    public partial class AppPlatformServiceRegistryCollection : ArmCollection, IEnumerable<AppPlatformServiceRegistryResource>, IAsyncEnumerable<AppPlatformServiceRegistryResource>
    {
        private readonly ClientDiagnostics _appPlatformServiceRegistryServiceRegistriesClientDiagnostics;
        private readonly ServiceRegistriesRestOperations _appPlatformServiceRegistryServiceRegistriesRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppPlatformServiceRegistryCollection"/> class for mocking. </summary>
        protected AppPlatformServiceRegistryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformServiceRegistryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppPlatformServiceRegistryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformServiceRegistryServiceRegistriesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", AppPlatformServiceRegistryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppPlatformServiceRegistryResource.ResourceType, out string appPlatformServiceRegistryServiceRegistriesApiVersion);
            _appPlatformServiceRegistryServiceRegistriesRestClient = new ServiceRegistriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformServiceRegistryServiceRegistriesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppPlatformServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppPlatformServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create the default Service Registry or update the existing Service Registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/serviceRegistries/{serviceRegistryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceRegistries_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformServiceRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serviceRegistryName"> The name of Service Registry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceRegistryName"/> is null. </exception>
        public virtual async Task<ArmOperation<AppPlatformServiceRegistryResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string serviceRegistryName, CancellationToken cancellationToken = default)
        {
            if (serviceRegistryName == null)
            {
                throw new ArgumentNullException(nameof(serviceRegistryName));
            }
            if (serviceRegistryName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serviceRegistryName));
            }

            using var scope = _appPlatformServiceRegistryServiceRegistriesClientDiagnostics.CreateScope("AppPlatformServiceRegistryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appPlatformServiceRegistryServiceRegistriesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceRegistryName, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<AppPlatformServiceRegistryResource>(new AppPlatformServiceRegistryOperationSource(Client), _appPlatformServiceRegistryServiceRegistriesClientDiagnostics, Pipeline, _appPlatformServiceRegistryServiceRegistriesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceRegistryName).Request, response, OperationFinalStateVia.Location);
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
        /// Create the default Service Registry or update the existing Service Registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/serviceRegistries/{serviceRegistryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceRegistries_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformServiceRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serviceRegistryName"> The name of Service Registry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceRegistryName"/> is null. </exception>
        public virtual ArmOperation<AppPlatformServiceRegistryResource> CreateOrUpdate(WaitUntil waitUntil, string serviceRegistryName, CancellationToken cancellationToken = default)
        {
            if (serviceRegistryName == null)
            {
                throw new ArgumentNullException(nameof(serviceRegistryName));
            }
            if (serviceRegistryName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serviceRegistryName));
            }

            using var scope = _appPlatformServiceRegistryServiceRegistriesClientDiagnostics.CreateScope("AppPlatformServiceRegistryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appPlatformServiceRegistryServiceRegistriesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceRegistryName, cancellationToken);
                var operation = new AppPlatformArmOperation<AppPlatformServiceRegistryResource>(new AppPlatformServiceRegistryOperationSource(Client), _appPlatformServiceRegistryServiceRegistriesClientDiagnostics, Pipeline, _appPlatformServiceRegistryServiceRegistriesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceRegistryName).Request, response, OperationFinalStateVia.Location);
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
        /// Get the Service Registry and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/serviceRegistries/{serviceRegistryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceRegistries_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformServiceRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceRegistryName"> The name of Service Registry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceRegistryName"/> is null. </exception>
        public virtual async Task<Response<AppPlatformServiceRegistryResource>> GetAsync(string serviceRegistryName, CancellationToken cancellationToken = default)
        {
            if (serviceRegistryName == null)
            {
                throw new ArgumentNullException(nameof(serviceRegistryName));
            }
            if (serviceRegistryName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serviceRegistryName));
            }

            using var scope = _appPlatformServiceRegistryServiceRegistriesClientDiagnostics.CreateScope("AppPlatformServiceRegistryCollection.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformServiceRegistryServiceRegistriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceRegistryName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformServiceRegistryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Service Registry and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/serviceRegistries/{serviceRegistryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceRegistries_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformServiceRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceRegistryName"> The name of Service Registry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceRegistryName"/> is null. </exception>
        public virtual Response<AppPlatformServiceRegistryResource> Get(string serviceRegistryName, CancellationToken cancellationToken = default)
        {
            if (serviceRegistryName == null)
            {
                throw new ArgumentNullException(nameof(serviceRegistryName));
            }
            if (serviceRegistryName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serviceRegistryName));
            }

            using var scope = _appPlatformServiceRegistryServiceRegistriesClientDiagnostics.CreateScope("AppPlatformServiceRegistryCollection.Get");
            scope.Start();
            try
            {
                var response = _appPlatformServiceRegistryServiceRegistriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceRegistryName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformServiceRegistryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Handles requests to list all resources in a Service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/serviceRegistries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceRegistries_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformServiceRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppPlatformServiceRegistryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppPlatformServiceRegistryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformServiceRegistryServiceRegistriesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformServiceRegistryServiceRegistriesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AppPlatformServiceRegistryResource(Client, AppPlatformServiceRegistryData.DeserializeAppPlatformServiceRegistryData(e)), _appPlatformServiceRegistryServiceRegistriesClientDiagnostics, Pipeline, "AppPlatformServiceRegistryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a Service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/serviceRegistries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceRegistries_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformServiceRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppPlatformServiceRegistryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppPlatformServiceRegistryResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformServiceRegistryServiceRegistriesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformServiceRegistryServiceRegistriesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AppPlatformServiceRegistryResource(Client, AppPlatformServiceRegistryData.DeserializeAppPlatformServiceRegistryData(e)), _appPlatformServiceRegistryServiceRegistriesClientDiagnostics, Pipeline, "AppPlatformServiceRegistryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/serviceRegistries/{serviceRegistryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceRegistries_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformServiceRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceRegistryName"> The name of Service Registry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceRegistryName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serviceRegistryName, CancellationToken cancellationToken = default)
        {
            if (serviceRegistryName == null)
            {
                throw new ArgumentNullException(nameof(serviceRegistryName));
            }
            if (serviceRegistryName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serviceRegistryName));
            }

            using var scope = _appPlatformServiceRegistryServiceRegistriesClientDiagnostics.CreateScope("AppPlatformServiceRegistryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appPlatformServiceRegistryServiceRegistriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceRegistryName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/serviceRegistries/{serviceRegistryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceRegistries_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformServiceRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceRegistryName"> The name of Service Registry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceRegistryName"/> is null. </exception>
        public virtual Response<bool> Exists(string serviceRegistryName, CancellationToken cancellationToken = default)
        {
            if (serviceRegistryName == null)
            {
                throw new ArgumentNullException(nameof(serviceRegistryName));
            }
            if (serviceRegistryName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serviceRegistryName));
            }

            using var scope = _appPlatformServiceRegistryServiceRegistriesClientDiagnostics.CreateScope("AppPlatformServiceRegistryCollection.Exists");
            scope.Start();
            try
            {
                var response = _appPlatformServiceRegistryServiceRegistriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceRegistryName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/serviceRegistries/{serviceRegistryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceRegistries_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformServiceRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceRegistryName"> The name of Service Registry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceRegistryName"/> is null. </exception>
        public virtual async Task<NullableResponse<AppPlatformServiceRegistryResource>> GetIfExistsAsync(string serviceRegistryName, CancellationToken cancellationToken = default)
        {
            if (serviceRegistryName == null)
            {
                throw new ArgumentNullException(nameof(serviceRegistryName));
            }
            if (serviceRegistryName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serviceRegistryName));
            }

            using var scope = _appPlatformServiceRegistryServiceRegistriesClientDiagnostics.CreateScope("AppPlatformServiceRegistryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _appPlatformServiceRegistryServiceRegistriesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceRegistryName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AppPlatformServiceRegistryResource>(response.GetRawResponse());
                return Response.FromValue(new AppPlatformServiceRegistryResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/serviceRegistries/{serviceRegistryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceRegistries_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformServiceRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceRegistryName"> The name of Service Registry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceRegistryName"/> is null. </exception>
        public virtual NullableResponse<AppPlatformServiceRegistryResource> GetIfExists(string serviceRegistryName, CancellationToken cancellationToken = default)
        {
            if (serviceRegistryName == null)
            {
                throw new ArgumentNullException(nameof(serviceRegistryName));
            }
            if (serviceRegistryName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serviceRegistryName));
            }

            using var scope = _appPlatformServiceRegistryServiceRegistriesClientDiagnostics.CreateScope("AppPlatformServiceRegistryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appPlatformServiceRegistryServiceRegistriesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceRegistryName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AppPlatformServiceRegistryResource>(response.GetRawResponse());
                return Response.FromValue(new AppPlatformServiceRegistryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppPlatformServiceRegistryResource> IEnumerable<AppPlatformServiceRegistryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppPlatformServiceRegistryResource> IAsyncEnumerable<AppPlatformServiceRegistryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
