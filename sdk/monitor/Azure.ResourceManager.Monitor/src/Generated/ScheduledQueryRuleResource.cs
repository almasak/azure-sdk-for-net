// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Monitor.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A Class representing a ScheduledQueryRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ScheduledQueryRuleResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetScheduledQueryRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource"/> using the GetScheduledQueryRule method.
    /// </summary>
    public partial class ScheduledQueryRuleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ScheduledQueryRuleResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="ruleName"> The ruleName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string ruleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _scheduledQueryRuleClientDiagnostics;
        private readonly ScheduledQueryRulesRestOperations _scheduledQueryRuleRestClient;
        private readonly ScheduledQueryRuleData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Insights/scheduledQueryRules";

        /// <summary> Initializes a new instance of the <see cref="ScheduledQueryRuleResource"/> class for mocking. </summary>
        protected ScheduledQueryRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScheduledQueryRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ScheduledQueryRuleResource(ArmClient client, ScheduledQueryRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ScheduledQueryRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ScheduledQueryRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scheduledQueryRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string scheduledQueryRuleApiVersion);
            _scheduledQueryRuleRestClient = new ScheduledQueryRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scheduledQueryRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ScheduledQueryRuleData Data
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
        /// Retrieve an scheduled query rule definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledQueryRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledQueryRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ScheduledQueryRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _scheduledQueryRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScheduledQueryRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve an scheduled query rule definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledQueryRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledQueryRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ScheduledQueryRuleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleResource.Get");
            scope.Start();
            try
            {
                var response = _scheduledQueryRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScheduledQueryRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a scheduled query rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledQueryRules_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledQueryRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleResource.Delete");
            scope.Start();
            try
            {
                var response = await _scheduledQueryRuleRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MonitorArmOperation(response);
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
        /// Deletes a scheduled query rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledQueryRules_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledQueryRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleResource.Delete");
            scope.Start();
            try
            {
                var response = _scheduledQueryRuleRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new MonitorArmOperation(response);
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
        /// Update a scheduled query rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledQueryRules_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledQueryRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> The parameters of the rule to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<ScheduledQueryRuleResource>> UpdateAsync(ScheduledQueryRulePatch patch, CancellationToken cancellationToken = default)
        {
            if (patch == null)
            {
                throw new ArgumentNullException(nameof(patch));
            }

            using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleResource.Update");
            scope.Start();
            try
            {
                var response = await _scheduledQueryRuleRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ScheduledQueryRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update a scheduled query rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledQueryRules_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledQueryRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> The parameters of the rule to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<ScheduledQueryRuleResource> Update(ScheduledQueryRulePatch patch, CancellationToken cancellationToken = default)
        {
            if (patch == null)
            {
                throw new ArgumentNullException(nameof(patch));
            }

            using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleResource.Update");
            scope.Start();
            try
            {
                var response = _scheduledQueryRuleRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch, cancellationToken);
                return Response.FromValue(new ScheduledQueryRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledQueryRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledQueryRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<ScheduledQueryRuleResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleResource.AddTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues[key] = value;
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _scheduledQueryRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new ScheduledQueryRuleResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new ScheduledQueryRulePatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = await UpdateAsync(patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledQueryRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledQueryRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<ScheduledQueryRuleResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleResource.AddTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues[key] = value;
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _scheduledQueryRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                    return Response.FromValue(new ScheduledQueryRuleResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new ScheduledQueryRulePatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = Update(patch, cancellationToken: cancellationToken);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledQueryRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledQueryRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<ScheduledQueryRuleResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleResource.SetTags");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _scheduledQueryRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new ScheduledQueryRuleResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new ScheduledQueryRulePatch();
                    patch.Tags.ReplaceWith(tags);
                    var result = await UpdateAsync(patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledQueryRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledQueryRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<ScheduledQueryRuleResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleResource.SetTags");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _scheduledQueryRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                    return Response.FromValue(new ScheduledQueryRuleResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new ScheduledQueryRulePatch();
                    patch.Tags.ReplaceWith(tags);
                    var result = Update(patch, cancellationToken: cancellationToken);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledQueryRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledQueryRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<ScheduledQueryRuleResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleResource.RemoveTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.Remove(key);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _scheduledQueryRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new ScheduledQueryRuleResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new ScheduledQueryRulePatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = await UpdateAsync(patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScheduledQueryRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScheduledQueryRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<ScheduledQueryRuleResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleResource.RemoveTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.Remove(key);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _scheduledQueryRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                    return Response.FromValue(new ScheduledQueryRuleResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new ScheduledQueryRulePatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = Update(patch, cancellationToken: cancellationToken);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
