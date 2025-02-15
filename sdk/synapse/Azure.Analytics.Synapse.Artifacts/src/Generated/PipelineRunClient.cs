// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> The PipelineRun service client. </summary>
    public partial class PipelineRunClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PipelineRunRestClient RestClient { get; }

        /// <summary> Initializes a new instance of PipelineRunClient for mocking. </summary>
        protected PipelineRunClient()
        {
        }

        /// <summary> Initializes a new instance of PipelineRunClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example `https://myworkspace.dev.azuresynapse.net`. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public PipelineRunClient(Uri endpoint, TokenCredential credential, ArtifactsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new ArtifactsClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://dev.azuresynapse.net/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new PipelineRunRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of PipelineRunClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example `https://myworkspace.dev.azuresynapse.net`. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        internal PipelineRunClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            RestClient = new PipelineRunRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Query pipeline runs in the workspace based on input filter conditions. </summary>
        /// <param name="filterParameters"> Parameters to filter the pipeline run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PipelineRunsQueryResponse>> QueryPipelineRunsByWorkspaceAsync(RunFilterParameters filterParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PipelineRunClient.QueryPipelineRunsByWorkspace");
            scope.Start();
            try
            {
                return await RestClient.QueryPipelineRunsByWorkspaceAsync(filterParameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query pipeline runs in the workspace based on input filter conditions. </summary>
        /// <param name="filterParameters"> Parameters to filter the pipeline run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PipelineRunsQueryResponse> QueryPipelineRunsByWorkspace(RunFilterParameters filterParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PipelineRunClient.QueryPipelineRunsByWorkspace");
            scope.Start();
            try
            {
                return RestClient.QueryPipelineRunsByWorkspace(filterParameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a pipeline run by its run ID. </summary>
        /// <param name="runId"> The pipeline run identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PipelineRun>> GetPipelineRunAsync(string runId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PipelineRunClient.GetPipelineRun");
            scope.Start();
            try
            {
                return await RestClient.GetPipelineRunAsync(runId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a pipeline run by its run ID. </summary>
        /// <param name="runId"> The pipeline run identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PipelineRun> GetPipelineRun(string runId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PipelineRunClient.GetPipelineRun");
            scope.Start();
            try
            {
                return RestClient.GetPipelineRun(runId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query activity runs based on input filter conditions. </summary>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="runId"> The pipeline run identifier. </param>
        /// <param name="filterParameters"> Parameters to filter the activity runs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ActivityRunsQueryResponse>> QueryActivityRunsAsync(string pipelineName, string runId, RunFilterParameters filterParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PipelineRunClient.QueryActivityRuns");
            scope.Start();
            try
            {
                return await RestClient.QueryActivityRunsAsync(pipelineName, runId, filterParameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query activity runs based on input filter conditions. </summary>
        /// <param name="pipelineName"> The pipeline name. </param>
        /// <param name="runId"> The pipeline run identifier. </param>
        /// <param name="filterParameters"> Parameters to filter the activity runs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ActivityRunsQueryResponse> QueryActivityRuns(string pipelineName, string runId, RunFilterParameters filterParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PipelineRunClient.QueryActivityRuns");
            scope.Start();
            try
            {
                return RestClient.QueryActivityRuns(pipelineName, runId, filterParameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancel a pipeline run by its run ID. </summary>
        /// <param name="runId"> The pipeline run identifier. </param>
        /// <param name="isRecursive"> If true, cancel all the Child pipelines that are triggered by the current pipeline. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CancelPipelineRunAsync(string runId, bool? isRecursive = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PipelineRunClient.CancelPipelineRun");
            scope.Start();
            try
            {
                return await RestClient.CancelPipelineRunAsync(runId, isRecursive, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancel a pipeline run by its run ID. </summary>
        /// <param name="runId"> The pipeline run identifier. </param>
        /// <param name="isRecursive"> If true, cancel all the Child pipelines that are triggered by the current pipeline. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CancelPipelineRun(string runId, bool? isRecursive = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PipelineRunClient.CancelPipelineRun");
            scope.Start();
            try
            {
                return RestClient.CancelPipelineRun(runId, isRecursive, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
