// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// KustoPoolAttachedDatabaseConfigurationsOperations operations.
    /// </summary>
    public partial interface IKustoPoolAttachedDatabaseConfigurationsOperations
    {
        /// <summary>
        /// Returns the list of attached database configurations of the given
        /// Kusto Pool.
        /// </summary>
        /// <param name='workspaceName'>
        /// The name of the workspace
        /// </param>
        /// <param name='kustoPoolName'>
        /// The name of the Kusto pool.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<AttachedDatabaseConfiguration>>> ListByKustoPoolWithHttpMessagesAsync(string workspaceName, string kustoPoolName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns an attached database configuration.
        /// </summary>
        /// <param name='workspaceName'>
        /// The name of the workspace
        /// </param>
        /// <param name='kustoPoolName'>
        /// The name of the Kusto pool.
        /// </param>
        /// <param name='attachedDatabaseConfigurationName'>
        /// The name of the attached database configuration.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AttachedDatabaseConfiguration>> GetWithHttpMessagesAsync(string workspaceName, string kustoPoolName, string attachedDatabaseConfigurationName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates an attached database configuration.
        /// </summary>
        /// <param name='workspaceName'>
        /// The name of the workspace
        /// </param>
        /// <param name='kustoPoolName'>
        /// The name of the Kusto pool.
        /// </param>
        /// <param name='attachedDatabaseConfigurationName'>
        /// The name of the attached database configuration.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='parameters'>
        /// The database parameters supplied to the CreateOrUpdate operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AttachedDatabaseConfiguration>> CreateOrUpdateWithHttpMessagesAsync(string workspaceName, string kustoPoolName, string attachedDatabaseConfigurationName, string resourceGroupName, AttachedDatabaseConfiguration parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the attached database configuration with the given name.
        /// </summary>
        /// <param name='workspaceName'>
        /// The name of the workspace
        /// </param>
        /// <param name='kustoPoolName'>
        /// The name of the Kusto pool.
        /// </param>
        /// <param name='attachedDatabaseConfigurationName'>
        /// The name of the attached database configuration.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string workspaceName, string kustoPoolName, string attachedDatabaseConfigurationName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates an attached database configuration.
        /// </summary>
        /// <param name='workspaceName'>
        /// The name of the workspace
        /// </param>
        /// <param name='kustoPoolName'>
        /// The name of the Kusto pool.
        /// </param>
        /// <param name='attachedDatabaseConfigurationName'>
        /// The name of the attached database configuration.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='parameters'>
        /// The database parameters supplied to the CreateOrUpdate operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AttachedDatabaseConfiguration>> BeginCreateOrUpdateWithHttpMessagesAsync(string workspaceName, string kustoPoolName, string attachedDatabaseConfigurationName, string resourceGroupName, AttachedDatabaseConfiguration parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the attached database configuration with the given name.
        /// </summary>
        /// <param name='workspaceName'>
        /// The name of the workspace
        /// </param>
        /// <param name='kustoPoolName'>
        /// The name of the Kusto pool.
        /// </param>
        /// <param name='attachedDatabaseConfigurationName'>
        /// The name of the attached database configuration.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string workspaceName, string kustoPoolName, string attachedDatabaseConfigurationName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
