// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Xml.Linq;

namespace Azure.Storage.Files.DataLake.Models
{
    internal partial class BlobHierarchyListSegment
    {
        internal static BlobHierarchyListSegment DeserializeBlobHierarchyListSegment(XElement element)
        {
            IReadOnlyList<BlobPrefix> blobPrefixes = default;
            IReadOnlyList<BlobItemInternal> blobItems = default;
            var array = new List<BlobPrefix>();
            foreach (var e in element.Elements("BlobPrefix"))
            {
                array.Add(BlobPrefix.DeserializeBlobPrefix(e));
            }
            blobPrefixes = array;
            var array0 = new List<BlobItemInternal>();
            foreach (var e in element.Elements("Blob"))
            {
                array0.Add(BlobItemInternal.DeserializeBlobItemInternal(e));
            }
            blobItems = array0;
            return new BlobHierarchyListSegment(blobPrefixes, blobItems);
        }
    }
}
