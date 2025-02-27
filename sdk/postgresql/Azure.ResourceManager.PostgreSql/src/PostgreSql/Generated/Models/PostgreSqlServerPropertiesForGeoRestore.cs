// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> The properties used to create a new server by restoring to a different region from a geo replicated backup. </summary>
    public partial class PostgreSqlServerPropertiesForGeoRestore : PostgreSqlServerPropertiesForCreate
    {
        /// <summary> Initializes a new instance of <see cref="PostgreSqlServerPropertiesForGeoRestore"/>. </summary>
        /// <param name="sourceServerId"> The source server id to restore from. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceServerId"/> is null. </exception>
        public PostgreSqlServerPropertiesForGeoRestore(ResourceIdentifier sourceServerId)
        {
            Argument.AssertNotNull(sourceServerId, nameof(sourceServerId));

            SourceServerId = sourceServerId;
            CreateMode = PostgreSqlCreateMode.GeoRestore;
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlServerPropertiesForGeoRestore"/>. </summary>
        /// <param name="version"> Server version. </param>
        /// <param name="sslEnforcement"> Enable ssl enforcement or not when connect to server. </param>
        /// <param name="minimalTlsVersion"> Enforce a minimal Tls version for the server. </param>
        /// <param name="infrastructureEncryption"> Status showing whether the server enabled infrastructure encryption. </param>
        /// <param name="publicNetworkAccess"> Whether or not public network access is allowed for this server. Value is optional but if passed in, must be 'Enabled' or 'Disabled'. </param>
        /// <param name="storageProfile"> Storage profile of a server. </param>
        /// <param name="createMode"> The mode to create a new server. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="sourceServerId"> The source server id to restore from. </param>
        internal PostgreSqlServerPropertiesForGeoRestore(PostgreSqlServerVersion? version, PostgreSqlSslEnforcementEnum? sslEnforcement, PostgreSqlMinimalTlsVersionEnum? minimalTlsVersion, PostgreSqlInfrastructureEncryption? infrastructureEncryption, PostgreSqlPublicNetworkAccessEnum? publicNetworkAccess, PostgreSqlStorageProfile storageProfile, PostgreSqlCreateMode createMode, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier sourceServerId) : base(version, sslEnforcement, minimalTlsVersion, infrastructureEncryption, publicNetworkAccess, storageProfile, createMode, serializedAdditionalRawData)
        {
            SourceServerId = sourceServerId;
            CreateMode = createMode;
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlServerPropertiesForGeoRestore"/> for deserialization. </summary>
        internal PostgreSqlServerPropertiesForGeoRestore()
        {
        }

        /// <summary> The source server id to restore from. </summary>
        public ResourceIdentifier SourceServerId { get; }
    }
}
