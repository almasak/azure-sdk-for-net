// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CognitiveServicesKeyVaultProperties
    {
        BinaryData global::System.ClientModel.Primitives.IPersistableModel<CognitiveServicesKeyVaultProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CognitiveServicesKeyVaultProperties)} does not support '{options.Format}' format.");
            }
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder sb = new StringBuilder();
            if (Optional.IsDefined(KeyName))
            {
                sb.AppendLine($"  keyName: '{KeyName}'");
            }
            if (Optional.IsDefined(KeyVersion))
            {
                sb.AppendLine($"  keyVersion: '{KeyVersion}'");
            }
            if (Optional.IsDefined(KeyVaultUri))
            {
                sb.AppendLine($"  keyVaultUri: '{KeyVaultUri.AbsoluteUri}'");
            }
            if (Optional.IsDefined(IdentityClientId))
            {
                sb.AppendLine($"  identityClientId: '{IdentityClientId.Value}'");
            }
            return BinaryData.FromString(sb.ToString());
        }
    }
}
