// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

internal class ConversationMemberRoleUpdatedEventMessageDetailModel
{
    [JsonPropertyName("conversationMemberRoles")]
    public List<string>? ConversationMemberRoles { get; set; }

    [JsonPropertyName("conversationMemberUser")]
    public TeamworkUserIdentityModel? ConversationMemberUser { get; set; }

    [JsonPropertyName("initiator")]
    public IdentitySetModel? Initiator { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }
}
