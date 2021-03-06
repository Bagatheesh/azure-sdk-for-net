// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MySQL.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Recommendation action session operation status.
    /// </summary>
    public partial class RecommendedActionSessionsOperationStatus
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RecommendedActionSessionsOperationStatus class.
        /// </summary>
        public RecommendedActionSessionsOperationStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RecommendedActionSessionsOperationStatus class.
        /// </summary>
        /// <param name="name">Operation identifier.</param>
        /// <param name="startTime">Operation start time.</param>
        /// <param name="status">Operation status.</param>
        public RecommendedActionSessionsOperationStatus(string name = default(string), System.DateTime? startTime = default(System.DateTime?), string status = default(string))
        {
            Name = name;
            StartTime = startTime;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets operation identifier.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets operation start time.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets operation status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

    }
}
