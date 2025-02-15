// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Statistical information about the number of recommendations per device, per recommendation type. </summary>
    public partial class IotSecurityDeviceRecommendation
    {
        /// <summary> Initializes a new instance of <see cref="IotSecurityDeviceRecommendation"/>. </summary>
        public IotSecurityDeviceRecommendation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IotSecurityDeviceRecommendation"/>. </summary>
        /// <param name="recommendationDisplayName"> Display name of the recommendation. </param>
        /// <param name="reportedSeverity"> Assessed recommendation severity. </param>
        /// <param name="devicesCount"> Number of devices with this recommendation. </param>
        internal IotSecurityDeviceRecommendation(string recommendationDisplayName, ReportedSeverity? reportedSeverity, long? devicesCount)
        {
            RecommendationDisplayName = recommendationDisplayName;
            ReportedSeverity = reportedSeverity;
            DevicesCount = devicesCount;
        }

        /// <summary> Display name of the recommendation. </summary>
        public string RecommendationDisplayName { get; }
        /// <summary> Assessed recommendation severity. </summary>
        public ReportedSeverity? ReportedSeverity { get; }
        /// <summary> Number of devices with this recommendation. </summary>
        public long? DevicesCount { get; }
    }
}
