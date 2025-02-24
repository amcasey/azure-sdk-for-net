// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class ResourceMoveChangeHistory : IUtf8JsonSerializable, IJsonModel<ResourceMoveChangeHistory>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceMoveChangeHistory>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceMoveChangeHistory>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceMoveChangeHistory>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceMoveChangeHistory)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AzureSubscriptionId))
            {
                writer.WritePropertyName("azureSubscriptionId"u8);
                writer.WriteStringValue(AzureSubscriptionId);
            }
            if (Optional.IsDefined(ResourceGroupName))
            {
                writer.WritePropertyName("resourceGroupName"u8);
                writer.WriteStringValue(ResourceGroupName);
            }
            if (Optional.IsDefined(ChangedTimeUtc))
            {
                writer.WritePropertyName("changedTimeUtc"u8);
                writer.WriteStringValue(ChangedTimeUtc.Value, "O");
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

        ResourceMoveChangeHistory IJsonModel<ResourceMoveChangeHistory>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceMoveChangeHistory>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceMoveChangeHistory)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceMoveChangeHistory(document.RootElement, options);
        }

        internal static ResourceMoveChangeHistory DeserializeResourceMoveChangeHistory(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> azureSubscriptionId = default;
            Optional<string> resourceGroupName = default;
            Optional<DateTimeOffset> changedTimeUtc = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureSubscriptionId"u8))
                {
                    azureSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroupName"u8))
                {
                    resourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("changedTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changedTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceMoveChangeHistory(azureSubscriptionId.Value, resourceGroupName.Value, Optional.ToNullable(changedTimeUtc), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceMoveChangeHistory>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceMoveChangeHistory>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceMoveChangeHistory)} does not support '{options.Format}' format.");
            }
        }

        ResourceMoveChangeHistory IPersistableModel<ResourceMoveChangeHistory>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceMoveChangeHistory>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceMoveChangeHistory(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceMoveChangeHistory)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceMoveChangeHistory>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
