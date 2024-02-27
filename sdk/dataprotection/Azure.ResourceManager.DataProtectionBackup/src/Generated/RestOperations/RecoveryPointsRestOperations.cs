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
using Azure.ResourceManager.DataProtectionBackup.Models;

namespace Azure.ResourceManager.DataProtectionBackup
{
    internal partial class RecoveryPointsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of RecoveryPointsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public RecoveryPointsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-11-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string vaultName, string backupInstanceName, string filter, string skipToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataProtection/backupVaults/", false);
            uri.AppendPath(vaultName, true);
            uri.AppendPath("/backupInstances/", false);
            uri.AppendPath(backupInstanceName, true);
            uri.AppendPath("/recoveryPoints", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Returns a list of Recovery Points for a DataSource in a vault. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="backupInstanceName"> The name of the backup instance. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="skipToken"> skipToken Filter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/> or <paramref name="backupInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/> or <paramref name="backupInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AzureBackupRecoveryPointResourceList>> ListAsync(string subscriptionId, string resourceGroupName, string vaultName, string backupInstanceName, string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (backupInstanceName == null)
            {
                throw new ArgumentNullException(nameof(backupInstanceName));
            }
            if (backupInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(backupInstanceName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, vaultName, backupInstanceName, filter, skipToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureBackupRecoveryPointResourceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AzureBackupRecoveryPointResourceList.DeserializeAzureBackupRecoveryPointResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns a list of Recovery Points for a DataSource in a vault. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="backupInstanceName"> The name of the backup instance. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="skipToken"> skipToken Filter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/> or <paramref name="backupInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/> or <paramref name="backupInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AzureBackupRecoveryPointResourceList> List(string subscriptionId, string resourceGroupName, string vaultName, string backupInstanceName, string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (backupInstanceName == null)
            {
                throw new ArgumentNullException(nameof(backupInstanceName));
            }
            if (backupInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(backupInstanceName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, vaultName, backupInstanceName, filter, skipToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureBackupRecoveryPointResourceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AzureBackupRecoveryPointResourceList.DeserializeAzureBackupRecoveryPointResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string vaultName, string backupInstanceName, string recoveryPointId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataProtection/backupVaults/", false);
            uri.AppendPath(vaultName, true);
            uri.AppendPath("/backupInstances/", false);
            uri.AppendPath(backupInstanceName, true);
            uri.AppendPath("/recoveryPoints/", false);
            uri.AppendPath(recoveryPointId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a Recovery Point using recoveryPointId for a Datasource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="backupInstanceName"> The name of the backup instance. </param>
        /// <param name="recoveryPointId"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="backupInstanceName"/> or <paramref name="recoveryPointId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="backupInstanceName"/> or <paramref name="recoveryPointId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataProtectionBackupRecoveryPointData>> GetAsync(string subscriptionId, string resourceGroupName, string vaultName, string backupInstanceName, string recoveryPointId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (backupInstanceName == null)
            {
                throw new ArgumentNullException(nameof(backupInstanceName));
            }
            if (backupInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(backupInstanceName));
            }
            if (recoveryPointId == null)
            {
                throw new ArgumentNullException(nameof(recoveryPointId));
            }
            if (recoveryPointId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(recoveryPointId));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, vaultName, backupInstanceName, recoveryPointId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataProtectionBackupRecoveryPointData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataProtectionBackupRecoveryPointData.DeserializeDataProtectionBackupRecoveryPointData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DataProtectionBackupRecoveryPointData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a Recovery Point using recoveryPointId for a Datasource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="backupInstanceName"> The name of the backup instance. </param>
        /// <param name="recoveryPointId"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="backupInstanceName"/> or <paramref name="recoveryPointId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="backupInstanceName"/> or <paramref name="recoveryPointId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataProtectionBackupRecoveryPointData> Get(string subscriptionId, string resourceGroupName, string vaultName, string backupInstanceName, string recoveryPointId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (backupInstanceName == null)
            {
                throw new ArgumentNullException(nameof(backupInstanceName));
            }
            if (backupInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(backupInstanceName));
            }
            if (recoveryPointId == null)
            {
                throw new ArgumentNullException(nameof(recoveryPointId));
            }
            if (recoveryPointId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(recoveryPointId));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, vaultName, backupInstanceName, recoveryPointId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataProtectionBackupRecoveryPointData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataProtectionBackupRecoveryPointData.DeserializeDataProtectionBackupRecoveryPointData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DataProtectionBackupRecoveryPointData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string vaultName, string backupInstanceName, string filter, string skipToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Returns a list of Recovery Points for a DataSource in a vault. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="backupInstanceName"> The name of the backup instance. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="skipToken"> skipToken Filter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/> or <paramref name="backupInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/> or <paramref name="backupInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AzureBackupRecoveryPointResourceList>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string vaultName, string backupInstanceName, string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (backupInstanceName == null)
            {
                throw new ArgumentNullException(nameof(backupInstanceName));
            }
            if (backupInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(backupInstanceName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, vaultName, backupInstanceName, filter, skipToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureBackupRecoveryPointResourceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AzureBackupRecoveryPointResourceList.DeserializeAzureBackupRecoveryPointResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns a list of Recovery Points for a DataSource in a vault. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="backupInstanceName"> The name of the backup instance. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="skipToken"> skipToken Filter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/> or <paramref name="backupInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/> or <paramref name="backupInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AzureBackupRecoveryPointResourceList> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string vaultName, string backupInstanceName, string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (backupInstanceName == null)
            {
                throw new ArgumentNullException(nameof(backupInstanceName));
            }
            if (backupInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(backupInstanceName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, vaultName, backupInstanceName, filter, skipToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureBackupRecoveryPointResourceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AzureBackupRecoveryPointResourceList.DeserializeAzureBackupRecoveryPointResourceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
