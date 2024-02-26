// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Verticals.AgriFood.Farming
{
    // Data plane generated sub-client.
    /// <summary> The SensorDataModels sub-client. </summary>
    public partial class SensorDataModels
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of SensorDataModels for mocking. </summary>
        protected SensorDataModels()
        {
        }

        /// <summary> Initializes a new instance of SensorDataModels. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="tokenCredential"> The token credential to copy. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal SensorDataModels(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, TokenCredential tokenCredential, Uri endpoint, string apiVersion)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _tokenCredential = tokenCredential;
            _endpoint = endpoint;
            _apiVersion = apiVersion;
        }

        /// <summary>
        /// [Protocol Method] Create a sensor data model entity.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensorPartnerId"> Id of the sensor partner. </param>
        /// <param name="sensorDataModelId"> Id of the sensor data model. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sensorPartnerId"/>, <paramref name="sensorDataModelId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sensorPartnerId"/> or <paramref name="sensorDataModelId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/SensorDataModels.xml" path="doc/members/member[@name='CreateOrUpdateAsync(string,string,RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> CreateOrUpdateAsync(string sensorPartnerId, string sensorDataModelId, RequestContent content, RequestContext context = null)
        {
            if (sensorPartnerId == null)
            {
                throw new ArgumentNullException(nameof(sensorPartnerId));
            }
            if (sensorPartnerId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sensorPartnerId));
            }
            if (sensorDataModelId == null)
            {
                throw new ArgumentNullException(nameof(sensorDataModelId));
            }
            if (sensorDataModelId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sensorDataModelId));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = ClientDiagnostics.CreateScope("SensorDataModels.CreateOrUpdate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateRequest(sensorPartnerId, sensorDataModelId, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Create a sensor data model entity.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensorPartnerId"> Id of the sensor partner. </param>
        /// <param name="sensorDataModelId"> Id of the sensor data model. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sensorPartnerId"/>, <paramref name="sensorDataModelId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sensorPartnerId"/> or <paramref name="sensorDataModelId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/SensorDataModels.xml" path="doc/members/member[@name='CreateOrUpdate(string,string,RequestContent,RequestContext)']/*" />
        public virtual Response CreateOrUpdate(string sensorPartnerId, string sensorDataModelId, RequestContent content, RequestContext context = null)
        {
            if (sensorPartnerId == null)
            {
                throw new ArgumentNullException(nameof(sensorPartnerId));
            }
            if (sensorPartnerId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sensorPartnerId));
            }
            if (sensorDataModelId == null)
            {
                throw new ArgumentNullException(nameof(sensorDataModelId));
            }
            if (sensorDataModelId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sensorDataModelId));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = ClientDiagnostics.CreateScope("SensorDataModels.CreateOrUpdate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateRequest(sensorPartnerId, sensorDataModelId, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets a sensor data model entity.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensorPartnerId"> Id of the sensor partner. </param>
        /// <param name="sensorDataModelId"> Id of the sensor data model resource. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sensorPartnerId"/> or <paramref name="sensorDataModelId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sensorPartnerId"/> or <paramref name="sensorDataModelId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/SensorDataModels.xml" path="doc/members/member[@name='GetSensorDataModelAsync(string,string,RequestContext)']/*" />
        public virtual async Task<Response> GetSensorDataModelAsync(string sensorPartnerId, string sensorDataModelId, RequestContext context)
        {
            if (sensorPartnerId == null)
            {
                throw new ArgumentNullException(nameof(sensorPartnerId));
            }
            if (sensorPartnerId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sensorPartnerId));
            }
            if (sensorDataModelId == null)
            {
                throw new ArgumentNullException(nameof(sensorDataModelId));
            }
            if (sensorDataModelId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sensorDataModelId));
            }

            using var scope = ClientDiagnostics.CreateScope("SensorDataModels.GetSensorDataModel");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetSensorDataModelRequest(sensorPartnerId, sensorDataModelId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets a sensor data model entity.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensorPartnerId"> Id of the sensor partner. </param>
        /// <param name="sensorDataModelId"> Id of the sensor data model resource. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sensorPartnerId"/> or <paramref name="sensorDataModelId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sensorPartnerId"/> or <paramref name="sensorDataModelId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/SensorDataModels.xml" path="doc/members/member[@name='GetSensorDataModel(string,string,RequestContext)']/*" />
        public virtual Response GetSensorDataModel(string sensorPartnerId, string sensorDataModelId, RequestContext context)
        {
            if (sensorPartnerId == null)
            {
                throw new ArgumentNullException(nameof(sensorPartnerId));
            }
            if (sensorPartnerId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sensorPartnerId));
            }
            if (sensorDataModelId == null)
            {
                throw new ArgumentNullException(nameof(sensorDataModelId));
            }
            if (sensorDataModelId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sensorDataModelId));
            }

            using var scope = ClientDiagnostics.CreateScope("SensorDataModels.GetSensorDataModel");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetSensorDataModelRequest(sensorPartnerId, sensorDataModelId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Deletes a sensor data model entity.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensorPartnerId"> Id of the sensor partner. </param>
        /// <param name="sensorDataModelId"> Id of the sensor data model resource. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sensorPartnerId"/> or <paramref name="sensorDataModelId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sensorPartnerId"/> or <paramref name="sensorDataModelId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/SensorDataModels.xml" path="doc/members/member[@name='DeleteAsync(string,string,RequestContext)']/*" />
        public virtual async Task<Response> DeleteAsync(string sensorPartnerId, string sensorDataModelId, RequestContext context = null)
        {
            if (sensorPartnerId == null)
            {
                throw new ArgumentNullException(nameof(sensorPartnerId));
            }
            if (sensorPartnerId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sensorPartnerId));
            }
            if (sensorDataModelId == null)
            {
                throw new ArgumentNullException(nameof(sensorDataModelId));
            }
            if (sensorDataModelId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sensorDataModelId));
            }

            using var scope = ClientDiagnostics.CreateScope("SensorDataModels.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(sensorPartnerId, sensorDataModelId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Deletes a sensor data model entity.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensorPartnerId"> Id of the sensor partner. </param>
        /// <param name="sensorDataModelId"> Id of the sensor data model resource. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sensorPartnerId"/> or <paramref name="sensorDataModelId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sensorPartnerId"/> or <paramref name="sensorDataModelId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/SensorDataModels.xml" path="doc/members/member[@name='Delete(string,string,RequestContext)']/*" />
        public virtual Response Delete(string sensorPartnerId, string sensorDataModelId, RequestContext context = null)
        {
            if (sensorPartnerId == null)
            {
                throw new ArgumentNullException(nameof(sensorPartnerId));
            }
            if (sensorPartnerId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sensorPartnerId));
            }
            if (sensorDataModelId == null)
            {
                throw new ArgumentNullException(nameof(sensorDataModelId));
            }
            if (sensorDataModelId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sensorDataModelId));
            }

            using var scope = ClientDiagnostics.CreateScope("SensorDataModels.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(sensorPartnerId, sensorDataModelId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Returns a paginated list of sensor data model resources.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensorPartnerId"> Id of the associated sensor partner. </param>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// eg. "{testKey} eq {testValue}".
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sensorPartnerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sensorPartnerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="AsyncPageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/SensorDataModels.xml" path="doc/members/member[@name='GetSensorDataModelsAsync(string,IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,int?,string,RequestContext)']/*" />
        public virtual AsyncPageable<BinaryData> GetSensorDataModelsAsync(string sensorPartnerId, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            if (sensorPartnerId == null)
            {
                throw new ArgumentNullException(nameof(sensorPartnerId));
            }
            if (sensorPartnerId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sensorPartnerId));
            }

            HttpMessage FirstPageRequest(int? pageSizeHint) => CreateGetSensorDataModelsRequest(sensorPartnerId, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CreateGetSensorDataModelsNextPageRequest(nextLink, sensorPartnerId, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => BinaryData.FromString(e.GetRawText()), ClientDiagnostics, _pipeline, "SensorDataModels.GetSensorDataModels", "value", "nextLink", context);
        }

        /// <summary>
        /// [Protocol Method] Returns a paginated list of sensor data model resources.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sensorPartnerId"> Id of the associated sensor partner. </param>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// eg. "{testKey} eq {testValue}".
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sensorPartnerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sensorPartnerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Pageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/SensorDataModels.xml" path="doc/members/member[@name='GetSensorDataModels(string,IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,int?,string,RequestContext)']/*" />
        public virtual Pageable<BinaryData> GetSensorDataModels(string sensorPartnerId, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            if (sensorPartnerId == null)
            {
                throw new ArgumentNullException(nameof(sensorPartnerId));
            }
            if (sensorPartnerId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sensorPartnerId));
            }

            HttpMessage FirstPageRequest(int? pageSizeHint) => CreateGetSensorDataModelsRequest(sensorPartnerId, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CreateGetSensorDataModelsNextPageRequest(nextLink, sensorPartnerId, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => BinaryData.FromString(e.GetRawText()), ClientDiagnostics, _pipeline, "SensorDataModels.GetSensorDataModels", "value", "nextLink", context);
        }

        internal HttpMessage CreateGetSensorDataModelsRequest(string sensorPartnerId, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sensor-partners/", false);
            uri.AppendPath(sensorPartnerId, true);
            uri.AppendPath("/sensor-data-models", false);
            if (ids != null && !(ids is ChangeTrackingList<string> changeTrackingList && changeTrackingList.IsUndefined))
            {
                foreach (var param in ids)
                {
                    uri.AppendQuery("ids", param, true);
                }
            }
            if (names != null && !(names is ChangeTrackingList<string> changeTrackingList0 && changeTrackingList0.IsUndefined))
            {
                foreach (var param in names)
                {
                    uri.AppendQuery("names", param, true);
                }
            }
            if (propertyFilters != null && !(propertyFilters is ChangeTrackingList<string> changeTrackingList1 && changeTrackingList1.IsUndefined))
            {
                foreach (var param in propertyFilters)
                {
                    uri.AppendQuery("propertyFilters", param, true);
                }
            }
            if (statuses != null && !(statuses is ChangeTrackingList<string> changeTrackingList2 && changeTrackingList2.IsUndefined))
            {
                foreach (var param in statuses)
                {
                    uri.AppendQuery("statuses", param, true);
                }
            }
            if (minCreatedDateTime != null)
            {
                uri.AppendQuery("minCreatedDateTime", minCreatedDateTime.Value, "O", true);
            }
            if (maxCreatedDateTime != null)
            {
                uri.AppendQuery("maxCreatedDateTime", maxCreatedDateTime.Value, "O", true);
            }
            if (minLastModifiedDateTime != null)
            {
                uri.AppendQuery("minLastModifiedDateTime", minLastModifiedDateTime.Value, "O", true);
            }
            if (maxLastModifiedDateTime != null)
            {
                uri.AppendQuery("maxLastModifiedDateTime", maxLastModifiedDateTime.Value, "O", true);
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("maxPageSize", maxPageSize.Value, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("skipToken", skipToken, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string sensorPartnerId, string sensorDataModelId, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200201);
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sensor-partners/", false);
            uri.AppendPath(sensorPartnerId, true);
            uri.AppendPath("/sensor-data-models/", false);
            uri.AppendPath(sensorDataModelId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/merge-patch+json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetSensorDataModelRequest(string sensorPartnerId, string sensorDataModelId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sensor-partners/", false);
            uri.AppendPath(sensorPartnerId, true);
            uri.AppendPath("/sensor-data-models/", false);
            uri.AppendPath(sensorDataModelId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateDeleteRequest(string sensorPartnerId, string sensorDataModelId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sensor-partners/", false);
            uri.AppendPath(sensorPartnerId, true);
            uri.AppendPath("/sensor-data-models/", false);
            uri.AppendPath(sensorDataModelId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetSensorDataModelsNextPageRequest(string nextLink, string sensorPartnerId, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
        private static ResponseClassifier _responseClassifier200201;
        private static ResponseClassifier ResponseClassifier200201 => _responseClassifier200201 ??= new StatusCodeClassifier(stackalloc ushort[] { 200, 201 });
        private static ResponseClassifier _responseClassifier204;
        private static ResponseClassifier ResponseClassifier204 => _responseClassifier204 ??= new StatusCodeClassifier(stackalloc ushort[] { 204 });
    }
}
