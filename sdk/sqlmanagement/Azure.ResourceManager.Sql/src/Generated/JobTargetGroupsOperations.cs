// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> The JobTargetGroups service client. </summary>
    public partial class JobTargetGroupsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal JobTargetGroupsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of JobTargetGroupsOperations for mocking. </summary>
        protected JobTargetGroupsOperations()
        {
        }
        /// <summary> Initializes a new instance of JobTargetGroupsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal JobTargetGroupsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new JobTargetGroupsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a target group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JobTargetGroup>> GetAsync(string resourceGroupName, string serverName, string jobAgentName, string targetGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobTargetGroupsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, serverName, jobAgentName, targetGroupName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a target group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobTargetGroup> Get(string resourceGroupName, string serverName, string jobAgentName, string targetGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobTargetGroupsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, serverName, jobAgentName, targetGroupName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a target group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="parameters"> The requested state of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JobTargetGroup>> CreateOrUpdateAsync(string resourceGroupName, string serverName, string jobAgentName, string targetGroupName, JobTargetGroup parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobTargetGroupsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return await RestClient.CreateOrUpdateAsync(resourceGroupName, serverName, jobAgentName, targetGroupName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a target group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="parameters"> The requested state of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobTargetGroup> CreateOrUpdate(string resourceGroupName, string serverName, string jobAgentName, string targetGroupName, JobTargetGroup parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobTargetGroupsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return RestClient.CreateOrUpdate(resourceGroupName, serverName, jobAgentName, targetGroupName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a target group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string resourceGroupName, string serverName, string jobAgentName, string targetGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobTargetGroupsOperations.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(resourceGroupName, serverName, jobAgentName, targetGroupName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a target group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="targetGroupName"> The name of the target group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string resourceGroupName, string serverName, string jobAgentName, string targetGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobTargetGroupsOperations.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(resourceGroupName, serverName, jobAgentName, targetGroupName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all target groups in an agent. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="jobAgentName"/> is null. </exception>
        public virtual AsyncPageable<JobTargetGroup> ListByAgentAsync(string resourceGroupName, string serverName, string jobAgentName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (jobAgentName == null)
            {
                throw new ArgumentNullException(nameof(jobAgentName));
            }

            async Task<Page<JobTargetGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobTargetGroupsOperations.ListByAgent");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByAgentAsync(resourceGroupName, serverName, jobAgentName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<JobTargetGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobTargetGroupsOperations.ListByAgent");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByAgentNextPageAsync(nextLink, resourceGroupName, serverName, jobAgentName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all target groups in an agent. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="jobAgentName"/> is null. </exception>
        public virtual Pageable<JobTargetGroup> ListByAgent(string resourceGroupName, string serverName, string jobAgentName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (jobAgentName == null)
            {
                throw new ArgumentNullException(nameof(jobAgentName));
            }

            Page<JobTargetGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobTargetGroupsOperations.ListByAgent");
                scope.Start();
                try
                {
                    var response = RestClient.ListByAgent(resourceGroupName, serverName, jobAgentName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<JobTargetGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobTargetGroupsOperations.ListByAgent");
                scope.Start();
                try
                {
                    var response = RestClient.ListByAgentNextPage(nextLink, resourceGroupName, serverName, jobAgentName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
