// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Maps.Routing.Models
{
    /// <summary> A valid `GeoJSON LineString` geometry type. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1.4) for details. </summary>
    internal partial class GeoJsonLineString : GeoJsonGeometry
    {
        /// <summary> Initializes a new instance of <see cref="GeoJsonLineString"/>. </summary>
        /// <param name="coordinates"> Coordinates for the `GeoJson LineString` geometry. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="coordinates"/> is null. </exception>
        public GeoJsonLineString(IEnumerable<IList<double>> coordinates)
        {
            if (coordinates == null)
            {
                throw new ArgumentNullException(nameof(coordinates));
            }

            Coordinates = coordinates.ToList();
            Type = GeoJsonObjectType.GeoJsonLineString;
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonLineString"/>. </summary>
        /// <param name="type"> Specifies the `GeoJSON` type. Must be one of the nine valid GeoJSON object types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon, GeometryCollection, Feature and FeatureCollection. </param>
        /// <param name="coordinates"> Coordinates for the `GeoJson LineString` geometry. </param>
        internal GeoJsonLineString(GeoJsonObjectType type, IList<IList<double>> coordinates) : base(type)
        {
            Coordinates = coordinates;
            Type = type;
        }

        /// <summary> Coordinates for the `GeoJson LineString` geometry. </summary>
        public IList<IList<double>> Coordinates { get; }
    }
}
