// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    [PersistableModelProxy(typeof(UnknownFunctionRetrieveDefaultDefinitionParameters))]
    public partial class FunctionRetrieveDefaultDefinitionContent : IUtf8JsonSerializable, IJsonModel<FunctionRetrieveDefaultDefinitionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FunctionRetrieveDefaultDefinitionContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FunctionRetrieveDefaultDefinitionContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionRetrieveDefaultDefinitionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FunctionRetrieveDefaultDefinitionContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("bindingType"u8);
            writer.WriteStringValue(BindingType);
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

        FunctionRetrieveDefaultDefinitionContent IJsonModel<FunctionRetrieveDefaultDefinitionContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionRetrieveDefaultDefinitionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FunctionRetrieveDefaultDefinitionContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFunctionRetrieveDefaultDefinitionContent(document.RootElement, options);
        }

        internal static FunctionRetrieveDefaultDefinitionContent DeserializeFunctionRetrieveDefaultDefinitionContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("bindingType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Microsoft.MachineLearning/WebService": return MachineLearningStudioFunctionRetrieveDefaultDefinitionContent.DeserializeMachineLearningStudioFunctionRetrieveDefaultDefinitionContent(element);
                    case "Microsoft.MachineLearningServices": return MachineLearningServiceFunctionRetrieveDefaultDefinitionContent.DeserializeMachineLearningServiceFunctionRetrieveDefaultDefinitionContent(element);
                    case "Microsoft.StreamAnalytics/CLRUdf": return CSharpFunctionRetrieveDefaultDefinitionContent.DeserializeCSharpFunctionRetrieveDefaultDefinitionContent(element);
                    case "Microsoft.StreamAnalytics/JavascriptUdf": return JavaScriptFunctionRetrieveDefaultDefinitionContent.DeserializeJavaScriptFunctionRetrieveDefaultDefinitionContent(element);
                }
            }
            return UnknownFunctionRetrieveDefaultDefinitionParameters.DeserializeUnknownFunctionRetrieveDefaultDefinitionParameters(element);
        }

        BinaryData IPersistableModel<FunctionRetrieveDefaultDefinitionContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionRetrieveDefaultDefinitionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FunctionRetrieveDefaultDefinitionContent)} does not support '{options.Format}' format.");
            }
        }

        FunctionRetrieveDefaultDefinitionContent IPersistableModel<FunctionRetrieveDefaultDefinitionContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionRetrieveDefaultDefinitionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFunctionRetrieveDefaultDefinitionContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FunctionRetrieveDefaultDefinitionContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FunctionRetrieveDefaultDefinitionContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
