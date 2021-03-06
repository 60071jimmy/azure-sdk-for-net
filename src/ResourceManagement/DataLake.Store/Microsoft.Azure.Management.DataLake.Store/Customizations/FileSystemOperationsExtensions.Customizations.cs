// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace Microsoft.Azure.Management.DataLake.Store
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for FileSystemOperations.
    /// </summary>
    public static partial class FileSystemOperationsExtensions
    {
        /// <summary>
        /// Test the existence of a file or directory object specified by the file path.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations on.
        /// </param>
        /// <param name='getFilePath'>
        /// The Data Lake Store path (starting with '/') of the file or directory for
        /// which to test the existence of.
        /// </param>
        public static bool PathExists(this IFileSystemOperations operations, string accountName, string getFilePath)
        {
            return Task.Factory.StartNew(s => ((IFileSystemOperations)s).PathExistsAsync(accountName, getFilePath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test the existence of a file or directory object specified by the file path.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='accountName'>
        /// The Azure Data Lake Store account to execute filesystem operations on.
        /// </param>
        /// <param name='getFilePath'>
        /// The Data Lake Store path (starting with '/') of the file or directory for
        /// which to test the existence of.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<bool> PathExistsAsync(this IFileSystemOperations operations, string accountName, string getFilePath, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.PathExistsWithHttpMessagesAsync(accountName, getFilePath, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}
