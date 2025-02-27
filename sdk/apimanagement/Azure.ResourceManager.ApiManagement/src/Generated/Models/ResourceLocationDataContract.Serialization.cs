// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ResourceLocationDataContract : IUtf8JsonSerializable, IJsonModel<ResourceLocationDataContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceLocationDataContract>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceLocationDataContract>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceLocationDataContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceLocationDataContract)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(City))
            {
                writer.WritePropertyName("city"u8);
                writer.WriteStringValue(City);
            }
            if (Optional.IsDefined(District))
            {
                writer.WritePropertyName("district"u8);
                writer.WriteStringValue(District);
            }
            if (Optional.IsDefined(CountryOrRegion))
            {
                writer.WritePropertyName("countryOrRegion"u8);
                writer.WriteStringValue(CountryOrRegion);
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

        ResourceLocationDataContract IJsonModel<ResourceLocationDataContract>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceLocationDataContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceLocationDataContract)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceLocationDataContract(document.RootElement, options);
        }

        internal static ResourceLocationDataContract DeserializeResourceLocationDataContract(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<string> city = default;
            Optional<string> district = default;
            Optional<string> countryOrRegion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("city"u8))
                {
                    city = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("district"u8))
                {
                    district = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("countryOrRegion"u8))
                {
                    countryOrRegion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceLocationDataContract(name, city.Value, district.Value, countryOrRegion.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceLocationDataContract>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceLocationDataContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceLocationDataContract)} does not support '{options.Format}' format.");
            }
        }

        ResourceLocationDataContract IPersistableModel<ResourceLocationDataContract>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceLocationDataContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceLocationDataContract(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceLocationDataContract)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceLocationDataContract>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
