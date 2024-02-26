// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Distcp settings. </summary>
    public partial class DistcpSettings
    {
        /// <summary> Initializes a new instance of <see cref="DistcpSettings"/>. </summary>
        /// <param name="resourceManagerEndpoint"> Specifies the Yarn ResourceManager endpoint. Type: string (or Expression with resultType string). </param>
        /// <param name="tempScriptPath"> Specifies an existing folder path which will be used to store temp Distcp command script. The script file is generated by ADF and will be removed after Copy job finished. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceManagerEndpoint"/> or <paramref name="tempScriptPath"/> is null. </exception>
        public DistcpSettings(object resourceManagerEndpoint, object tempScriptPath)
        {
            if (resourceManagerEndpoint == null)
            {
                throw new ArgumentNullException(nameof(resourceManagerEndpoint));
            }
            if (tempScriptPath == null)
            {
                throw new ArgumentNullException(nameof(tempScriptPath));
            }

            ResourceManagerEndpoint = resourceManagerEndpoint;
            TempScriptPath = tempScriptPath;
        }

        /// <summary> Initializes a new instance of <see cref="DistcpSettings"/>. </summary>
        /// <param name="resourceManagerEndpoint"> Specifies the Yarn ResourceManager endpoint. Type: string (or Expression with resultType string). </param>
        /// <param name="tempScriptPath"> Specifies an existing folder path which will be used to store temp Distcp command script. The script file is generated by ADF and will be removed after Copy job finished. Type: string (or Expression with resultType string). </param>
        /// <param name="distcpOptions"> Specifies the Distcp options. Type: string (or Expression with resultType string). </param>
        internal DistcpSettings(object resourceManagerEndpoint, object tempScriptPath, object distcpOptions)
        {
            ResourceManagerEndpoint = resourceManagerEndpoint;
            TempScriptPath = tempScriptPath;
            DistcpOptions = distcpOptions;
        }

        /// <summary> Specifies the Yarn ResourceManager endpoint. Type: string (or Expression with resultType string). </summary>
        public object ResourceManagerEndpoint { get; set; }
        /// <summary> Specifies an existing folder path which will be used to store temp Distcp command script. The script file is generated by ADF and will be removed after Copy job finished. Type: string (or Expression with resultType string). </summary>
        public object TempScriptPath { get; set; }
        /// <summary> Specifies the Distcp options. Type: string (or Expression with resultType string). </summary>
        public object DistcpOptions { get; set; }
    }
}
