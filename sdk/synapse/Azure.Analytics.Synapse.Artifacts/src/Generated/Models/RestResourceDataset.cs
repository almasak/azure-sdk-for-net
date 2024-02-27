// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A Rest service dataset. </summary>
    public partial class RestResourceDataset : Dataset
    {
        /// <summary> Initializes a new instance of <see cref="RestResourceDataset"/>. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public RestResourceDataset(LinkedServiceReference linkedServiceName) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            Type = "RestResource";
        }

        /// <summary> Initializes a new instance of <see cref="RestResourceDataset"/>. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="relativeUrl"> The relative URL to the resource that the RESTful API provides. Type: string (or Expression with resultType string). </param>
        /// <param name="requestMethod"> The HTTP method used to call the RESTful API. The default is GET. Type: string (or Expression with resultType string). </param>
        /// <param name="requestBody"> The HTTP request body to the RESTful API if requestMethod is POST. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalHeaders"> The additional HTTP headers in the request to the RESTful API. Type: string (or Expression with resultType string). </param>
        /// <param name="paginationRules"> The pagination rules to compose next page requests. Type: string (or Expression with resultType string). </param>
        internal RestResourceDataset(string type, string description, object structure, object schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, DatasetFolder folder, IDictionary<string, object> additionalProperties, object relativeUrl, object requestMethod, object requestBody, object additionalHeaders, object paginationRules) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            RelativeUrl = relativeUrl;
            RequestMethod = requestMethod;
            RequestBody = requestBody;
            AdditionalHeaders = additionalHeaders;
            PaginationRules = paginationRules;
            Type = type ?? "RestResource";
        }

        /// <summary> The relative URL to the resource that the RESTful API provides. Type: string (or Expression with resultType string). </summary>
        public object RelativeUrl { get; set; }
        /// <summary> The HTTP method used to call the RESTful API. The default is GET. Type: string (or Expression with resultType string). </summary>
        public object RequestMethod { get; set; }
        /// <summary> The HTTP request body to the RESTful API if requestMethod is POST. Type: string (or Expression with resultType string). </summary>
        public object RequestBody { get; set; }
        /// <summary> The additional HTTP headers in the request to the RESTful API. Type: string (or Expression with resultType string). </summary>
        public object AdditionalHeaders { get; set; }
        /// <summary> The pagination rules to compose next page requests. Type: string (or Expression with resultType string). </summary>
        public object PaginationRules { get; set; }
    }
}
