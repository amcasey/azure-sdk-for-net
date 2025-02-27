// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class MongoClusterRestoreParameters : IUtf8JsonSerializable, IJsonModel<MongoClusterRestoreParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MongoClusterRestoreParameters>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MongoClusterRestoreParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoClusterRestoreParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoClusterRestoreParameters)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PointInTimeUTC))
            {
                writer.WritePropertyName("pointInTimeUTC"u8);
                writer.WriteStringValue(PointInTimeUTC.Value, "O");
            }
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MongoClusterRestoreParameters IJsonModel<MongoClusterRestoreParameters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoClusterRestoreParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoClusterRestoreParameters)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMongoClusterRestoreParameters(document.RootElement, options);
        }

        internal static MongoClusterRestoreParameters DeserializeMongoClusterRestoreParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> pointInTimeUTC = default;
            Optional<string> sourceResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pointInTimeUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pointInTimeUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("sourceResourceId"u8))
                {
                    sourceResourceId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MongoClusterRestoreParameters(Optional.ToNullable(pointInTimeUTC), sourceResourceId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MongoClusterRestoreParameters>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoClusterRestoreParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MongoClusterRestoreParameters)} does not support '{options.Format}' format.");
            }
        }

        MongoClusterRestoreParameters IPersistableModel<MongoClusterRestoreParameters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoClusterRestoreParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMongoClusterRestoreParameters(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MongoClusterRestoreParameters)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MongoClusterRestoreParameters>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
