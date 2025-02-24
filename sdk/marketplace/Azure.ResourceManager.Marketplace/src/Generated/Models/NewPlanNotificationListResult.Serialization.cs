// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class NewPlanNotificationListResult : IUtf8JsonSerializable, IJsonModel<NewPlanNotificationListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NewPlanNotificationListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NewPlanNotificationListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewPlanNotificationListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewPlanNotificationListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(NewPlansNotifications))
            {
                writer.WritePropertyName("newPlansNotifications"u8);
                writer.WriteStartArray();
                foreach (var item in NewPlansNotifications)
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

        NewPlanNotificationListResult IJsonModel<NewPlanNotificationListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewPlanNotificationListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewPlanNotificationListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNewPlanNotificationListResult(document.RootElement, options);
        }

        internal static NewPlanNotificationListResult DeserializeNewPlanNotificationListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<NewPlanNotification>> newPlansNotifications = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("newPlansNotifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NewPlanNotification> array = new List<NewPlanNotification>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NewPlanNotification.DeserializeNewPlanNotification(item));
                    }
                    newPlansNotifications = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NewPlanNotificationListResult(Optional.ToList(newPlansNotifications), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NewPlanNotificationListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewPlanNotificationListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NewPlanNotificationListResult)} does not support '{options.Format}' format.");
            }
        }

        NewPlanNotificationListResult IPersistableModel<NewPlanNotificationListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewPlanNotificationListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNewPlanNotificationListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NewPlanNotificationListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NewPlanNotificationListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
