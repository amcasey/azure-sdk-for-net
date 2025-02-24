// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Email Template update Parameters. </summary>
    public partial class ApiManagementEmailTemplateCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="ApiManagementEmailTemplateCreateOrUpdateContent"/>. </summary>
        public ApiManagementEmailTemplateCreateOrUpdateContent()
        {
            Parameters = new ChangeTrackingList<EmailTemplateParametersContractProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementEmailTemplateCreateOrUpdateContent"/>. </summary>
        /// <param name="subject"> Subject of the Template. </param>
        /// <param name="title"> Title of the Template. </param>
        /// <param name="description"> Description of the Email Template. </param>
        /// <param name="body"> Email Template Body. This should be a valid XDocument. </param>
        /// <param name="parameters"> Email Template Parameter values. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementEmailTemplateCreateOrUpdateContent(string subject, string title, string description, string body, IList<EmailTemplateParametersContractProperties> parameters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Subject = subject;
            Title = title;
            Description = description;
            Body = body;
            Parameters = parameters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Subject of the Template. </summary>
        public string Subject { get; set; }
        /// <summary> Title of the Template. </summary>
        public string Title { get; set; }
        /// <summary> Description of the Email Template. </summary>
        public string Description { get; set; }
        /// <summary> Email Template Body. This should be a valid XDocument. </summary>
        public string Body { get; set; }
        /// <summary> Email Template Parameter values. </summary>
        public IList<EmailTemplateParametersContractProperties> Parameters { get; }
    }
}
