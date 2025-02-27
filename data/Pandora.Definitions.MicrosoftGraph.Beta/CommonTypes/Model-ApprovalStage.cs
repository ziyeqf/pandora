// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class ApprovalStageModel
{
    [JsonPropertyName("approvalStageTimeOutInDays")]
    public int? ApprovalStageTimeOutInDays { get; set; }

    [JsonPropertyName("escalationApprovers")]
    public List<UserSetModel>? EscalationApprovers { get; set; }

    [JsonPropertyName("escalationTimeInMinutes")]
    public int? EscalationTimeInMinutes { get; set; }

    [JsonPropertyName("isApproverJustificationRequired")]
    public bool? IsApproverJustificationRequired { get; set; }

    [JsonPropertyName("isEscalationEnabled")]
    public bool? IsEscalationEnabled { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("primaryApprovers")]
    public List<UserSetModel>? PrimaryApprovers { get; set; }
}
