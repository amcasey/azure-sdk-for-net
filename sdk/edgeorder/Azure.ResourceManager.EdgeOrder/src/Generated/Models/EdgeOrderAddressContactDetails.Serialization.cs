// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class EdgeOrderAddressContactDetails : IUtf8JsonSerializable, IJsonModel<EdgeOrderAddressContactDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeOrderAddressContactDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdgeOrderAddressContactDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderAddressContactDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeOrderAddressContactDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("contactName"u8);
            writer.WriteStringValue(ContactName);
            writer.WritePropertyName("phone"u8);
            writer.WriteStringValue(Phone);
            if (Optional.IsDefined(PhoneExtension))
            {
                writer.WritePropertyName("phoneExtension"u8);
                writer.WriteStringValue(PhoneExtension);
            }
            if (Optional.IsDefined(Mobile))
            {
                writer.WritePropertyName("mobile"u8);
                writer.WriteStringValue(Mobile);
            }
            writer.WritePropertyName("emailList"u8);
            writer.WriteStartArray();
            foreach (var item in EmailList)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
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

        EdgeOrderAddressContactDetails IJsonModel<EdgeOrderAddressContactDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderAddressContactDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeOrderAddressContactDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeOrderAddressContactDetails(document.RootElement, options);
        }

        internal static EdgeOrderAddressContactDetails DeserializeEdgeOrderAddressContactDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string contactName = default;
            string phone = default;
            Optional<string> phoneExtension = default;
            Optional<string> mobile = default;
            IList<string> emailList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contactName"u8))
                {
                    contactName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phone"u8))
                {
                    phone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phoneExtension"u8))
                {
                    phoneExtension = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mobile"u8))
                {
                    mobile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("emailList"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    emailList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EdgeOrderAddressContactDetails(contactName, phone, phoneExtension.Value, mobile.Value, emailList, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeOrderAddressContactDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderAddressContactDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdgeOrderAddressContactDetails)} does not support '{options.Format}' format.");
            }
        }

        EdgeOrderAddressContactDetails IPersistableModel<EdgeOrderAddressContactDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderAddressContactDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdgeOrderAddressContactDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeOrderAddressContactDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeOrderAddressContactDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
