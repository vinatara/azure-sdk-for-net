// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Parameters for an ApplicationOperations.UpdateApplication request.
    /// </summary>
    public partial class UpdateApplicationParameters
    {
        /// <summary>
        /// Initializes a new instance of the UpdateApplicationParameters
        /// class.
        /// </summary>
        public UpdateApplicationParameters() { }

        /// <summary>
        /// Initializes a new instance of the UpdateApplicationParameters
        /// class.
        /// </summary>
        public UpdateApplicationParameters(bool? allowUpdates = default(bool?), string defaultVersion = default(string), string displayName = default(string))
        {
            AllowUpdates = allowUpdates;
            DefaultVersion = defaultVersion;
            DisplayName = displayName;
        }

        /// <summary>
        /// Gets or sets a value indicating whether packages within the
        /// application may be overwritten using the same version string.
        /// </summary>
        [JsonProperty(PropertyName = "allowUpdates")]
        public bool? AllowUpdates { get; set; }

        /// <summary>
        /// Gets or sets the package to use if a client requests the
        /// application but does not specify a version.
        /// </summary>
        [JsonProperty(PropertyName = "defaultVersion")]
        public string DefaultVersion { get; set; }

        /// <summary>
        /// Gets or sets the display name for the application.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

    }
}
