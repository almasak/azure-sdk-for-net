// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Communication.MediaComposition.Models;

namespace Azure.Communication.MediaComposition
{
    /// <summary> A Room to be used as an output. </summary>
    public partial class RoomOutput : MediaOutput
    {
        /// <summary> Initializes a new instance of <see cref="RoomOutput"/>. </summary>
        /// <param name="id"> Room identifier. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public RoomOutput(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
            Kind = MediaOutputType.Room;
        }

        /// <summary> Initializes a new instance of <see cref="RoomOutput"/>. </summary>
        /// <param name="kind"> Kind of media output. </param>
        /// <param name="id"> Room identifier. </param>
        internal RoomOutput(MediaOutputType kind, string id) : base(kind)
        {
            Id = id;
            Kind = kind;
        }

        /// <summary> Room identifier. </summary>
        public string Id { get; set; }
    }
}
