// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetIPConfiguration : IUtf8JsonSerializable, IJsonModel<VirtualMachineScaleSetIPConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineScaleSetIPConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineScaleSetIPConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetIPConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetIPConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Subnet))
            {
                writer.WritePropertyName("subnet"u8);
                JsonSerializer.Serialize(writer, Subnet);
            }
            if (Optional.IsDefined(Primary))
            {
                writer.WritePropertyName("primary"u8);
                writer.WriteBooleanValue(Primary.Value);
            }
            if (Optional.IsDefined(PublicIPAddressConfiguration))
            {
                writer.WritePropertyName("publicIPAddressConfiguration"u8);
                writer.WriteObjectValue(PublicIPAddressConfiguration);
            }
            if (Optional.IsDefined(PrivateIPAddressVersion))
            {
                writer.WritePropertyName("privateIPAddressVersion"u8);
                writer.WriteStringValue(PrivateIPAddressVersion.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ApplicationGatewayBackendAddressPools))
            {
                writer.WritePropertyName("applicationGatewayBackendAddressPools"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationGatewayBackendAddressPools)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ApplicationSecurityGroups))
            {
                writer.WritePropertyName("applicationSecurityGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationSecurityGroups)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LoadBalancerBackendAddressPools))
            {
                writer.WritePropertyName("loadBalancerBackendAddressPools"u8);
                writer.WriteStartArray();
                foreach (var item in LoadBalancerBackendAddressPools)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LoadBalancerInboundNatPools))
            {
                writer.WritePropertyName("loadBalancerInboundNatPools"u8);
                writer.WriteStartArray();
                foreach (var item in LoadBalancerInboundNatPools)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        VirtualMachineScaleSetIPConfiguration IJsonModel<VirtualMachineScaleSetIPConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetIPConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetIPConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetIPConfiguration(document.RootElement, options);
        }

        internal static VirtualMachineScaleSetIPConfiguration DeserializeVirtualMachineScaleSetIPConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<ResourceIdentifier> id = default;
            Optional<WritableSubResource> subnet = default;
            Optional<bool> primary = default;
            Optional<VirtualMachineScaleSetPublicIPAddressConfiguration> publicIPAddressConfiguration = default;
            Optional<IPVersion> privateIPAddressVersion = default;
            Optional<IList<WritableSubResource>> applicationGatewayBackendAddressPools = default;
            Optional<IList<WritableSubResource>> applicationSecurityGroups = default;
            Optional<IList<WritableSubResource>> loadBalancerBackendAddressPools = default;
            Optional<IList<WritableSubResource>> loadBalancerInboundNatPools = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("subnet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnet = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("primary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            primary = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publicIPAddressConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicIPAddressConfiguration = VirtualMachineScaleSetPublicIPAddressConfiguration.DeserializeVirtualMachineScaleSetPublicIPAddressConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("privateIPAddressVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateIPAddressVersion = new IPVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("applicationGatewayBackendAddressPools"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            applicationGatewayBackendAddressPools = array;
                            continue;
                        }
                        if (property0.NameEquals("applicationSecurityGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            applicationSecurityGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerBackendAddressPools"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            loadBalancerBackendAddressPools = array;
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerInboundNatPools"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            loadBalancerInboundNatPools = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineScaleSetIPConfiguration(id.Value, serializedAdditionalRawData, name, subnet, Optional.ToNullable(primary), publicIPAddressConfiguration.Value, Optional.ToNullable(privateIPAddressVersion), Optional.ToList(applicationGatewayBackendAddressPools), Optional.ToList(applicationSecurityGroups), Optional.ToList(loadBalancerBackendAddressPools), Optional.ToList(loadBalancerInboundNatPools));
        }

        BinaryData IPersistableModel<VirtualMachineScaleSetIPConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetIPConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetIPConfiguration)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineScaleSetIPConfiguration IPersistableModel<VirtualMachineScaleSetIPConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetIPConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineScaleSetIPConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetIPConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineScaleSetIPConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
