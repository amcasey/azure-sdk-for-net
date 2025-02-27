// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.DataLakeStore;

namespace Azure.ResourceManager.DataLakeStore.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableDataLakeStoreResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableDataLakeStoreResourceGroupResource"/> class for mocking. </summary>
        protected MockableDataLakeStoreResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDataLakeStoreResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDataLakeStoreResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DataLakeStoreAccountResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DataLakeStoreAccountResources and their operations over a DataLakeStoreAccountResource. </returns>
        public virtual DataLakeStoreAccountCollection GetDataLakeStoreAccounts()
        {
            return GetCachedClient(client => new DataLakeStoreAccountCollection(client, Id));
        }

        /// <summary>
        /// Gets the specified Data Lake Store account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeStoreAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DataLakeStoreAccountResource>> GetDataLakeStoreAccountAsync(string accountName, CancellationToken cancellationToken = default)
        {
            return await GetDataLakeStoreAccounts().GetAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Data Lake Store account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeStore/accounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataLakeStoreAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DataLakeStoreAccountResource> GetDataLakeStoreAccount(string accountName, CancellationToken cancellationToken = default)
        {
            return GetDataLakeStoreAccounts().Get(accountName, cancellationToken);
        }
    }
}
