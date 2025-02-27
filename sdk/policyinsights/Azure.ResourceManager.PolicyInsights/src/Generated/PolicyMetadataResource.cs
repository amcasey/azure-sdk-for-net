// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PolicyInsights
{
    /// <summary>
    /// A Class representing a PolicyMetadata along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="PolicyMetadataResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetPolicyMetadataResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource"/> using the GetPolicyMetadata method.
    /// </summary>
    public partial class PolicyMetadataResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PolicyMetadataResource"/> instance. </summary>
        /// <param name="resourceName"> The resourceName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceName)
        {
            var resourceId = $"/providers/Microsoft.PolicyInsights/policyMetadata/{resourceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _policyMetadataPolicyMetadataClientDiagnostics;
        private readonly PolicyMetadataRestOperations _policyMetadataPolicyMetadataRestClient;
        private readonly PolicyMetadataData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.PolicyInsights/policyMetadata";

        /// <summary> Initializes a new instance of the <see cref="PolicyMetadataResource"/> class for mocking. </summary>
        protected PolicyMetadataResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyMetadataResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PolicyMetadataResource(ArmClient client, PolicyMetadataData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyMetadataResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PolicyMetadataResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _policyMetadataPolicyMetadataClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string policyMetadataPolicyMetadataApiVersion);
            _policyMetadataPolicyMetadataRestClient = new PolicyMetadataRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, policyMetadataPolicyMetadataApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PolicyMetadataData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get policy metadata resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.PolicyInsights/policyMetadata/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyMetadata_GetResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyMetadataResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PolicyMetadataResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _policyMetadataPolicyMetadataClientDiagnostics.CreateScope("PolicyMetadataResource.Get");
            scope.Start();
            try
            {
                var response = await _policyMetadataPolicyMetadataRestClient.GetResourceAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get policy metadata resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.PolicyInsights/policyMetadata/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyMetadata_GetResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyMetadataResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicyMetadataResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _policyMetadataPolicyMetadataClientDiagnostics.CreateScope("PolicyMetadataResource.Get");
            scope.Start();
            try
            {
                var response = _policyMetadataPolicyMetadataRestClient.GetResource(Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
