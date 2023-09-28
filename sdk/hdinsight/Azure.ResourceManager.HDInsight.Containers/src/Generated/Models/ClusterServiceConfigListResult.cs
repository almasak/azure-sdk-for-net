// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Cluster instance service configs api response. </summary>
    internal partial class ClusterServiceConfigListResult
    {
        /// <summary> Initializes a new instance of ClusterServiceConfigListResult. </summary>
        internal ClusterServiceConfigListResult()
        {
            Value = new ChangeTrackingList<ClusterServiceConfigResult>();
        }

        /// <summary> Initializes a new instance of ClusterServiceConfigListResult. </summary>
        /// <param name="value"> Cluster instance service config array. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        internal ClusterServiceConfigListResult(IReadOnlyList<ClusterServiceConfigResult> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Cluster instance service config array. </summary>
        public IReadOnlyList<ClusterServiceConfigResult> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
