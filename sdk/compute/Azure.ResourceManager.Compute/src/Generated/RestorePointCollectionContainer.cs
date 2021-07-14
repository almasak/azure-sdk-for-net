// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of RestorePointCollection and their operations over a ResourceGroup. </summary>
    public partial class RestorePointCollectionContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, RestorePointCollection, RestorePointCollectionData>
    {
        /// <summary> Initializes a new instance of the <see cref="RestorePointCollectionContainer"/> class for mocking. </summary>
        protected RestorePointCollectionContainer()
        {
        }

        /// <summary> Initializes a new instance of RestorePointCollectionContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal RestorePointCollectionContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private RestorePointCollectionsRestOperations _restClient => new RestorePointCollectionsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update the restore point collection. Please refer to https://aka.ms/RestorePoints for more details. When updating a restore point collection, only tags may be modified. </summary>
        /// <param name="restorePointCollectionName"> The name of the restore point collection. </param>
        /// <param name="parameters"> Parameters supplied to the Create or Update restore point collection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointCollectionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<RestorePointCollection> CreateOrUpdate(string restorePointCollectionName, RestorePointCollectionData parameters, CancellationToken cancellationToken = default)
        {
            if (restorePointCollectionName == null)
            {
                throw new ArgumentNullException(nameof(restorePointCollectionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorePointCollectionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(restorePointCollectionName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update the restore point collection. Please refer to https://aka.ms/RestorePoints for more details. When updating a restore point collection, only tags may be modified. </summary>
        /// <param name="restorePointCollectionName"> The name of the restore point collection. </param>
        /// <param name="parameters"> Parameters supplied to the Create or Update restore point collection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointCollectionName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<RestorePointCollection>> CreateOrUpdateAsync(string restorePointCollectionName, RestorePointCollectionData parameters, CancellationToken cancellationToken = default)
        {
            if (restorePointCollectionName == null)
            {
                throw new ArgumentNullException(nameof(restorePointCollectionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorePointCollectionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(restorePointCollectionName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update the restore point collection. Please refer to https://aka.ms/RestorePoints for more details. When updating a restore point collection, only tags may be modified. </summary>
        /// <param name="restorePointCollectionName"> The name of the restore point collection. </param>
        /// <param name="parameters"> Parameters supplied to the Create or Update restore point collection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointCollectionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual RestorePointCollectionsCreateOrUpdateOperation StartCreateOrUpdate(string restorePointCollectionName, RestorePointCollectionData parameters, CancellationToken cancellationToken = default)
        {
            if (restorePointCollectionName == null)
            {
                throw new ArgumentNullException(nameof(restorePointCollectionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorePointCollectionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, restorePointCollectionName, parameters, cancellationToken);
                return new RestorePointCollectionsCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update the restore point collection. Please refer to https://aka.ms/RestorePoints for more details. When updating a restore point collection, only tags may be modified. </summary>
        /// <param name="restorePointCollectionName"> The name of the restore point collection. </param>
        /// <param name="parameters"> Parameters supplied to the Create or Update restore point collection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointCollectionName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<RestorePointCollectionsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string restorePointCollectionName, RestorePointCollectionData parameters, CancellationToken cancellationToken = default)
        {
            if (restorePointCollectionName == null)
            {
                throw new ArgumentNullException(nameof(restorePointCollectionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorePointCollectionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, restorePointCollectionName, parameters, cancellationToken).ConfigureAwait(false);
                return new RestorePointCollectionsCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="restorePointCollectionName"> The name of the restore point collection. </param>
        /// <param name="expand"> The expand expression to apply on the operation. If expand=restorePoints, server will return all contained restore points in the restorePointCollection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<RestorePointCollection> Get(string restorePointCollectionName, RestorePointCollectionExpandOptions? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RestorePointCollectionContainer.Get");
            scope.Start();
            try
            {
                if (restorePointCollectionName == null)
                {
                    throw new ArgumentNullException(nameof(restorePointCollectionName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, restorePointCollectionName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(new RestorePointCollection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="restorePointCollectionName"> The name of the restore point collection. </param>
        /// <param name="expand"> The expand expression to apply on the operation. If expand=restorePoints, server will return all contained restore points in the restorePointCollection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<RestorePointCollection>> GetAsync(string restorePointCollectionName, RestorePointCollectionExpandOptions? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RestorePointCollectionContainer.Get");
            scope.Start();
            try
            {
                if (restorePointCollectionName == null)
                {
                    throw new ArgumentNullException(nameof(restorePointCollectionName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, restorePointCollectionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new RestorePointCollection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="restorePointCollectionName"> The name of the restore point collection. </param>
        /// <param name="expand"> The expand expression to apply on the operation. If expand=restorePoints, server will return all contained restore points in the restorePointCollection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public RestorePointCollection TryGet(string restorePointCollectionName, RestorePointCollectionExpandOptions? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RestorePointCollectionContainer.TryGet");
            scope.Start();
            try
            {
                if (restorePointCollectionName == null)
                {
                    throw new ArgumentNullException(nameof(restorePointCollectionName));
                }

                return Get(restorePointCollectionName, expand, cancellationToken: cancellationToken).Value;
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="restorePointCollectionName"> The name of the restore point collection. </param>
        /// <param name="expand"> The expand expression to apply on the operation. If expand=restorePoints, server will return all contained restore points in the restorePointCollection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<RestorePointCollection> TryGetAsync(string restorePointCollectionName, RestorePointCollectionExpandOptions? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RestorePointCollectionContainer.TryGet");
            scope.Start();
            try
            {
                if (restorePointCollectionName == null)
                {
                    throw new ArgumentNullException(nameof(restorePointCollectionName));
                }

                return await GetAsync(restorePointCollectionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="restorePointCollectionName"> The name of the restore point collection. </param>
        /// <param name="expand"> The expand expression to apply on the operation. If expand=restorePoints, server will return all contained restore points in the restorePointCollection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public bool DoesExist(string restorePointCollectionName, RestorePointCollectionExpandOptions? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RestorePointCollectionContainer.DoesExist");
            scope.Start();
            try
            {
                if (restorePointCollectionName == null)
                {
                    throw new ArgumentNullException(nameof(restorePointCollectionName));
                }

                return TryGet(restorePointCollectionName, expand, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="restorePointCollectionName"> The name of the restore point collection. </param>
        /// <param name="expand"> The expand expression to apply on the operation. If expand=restorePoints, server will return all contained restore points in the restorePointCollection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<bool> DoesExistAsync(string restorePointCollectionName, RestorePointCollectionExpandOptions? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RestorePointCollectionContainer.DoesExist");
            scope.Start();
            try
            {
                if (restorePointCollectionName == null)
                {
                    throw new ArgumentNullException(nameof(restorePointCollectionName));
                }

                return await TryGetAsync(restorePointCollectionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the list of restore point collections in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorePointCollection" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<RestorePointCollection> List(CancellationToken cancellationToken = default)
        {
            Page<RestorePointCollection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestorePointCollectionContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.List(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorePointCollection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RestorePointCollection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestorePointCollectionContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorePointCollection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the list of restore point collections in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorePointCollection" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<RestorePointCollection> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RestorePointCollection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestorePointCollectionContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorePointCollection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RestorePointCollection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestorePointCollectionContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorePointCollection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of RestorePointCollection for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RestorePointCollectionContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(RestorePointCollectionOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of RestorePointCollection for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RestorePointCollectionContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(RestorePointCollectionOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, RestorePointCollection, RestorePointCollectionData> Construct() { }
    }
}
