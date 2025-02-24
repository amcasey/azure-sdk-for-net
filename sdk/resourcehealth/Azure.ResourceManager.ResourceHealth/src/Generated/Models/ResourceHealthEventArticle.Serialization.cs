// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    public partial class ResourceHealthEventArticle : IUtf8JsonSerializable, IJsonModel<ResourceHealthEventArticle>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceHealthEventArticle>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceHealthEventArticle>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventArticle>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceHealthEventArticle)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ArticleContent))
            {
                writer.WritePropertyName("articleContent"u8);
                writer.WriteStringValue(ArticleContent);
            }
            if (Optional.IsDefined(ArticleId))
            {
                writer.WritePropertyName("articleId"u8);
                writer.WriteStringValue(ArticleId);
            }
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Parameters);
#else
                using (JsonDocument document = JsonDocument.Parse(Parameters))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        ResourceHealthEventArticle IJsonModel<ResourceHealthEventArticle>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventArticle>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceHealthEventArticle)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceHealthEventArticle(document.RootElement, options);
        }

        internal static ResourceHealthEventArticle DeserializeResourceHealthEventArticle(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> articleContent = default;
            Optional<string> articleId = default;
            Optional<BinaryData> parameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("articleContent"u8))
                {
                    articleContent = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("articleId"u8))
                {
                    articleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceHealthEventArticle(articleContent.Value, articleId.Value, parameters.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceHealthEventArticle>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventArticle>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceHealthEventArticle)} does not support '{options.Format}' format.");
            }
        }

        ResourceHealthEventArticle IPersistableModel<ResourceHealthEventArticle>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventArticle>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceHealthEventArticle(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceHealthEventArticle)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceHealthEventArticle>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
