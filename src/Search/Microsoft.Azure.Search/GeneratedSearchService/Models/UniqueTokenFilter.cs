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
    /// Filters out tokens with same text as the previous token.
    /// </summary>
    [JsonObject("#Microsoft.Azure.Search.UniqueTokenFilter")]
    public partial class UniqueTokenFilter : TokenFilter
    {
        /// <summary>
        /// Initializes a new instance of the UniqueTokenFilter class.
        /// </summary>
        public UniqueTokenFilter() { }

        /// <summary>
        /// Initializes a new instance of the UniqueTokenFilter class.
        /// </summary>
        public UniqueTokenFilter(string name, bool? onlyOnSamePosition = default(bool?))
            : base(name)
        {
            OnlyOnSamePosition = onlyOnSamePosition;
        }

        /// <summary>
        /// Gets or sets a value indicating whether to remove duplicates only
        /// at the same position.
        /// </summary>
        [JsonProperty(PropertyName = "onlyOnSamePosition")]
        public bool? OnlyOnSamePosition { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
