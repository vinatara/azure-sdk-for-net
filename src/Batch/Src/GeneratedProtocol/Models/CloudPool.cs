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
    /// A pool in the Azure Batch service.
    /// </summary>
    public partial class CloudPool
    {
        /// <summary>
        /// Initializes a new instance of the CloudPool class.
        /// </summary>
        public CloudPool() { }

        /// <summary>
        /// Initializes a new instance of the CloudPool class.
        /// </summary>
        public CloudPool(string id = default(string), string displayName = default(string), string url = default(string), string eTag = default(string), DateTime? lastModified = default(DateTime?), DateTime? creationTime = default(DateTime?), PoolState? state = default(PoolState?), DateTime? stateTransitionTime = default(DateTime?), AllocationState? allocationState = default(AllocationState?), DateTime? allocationStateTransitionTime = default(DateTime?), string vmSize = default(string), CloudServiceConfiguration cloudServiceConfiguration = default(CloudServiceConfiguration), VirtualMachineConfiguration virtualMachineConfiguration = default(VirtualMachineConfiguration), TimeSpan? resizeTimeout = default(TimeSpan?), ResizeError resizeError = default(ResizeError), int? currentDedicated = default(int?), int? targetDedicated = default(int?), bool? enableAutoScale = default(bool?), string autoScaleFormula = default(string), TimeSpan? autoScaleEvaluationInterval = default(TimeSpan?), AutoScaleRun autoScaleRun = default(AutoScaleRun), bool? enableInterNodeCommunication = default(bool?), StartTask startTask = default(StartTask), IList<CertificateReference> certificateReferences = default(IList<CertificateReference>), IList<ApplicationPackageReference> applicationPackageReferences = default(IList<ApplicationPackageReference>), int? maxTasksPerNode = default(int?), TaskSchedulingPolicy taskSchedulingPolicy = default(TaskSchedulingPolicy), IList<MetadataItem> metadata = default(IList<MetadataItem>), PoolStatistics stats = default(PoolStatistics))
        {
            Id = id;
            DisplayName = displayName;
            Url = url;
            ETag = eTag;
            LastModified = lastModified;
            CreationTime = creationTime;
            State = state;
            StateTransitionTime = stateTransitionTime;
            AllocationState = allocationState;
            AllocationStateTransitionTime = allocationStateTransitionTime;
            VmSize = vmSize;
            CloudServiceConfiguration = cloudServiceConfiguration;
            VirtualMachineConfiguration = virtualMachineConfiguration;
            ResizeTimeout = resizeTimeout;
            ResizeError = resizeError;
            CurrentDedicated = currentDedicated;
            TargetDedicated = targetDedicated;
            EnableAutoScale = enableAutoScale;
            AutoScaleFormula = autoScaleFormula;
            AutoScaleEvaluationInterval = autoScaleEvaluationInterval;
            AutoScaleRun = autoScaleRun;
            EnableInterNodeCommunication = enableInterNodeCommunication;
            StartTask = startTask;
            CertificateReferences = certificateReferences;
            ApplicationPackageReferences = applicationPackageReferences;
            MaxTasksPerNode = maxTasksPerNode;
            TaskSchedulingPolicy = taskSchedulingPolicy;
            Metadata = metadata;
            Stats = stats;
        }

        /// <summary>
        /// Gets or sets a string that uniquely identifies the pool within the
        /// account. The id can contain any combination of alphanumeric
        /// characters including hyphens and underscores, and cannot contain
        /// more than 64 characters.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display name for the pool.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the URL of the pool.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the pool.
        /// </summary>
        [JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the last modified time of the pool.
        /// </summary>
        [JsonProperty(PropertyName = "lastModified")]
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Gets or sets the creation time of the pool.
        /// </summary>
        [JsonProperty(PropertyName = "creationTime")]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the current state of the pool. Possible values
        /// include: 'active', 'deleting', 'upgrading'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public PoolState? State { get; set; }

        /// <summary>
        /// Gets or sets the time at which the pool entered its current state.
        /// </summary>
        [JsonProperty(PropertyName = "stateTransitionTime")]
        public DateTime? StateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets whether the pool is resizing. Possible values
        /// include: 'steady', 'resizing', 'stopping'
        /// </summary>
        [JsonProperty(PropertyName = "allocationState")]
        public AllocationState? AllocationState { get; set; }

        /// <summary>
        /// Gets or sets the time at which the pool entered its current
        /// allocation state.
        /// </summary>
        [JsonProperty(PropertyName = "allocationStateTransitionTime")]
        public DateTime? AllocationStateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the size of virtual machines in the pool.  All VMs in
        /// a pool are the same size.
        /// </summary>
        [JsonProperty(PropertyName = "vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// Gets or sets the cloud service configuration for the pool. This
        /// property and VirtualMachineConfiguration are mutually exclusive
        /// and one of the properties must be specified.
        /// </summary>
        [JsonProperty(PropertyName = "cloudServiceConfiguration")]
        public CloudServiceConfiguration CloudServiceConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine configuration for the pool. This
        /// property and CloudServiceConfiguration are mutually exclusive and
        /// one of the properties must be specified.
        /// </summary>
        [JsonProperty(PropertyName = "virtualMachineConfiguration")]
        public VirtualMachineConfiguration VirtualMachineConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the timeout for allocation of compute nodes to the
        /// pool. In a Get Pool operation, this is the timeout for the most
        /// recent resize operation. The default value is 10 minutes.
        /// </summary>
        [JsonProperty(PropertyName = "resizeTimeout")]
        public TimeSpan? ResizeTimeout { get; set; }

        /// <summary>
        /// Gets or sets details of any error encountered while performing the
        /// last resize on the pool. This property is set only if an error
        /// occurred during the last pool resize, and only when the pool
        /// AllocationState is Steady.
        /// </summary>
        [JsonProperty(PropertyName = "resizeError")]
        public ResizeError ResizeError { get; set; }

        /// <summary>
        /// Gets or sets the number of compute nodes currently in the pool.
        /// </summary>
        [JsonProperty(PropertyName = "currentDedicated")]
        public int? CurrentDedicated { get; set; }

        /// <summary>
        /// Gets or sets the desired number of compute nodes in the pool. This
        /// property must have the default value if EnableAutoScale is true.
        /// It is required if EnableAutoScale is false.
        /// </summary>
        [JsonProperty(PropertyName = "targetDedicated")]
        public int? TargetDedicated { get; set; }

        /// <summary>
        /// Gets or sets whether the pool size should automatically adjust
        /// over time. If true, the AutoScaleFormula property must be set. If
        /// false, the TargetDedicated property must be set.
        /// </summary>
        [JsonProperty(PropertyName = "enableAutoScale")]
        public bool? EnableAutoScale { get; set; }

        /// <summary>
        /// Gets or sets a formula for the desired number of compute nodes in
        /// the pool.
        /// </summary>
        [JsonProperty(PropertyName = "autoScaleFormula")]
        public string AutoScaleFormula { get; set; }

        /// <summary>
        /// Gets or sets a time interval for the desired AutoScale evaluation
        /// period in the pool.
        /// </summary>
        [JsonProperty(PropertyName = "autoScaleEvaluationInterval")]
        public TimeSpan? AutoScaleEvaluationInterval { get; set; }

        /// <summary>
        /// Gets or sets the results and errors from the last execution of the
        /// autoscale formula.
        /// </summary>
        [JsonProperty(PropertyName = "autoScaleRun")]
        public AutoScaleRun AutoScaleRun { get; set; }

        /// <summary>
        /// Gets or sets whether the pool permits direct communication between
        /// nodes.
        /// </summary>
        [JsonProperty(PropertyName = "enableInterNodeCommunication")]
        public bool? EnableInterNodeCommunication { get; set; }

        /// <summary>
        /// Gets or sets a task specified to run on each compute node as it
        /// joins the pool.
        /// </summary>
        [JsonProperty(PropertyName = "startTask")]
        public StartTask StartTask { get; set; }

        /// <summary>
        /// Gets or sets the list of certificates to be installed on each
        /// compute node in the pool.
        /// </summary>
        [JsonProperty(PropertyName = "certificateReferences")]
        public IList<CertificateReference> CertificateReferences { get; set; }

        /// <summary>
        /// Gets or sets the list of application packages to be installed on
        /// each compute node in the pool.
        /// </summary>
        [JsonProperty(PropertyName = "applicationPackageReferences")]
        public IList<ApplicationPackageReference> ApplicationPackageReferences { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of tasks that can run concurrently
        /// on a single compute node in the pool.
        /// </summary>
        [JsonProperty(PropertyName = "maxTasksPerNode")]
        public int? MaxTasksPerNode { get; set; }

        /// <summary>
        /// Gets or sets how the Batch service distributes tasks between
        /// compute nodes in the pool.
        /// </summary>
        [JsonProperty(PropertyName = "taskSchedulingPolicy")]
        public TaskSchedulingPolicy TaskSchedulingPolicy { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the pool
        /// as metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Gets or sets utilization and resource usage statistics for the
        /// entire lifetime of the pool.
        /// </summary>
        [JsonProperty(PropertyName = "stats")]
        public PoolStatistics Stats { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.CloudServiceConfiguration != null)
            {
                this.CloudServiceConfiguration.Validate();
            }
            if (this.VirtualMachineConfiguration != null)
            {
                this.VirtualMachineConfiguration.Validate();
            }
            if (this.AutoScaleRun != null)
            {
                this.AutoScaleRun.Validate();
            }
            if (this.CertificateReferences != null)
            {
                foreach (var element in this.CertificateReferences)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.ApplicationPackageReferences != null)
            {
                foreach (var element1 in this.ApplicationPackageReferences)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (this.TaskSchedulingPolicy != null)
            {
                this.TaskSchedulingPolicy.Validate();
            }
            if (this.Stats != null)
            {
                this.Stats.Validate();
            }
        }
    }
}
