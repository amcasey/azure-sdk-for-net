// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Schedule info describing when the server should be started or stopped. </summary>
    public partial class SqlScheduleItem
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

        /// <summary> Initializes a new instance of <see cref="SqlScheduleItem"/>. </summary>
        /// <param name="startDay"> Start day. </param>
        /// <param name="startTime"> Start time. </param>
        /// <param name="stopDay"> Stop day. </param>
        /// <param name="stopTime"> Stop time. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="startTime"/> or <paramref name="stopTime"/> is null. </exception>
        public SqlScheduleItem(SqlDayOfWeek startDay, string startTime, SqlDayOfWeek stopDay, string stopTime)
        {
            Argument.AssertNotNull(startTime, nameof(startTime));
            Argument.AssertNotNull(stopTime, nameof(stopTime));

            StartDay = startDay;
            StartTime = startTime;
            StopDay = stopDay;
            StopTime = stopTime;
        }

        /// <summary> Initializes a new instance of <see cref="SqlScheduleItem"/>. </summary>
        /// <param name="startDay"> Start day. </param>
        /// <param name="startTime"> Start time. </param>
        /// <param name="stopDay"> Stop day. </param>
        /// <param name="stopTime"> Stop time. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlScheduleItem(SqlDayOfWeek startDay, string startTime, SqlDayOfWeek stopDay, string stopTime, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StartDay = startDay;
            StartTime = startTime;
            StopDay = stopDay;
            StopTime = stopTime;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SqlScheduleItem"/> for deserialization. </summary>
        internal SqlScheduleItem()
        {
        }

        /// <summary> Start day. </summary>
        public SqlDayOfWeek StartDay { get; set; }
        /// <summary> Start time. </summary>
        public string StartTime { get; set; }
        /// <summary> Stop day. </summary>
        public SqlDayOfWeek StopDay { get; set; }
        /// <summary> Stop time. </summary>
        public string StopTime { get; set; }
    }
}
