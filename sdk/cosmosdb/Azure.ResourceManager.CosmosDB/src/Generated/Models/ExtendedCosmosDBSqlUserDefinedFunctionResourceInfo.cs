// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The ExtendedCosmosDBSqlUserDefinedFunctionResourceInfo. </summary>
    public partial class ExtendedCosmosDBSqlUserDefinedFunctionResourceInfo : CosmosDBSqlUserDefinedFunctionResourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="ExtendedCosmosDBSqlUserDefinedFunctionResourceInfo"/>. </summary>
        /// <param name="functionName"> Name of the Cosmos DB SQL userDefinedFunction. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public ExtendedCosmosDBSqlUserDefinedFunctionResourceInfo(string functionName) : base(functionName)
        {
            Argument.AssertNotNull(functionName, nameof(functionName));
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedCosmosDBSqlUserDefinedFunctionResourceInfo"/>. </summary>
        /// <param name="functionName"> Name of the Cosmos DB SQL userDefinedFunction. </param>
        /// <param name="body"> Body of the User Defined Function. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="timestamp"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="etag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        internal ExtendedCosmosDBSqlUserDefinedFunctionResourceInfo(string functionName, string body, IDictionary<string, BinaryData> serializedAdditionalRawData, string rid, float? timestamp, ETag? etag) : base(functionName, body, serializedAdditionalRawData)
        {
            Rid = rid;
            Timestamp = timestamp;
            ETag = etag;
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedCosmosDBSqlUserDefinedFunctionResourceInfo"/> for deserialization. </summary>
        internal ExtendedCosmosDBSqlUserDefinedFunctionResourceInfo()
        {
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> A system generated property that denotes the last updated timestamp of the resource. </summary>
        public float? Timestamp { get; }
        /// <summary> A system generated property representing the resource etag required for optimistic concurrency control. </summary>
        public ETag? ETag { get; }
    }
}
