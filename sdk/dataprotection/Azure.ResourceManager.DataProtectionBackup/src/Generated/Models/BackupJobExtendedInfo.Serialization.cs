// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class BackupJobExtendedInfo : IUtf8JsonSerializable, IJsonModel<BackupJobExtendedInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupJobExtendedInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupJobExtendedInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupJobExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupJobExtendedInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AdditionalDetails))
            {
                writer.WritePropertyName("additionalDetails"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalDetails)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(BackupInstanceState))
            {
                writer.WritePropertyName("backupInstanceState"u8);
                writer.WriteStringValue(BackupInstanceState);
            }
            if (options.Format != "W" && Optional.IsDefined(DataTransferredInBytes))
            {
                writer.WritePropertyName("dataTransferredInBytes"u8);
                writer.WriteNumberValue(DataTransferredInBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RecoveryDestination))
            {
                writer.WritePropertyName("recoveryDestination"u8);
                writer.WriteStringValue(RecoveryDestination);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceRecoverPoint))
            {
                writer.WritePropertyName("sourceRecoverPoint"u8);
                writer.WriteObjectValue(SourceRecoverPoint);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SubTasks))
            {
                writer.WritePropertyName("subTasks"u8);
                writer.WriteStartArray();
                foreach (var item in SubTasks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(TargetRecoverPoint))
            {
                writer.WritePropertyName("targetRecoverPoint"u8);
                writer.WriteObjectValue(TargetRecoverPoint);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(WarningDetails))
            {
                writer.WritePropertyName("warningDetails"u8);
                writer.WriteStartArray();
                foreach (var item in WarningDetails)
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

        BackupJobExtendedInfo IJsonModel<BackupJobExtendedInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupJobExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupJobExtendedInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupJobExtendedInfo(document.RootElement, options);
        }

        internal static BackupJobExtendedInfo DeserializeBackupJobExtendedInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyDictionary<string, string>> additionalDetails = default;
            Optional<string> backupInstanceState = default;
            Optional<double> dataTransferredInBytes = default;
            Optional<string> recoveryDestination = default;
            Optional<RestoreJobRecoveryPointDetails> sourceRecoverPoint = default;
            Optional<IReadOnlyList<BackupJobSubTask>> subTasks = default;
            Optional<RestoreJobRecoveryPointDetails> targetRecoverPoint = default;
            Optional<IReadOnlyList<UserFacingWarningDetail>> warningDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("additionalDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    additionalDetails = dictionary;
                    continue;
                }
                if (property.NameEquals("backupInstanceState"u8))
                {
                    backupInstanceState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataTransferredInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataTransferredInBytes = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("recoveryDestination"u8))
                {
                    recoveryDestination = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRecoverPoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRecoverPoint = RestoreJobRecoveryPointDetails.DeserializeRestoreJobRecoveryPointDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("subTasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BackupJobSubTask> array = new List<BackupJobSubTask>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BackupJobSubTask.DeserializeBackupJobSubTask(item));
                    }
                    subTasks = array;
                    continue;
                }
                if (property.NameEquals("targetRecoverPoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetRecoverPoint = RestoreJobRecoveryPointDetails.DeserializeRestoreJobRecoveryPointDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("warningDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UserFacingWarningDetail> array = new List<UserFacingWarningDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserFacingWarningDetail.DeserializeUserFacingWarningDetail(item));
                    }
                    warningDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackupJobExtendedInfo(Optional.ToDictionary(additionalDetails), backupInstanceState.Value, Optional.ToNullable(dataTransferredInBytes), recoveryDestination.Value, sourceRecoverPoint.Value, Optional.ToList(subTasks), targetRecoverPoint.Value, Optional.ToList(warningDetails), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupJobExtendedInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupJobExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupJobExtendedInfo)} does not support '{options.Format}' format.");
            }
        }

        BackupJobExtendedInfo IPersistableModel<BackupJobExtendedInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupJobExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupJobExtendedInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupJobExtendedInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupJobExtendedInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
