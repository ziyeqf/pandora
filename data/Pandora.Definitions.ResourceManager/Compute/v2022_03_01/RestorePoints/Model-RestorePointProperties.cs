using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Compute.v2022_03_01.RestorePoints;


internal class RestorePointPropertiesModel
{
    [JsonPropertyName("consistencyMode")]
    public ConsistencyModeTypesConstant? ConsistencyMode { get; set; }

    [JsonPropertyName("excludeDisks")]
    public List<ApiEntityReferenceModel>? ExcludeDisks { get; set; }

    [JsonPropertyName("instanceView")]
    public RestorePointInstanceViewModel? InstanceView { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("sourceMetadata")]
    public RestorePointSourceMetadataModel? SourceMetadata { get; set; }

    [JsonPropertyName("sourceRestorePoint")]
    public ApiEntityReferenceModel? SourceRestorePoint { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("timeCreated")]
    public DateTime? TimeCreated { get; set; }
}
