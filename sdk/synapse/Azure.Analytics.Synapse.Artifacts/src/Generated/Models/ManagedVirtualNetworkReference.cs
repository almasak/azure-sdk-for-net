// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Managed Virtual Network reference type. </summary>
    public partial class ManagedVirtualNetworkReference
    {
        /// <summary> Initializes a new instance of <see cref="ManagedVirtualNetworkReference"/>. </summary>
        /// <param name="referenceName"> Reference ManagedVirtualNetwork name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public ManagedVirtualNetworkReference(string referenceName)
        {
            if (referenceName == null)
            {
                throw new ArgumentNullException(nameof(referenceName));
            }

            Type = ManagedVirtualNetworkReferenceType.ManagedVirtualNetworkReference;
            ReferenceName = referenceName;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedVirtualNetworkReference"/>. </summary>
        /// <param name="type"> Managed Virtual Network reference type. </param>
        /// <param name="referenceName"> Reference ManagedVirtualNetwork name. </param>
        internal ManagedVirtualNetworkReference(ManagedVirtualNetworkReferenceType type, string referenceName)
        {
            Type = type;
            ReferenceName = referenceName;
        }

        /// <summary> Managed Virtual Network reference type. </summary>
        public ManagedVirtualNetworkReferenceType Type { get; }
        /// <summary> Reference ManagedVirtualNetwork name. </summary>
        public string ReferenceName { get; set; }
    }
}
