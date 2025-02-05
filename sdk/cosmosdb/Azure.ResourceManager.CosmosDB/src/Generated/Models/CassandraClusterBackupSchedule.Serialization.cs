// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CassandraClusterBackupSchedule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ScheduleName))
            {
                writer.WritePropertyName("scheduleName"u8);
                writer.WriteStringValue(ScheduleName);
            }
            if (Optional.IsDefined(CronExpression))
            {
                writer.WritePropertyName("cronExpression"u8);
                writer.WriteStringValue(CronExpression);
            }
            if (Optional.IsDefined(RetentionInHours))
            {
                writer.WritePropertyName("retentionInHours"u8);
                writer.WriteNumberValue(RetentionInHours.Value);
            }
            writer.WriteEndObject();
        }

        internal static CassandraClusterBackupSchedule DeserializeCassandraClusterBackupSchedule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> scheduleName = default;
            Optional<string> cronExpression = default;
            Optional<int> retentionInHours = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheduleName"u8))
                {
                    scheduleName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cronExpression"u8))
                {
                    cronExpression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("retentionInHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionInHours = property.Value.GetInt32();
                    continue;
                }
            }
            return new CassandraClusterBackupSchedule(scheduleName.Value, cronExpression.Value, Optional.ToNullable(retentionInHours));
        }
    }
}
