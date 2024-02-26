// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Projection definition for what data to store in Azure Blob. </summary>
    public partial class KnowledgeStoreObjectProjectionSelector : KnowledgeStoreStorageProjectionSelector
    {
        /// <summary> Initializes a new instance of <see cref="KnowledgeStoreObjectProjectionSelector"/>. </summary>
        /// <param name="storageContainer"> Blob container to store projections in. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageContainer"/> is null. </exception>
        public KnowledgeStoreObjectProjectionSelector(string storageContainer) : base(storageContainer)
        {
            if (storageContainer == null)
            {
                throw new ArgumentNullException(nameof(storageContainer));
            }
        }

        /// <summary> Initializes a new instance of <see cref="KnowledgeStoreObjectProjectionSelector"/>. </summary>
        /// <param name="referenceKeyName"> Name of reference key to different projection. </param>
        /// <param name="generatedKeyName"> Name of generated key to store projection under. </param>
        /// <param name="source"> Source data to project. </param>
        /// <param name="sourceContext"> Source context for complex projections. </param>
        /// <param name="inputs"> Nested inputs for complex projections. </param>
        /// <param name="storageContainer"> Blob container to store projections in. </param>
        internal KnowledgeStoreObjectProjectionSelector(string referenceKeyName, string generatedKeyName, string source, string sourceContext, IList<InputFieldMappingEntry> inputs, string storageContainer) : base(referenceKeyName, generatedKeyName, source, sourceContext, inputs, storageContainer)
        {
        }
    }
}
