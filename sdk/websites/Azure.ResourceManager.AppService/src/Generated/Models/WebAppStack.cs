// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Web App stack. </summary>
    public partial class WebAppStack : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WebAppStack"/>. </summary>
        public WebAppStack()
        {
            MajorVersions = new ChangeTrackingList<WebAppMajorVersion>();
        }

        /// <summary> Initializes a new instance of <see cref="WebAppStack"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Web App stack location. </param>
        /// <param name="displayText"> Web App stack (display only). </param>
        /// <param name="value"> Web App stack name. </param>
        /// <param name="majorVersions"> List of major versions available. </param>
        /// <param name="preferredOS"> Web App stack preferred OS. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WebAppStack(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, string displayText, string value, IReadOnlyList<WebAppMajorVersion> majorVersions, StackPreferredOS? preferredOS, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Location = location;
            DisplayText = displayText;
            Value = value;
            MajorVersions = majorVersions;
            PreferredOS = preferredOS;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Web App stack location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Web App stack (display only). </summary>
        public string DisplayText { get; }
        /// <summary> Web App stack name. </summary>
        public string Value { get; }
        /// <summary> List of major versions available. </summary>
        public IReadOnlyList<WebAppMajorVersion> MajorVersions { get; }
        /// <summary> Web App stack preferred OS. </summary>
        public StackPreferredOS? PreferredOS { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
