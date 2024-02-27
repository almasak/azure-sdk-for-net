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

namespace Azure.ResourceManager.HealthcareApis
{
    /// <summary>
    /// A Class representing a HealthcareApisIotFhirDestination along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="HealthcareApisIotFhirDestinationResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetHealthcareApisIotFhirDestinationResource method.
    /// Otherwise you can get one from its parent resource <see cref="HealthcareApisIotConnectorResource"/> using the GetHealthcareApisIotFhirDestination method.
    /// </summary>
    public partial class HealthcareApisIotFhirDestinationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HealthcareApisIotFhirDestinationResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="workspaceName"> The workspaceName. </param>
        /// <param name="iotConnectorName"> The iotConnectorName. </param>
        /// <param name="fhirDestinationName"> The fhirDestinationName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string iotConnectorName, string fhirDestinationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _healthcareApisIotFhirDestinationIotConnectorFhirDestinationClientDiagnostics;
        private readonly IotConnectorFhirDestinationRestOperations _healthcareApisIotFhirDestinationIotConnectorFhirDestinationRestClient;
        private readonly HealthcareApisIotFhirDestinationData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.HealthcareApis/workspaces/iotconnectors/fhirdestinations";

        /// <summary> Initializes a new instance of the <see cref="HealthcareApisIotFhirDestinationResource"/> class for mocking. </summary>
        protected HealthcareApisIotFhirDestinationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HealthcareApisIotFhirDestinationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal HealthcareApisIotFhirDestinationResource(ArmClient client, HealthcareApisIotFhirDestinationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="HealthcareApisIotFhirDestinationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HealthcareApisIotFhirDestinationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _healthcareApisIotFhirDestinationIotConnectorFhirDestinationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HealthcareApis", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string healthcareApisIotFhirDestinationIotConnectorFhirDestinationApiVersion);
            _healthcareApisIotFhirDestinationIotConnectorFhirDestinationRestClient = new IotConnectorFhirDestinationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, healthcareApisIotFhirDestinationIotConnectorFhirDestinationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual HealthcareApisIotFhirDestinationData Data
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
        /// Gets the properties of the specified Iot Connector FHIR destination.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotConnectorFhirDestination_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HealthcareApisIotFhirDestinationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HealthcareApisIotFhirDestinationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _healthcareApisIotFhirDestinationIotConnectorFhirDestinationClientDiagnostics.CreateScope("HealthcareApisIotFhirDestinationResource.Get");
            scope.Start();
            try
            {
                var response = await _healthcareApisIotFhirDestinationIotConnectorFhirDestinationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HealthcareApisIotFhirDestinationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified Iot Connector FHIR destination.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotConnectorFhirDestination_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HealthcareApisIotFhirDestinationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HealthcareApisIotFhirDestinationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _healthcareApisIotFhirDestinationIotConnectorFhirDestinationClientDiagnostics.CreateScope("HealthcareApisIotFhirDestinationResource.Get");
            scope.Start();
            try
            {
                var response = _healthcareApisIotFhirDestinationIotConnectorFhirDestinationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HealthcareApisIotFhirDestinationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an IoT Connector FHIR destination.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotConnectorFhirDestination_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HealthcareApisIotFhirDestinationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _healthcareApisIotFhirDestinationIotConnectorFhirDestinationClientDiagnostics.CreateScope("HealthcareApisIotFhirDestinationResource.Delete");
            scope.Start();
            try
            {
                var response = await _healthcareApisIotFhirDestinationIotConnectorFhirDestinationRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new HealthcareApisArmOperation(_healthcareApisIotFhirDestinationIotConnectorFhirDestinationClientDiagnostics, Pipeline, _healthcareApisIotFhirDestinationIotConnectorFhirDestinationRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes an IoT Connector FHIR destination.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotConnectorFhirDestination_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HealthcareApisIotFhirDestinationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _healthcareApisIotFhirDestinationIotConnectorFhirDestinationClientDiagnostics.CreateScope("HealthcareApisIotFhirDestinationResource.Delete");
            scope.Start();
            try
            {
                var response = _healthcareApisIotFhirDestinationIotConnectorFhirDestinationRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new HealthcareApisArmOperation(_healthcareApisIotFhirDestinationIotConnectorFhirDestinationClientDiagnostics, Pipeline, _healthcareApisIotFhirDestinationIotConnectorFhirDestinationRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an IoT Connector FHIR destination resource with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotConnectorFhirDestination_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HealthcareApisIotFhirDestinationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The parameters for creating or updating an IoT Connector FHIR destination resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HealthcareApisIotFhirDestinationResource>> UpdateAsync(WaitUntil waitUntil, HealthcareApisIotFhirDestinationData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _healthcareApisIotFhirDestinationIotConnectorFhirDestinationClientDiagnostics.CreateScope("HealthcareApisIotFhirDestinationResource.Update");
            scope.Start();
            try
            {
                var response = await _healthcareApisIotFhirDestinationIotConnectorFhirDestinationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new HealthcareApisArmOperation<HealthcareApisIotFhirDestinationResource>(new HealthcareApisIotFhirDestinationOperationSource(Client), _healthcareApisIotFhirDestinationIotConnectorFhirDestinationClientDiagnostics, Pipeline, _healthcareApisIotFhirDestinationIotConnectorFhirDestinationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an IoT Connector FHIR destination resource with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotconnectors/{iotConnectorName}/fhirdestinations/{fhirDestinationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotConnectorFhirDestination_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HealthcareApisIotFhirDestinationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The parameters for creating or updating an IoT Connector FHIR destination resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HealthcareApisIotFhirDestinationResource> Update(WaitUntil waitUntil, HealthcareApisIotFhirDestinationData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _healthcareApisIotFhirDestinationIotConnectorFhirDestinationClientDiagnostics.CreateScope("HealthcareApisIotFhirDestinationResource.Update");
            scope.Start();
            try
            {
                var response = _healthcareApisIotFhirDestinationIotConnectorFhirDestinationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new HealthcareApisArmOperation<HealthcareApisIotFhirDestinationResource>(new HealthcareApisIotFhirDestinationOperationSource(Client), _healthcareApisIotFhirDestinationIotConnectorFhirDestinationClientDiagnostics, Pipeline, _healthcareApisIotFhirDestinationIotConnectorFhirDestinationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
