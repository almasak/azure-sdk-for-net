// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> SAS datastore credentials configuration. </summary>
    public partial class MachineLearningSasDatastoreCredentials : MachineLearningDatastoreCredentials
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningSasDatastoreCredentials"/>. </summary>
        /// <param name="secrets"> [Required] Storage container secrets. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secrets"/> is null. </exception>
        public MachineLearningSasDatastoreCredentials(MachineLearningSasDatastoreSecrets secrets)
        {
            if (secrets == null)
            {
                throw new ArgumentNullException(nameof(secrets));
            }

            Secrets = secrets;
            CredentialsType = CredentialsType.Sas;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningSasDatastoreCredentials"/>. </summary>
        /// <param name="credentialsType"> [Required] Credential type used to authentication with storage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="secrets"> [Required] Storage container secrets. </param>
        internal MachineLearningSasDatastoreCredentials(CredentialsType credentialsType, IDictionary<string, BinaryData> serializedAdditionalRawData, MachineLearningSasDatastoreSecrets secrets) : base(credentialsType, serializedAdditionalRawData)
        {
            Secrets = secrets;
            CredentialsType = credentialsType;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningSasDatastoreCredentials"/> for deserialization. </summary>
        internal MachineLearningSasDatastoreCredentials()
        {
        }

        /// <summary> [Required] Storage container secrets. </summary>
        public MachineLearningSasDatastoreSecrets Secrets { get; set; }
    }
}
