using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerApps.v2023_05_01.ContainerAppsRevisions;


internal class VolumeModel
{
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("secrets")]
    public List<SecretVolumeItemModel>? Secrets { get; set; }

    [JsonPropertyName("storageName")]
    public string? StorageName { get; set; }

    [JsonPropertyName("storageType")]
    public StorageTypeConstant? StorageType { get; set; }
}
