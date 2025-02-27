// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class PassThroughQueueSelectorAttachment : IUtf8JsonSerializable, IJsonModel<PassThroughQueueSelectorAttachment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PassThroughQueueSelectorAttachment>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PassThroughQueueSelectorAttachment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PassThroughQueueSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PassThroughQueueSelectorAttachment)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("key"u8);
            writer.WriteStringValue(Key);
            writer.WritePropertyName("labelOperator"u8);
            writer.WriteStringValue(LabelOperator.ToString());
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        PassThroughQueueSelectorAttachment IJsonModel<PassThroughQueueSelectorAttachment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PassThroughQueueSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PassThroughQueueSelectorAttachment)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePassThroughQueueSelectorAttachment(document.RootElement, options);
        }

        internal static PassThroughQueueSelectorAttachment DeserializePassThroughQueueSelectorAttachment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string key = default;
            LabelOperator labelOperator = default;
            QueueSelectorAttachmentKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labelOperator"u8))
                {
                    labelOperator = new LabelOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new QueueSelectorAttachmentKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PassThroughQueueSelectorAttachment(kind, serializedAdditionalRawData, key, labelOperator);
        }

        BinaryData IPersistableModel<PassThroughQueueSelectorAttachment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PassThroughQueueSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PassThroughQueueSelectorAttachment)} does not support '{options.Format}' format.");
            }
        }

        PassThroughQueueSelectorAttachment IPersistableModel<PassThroughQueueSelectorAttachment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PassThroughQueueSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePassThroughQueueSelectorAttachment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PassThroughQueueSelectorAttachment)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PassThroughQueueSelectorAttachment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new PassThroughQueueSelectorAttachment FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePassThroughQueueSelectorAttachment(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
