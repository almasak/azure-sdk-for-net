// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> The operation to create or update the extension. </summary>
    public partial class VirtualMachineExtensionsCreateOrUpdateOperation : Operation<VirtualMachineExtensionVirtualMachine>, IOperationSource<VirtualMachineExtensionVirtualMachine>
    {
        private readonly OperationInternals<VirtualMachineExtensionVirtualMachine> _operation;

        private readonly OperationsBase _operationBase;

        /// <summary> Initializes a new instance of VirtualMachineExtensionsCreateOrUpdateOperation for mocking. </summary>
        protected VirtualMachineExtensionsCreateOrUpdateOperation()
        {
        }

        internal VirtualMachineExtensionsCreateOrUpdateOperation(OperationsBase operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VirtualMachineExtensionVirtualMachine>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "VirtualMachineExtensionsCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VirtualMachineExtensionVirtualMachine Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualMachineExtensionVirtualMachine>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualMachineExtensionVirtualMachine>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VirtualMachineExtensionVirtualMachine IOperationSource<VirtualMachineExtensionVirtualMachine>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new VirtualMachineExtensionVirtualMachine(_operationBase, VirtualMachineExtensionData.DeserializeVirtualMachineExtensionData(document.RootElement));
        }

        async ValueTask<VirtualMachineExtensionVirtualMachine> IOperationSource<VirtualMachineExtensionVirtualMachine>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new VirtualMachineExtensionVirtualMachine(_operationBase, VirtualMachineExtensionData.DeserializeVirtualMachineExtensionData(document.RootElement));
        }
    }
}
