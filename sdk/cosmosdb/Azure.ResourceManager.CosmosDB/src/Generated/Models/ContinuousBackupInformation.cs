// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Information about the status of continuous backups. </summary>
    internal partial class ContinuousBackupInformation
    {
        /// <summary> Initializes a new instance of <see cref="ContinuousBackupInformation"/>. </summary>
        internal ContinuousBackupInformation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContinuousBackupInformation"/>. </summary>
        /// <param name="latestRestorableTimestamp"> The latest restorable timestamp for a resource. </param>
        internal ContinuousBackupInformation(DateTimeOffset? latestRestorableTimestamp)
        {
            LatestRestorableTimestamp = latestRestorableTimestamp;
        }

        /// <summary> The latest restorable timestamp for a resource. </summary>
        public DateTimeOffset? LatestRestorableTimestamp { get; }
    }
}
