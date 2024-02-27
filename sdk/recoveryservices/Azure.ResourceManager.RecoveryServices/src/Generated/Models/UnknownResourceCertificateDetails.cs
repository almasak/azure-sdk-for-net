// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> The UnknownResourceCertificateDetails. </summary>
    internal partial class UnknownResourceCertificateDetails : ResourceCertificateDetails
    {
        /// <summary> Initializes a new instance of <see cref="UnknownResourceCertificateDetails"/>. </summary>
        /// <param name="authType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="certificate"> The base64 encoded certificate raw data string. </param>
        /// <param name="friendlyName"> Certificate friendly name. </param>
        /// <param name="issuer"> Certificate issuer. </param>
        /// <param name="resourceId"> Resource ID of the vault. </param>
        /// <param name="subject"> Certificate Subject Name. </param>
        /// <param name="thumbprint"> Certificate thumbprint. </param>
        /// <param name="validStartOn"> Certificate Validity start Date time. </param>
        /// <param name="validEndOn"> Certificate Validity End Date time. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownResourceCertificateDetails(string authType, byte[] certificate, string friendlyName, string issuer, long? resourceId, string subject, BinaryData thumbprint, DateTimeOffset? validStartOn, DateTimeOffset? validEndOn, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(authType, certificate, friendlyName, issuer, resourceId, subject, thumbprint, validStartOn, validEndOn, serializedAdditionalRawData)
        {
            AuthType = authType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownResourceCertificateDetails"/> for deserialization. </summary>
        internal UnknownResourceCertificateDetails()
        {
        }
    }
}
