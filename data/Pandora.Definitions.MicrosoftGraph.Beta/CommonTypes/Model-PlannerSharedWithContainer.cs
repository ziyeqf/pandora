// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class PlannerSharedWithContainerModel
{
    [JsonPropertyName("accessLevel")]
    public PlannerSharedWithContainerAccessLevelConstant? AccessLevel { get; set; }

    [JsonPropertyName("containerId")]
    public string? ContainerId { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("type")]
    public PlannerSharedWithContainerTypeConstant? Type { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
