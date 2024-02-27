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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlServerJobExecutionResource"/> and their operations.
    /// Each <see cref="SqlServerJobExecutionResource"/> in the collection will belong to the same instance of <see cref="SqlServerJobResource"/>.
    /// To get a <see cref="SqlServerJobExecutionCollection"/> instance call the GetSqlServerJobExecutions method from an instance of <see cref="SqlServerJobResource"/>.
    /// </summary>
    public partial class SqlServerJobExecutionCollection : ArmCollection, IEnumerable<SqlServerJobExecutionResource>, IAsyncEnumerable<SqlServerJobExecutionResource>
    {
        private readonly ClientDiagnostics _sqlServerJobExecutionJobExecutionsClientDiagnostics;
        private readonly JobExecutionsRestOperations _sqlServerJobExecutionJobExecutionsRestClient;
        private readonly ClientDiagnostics _sqlServerJobExecutionStepTargetJobTargetExecutionsClientDiagnostics;
        private readonly JobTargetExecutionsRestOperations _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobExecutionCollection"/> class for mocking. </summary>
        protected SqlServerJobExecutionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobExecutionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerJobExecutionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerJobExecutionJobExecutionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerJobExecutionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerJobExecutionResource.ResourceType, out string sqlServerJobExecutionJobExecutionsApiVersion);
            _sqlServerJobExecutionJobExecutionsRestClient = new JobExecutionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerJobExecutionJobExecutionsApiVersion);
            _sqlServerJobExecutionStepTargetJobTargetExecutionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerJobExecutionStepTargetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerJobExecutionStepTargetResource.ResourceType, out string sqlServerJobExecutionStepTargetJobTargetExecutionsApiVersion);
            _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient = new JobTargetExecutionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerJobExecutionStepTargetJobTargetExecutionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerJobResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerJobResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a job execution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobExecutions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerJobExecutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobExecutionId"> The job execution id to create the job execution under. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<SqlServerJobExecutionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionJobExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlServerJobExecutionJobExecutionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerJobExecutionResource>(new SqlServerJobExecutionOperationSource(Client), _sqlServerJobExecutionJobExecutionsClientDiagnostics, Pipeline, _sqlServerJobExecutionJobExecutionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a job execution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobExecutions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerJobExecutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobExecutionId"> The job execution id to create the job execution under. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<SqlServerJobExecutionResource> CreateOrUpdate(WaitUntil waitUntil, Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionJobExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlServerJobExecutionJobExecutionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId, cancellationToken);
                var operation = new SqlArmOperation<SqlServerJobExecutionResource>(new SqlServerJobExecutionOperationSource(Client), _sqlServerJobExecutionJobExecutionsClientDiagnostics, Pipeline, _sqlServerJobExecutionJobExecutionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a job execution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobExecutions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerJobExecutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlServerJobExecutionResource>> GetAsync(Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionJobExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerJobExecutionJobExecutionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobExecutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a job execution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobExecutions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerJobExecutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlServerJobExecutionResource> Get(Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionJobExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerJobExecutionJobExecutionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobExecutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a job's executions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobExecutions_ListByJob</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerJobExecutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerJobExecutionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerJobExecutionResource> GetAllAsync(SqlServerJobExecutionCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new SqlServerJobExecutionCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerJobExecutionJobExecutionsRestClient.CreateListByJobRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, options.CreateTimeMin, options.CreateTimeMax, options.EndTimeMin, options.EndTimeMax, options.IsActive, options.Skip, options.Top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerJobExecutionJobExecutionsRestClient.CreateListByJobNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, options.CreateTimeMin, options.CreateTimeMax, options.EndTimeMin, options.EndTimeMax, options.IsActive, options.Skip, options.Top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SqlServerJobExecutionResource(Client, SqlServerJobExecutionData.DeserializeSqlServerJobExecutionData(e)), _sqlServerJobExecutionJobExecutionsClientDiagnostics, Pipeline, "SqlServerJobExecutionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a job's executions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobExecutions_ListByJob</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerJobExecutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerJobExecutionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerJobExecutionResource> GetAll(SqlServerJobExecutionCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new SqlServerJobExecutionCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerJobExecutionJobExecutionsRestClient.CreateListByJobRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, options.CreateTimeMin, options.CreateTimeMax, options.EndTimeMin, options.EndTimeMax, options.IsActive, options.Skip, options.Top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerJobExecutionJobExecutionsRestClient.CreateListByJobNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, options.CreateTimeMin, options.CreateTimeMax, options.EndTimeMin, options.EndTimeMax, options.IsActive, options.Skip, options.Top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SqlServerJobExecutionResource(Client, SqlServerJobExecutionData.DeserializeSqlServerJobExecutionData(e)), _sqlServerJobExecutionJobExecutionsClientDiagnostics, Pipeline, "SqlServerJobExecutionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists target executions for all steps of a job execution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/targets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobTargetExecutions_ListByJobExecution</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerJobExecutionStepTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        /// <returns> An async collection of <see cref="SqlServerJobExecutionStepTargetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerJobExecutionStepTargetResource> GetJobTargetExecutionsAsync(SqlServerJobExecutionCollectionGetJobTargetExecutionsOptions options, CancellationToken cancellationToken = default)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient.CreateListByJobExecutionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, options.JobExecutionId, options.CreateTimeMin, options.CreateTimeMax, options.EndTimeMin, options.EndTimeMax, options.IsActive, options.Skip, options.Top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient.CreateListByJobExecutionNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, options.JobExecutionId, options.CreateTimeMin, options.CreateTimeMax, options.EndTimeMin, options.EndTimeMax, options.IsActive, options.Skip, options.Top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SqlServerJobExecutionStepTargetResource(Client, SqlServerJobExecutionData.DeserializeSqlServerJobExecutionData(e)), _sqlServerJobExecutionStepTargetJobTargetExecutionsClientDiagnostics, Pipeline, "SqlServerJobExecutionCollection.GetJobTargetExecutions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists target executions for all steps of a job execution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}/targets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobTargetExecutions_ListByJobExecution</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerJobExecutionStepTargetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        /// <returns> A collection of <see cref="SqlServerJobExecutionStepTargetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerJobExecutionStepTargetResource> GetJobTargetExecutions(SqlServerJobExecutionCollectionGetJobTargetExecutionsOptions options, CancellationToken cancellationToken = default)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient.CreateListByJobExecutionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, options.JobExecutionId, options.CreateTimeMin, options.CreateTimeMax, options.EndTimeMin, options.EndTimeMax, options.IsActive, options.Skip, options.Top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerJobExecutionStepTargetJobTargetExecutionsRestClient.CreateListByJobExecutionNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, options.JobExecutionId, options.CreateTimeMin, options.CreateTimeMax, options.EndTimeMin, options.EndTimeMax, options.IsActive, options.Skip, options.Top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SqlServerJobExecutionStepTargetResource(Client, SqlServerJobExecutionData.DeserializeSqlServerJobExecutionData(e)), _sqlServerJobExecutionStepTargetJobTargetExecutionsClientDiagnostics, Pipeline, "SqlServerJobExecutionCollection.GetJobTargetExecutions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobExecutions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerJobExecutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionJobExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerJobExecutionJobExecutionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobExecutions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerJobExecutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionJobExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerJobExecutionJobExecutionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobExecutions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerJobExecutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<SqlServerJobExecutionResource>> GetIfExistsAsync(Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionJobExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlServerJobExecutionJobExecutionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerJobExecutionResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobExecutionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/executions/{jobExecutionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobExecutions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerJobExecutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<SqlServerJobExecutionResource> GetIfExists(Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobExecutionJobExecutionsClientDiagnostics.CreateScope("SqlServerJobExecutionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlServerJobExecutionJobExecutionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobExecutionId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerJobExecutionResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobExecutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerJobExecutionResource> IEnumerable<SqlServerJobExecutionResource>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<SqlServerJobExecutionResource> IAsyncEnumerable<SqlServerJobExecutionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
