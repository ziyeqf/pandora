using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.SecurityInsights.v2022_10_01_preview.AlertRules;


internal class FusionSourceSettingsModel
{
    [JsonPropertyName("enabled")]
    [Required]
    public bool Enabled { get; set; }

    [JsonPropertyName("sourceName")]
    [Required]
    public string SourceName { get; set; }

    [JsonPropertyName("sourceSubTypes")]
    public List<FusionSourceSubTypeSettingModel>? SourceSubTypes { get; set; }
}
