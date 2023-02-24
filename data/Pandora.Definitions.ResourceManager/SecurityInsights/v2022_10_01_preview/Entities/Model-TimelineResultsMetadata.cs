using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.SecurityInsights.v2022_10_01_preview.Entities;


internal class TimelineResultsMetadataModel
{
    [JsonPropertyName("aggregations")]
    [Required]
    public List<TimelineAggregationModel> Aggregations { get; set; }

    [JsonPropertyName("errors")]
    public List<TimelineErrorModel>? Errors { get; set; }

    [JsonPropertyName("totalCount")]
    [Required]
    public int TotalCount { get; set; }
}
