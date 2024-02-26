// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Allows you to configure normalization for filterable, sortable, and facetable fields, which by default operate with strict matching. This is a user-defined configuration consisting of at least one or more filters, which modify the token that is stored. </summary>
    public partial class CustomNormalizer : LexicalNormalizer
    {
        /// <summary> Initializes a new instance of <see cref="CustomNormalizer"/>. </summary>
        /// <param name="name"> The name of the normalizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. It cannot end in '.microsoft' nor '.lucene', nor be named 'asciifolding', 'standard', 'lowercase', 'uppercase', or 'elision'. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public CustomNormalizer(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            TokenFilters = new ChangeTrackingList<TokenFilterName>();
            CharFilters = new ChangeTrackingList<CharFilterName>();
            ODataType = "#Microsoft.Azure.Search.CustomNormalizer";
        }

        /// <summary> Initializes a new instance of <see cref="CustomNormalizer"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of normalizer. </param>
        /// <param name="name"> The name of the normalizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. It cannot end in '.microsoft' nor '.lucene', nor be named 'asciifolding', 'standard', 'lowercase', 'uppercase', or 'elision'. </param>
        /// <param name="tokenFilters"> A list of token filters used to filter out or modify the input token. For example, you can specify a lowercase filter that converts all characters to lowercase. The filters are run in the order in which they are listed. </param>
        /// <param name="charFilters"> A list of character filters used to prepare input text before it is processed. For instance, they can replace certain characters or symbols. The filters are run in the order in which they are listed. </param>
        internal CustomNormalizer(string oDataType, string name, IList<TokenFilterName> tokenFilters, IList<CharFilterName> charFilters) : base(oDataType, name)
        {
            TokenFilters = tokenFilters;
            CharFilters = charFilters;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.CustomNormalizer";
        }

        /// <summary> A list of token filters used to filter out or modify the input token. For example, you can specify a lowercase filter that converts all characters to lowercase. The filters are run in the order in which they are listed. </summary>
        public IList<TokenFilterName> TokenFilters { get; }
        /// <summary> A list of character filters used to prepare input text before it is processed. For instance, they can replace certain characters or symbols. The filters are run in the order in which they are listed. </summary>
        public IList<CharFilterName> CharFilters { get; }
    }
}
