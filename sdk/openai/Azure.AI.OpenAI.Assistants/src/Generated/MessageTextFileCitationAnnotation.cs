// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> A citation within the message that points to a specific quote from a specific File associated with the assistant or the message. Generated when the assistant uses the 'retrieval' tool to search files. </summary>
    public partial class MessageTextFileCitationAnnotation : MessageTextAnnotation
    {
        /// <summary> Initializes a new instance of <see cref="MessageTextFileCitationAnnotation"/>. </summary>
        /// <param name="text"> The textual content associated with this text annotation item. </param>
        /// <param name="startIndex"> The first text index associated with this text annotation. </param>
        /// <param name="endIndex"> The last text index associated with this text annotation. </param>
        /// <param name="internalDetails">
        /// A citation within the message that points to a specific quote from a specific file.
        /// Generated when the assistant uses the "retrieval" tool to search files.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> or <paramref name="internalDetails"/> is null. </exception>
        internal MessageTextFileCitationAnnotation(string text, int startIndex, int endIndex, InternalMessageTextFileCitationDetails internalDetails) : base(text, startIndex, endIndex)
        {
            Argument.AssertNotNull(text, nameof(text));
            Argument.AssertNotNull(internalDetails, nameof(internalDetails));

            Type = "file_citation";
            InternalDetails = internalDetails;
        }

        /// <summary> Initializes a new instance of <see cref="MessageTextFileCitationAnnotation"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="text"> The textual content associated with this text annotation item. </param>
        /// <param name="startIndex"> The first text index associated with this text annotation. </param>
        /// <param name="endIndex"> The last text index associated with this text annotation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="internalDetails">
        /// A citation within the message that points to a specific quote from a specific file.
        /// Generated when the assistant uses the "retrieval" tool to search files.
        /// </param>
        internal MessageTextFileCitationAnnotation(string type, string text, int startIndex, int endIndex, IDictionary<string, BinaryData> serializedAdditionalRawData, InternalMessageTextFileCitationDetails internalDetails) : base(type, text, startIndex, endIndex, serializedAdditionalRawData)
        {
            InternalDetails = internalDetails;
        }

        /// <summary> Initializes a new instance of <see cref="MessageTextFileCitationAnnotation"/> for deserialization. </summary>
        internal MessageTextFileCitationAnnotation()
        {
        }
    }
}
