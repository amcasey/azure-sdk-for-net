// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> BGP configuration properties. </summary>
    public partial class BgpConfiguration : AnnotationResourceProperties
    {
        /// <summary> Initializes a new instance of <see cref="BgpConfiguration"/>. </summary>
        public BgpConfiguration()
        {
            IPv4ListenRangePrefixes = new ChangeTrackingList<string>();
            IPv6ListenRangePrefixes = new ChangeTrackingList<string>();
            IPv4NeighborAddress = new ChangeTrackingList<NeighborAddress>();
            IPv6NeighborAddress = new ChangeTrackingList<NeighborAddress>();
        }

        /// <summary> Initializes a new instance of <see cref="BgpConfiguration"/>. </summary>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="bfdConfiguration"> BFD configuration properties. </param>
        /// <param name="defaultRouteOriginate"> Originate a defaultRoute. Ex: "True" | "False". </param>
        /// <param name="allowAS"> Allows for routes to be received and processed even if the router detects its own ASN in the AS-Path. 0 is disable, Possible values are 1-10, default is 2. </param>
        /// <param name="allowASOverride"> Enable Or Disable state. </param>
        /// <param name="fabricAsn"> ASN of Network Fabric. Example: 65048. </param>
        /// <param name="peerAsn"> Peer ASN. Example: 65047. </param>
        /// <param name="ipv4ListenRangePrefixes"> List of BGP IPv4 Listen Range prefixes. </param>
        /// <param name="ipv6ListenRangePrefixes"> List of BGP IPv6 Listen Ranges prefixes. </param>
        /// <param name="ipv4NeighborAddress"> List with stringified IPv4 Neighbor Addresses. </param>
        /// <param name="ipv6NeighborAddress"> List with stringified IPv6 Neighbor Address. </param>
        internal BgpConfiguration(string annotation, IDictionary<string, BinaryData> serializedAdditionalRawData, BfdConfiguration bfdConfiguration, NetworkFabricBooleanValue? defaultRouteOriginate, int? allowAS, AllowASOverride? allowASOverride, long? fabricAsn, long? peerAsn, IList<string> ipv4ListenRangePrefixes, IList<string> ipv6ListenRangePrefixes, IList<NeighborAddress> ipv4NeighborAddress, IList<NeighborAddress> ipv6NeighborAddress) : base(annotation, serializedAdditionalRawData)
        {
            BfdConfiguration = bfdConfiguration;
            DefaultRouteOriginate = defaultRouteOriginate;
            AllowAS = allowAS;
            AllowASOverride = allowASOverride;
            FabricAsn = fabricAsn;
            PeerAsn = peerAsn;
            IPv4ListenRangePrefixes = ipv4ListenRangePrefixes;
            IPv6ListenRangePrefixes = ipv6ListenRangePrefixes;
            IPv4NeighborAddress = ipv4NeighborAddress;
            IPv6NeighborAddress = ipv6NeighborAddress;
        }

        /// <summary> BFD configuration properties. </summary>
        public BfdConfiguration BfdConfiguration { get; set; }
        /// <summary> Originate a defaultRoute. Ex: "True" | "False". </summary>
        public NetworkFabricBooleanValue? DefaultRouteOriginate { get; set; }
        /// <summary> Allows for routes to be received and processed even if the router detects its own ASN in the AS-Path. 0 is disable, Possible values are 1-10, default is 2. </summary>
        public int? AllowAS { get; set; }
        /// <summary> Enable Or Disable state. </summary>
        public AllowASOverride? AllowASOverride { get; set; }
        /// <summary> ASN of Network Fabric. Example: 65048. </summary>
        public long? FabricAsn { get; }
        /// <summary> Peer ASN. Example: 65047. </summary>
        public long? PeerAsn { get; set; }
        /// <summary> List of BGP IPv4 Listen Range prefixes. </summary>
        public IList<string> IPv4ListenRangePrefixes { get; }
        /// <summary> List of BGP IPv6 Listen Ranges prefixes. </summary>
        public IList<string> IPv6ListenRangePrefixes { get; }
        /// <summary> List with stringified IPv4 Neighbor Addresses. </summary>
        public IList<NeighborAddress> IPv4NeighborAddress { get; }
        /// <summary> List with stringified IPv6 Neighbor Address. </summary>
        public IList<NeighborAddress> IPv6NeighborAddress { get; }
    }
}
