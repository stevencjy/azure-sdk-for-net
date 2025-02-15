// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBox;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Job Resource Collection. </summary>
    internal partial class DataBoxJobListResult
    {
        /// <summary> Initializes a new instance of <see cref="DataBoxJobListResult"/>. </summary>
        internal DataBoxJobListResult()
        {
            Value = new ChangeTrackingList<DataBoxJobData>();
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxJobListResult"/>. </summary>
        /// <param name="value"> List of job resources. </param>
        /// <param name="nextLink"> Link for the next set of job resources. </param>
        internal DataBoxJobListResult(IReadOnlyList<DataBoxJobData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of job resources. </summary>
        public IReadOnlyList<DataBoxJobData> Value { get; }
        /// <summary> Link for the next set of job resources. </summary>
        public string NextLink { get; }
    }
}
