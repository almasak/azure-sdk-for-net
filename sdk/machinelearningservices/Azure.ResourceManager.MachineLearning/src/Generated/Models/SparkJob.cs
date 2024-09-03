// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Spark job definition. </summary>
    public partial class SparkJob : MachineLearningJobProperties
    {
        /// <summary> Initializes a new instance of <see cref="SparkJob"/>. </summary>
        /// <param name="codeId"> [Required] arm-id of the code asset. </param>
        /// <param name="entry">
        /// [Required] The entry to execute on startup of the job.
        /// Please note <see cref="SparkJobEntry"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SparkJobPythonEntry"/> and <see cref="SparkJobScalaEntry"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="codeId"/> or <paramref name="entry"/> is null. </exception>
        public SparkJob(ResourceIdentifier codeId, SparkJobEntry entry)
        {
            Argument.AssertNotNull(codeId, nameof(codeId));
            Argument.AssertNotNull(entry, nameof(entry));

            Archives = new ChangeTrackingList<string>();
            CodeId = codeId;
            Conf = new ChangeTrackingDictionary<string, string>();
            Entry = entry;
            EnvironmentVariables = new ChangeTrackingDictionary<string, string>();
            Files = new ChangeTrackingList<string>();
            Inputs = new ChangeTrackingDictionary<string, MachineLearningJobInput>();
            Jars = new ChangeTrackingList<string>();
            Outputs = new ChangeTrackingDictionary<string, MachineLearningJobOutput>();
            PyFiles = new ChangeTrackingList<string>();
            JobType = JobType.Spark;
        }

        /// <summary> Initializes a new instance of <see cref="SparkJob"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="componentId"> ARM resource ID of the component resource. </param>
        /// <param name="computeId"> ARM resource ID of the compute resource. </param>
        /// <param name="displayName"> Display name of job. </param>
        /// <param name="experimentName"> The name of the experiment the job belongs to. If not set, the job is placed in the "Default" experiment. </param>
        /// <param name="identity">
        /// Identity configuration. If set, this should be one of AmlToken, ManagedIdentity, UserIdentity or null.
        /// Defaults to AmlToken if null.
        /// Please note <see cref="MachineLearningIdentityConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmlToken"/>, <see cref="MachineLearningManagedIdentity"/> and <see cref="MachineLearningUserIdentity"/>.
        /// </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="jobType"> [Required] Specifies the type of job. </param>
        /// <param name="notificationSetting"> Notification setting for the job. </param>
        /// <param name="services">
        /// List of JobEndpoints.
        /// For local jobs, a job endpoint will have an endpoint value of FileStreamObject.
        /// </param>
        /// <param name="status"> Status of the job. </param>
        /// <param name="archives"> Archive files used in the job. </param>
        /// <param name="args"> Arguments for the job. </param>
        /// <param name="codeId"> [Required] arm-id of the code asset. </param>
        /// <param name="conf"> Spark configured properties. </param>
        /// <param name="entry">
        /// [Required] The entry to execute on startup of the job.
        /// Please note <see cref="SparkJobEntry"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SparkJobPythonEntry"/> and <see cref="SparkJobScalaEntry"/>.
        /// </param>
        /// <param name="environmentId"> The ARM resource ID of the Environment specification for the job. </param>
        /// <param name="environmentVariables"> Environment variables included in the job. </param>
        /// <param name="files"> Files used in the job. </param>
        /// <param name="inputs">
        /// Mapping of input data bindings used in the job.
        /// Please note <see cref="MachineLearningJobInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobInput"/>, <see cref="MachineLearningLiteralJobInput"/>, <see cref="MachineLearningFlowModelJobInput"/>, <see cref="MachineLearningTableJobInput"/>, <see cref="MachineLearningTritonModelJobInput"/>, <see cref="MachineLearningUriFileJobInput"/> and <see cref="MachineLearningUriFolderJobInput"/>.
        /// </param>
        /// <param name="jars"> Jar files used in the job. </param>
        /// <param name="outputs">
        /// Mapping of output data bindings used in the job.
        /// Please note <see cref="MachineLearningJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobOutput"/>, <see cref="MachineLearningFlowModelJobOutput"/>, <see cref="MachineLearningTableJobOutput"/>, <see cref="MachineLearningTritonModelJobOutput"/>, <see cref="MachineLearningUriFileJobOutput"/> and <see cref="MachineLearningUriFolderJobOutput"/>.
        /// </param>
        /// <param name="pyFiles"> Python files used in the job. </param>
        /// <param name="queueSettings"> Queue settings for the job. </param>
        /// <param name="resources"> Compute Resource configuration for the job. </param>
        internal SparkJob(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier componentId, ResourceIdentifier computeId, string displayName, string experimentName, MachineLearningIdentityConfiguration identity, bool? isArchived, JobType jobType, NotificationSetting notificationSetting, IDictionary<string, MachineLearningJobService> services, MachineLearningJobStatus? status, IList<string> archives, string args, ResourceIdentifier codeId, IDictionary<string, string> conf, SparkJobEntry entry, ResourceIdentifier environmentId, IDictionary<string, string> environmentVariables, IList<string> files, IDictionary<string, MachineLearningJobInput> inputs, IList<string> jars, IDictionary<string, MachineLearningJobOutput> outputs, IList<string> pyFiles, JobQueueSettings queueSettings, SparkResourceConfiguration resources) : base(description, properties, tags, serializedAdditionalRawData, componentId, computeId, displayName, experimentName, identity, isArchived, jobType, notificationSetting, services, status)
        {
            Archives = archives;
            Args = args;
            CodeId = codeId;
            Conf = conf;
            Entry = entry;
            EnvironmentId = environmentId;
            EnvironmentVariables = environmentVariables;
            Files = files;
            Inputs = inputs;
            Jars = jars;
            Outputs = outputs;
            PyFiles = pyFiles;
            QueueSettings = queueSettings;
            Resources = resources;
            JobType = jobType;
        }

        /// <summary> Initializes a new instance of <see cref="SparkJob"/> for deserialization. </summary>
        internal SparkJob()
        {
        }

        /// <summary> Archive files used in the job. </summary>
        public IList<string> Archives { get; set; }
        /// <summary> Arguments for the job. </summary>
        public string Args { get; set; }
        /// <summary> [Required] arm-id of the code asset. </summary>
        public ResourceIdentifier CodeId { get; set; }
        /// <summary> Spark configured properties. </summary>
        public IDictionary<string, string> Conf { get; set; }
        /// <summary>
        /// [Required] The entry to execute on startup of the job.
        /// Please note <see cref="SparkJobEntry"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SparkJobPythonEntry"/> and <see cref="SparkJobScalaEntry"/>.
        /// </summary>
        public SparkJobEntry Entry { get; set; }
        /// <summary> The ARM resource ID of the Environment specification for the job. </summary>
        public ResourceIdentifier EnvironmentId { get; set; }
        /// <summary> Environment variables included in the job. </summary>
        public IDictionary<string, string> EnvironmentVariables { get; set; }
        /// <summary> Files used in the job. </summary>
        public IList<string> Files { get; set; }
        /// <summary>
        /// Mapping of input data bindings used in the job.
        /// Please note <see cref="MachineLearningJobInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobInput"/>, <see cref="MachineLearningLiteralJobInput"/>, <see cref="MachineLearningFlowModelJobInput"/>, <see cref="MachineLearningTableJobInput"/>, <see cref="MachineLearningTritonModelJobInput"/>, <see cref="MachineLearningUriFileJobInput"/> and <see cref="MachineLearningUriFolderJobInput"/>.
        /// </summary>
        public IDictionary<string, MachineLearningJobInput> Inputs { get; set; }
        /// <summary> Jar files used in the job. </summary>
        public IList<string> Jars { get; set; }
        /// <summary>
        /// Mapping of output data bindings used in the job.
        /// Please note <see cref="MachineLearningJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobOutput"/>, <see cref="MachineLearningFlowModelJobOutput"/>, <see cref="MachineLearningTableJobOutput"/>, <see cref="MachineLearningTritonModelJobOutput"/>, <see cref="MachineLearningUriFileJobOutput"/> and <see cref="MachineLearningUriFolderJobOutput"/>.
        /// </summary>
        public IDictionary<string, MachineLearningJobOutput> Outputs { get; set; }
        /// <summary> Python files used in the job. </summary>
        public IList<string> PyFiles { get; set; }
        /// <summary> Queue settings for the job. </summary>
        internal JobQueueSettings QueueSettings { get; set; }
        /// <summary> Controls the compute job tier. </summary>
        public JobTier? QueueJobTier
        {
            get => QueueSettings is null ? default : QueueSettings.JobTier;
            set
            {
                if (QueueSettings is null)
                    QueueSettings = new JobQueueSettings();
                QueueSettings.JobTier = value;
            }
        }

        /// <summary> Compute Resource configuration for the job. </summary>
        public SparkResourceConfiguration Resources { get; set; }
    }
}
