// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.Rooms
{
    /// <summary> A collection of participants in a room. </summary>
    internal partial class ParticipantsCollection
    {
        /// <summary> Initializes a new instance of <see cref="ParticipantsCollection"/>. </summary>
        /// <param name="value"> A collection of participants. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ParticipantsCollection(IEnumerable<RoomParticipant> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ParticipantsCollection"/>. </summary>
        /// <param name="value"> A collection of participants. </param>
        /// <param name="nextLink"> If there are more participants that can be retrieved, the next link will be populated. </param>
        internal ParticipantsCollection(IReadOnlyList<RoomParticipant> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A collection of participants. </summary>
        public IReadOnlyList<RoomParticipant> Value { get; }
        /// <summary> If there are more participants that can be retrieved, the next link will be populated. </summary>
        public string NextLink { get; }
    }
}
