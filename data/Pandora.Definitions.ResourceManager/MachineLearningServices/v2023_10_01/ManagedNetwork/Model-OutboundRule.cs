using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_10_01.ManagedNetwork;


internal abstract class OutboundRuleModel
{
    [JsonPropertyName("category")]
    public RuleCategoryConstant? Category { get; set; }

    [JsonPropertyName("status")]
    public RuleStatusConstant? Status { get; set; }

    [JsonPropertyName("type")]
    [ProvidesTypeHint]
    [Required]
    public RuleTypeConstant Type { get; set; }
}
