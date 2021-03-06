// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Graph.RBAC
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for ApplicationsOperations.
    /// </summary>
    public static partial class ApplicationsOperationsExtensions
    {
            /// <summary>
            /// Create a new application. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create an application.
            /// </param>
            public static Application Create(this IApplicationsOperations operations, ApplicationCreateParameters parameters)
            {
                return Task.Factory.StartNew(s => ((IApplicationsOperations)s).CreateAsync(parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new application. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create an application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Application> CreateAsync(this IApplicationsOperations operations, ApplicationCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists applications by filter parameters. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IEnumerable<Application> List(this IApplicationsOperations operations, ODataQuery<Application> odataQuery = default(ODataQuery<Application>))
            {
                return Task.Factory.StartNew(s => ((IApplicationsOperations)s).ListAsync(odataQuery), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists applications by filter parameters. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Application>> ListAsync(this IApplicationsOperations operations, ODataQuery<Application> odataQuery = default(ODataQuery<Application>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an application. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            public static void Delete(this IApplicationsOperations operations, string applicationObjectId)
            {
                Task.Factory.StartNew(s => ((IApplicationsOperations)s).DeleteAsync(applicationObjectId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an application. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IApplicationsOperations operations, string applicationObjectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(applicationObjectId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get an application by object Id. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            public static Application Get(this IApplicationsOperations operations, string applicationObjectId)
            {
                return Task.Factory.StartNew(s => ((IApplicationsOperations)s).GetAsync(applicationObjectId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an application by object Id. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Application> GetAsync(this IApplicationsOperations operations, string applicationObjectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(applicationObjectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update existing application. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update an existing application.
            /// </param>
            public static void Patch(this IApplicationsOperations operations, string applicationObjectId, ApplicationUpdateParameters parameters)
            {
                Task.Factory.StartNew(s => ((IApplicationsOperations)s).PatchAsync(applicationObjectId, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update existing application. Reference:
            /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object id
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update an existing application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PatchAsync(this IApplicationsOperations operations, string applicationObjectId, ApplicationUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PatchWithHttpMessagesAsync(applicationObjectId, parameters, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
