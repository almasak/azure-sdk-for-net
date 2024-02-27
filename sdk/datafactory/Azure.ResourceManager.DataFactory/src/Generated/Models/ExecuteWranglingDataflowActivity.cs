// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Execute power query activity. </summary>
    public partial class ExecuteWranglingDataflowActivity : PipelineActivity
    {
        /// <summary> Initializes a new instance of <see cref="ExecuteWranglingDataflowActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="dataFlow"> Data flow reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="dataFlow"/> is null. </exception>
        public ExecuteWranglingDataflowActivity(string name, DataFlowReference dataFlow) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (dataFlow == null)
            {
                throw new ArgumentNullException(nameof(dataFlow));
            }

            DataFlow = dataFlow;
            Sinks = new ChangeTrackingDictionary<string, PowerQuerySink>();
            Queries = new ChangeTrackingList<PowerQuerySinkMapping>();
            ActivityType = "ExecuteWranglingDataflow";
        }

        /// <summary> Initializes a new instance of <see cref="ExecuteWranglingDataflowActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="dataFlow"> Data flow reference. </param>
        /// <param name="staging"> Staging info for execute data flow activity. </param>
        /// <param name="integrationRuntime"> The integration runtime reference. </param>
        /// <param name="compute"> Compute properties for data flow activity. </param>
        /// <param name="traceLevel"> Trace level setting used for data flow monitoring output. Supported values are: 'coarse', 'fine', and 'none'. Type: string (or Expression with resultType string). </param>
        /// <param name="continueOnError"> Continue on error setting used for data flow execution. Enables processing to continue if a sink fails. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="runConcurrently"> Concurrent run setting used for data flow execution. Allows sinks with the same save order to be processed concurrently. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="sourceStagingConcurrency"> Specify number of parallel staging for sources applicable to the sink. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinks"> (Deprecated. Please use Queries). List of Power Query activity sinks mapped to a queryName. </param>
        /// <param name="queries"> List of mapping for Power Query mashup query to sink dataset(s). </param>
        internal ExecuteWranglingDataflowActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, PipelineActivityPolicy policy, DataFlowReference dataFlow, DataFlowStagingInfo staging, IntegrationRuntimeReference integrationRuntime, ExecuteDataFlowActivityComputeType compute, DataFactoryElement<string> traceLevel, DataFactoryElement<bool> continueOnError, DataFactoryElement<bool> runConcurrently, DataFactoryElement<int> sourceStagingConcurrency, IDictionary<string, PowerQuerySink> sinks, IList<PowerQuerySinkMapping> queries) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties)
        {
            Policy = policy;
            DataFlow = dataFlow;
            Staging = staging;
            IntegrationRuntime = integrationRuntime;
            Compute = compute;
            TraceLevel = traceLevel;
            ContinueOnError = continueOnError;
            RunConcurrently = runConcurrently;
            SourceStagingConcurrency = sourceStagingConcurrency;
            Sinks = sinks;
            Queries = queries;
            ActivityType = activityType ?? "ExecuteWranglingDataflow";
        }

        /// <summary> Initializes a new instance of <see cref="ExecuteWranglingDataflowActivity"/> for deserialization. </summary>
        internal ExecuteWranglingDataflowActivity()
        {
        }

        /// <summary> Activity policy. </summary>
        public PipelineActivityPolicy Policy { get; set; }
        /// <summary> Data flow reference. </summary>
        public DataFlowReference DataFlow { get; set; }
        /// <summary> Staging info for execute data flow activity. </summary>
        public DataFlowStagingInfo Staging { get; set; }
        /// <summary> The integration runtime reference. </summary>
        public IntegrationRuntimeReference IntegrationRuntime { get; set; }
        /// <summary> Compute properties for data flow activity. </summary>
        public ExecuteDataFlowActivityComputeType Compute { get; set; }
        /// <summary> Trace level setting used for data flow monitoring output. Supported values are: 'coarse', 'fine', and 'none'. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> TraceLevel { get; set; }
        /// <summary> Continue on error setting used for data flow execution. Enables processing to continue if a sink fails. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> ContinueOnError { get; set; }
        /// <summary> Concurrent run setting used for data flow execution. Allows sinks with the same save order to be processed concurrently. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> RunConcurrently { get; set; }
        /// <summary> Specify number of parallel staging for sources applicable to the sink. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> SourceStagingConcurrency { get; set; }
        /// <summary> (Deprecated. Please use Queries). List of Power Query activity sinks mapped to a queryName. </summary>
        public IDictionary<string, PowerQuerySink> Sinks { get; }
        /// <summary> List of mapping for Power Query mashup query to sink dataset(s). </summary>
        public IList<PowerQuerySinkMapping> Queries { get; }
    }
}
