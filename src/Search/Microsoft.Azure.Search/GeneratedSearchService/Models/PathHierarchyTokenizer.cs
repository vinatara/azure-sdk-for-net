// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Tokenizer for path-like hierarchies.
    /// </summary>
    [JsonObject("#Microsoft.Azure.Search.PathHierarchyTokenizer")]
    public partial class PathHierarchyTokenizer : Tokenizer
    {
        /// <summary>
        /// Initializes a new instance of the PathHierarchyTokenizer class.
        /// </summary>
        public PathHierarchyTokenizer() { }

        /// <summary>
        /// Initializes a new instance of the PathHierarchyTokenizer class.
        /// </summary>
        public PathHierarchyTokenizer(string name, string delimiter = default(string), string replacement = default(string), int? bufferSize = default(int?), bool? reverseTokenOrder = default(bool?), int? numberOfTokensToSkip = default(int?))
            : base(name)
        {
            Delimiter = delimiter;
            Replacement = replacement;
            BufferSize = bufferSize;
            ReverseTokenOrder = reverseTokenOrder;
            NumberOfTokensToSkip = numberOfTokensToSkip;
        }

        /// <summary>
        /// Gets or sets the delimiter character to use.
        /// </summary>
        [JsonProperty(PropertyName = "delimiter")]
        public string Delimiter { get; set; }

        /// <summary>
        /// Gets or sets a value that, if set, replaces the delimiter
        /// character.
        /// </summary>
        [JsonProperty(PropertyName = "replacement")]
        public string Replacement { get; set; }

        /// <summary>
        /// Gets or sets the buffer size.
        /// </summary>
        [JsonProperty(PropertyName = "bufferSize")]
        public int? BufferSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to generate tokens in
        /// reverse order.
        /// </summary>
        [JsonProperty(PropertyName = "reverse")]
        public bool? ReverseTokenOrder { get; set; }

        /// <summary>
        /// Gets or sets the number of initial tokens to skip.
        /// </summary>
        [JsonProperty(PropertyName = "skip")]
        public int? NumberOfTokensToSkip { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (this.Delimiter != null)
            {
                if (this.Delimiter.Length > 1)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Delimiter", 1);
                }
                if (this.Delimiter.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Delimiter", 1);
                }
            }
            if (this.Replacement != null)
            {
                if (this.Replacement.Length > 1)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Replacement", 1);
                }
                if (this.Replacement.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Replacement", 1);
                }
            }
        }
    }
}
