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
using Azure.ResourceManager.Orbital.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Orbital
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Orbital. </summary>
    public static partial class OrbitalExtensions
    {
        private static MockableOrbitalArmClient GetMockableOrbitalArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableOrbitalArmClient(client0));
        }

        private static MockableOrbitalResourceGroupResource GetMockableOrbitalResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableOrbitalResourceGroupResource(client, resource.Id));
        }

        private static MockableOrbitalSubscriptionResource GetMockableOrbitalSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableOrbitalSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing an <see cref="OrbitalSpacecraftResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OrbitalSpacecraftResource.CreateResourceIdentifier" /> to create an <see cref="OrbitalSpacecraftResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableOrbitalArmClient.GetOrbitalSpacecraftResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="OrbitalSpacecraftResource"/> object. </returns>
        public static OrbitalSpacecraftResource GetOrbitalSpacecraftResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableOrbitalArmClient(client).GetOrbitalSpacecraftResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OrbitalContactResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OrbitalContactResource.CreateResourceIdentifier" /> to create an <see cref="OrbitalContactResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableOrbitalArmClient.GetOrbitalContactResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="OrbitalContactResource"/> object. </returns>
        public static OrbitalContactResource GetOrbitalContactResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableOrbitalArmClient(client).GetOrbitalContactResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OrbitalContactProfileResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OrbitalContactProfileResource.CreateResourceIdentifier" /> to create an <see cref="OrbitalContactProfileResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableOrbitalArmClient.GetOrbitalContactProfileResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="OrbitalContactProfileResource"/> object. </returns>
        public static OrbitalContactProfileResource GetOrbitalContactProfileResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableOrbitalArmClient(client).GetOrbitalContactProfileResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AvailableGroundStationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AvailableGroundStationResource.CreateResourceIdentifier" /> to create an <see cref="AvailableGroundStationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableOrbitalArmClient.GetAvailableGroundStationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="AvailableGroundStationResource"/> object. </returns>
        public static AvailableGroundStationResource GetAvailableGroundStationResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableOrbitalArmClient(client).GetAvailableGroundStationResource(id);
        }

        /// <summary>
        /// Gets a collection of OrbitalSpacecraftResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableOrbitalResourceGroupResource.GetOrbitalSpacecrafts()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of OrbitalSpacecraftResources and their operations over a OrbitalSpacecraftResource. </returns>
        public static OrbitalSpacecraftCollection GetOrbitalSpacecrafts(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableOrbitalResourceGroupResource(resourceGroupResource).GetOrbitalSpacecrafts();
        }

        /// <summary>
        /// Gets the specified spacecraft in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/spacecrafts/{spacecraftName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Spacecrafts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OrbitalSpacecraftResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableOrbitalResourceGroupResource.GetOrbitalSpacecraftAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="spacecraftName"> Spacecraft ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="spacecraftName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="spacecraftName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<OrbitalSpacecraftResource>> GetOrbitalSpacecraftAsync(this ResourceGroupResource resourceGroupResource, string spacecraftName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableOrbitalResourceGroupResource(resourceGroupResource).GetOrbitalSpacecraftAsync(spacecraftName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified spacecraft in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/spacecrafts/{spacecraftName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Spacecrafts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OrbitalSpacecraftResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableOrbitalResourceGroupResource.GetOrbitalSpacecraft(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="spacecraftName"> Spacecraft ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="spacecraftName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="spacecraftName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<OrbitalSpacecraftResource> GetOrbitalSpacecraft(this ResourceGroupResource resourceGroupResource, string spacecraftName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableOrbitalResourceGroupResource(resourceGroupResource).GetOrbitalSpacecraft(spacecraftName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of OrbitalContactProfileResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableOrbitalResourceGroupResource.GetOrbitalContactProfiles()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of OrbitalContactProfileResources and their operations over a OrbitalContactProfileResource. </returns>
        public static OrbitalContactProfileCollection GetOrbitalContactProfiles(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableOrbitalResourceGroupResource(resourceGroupResource).GetOrbitalContactProfiles();
        }

        /// <summary>
        /// Gets the specified contact Profile in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/contactProfiles/{contactProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContactProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OrbitalContactProfileResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableOrbitalResourceGroupResource.GetOrbitalContactProfileAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="contactProfileName"> Contact Profile name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="contactProfileName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="contactProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<OrbitalContactProfileResource>> GetOrbitalContactProfileAsync(this ResourceGroupResource resourceGroupResource, string contactProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableOrbitalResourceGroupResource(resourceGroupResource).GetOrbitalContactProfileAsync(contactProfileName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified contact Profile in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/contactProfiles/{contactProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContactProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OrbitalContactProfileResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableOrbitalResourceGroupResource.GetOrbitalContactProfile(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="contactProfileName"> Contact Profile name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="contactProfileName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="contactProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<OrbitalContactProfileResource> GetOrbitalContactProfile(this ResourceGroupResource resourceGroupResource, string contactProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableOrbitalResourceGroupResource(resourceGroupResource).GetOrbitalContactProfile(contactProfileName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of AvailableGroundStationResources in the SubscriptionResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableOrbitalSubscriptionResource.GetAvailableGroundStations()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An object representing collection of AvailableGroundStationResources and their operations over a AvailableGroundStationResource. </returns>
        public static AvailableGroundStationCollection GetAvailableGroundStations(this SubscriptionResource subscriptionResource)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableOrbitalSubscriptionResource(subscriptionResource).GetAvailableGroundStations();
        }

        /// <summary>
        /// Gets the specified available ground station.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/availableGroundStations/{groundStationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableGroundStations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvailableGroundStationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableOrbitalSubscriptionResource.GetAvailableGroundStationAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="groundStationName"> Ground Station name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="groundStationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="groundStationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<AvailableGroundStationResource>> GetAvailableGroundStationAsync(this SubscriptionResource subscriptionResource, string groundStationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableOrbitalSubscriptionResource(subscriptionResource).GetAvailableGroundStationAsync(groundStationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified available ground station.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/availableGroundStations/{groundStationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableGroundStations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvailableGroundStationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableOrbitalSubscriptionResource.GetAvailableGroundStation(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="groundStationName"> Ground Station name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="groundStationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="groundStationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<AvailableGroundStationResource> GetAvailableGroundStation(this SubscriptionResource subscriptionResource, string groundStationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableOrbitalSubscriptionResource(subscriptionResource).GetAvailableGroundStation(groundStationName, cancellationToken);
        }

        /// <summary>
        /// Returns list of spacecrafts by subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/spacecrafts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Spacecrafts_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OrbitalSpacecraftResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableOrbitalSubscriptionResource.GetOrbitalSpacecrafts(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skiptoken"> An opaque string that the resource provider uses to skip over previously-returned results. This is used when a previous list operation call returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="OrbitalSpacecraftResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<OrbitalSpacecraftResource> GetOrbitalSpacecraftsAsync(this SubscriptionResource subscriptionResource, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableOrbitalSubscriptionResource(subscriptionResource).GetOrbitalSpacecraftsAsync(skiptoken, cancellationToken);
        }

        /// <summary>
        /// Returns list of spacecrafts by subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/spacecrafts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Spacecrafts_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OrbitalSpacecraftResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableOrbitalSubscriptionResource.GetOrbitalSpacecrafts(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skiptoken"> An opaque string that the resource provider uses to skip over previously-returned results. This is used when a previous list operation call returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="OrbitalSpacecraftResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<OrbitalSpacecraftResource> GetOrbitalSpacecrafts(this SubscriptionResource subscriptionResource, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableOrbitalSubscriptionResource(subscriptionResource).GetOrbitalSpacecrafts(skiptoken, cancellationToken);
        }

        /// <summary>
        /// Returns list of contact profiles by Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/contactProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContactProfiles_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OrbitalContactProfileResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableOrbitalSubscriptionResource.GetOrbitalContactProfiles(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skiptoken"> An opaque string that the resource provider uses to skip over previously-returned results. This is used when a previous list operation call returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="OrbitalContactProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<OrbitalContactProfileResource> GetOrbitalContactProfilesAsync(this SubscriptionResource subscriptionResource, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableOrbitalSubscriptionResource(subscriptionResource).GetOrbitalContactProfilesAsync(skiptoken, cancellationToken);
        }

        /// <summary>
        /// Returns list of contact profiles by Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Orbital/contactProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContactProfiles_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="OrbitalContactProfileResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableOrbitalSubscriptionResource.GetOrbitalContactProfiles(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skiptoken"> An opaque string that the resource provider uses to skip over previously-returned results. This is used when a previous list operation call returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="OrbitalContactProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<OrbitalContactProfileResource> GetOrbitalContactProfiles(this SubscriptionResource subscriptionResource, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableOrbitalSubscriptionResource(subscriptionResource).GetOrbitalContactProfiles(skiptoken, cancellationToken);
        }
    }
}
