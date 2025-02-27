// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    [PersistableModelProxy(typeof(UnknownDatasetStorageFormat))]
    public partial class DatasetStorageFormat : IUtf8JsonSerializable, IJsonModel<DatasetStorageFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DatasetStorageFormat>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DatasetStorageFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatasetStorageFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatasetStorageFormat)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DatasetStorageFormatType);
            if (Optional.IsDefined(Serializer))
            {
                writer.WritePropertyName("serializer"u8);
                JsonSerializer.Serialize(writer, Serializer);
            }
            if (Optional.IsDefined(Deserializer))
            {
                writer.WritePropertyName("deserializer"u8);
                JsonSerializer.Serialize(writer, Deserializer);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        DatasetStorageFormat IJsonModel<DatasetStorageFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatasetStorageFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatasetStorageFormat)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDatasetStorageFormat(document.RootElement, options);
        }

        internal static DatasetStorageFormat DeserializeDatasetStorageFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AvroFormat": return DatasetAvroFormat.DeserializeDatasetAvroFormat(element);
                    case "JsonFormat": return DatasetJsonFormat.DeserializeDatasetJsonFormat(element);
                    case "OrcFormat": return DatasetOrcFormat.DeserializeDatasetOrcFormat(element);
                    case "ParquetFormat": return DatasetParquetFormat.DeserializeDatasetParquetFormat(element);
                    case "TextFormat": return DatasetTextFormat.DeserializeDatasetTextFormat(element);
                }
            }
            return UnknownDatasetStorageFormat.DeserializeUnknownDatasetStorageFormat(element);
        }

        BinaryData IPersistableModel<DatasetStorageFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatasetStorageFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DatasetStorageFormat)} does not support '{options.Format}' format.");
            }
        }

        DatasetStorageFormat IPersistableModel<DatasetStorageFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatasetStorageFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDatasetStorageFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DatasetStorageFormat)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DatasetStorageFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
