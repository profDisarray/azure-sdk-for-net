// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkConfigurationDiagnosticContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetResourceId"u8);
            writer.WriteStringValue(TargetResourceId);
            if (Optional.IsDefined(VerbosityLevel))
            {
                writer.WritePropertyName("verbosityLevel"u8);
                writer.WriteStringValue(VerbosityLevel.Value.ToString());
            }
            writer.WritePropertyName("profiles"u8);
            writer.WriteStartArray();
            foreach (var item in Profiles)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}
