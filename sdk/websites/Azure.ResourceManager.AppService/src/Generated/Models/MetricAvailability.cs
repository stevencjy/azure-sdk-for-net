// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Retention policy of a resource metric. </summary>
    public partial class MetricAvailability
    {
        /// <summary> Initializes a new instance of <see cref="MetricAvailability"/>. </summary>
        internal MetricAvailability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MetricAvailability"/>. </summary>
        /// <param name="timeGrain"></param>
        /// <param name="blobDuration"></param>
        internal MetricAvailability(string timeGrain, TimeSpan? blobDuration)
        {
            TimeGrain = timeGrain;
            BlobDuration = blobDuration;
        }

        /// <summary> Gets the time grain. </summary>
        public string TimeGrain { get; }
        /// <summary> Gets the blob duration. </summary>
        public TimeSpan? BlobDuration { get; }
    }
}
