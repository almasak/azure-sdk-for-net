// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Represents Site Related Details. </summary>
    internal partial class SiteDetails
    {
        /// <summary> Initializes a new instance of SiteDetails. </summary>
        /// <param name="siteId"> Unique Id, Identifying A Site. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteId"/> is null. </exception>
        public SiteDetails(string siteId)
        {
            Argument.AssertNotNull(siteId, nameof(siteId));

            SiteId = siteId;
        }

        /// <summary> Unique Id, Identifying A Site. </summary>
        public string SiteId { get; set; }
    }
}
