// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// A TrackSelection to select video tracks.
    /// Please note <see cref="VideoTrackDescriptor"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SelectVideoTrackByAttribute"/> and <see cref="SelectVideoTrackById"/>.
    /// </summary>
    public partial class VideoTrackDescriptor : TrackDescriptor
    {
        /// <summary> Initializes a new instance of <see cref="VideoTrackDescriptor"/>. </summary>
        public VideoTrackDescriptor()
        {
            OdataType = "#Microsoft.Media.VideoTrackDescriptor";
        }

        /// <summary> Initializes a new instance of <see cref="VideoTrackDescriptor"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VideoTrackDescriptor(string odataType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(odataType, serializedAdditionalRawData)
        {
            OdataType = odataType ?? "#Microsoft.Media.VideoTrackDescriptor";
        }
    }
}
