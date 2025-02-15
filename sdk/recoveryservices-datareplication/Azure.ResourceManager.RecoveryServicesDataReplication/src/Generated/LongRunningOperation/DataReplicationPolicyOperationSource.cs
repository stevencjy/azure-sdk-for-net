// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    internal class DataReplicationPolicyOperationSource : IOperationSource<DataReplicationPolicyResource>
    {
        private readonly ArmClient _client;

        internal DataReplicationPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        DataReplicationPolicyResource IOperationSource<DataReplicationPolicyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DataReplicationPolicyData.DeserializeDataReplicationPolicyData(document.RootElement);
            return new DataReplicationPolicyResource(_client, data);
        }

        async ValueTask<DataReplicationPolicyResource> IOperationSource<DataReplicationPolicyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DataReplicationPolicyData.DeserializeDataReplicationPolicyData(document.RootElement);
            return new DataReplicationPolicyResource(_client, data);
        }
    }
}
