// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    internal partial class ServiceError
    {
        internal static ServiceError DeserializeServiceError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> requestId = default;
            Optional<DateTimeOffset> responseDateTime = default;
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<string> exception = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("RequestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ResponseDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    responseDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("Code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Exception"u8))
                {
                    exception = property.Value.GetString();
                    continue;
                }
            }
            return new ServiceError(requestId.Value, Optional.ToNullable(responseDateTime), code.Value, message.Value, exception.Value);
        }
    }
}
