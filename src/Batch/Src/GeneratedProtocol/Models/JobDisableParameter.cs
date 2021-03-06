// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Parameters for a CloudJobOperations.Disable request.
    /// </summary>
    public partial class JobDisableParameter
    {
        /// <summary>
        /// Initializes a new instance of the JobDisableParameter class.
        /// </summary>
        public JobDisableParameter() { }

        /// <summary>
        /// Initializes a new instance of the JobDisableParameter class.
        /// </summary>
        public JobDisableParameter(DisableJobOption disableTasks)
        {
            DisableTasks = disableTasks;
        }

        /// <summary>
        /// Sets what to do with active tasks associated with the job.
        /// Possible values include: 'requeue', 'terminate', 'wait'
        /// </summary>
        [JsonProperty(PropertyName = "disableTasks")]
        public DisableJobOption DisableTasks { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
        }
    }
}
