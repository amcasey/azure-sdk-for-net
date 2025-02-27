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
    internal partial class PhysicalPartitionThroughputInfoProperties : IUtf8JsonSerializable, IJsonModel<PhysicalPartitionThroughputInfoProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PhysicalPartitionThroughputInfoProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PhysicalPartitionThroughputInfoProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PhysicalPartitionThroughputInfoProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PhysicalPartitionThroughputInfoProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PhysicalPartitionThroughputInfo))
            {
                writer.WritePropertyName("physicalPartitionThroughputInfo"u8);
                writer.WriteStartArray();
                foreach (var item in PhysicalPartitionThroughputInfo)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        PhysicalPartitionThroughputInfoProperties IJsonModel<PhysicalPartitionThroughputInfoProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PhysicalPartitionThroughputInfoProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PhysicalPartitionThroughputInfoProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePhysicalPartitionThroughputInfoProperties(document.RootElement, options);
        }

        internal static PhysicalPartitionThroughputInfoProperties DeserializePhysicalPartitionThroughputInfoProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<PhysicalPartitionThroughputInfoResource>> physicalPartitionThroughputInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("physicalPartitionThroughputInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PhysicalPartitionThroughputInfoResource> array = new List<PhysicalPartitionThroughputInfoResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PhysicalPartitionThroughputInfoResource.DeserializePhysicalPartitionThroughputInfoResource(item));
                    }
                    physicalPartitionThroughputInfo = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PhysicalPartitionThroughputInfoProperties(Optional.ToList(physicalPartitionThroughputInfo), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PhysicalPartitionThroughputInfoProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PhysicalPartitionThroughputInfoProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PhysicalPartitionThroughputInfoProperties)} does not support '{options.Format}' format.");
            }
        }

        PhysicalPartitionThroughputInfoProperties IPersistableModel<PhysicalPartitionThroughputInfoProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PhysicalPartitionThroughputInfoProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePhysicalPartitionThroughputInfoProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PhysicalPartitionThroughputInfoProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PhysicalPartitionThroughputInfoProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
