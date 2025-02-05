// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> List of security controls definition. </summary>
    internal partial class SecureScoreControlDefinitionList
    {
        /// <summary> Initializes a new instance of <see cref="SecureScoreControlDefinitionList"/>. </summary>
        internal SecureScoreControlDefinitionList()
        {
            Value = new ChangeTrackingList<SecureScoreControlDefinitionItem>();
        }

        /// <summary> Initializes a new instance of <see cref="SecureScoreControlDefinitionList"/>. </summary>
        /// <param name="value"> Collection of security controls definition in this page. </param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        internal SecureScoreControlDefinitionList(IReadOnlyList<SecureScoreControlDefinitionItem> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of security controls definition in this page. </summary>
        public IReadOnlyList<SecureScoreControlDefinitionItem> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
