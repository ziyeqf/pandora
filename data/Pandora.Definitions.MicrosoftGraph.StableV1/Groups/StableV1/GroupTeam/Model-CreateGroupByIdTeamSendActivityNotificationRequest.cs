// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Groups.StableV1.GroupTeam;

internal class CreateGroupByIdTeamSendActivityNotificationRequestModel
{
    [JsonPropertyName("activityType")]
    public string? ActivityType { get; set; }

    [JsonPropertyName("chainId")]
    public int? ChainId { get; set; }

    [JsonPropertyName("previewText")]
    public ItemBodyModel? PreviewText { get; set; }

    [JsonPropertyName("recipient")]
    public TeamworkNotificationRecipientModel? Recipient { get; set; }

    [JsonPropertyName("templateParameters")]
    public List<KeyValuePairModel>? TemplateParameters { get; set; }

    [JsonPropertyName("topic")]
    public TeamworkActivityTopicModel? Topic { get; set; }
}
