using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2023_03_01_preview.Logger;


internal class LoggerContractPropertiesModel
{
    [JsonPropertyName("credentials")]
    public Dictionary<string, string>? Credentials { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("isBuffered")]
    public bool? IsBuffered { get; set; }

    [JsonPropertyName("loggerType")]
    [Required]
    public LoggerTypeConstant LoggerType { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}
