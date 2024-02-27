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

namespace Azure.ResourceManager.MySql
{
    /// <summary>
    /// A Class representing a MySqlAdvisor along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="MySqlAdvisorResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetMySqlAdvisorResource method.
    /// Otherwise you can get one from its parent resource <see cref="MySqlServerResource"/> using the GetMySqlAdvisor method.
    /// </summary>
    public partial class MySqlAdvisorResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MySqlAdvisorResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serverName"> The serverName. </param>
        /// <param name="advisorName"> The advisorName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string advisorName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/advisors/{advisorName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _mySqlAdvisorAdvisorsClientDiagnostics;
        private readonly AdvisorsRestOperations _mySqlAdvisorAdvisorsRestClient;
        private readonly ClientDiagnostics _defaultClientDiagnostics;
        private readonly MySQLManagementRestOperations _defaultRestClient;
        private readonly MySqlAdvisorData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DBforMySQL/servers/advisors";

        /// <summary> Initializes a new instance of the <see cref="MySqlAdvisorResource"/> class for mocking. </summary>
        protected MySqlAdvisorResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MySqlAdvisorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MySqlAdvisorResource(ArmClient client, MySqlAdvisorData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MySqlAdvisorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MySqlAdvisorResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mySqlAdvisorAdvisorsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string mySqlAdvisorAdvisorsApiVersion);
            _mySqlAdvisorAdvisorsRestClient = new AdvisorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mySqlAdvisorAdvisorsApiVersion);
            _defaultClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _defaultRestClient = new MySQLManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MySqlAdvisorData Data
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

        /// <summary> Gets a collection of MySqlRecommendationActionResources in the MySqlAdvisor. </summary>
        /// <returns> An object representing collection of MySqlRecommendationActionResources and their operations over a MySqlRecommendationActionResource. </returns>
        public virtual MySqlRecommendationActionCollection GetMySqlRecommendationActions()
        {
            return GetCachedClient(client => new MySqlRecommendationActionCollection(client, Id));
        }

        /// <summary>
        /// Retrieve recommended actions from the advisor.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/advisors/{advisorName}/recommendedActions/{recommendedActionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecommendedActions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlRecommendationActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recommendedActionName"> The recommended action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendedActionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="recommendedActionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MySqlRecommendationActionResource>> GetMySqlRecommendationActionAsync(string recommendedActionName, CancellationToken cancellationToken = default)
        {
            return await GetMySqlRecommendationActions().GetAsync(recommendedActionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieve recommended actions from the advisor.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/advisors/{advisorName}/recommendedActions/{recommendedActionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecommendedActions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlRecommendationActionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="recommendedActionName"> The recommended action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recommendedActionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="recommendedActionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<MySqlRecommendationActionResource> GetMySqlRecommendationAction(string recommendedActionName, CancellationToken cancellationToken = default)
        {
            return GetMySqlRecommendationActions().Get(recommendedActionName, cancellationToken);
        }

        /// <summary>
        /// Get a recommendation action advisor.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/advisors/{advisorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Advisors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlAdvisorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MySqlAdvisorResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _mySqlAdvisorAdvisorsClientDiagnostics.CreateScope("MySqlAdvisorResource.Get");
            scope.Start();
            try
            {
                var response = await _mySqlAdvisorAdvisorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlAdvisorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a recommendation action advisor.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/advisors/{advisorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Advisors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MySqlAdvisorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MySqlAdvisorResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _mySqlAdvisorAdvisorsClientDiagnostics.CreateScope("MySqlAdvisorResource.Get");
            scope.Start();
            try
            {
                var response = _mySqlAdvisorAdvisorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlAdvisorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create recommendation action session for the advisor.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/advisors/{advisorName}/createRecommendedActionSession</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CreateRecommendedActionSession</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual async Task<ArmOperation> CreateRecommendedActionSessionAsync(WaitUntil waitUntil, string databaseName, CancellationToken cancellationToken = default)
        {
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            using var scope = _defaultClientDiagnostics.CreateScope("MySqlAdvisorResource.CreateRecommendedActionSession");
            scope.Start();
            try
            {
                var response = await _defaultRestClient.CreateRecommendedActionSessionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, databaseName, cancellationToken).ConfigureAwait(false);
                var operation = new MySqlArmOperation(_defaultClientDiagnostics, Pipeline, _defaultRestClient.CreateCreateRecommendedActionSessionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, databaseName).Request, response, OperationFinalStateVia.Location);
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
        /// Create recommendation action session for the advisor.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/advisors/{advisorName}/createRecommendedActionSession</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CreateRecommendedActionSession</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual ArmOperation CreateRecommendedActionSession(WaitUntil waitUntil, string databaseName, CancellationToken cancellationToken = default)
        {
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            using var scope = _defaultClientDiagnostics.CreateScope("MySqlAdvisorResource.CreateRecommendedActionSession");
            scope.Start();
            try
            {
                var response = _defaultRestClient.CreateRecommendedActionSession(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, databaseName, cancellationToken);
                var operation = new MySqlArmOperation(_defaultClientDiagnostics, Pipeline, _defaultRestClient.CreateCreateRecommendedActionSessionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, databaseName).Request, response, OperationFinalStateVia.Location);
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
    }
}
