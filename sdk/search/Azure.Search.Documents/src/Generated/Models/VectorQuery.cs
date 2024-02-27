// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Models
{
    /// <summary>
    /// The query parameters for vector and hybrid search queries.
    /// Please note <see cref="VectorQuery"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="VectorizableTextQuery"/> and <see cref="VectorizedQuery"/>.
    /// </summary>
    public abstract partial class VectorQuery
    {
        /// <summary> Initializes a new instance of <see cref="VectorQuery"/>. </summary>
        protected VectorQuery()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VectorQuery"/>. </summary>
        /// <param name="kind"> The kind of vector query being performed. </param>
        /// <param name="kNearestNeighborsCount"> Number of nearest neighbors to return as top hits. </param>
        /// <param name="fieldsRaw"> Vector Fields of type Collection(Edm.Single) to be included in the vector searched. </param>
        /// <param name="exhaustive"> When true, triggers an exhaustive k-nearest neighbor search across all vectors within the vector index. Useful for scenarios where exact matches are critical, such as determining ground truth values. </param>
        /// <param name="oversampling"> Oversampling factor. Minimum value is 1. It overrides the 'defaultOversampling' parameter configured in the index definition. It can be set only when 'rerankWithOriginalVectors' is true. This parameter is only permitted when a compression method is used on the underlying vector field. </param>
        internal VectorQuery(VectorQueryKind kind, int? kNearestNeighborsCount, string fieldsRaw, bool? exhaustive, double? oversampling)
        {
            Kind = kind;
            KNearestNeighborsCount = kNearestNeighborsCount;
            FieldsRaw = fieldsRaw;
            Exhaustive = exhaustive;
            Oversampling = oversampling;
        }

        /// <summary> The kind of vector query being performed. </summary>
        internal VectorQueryKind Kind { get; set; }
        /// <summary> Number of nearest neighbors to return as top hits. </summary>
        public int? KNearestNeighborsCount { get; set; }
        /// <summary> When true, triggers an exhaustive k-nearest neighbor search across all vectors within the vector index. Useful for scenarios where exact matches are critical, such as determining ground truth values. </summary>
        public bool? Exhaustive { get; set; }
        /// <summary> Oversampling factor. Minimum value is 1. It overrides the 'defaultOversampling' parameter configured in the index definition. It can be set only when 'rerankWithOriginalVectors' is true. This parameter is only permitted when a compression method is used on the underlying vector field. </summary>
        public double? Oversampling { get; set; }
    }
}
