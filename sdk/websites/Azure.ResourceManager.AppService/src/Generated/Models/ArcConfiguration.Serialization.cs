// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ArcConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ArtifactsStorageType))
            {
                writer.WritePropertyName("artifactsStorageType"u8);
                writer.WriteStringValue(ArtifactsStorageType.Value.ToSerialString());
            }
            if (Optional.IsDefined(ArtifactStorageClassName))
            {
                writer.WritePropertyName("artifactStorageClassName"u8);
                writer.WriteStringValue(ArtifactStorageClassName);
            }
            if (Optional.IsDefined(ArtifactStorageMountPath))
            {
                writer.WritePropertyName("artifactStorageMountPath"u8);
                writer.WriteStringValue(ArtifactStorageMountPath);
            }
            if (Optional.IsDefined(ArtifactStorageNodeName))
            {
                writer.WritePropertyName("artifactStorageNodeName"u8);
                writer.WriteStringValue(ArtifactStorageNodeName);
            }
            if (Optional.IsDefined(ArtifactStorageAccessMode))
            {
                writer.WritePropertyName("artifactStorageAccessMode"u8);
                writer.WriteStringValue(ArtifactStorageAccessMode);
            }
            if (Optional.IsDefined(FrontEndServiceConfiguration))
            {
                writer.WritePropertyName("frontEndServiceConfiguration"u8);
                writer.WriteObjectValue(FrontEndServiceConfiguration);
            }
            if (Optional.IsDefined(KubeConfig))
            {
                writer.WritePropertyName("kubeConfig"u8);
                writer.WriteStringValue(KubeConfig);
            }
            writer.WriteEndObject();
        }

        internal static ArcConfiguration DeserializeArcConfiguration(JsonElement element)
        {
            Optional<ArtifactStorageType> artifactsStorageType = default;
            Optional<string> artifactStorageClassName = default;
            Optional<string> artifactStorageMountPath = default;
            Optional<string> artifactStorageNodeName = default;
            Optional<string> artifactStorageAccessMode = default;
            Optional<FrontEndConfiguration> frontEndServiceConfiguration = default;
            Optional<string> kubeConfig = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactsStorageType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    artifactsStorageType = property.Value.GetString().ToArtifactStorageType();
                    continue;
                }
                if (property.NameEquals("artifactStorageClassName"u8))
                {
                    artifactStorageClassName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactStorageMountPath"u8))
                {
                    artifactStorageMountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactStorageNodeName"u8))
                {
                    artifactStorageNodeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactStorageAccessMode"u8))
                {
                    artifactStorageAccessMode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("frontEndServiceConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    frontEndServiceConfiguration = FrontEndConfiguration.DeserializeFrontEndConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("kubeConfig"u8))
                {
                    kubeConfig = property.Value.GetString();
                    continue;
                }
            }
            return new ArcConfiguration(Optional.ToNullable(artifactsStorageType), artifactStorageClassName.Value, artifactStorageMountPath.Value, artifactStorageNodeName.Value, artifactStorageAccessMode.Value, frontEndServiceConfiguration.Value, kubeConfig.Value);
        }
    }
}
