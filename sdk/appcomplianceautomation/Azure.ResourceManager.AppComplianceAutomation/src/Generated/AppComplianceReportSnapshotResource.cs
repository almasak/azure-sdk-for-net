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
using Azure.ResourceManager.AppComplianceAutomation.Models;

namespace Azure.ResourceManager.AppComplianceAutomation
{
    /// <summary>
    /// A Class representing an AppComplianceReportSnapshot along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AppComplianceReportSnapshotResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAppComplianceReportSnapshotResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppComplianceReportResource"/> using the GetAppComplianceReportSnapshot method.
    /// </summary>
    public partial class AppComplianceReportSnapshotResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AppComplianceReportSnapshotResource"/> instance. </summary>
        /// <param name="reportName"> The reportName. </param>
        /// <param name="snapshotName"> The snapshotName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string reportName, string snapshotName)
        {
            var resourceId = $"/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots/{snapshotName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _appComplianceReportSnapshotSnapshotClientDiagnostics;
        private readonly SnapshotRestOperations _appComplianceReportSnapshotSnapshotRestClient;
        private readonly AppComplianceReportSnapshotData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AppComplianceAutomation/reports/snapshots";

        /// <summary> Initializes a new instance of the <see cref="AppComplianceReportSnapshotResource"/> class for mocking. </summary>
        protected AppComplianceReportSnapshotResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppComplianceReportSnapshotResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AppComplianceReportSnapshotResource(ArmClient client, AppComplianceReportSnapshotData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AppComplianceReportSnapshotResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AppComplianceReportSnapshotResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appComplianceReportSnapshotSnapshotClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppComplianceAutomation", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string appComplianceReportSnapshotSnapshotApiVersion);
            _appComplianceReportSnapshotSnapshotRestClient = new SnapshotRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appComplianceReportSnapshotSnapshotApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AppComplianceReportSnapshotData Data
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
        /// Get the AppComplianceAutomation snapshot and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshot_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-27</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppComplianceReportSnapshotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AppComplianceReportSnapshotResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _appComplianceReportSnapshotSnapshotClientDiagnostics.CreateScope("AppComplianceReportSnapshotResource.Get");
            scope.Start();
            try
            {
                var response = await _appComplianceReportSnapshotSnapshotRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppComplianceReportSnapshotResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the AppComplianceAutomation snapshot and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshot_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-27</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppComplianceReportSnapshotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AppComplianceReportSnapshotResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _appComplianceReportSnapshotSnapshotClientDiagnostics.CreateScope("AppComplianceReportSnapshotResource.Get");
            scope.Start();
            try
            {
                var response = _appComplianceReportSnapshotSnapshotRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppComplianceReportSnapshotResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Download compliance needs from snapshot, like: Compliance Report, Resource List.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots/{snapshotName}/download</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshot_Download</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-27</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppComplianceReportSnapshotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Parameters for the query operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<AppComplianceDownloadResult>> DownloadAsync(WaitUntil waitUntil, SnapshotDownloadRequestContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _appComplianceReportSnapshotSnapshotClientDiagnostics.CreateScope("AppComplianceReportSnapshotResource.Download");
            scope.Start();
            try
            {
                var response = await _appComplianceReportSnapshotSnapshotRestClient.DownloadAsync(Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new AppComplianceAutomationArmOperation<AppComplianceDownloadResult>(new AppComplianceDownloadResultOperationSource(), _appComplianceReportSnapshotSnapshotClientDiagnostics, Pipeline, _appComplianceReportSnapshotSnapshotRestClient.CreateDownloadRequest(Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
        /// Download compliance needs from snapshot, like: Compliance Report, Resource List.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots/{snapshotName}/download</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshot_Download</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-27</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppComplianceReportSnapshotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Parameters for the query operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<AppComplianceDownloadResult> Download(WaitUntil waitUntil, SnapshotDownloadRequestContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _appComplianceReportSnapshotSnapshotClientDiagnostics.CreateScope("AppComplianceReportSnapshotResource.Download");
            scope.Start();
            try
            {
                var response = _appComplianceReportSnapshotSnapshotRestClient.Download(Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new AppComplianceAutomationArmOperation<AppComplianceDownloadResult>(new AppComplianceDownloadResultOperationSource(), _appComplianceReportSnapshotSnapshotClientDiagnostics, Pipeline, _appComplianceReportSnapshotSnapshotRestClient.CreateDownloadRequest(Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
