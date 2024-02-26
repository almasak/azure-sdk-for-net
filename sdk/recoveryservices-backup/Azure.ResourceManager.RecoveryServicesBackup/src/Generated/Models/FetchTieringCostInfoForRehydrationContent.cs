// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Request parameters for fetching cost info of rehydration. </summary>
    public partial class FetchTieringCostInfoForRehydrationContent : FetchTieringCostInfoContent
    {
        /// <summary> Initializes a new instance of <see cref="FetchTieringCostInfoForRehydrationContent"/>. </summary>
        /// <param name="sourceTierType"> Source tier for the request. </param>
        /// <param name="targetTierType"> target tier for the request. </param>
        /// <param name="containerName"> Name of the protected item container. </param>
        /// <param name="protectedItemName"> Name of the protectedItemName. </param>
        /// <param name="recoveryPointId"> ID of the backup copy for rehydration cost info needs to be fetched. </param>
        /// <param name="rehydrationPriority"> Rehydration Priority. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/>, <paramref name="protectedItemName"/> or <paramref name="recoveryPointId"/> is null. </exception>
        public FetchTieringCostInfoForRehydrationContent(RecoveryPointTierType sourceTierType, RecoveryPointTierType targetTierType, string containerName, string protectedItemName, string recoveryPointId, RehydrationPriority rehydrationPriority) : base(sourceTierType, targetTierType)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (protectedItemName == null)
            {
                throw new ArgumentNullException(nameof(protectedItemName));
            }
            if (recoveryPointId == null)
            {
                throw new ArgumentNullException(nameof(recoveryPointId));
            }

            ContainerName = containerName;
            ProtectedItemName = protectedItemName;
            RecoveryPointId = recoveryPointId;
            RehydrationPriority = rehydrationPriority;
            ObjectType = "FetchTieringCostInfoForRehydrationRequest";
        }

        /// <summary> Initializes a new instance of <see cref="FetchTieringCostInfoForRehydrationContent"/>. </summary>
        /// <param name="sourceTierType"> Source tier for the request. </param>
        /// <param name="targetTierType"> target tier for the request. </param>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="containerName"> Name of the protected item container. </param>
        /// <param name="protectedItemName"> Name of the protectedItemName. </param>
        /// <param name="recoveryPointId"> ID of the backup copy for rehydration cost info needs to be fetched. </param>
        /// <param name="rehydrationPriority"> Rehydration Priority. </param>
        internal FetchTieringCostInfoForRehydrationContent(RecoveryPointTierType sourceTierType, RecoveryPointTierType targetTierType, string objectType, IDictionary<string, BinaryData> serializedAdditionalRawData, string containerName, string protectedItemName, string recoveryPointId, RehydrationPriority rehydrationPriority) : base(sourceTierType, targetTierType, objectType, serializedAdditionalRawData)
        {
            ContainerName = containerName;
            ProtectedItemName = protectedItemName;
            RecoveryPointId = recoveryPointId;
            RehydrationPriority = rehydrationPriority;
            ObjectType = objectType ?? "FetchTieringCostInfoForRehydrationRequest";
        }

        /// <summary> Initializes a new instance of <see cref="FetchTieringCostInfoForRehydrationContent"/> for deserialization. </summary>
        internal FetchTieringCostInfoForRehydrationContent()
        {
        }

        /// <summary> Name of the protected item container. </summary>
        public string ContainerName { get; }
        /// <summary> Name of the protectedItemName. </summary>
        public string ProtectedItemName { get; }
        /// <summary> ID of the backup copy for rehydration cost info needs to be fetched. </summary>
        public string RecoveryPointId { get; }
        /// <summary> Rehydration Priority. </summary>
        public RehydrationPriority RehydrationPriority { get; }
    }
}
