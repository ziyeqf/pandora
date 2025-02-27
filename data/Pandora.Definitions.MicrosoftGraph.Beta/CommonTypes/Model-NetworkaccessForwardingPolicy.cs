// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class NetworkaccessForwardingPolicyModel
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("policyRules")]
    public List<NetworkaccessPolicyRuleModel>? PolicyRules { get; set; }

    [JsonPropertyName("trafficForwardingType")]
    public NetworkaccessForwardingPolicyTrafficForwardingTypeConstant? TrafficForwardingType { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
