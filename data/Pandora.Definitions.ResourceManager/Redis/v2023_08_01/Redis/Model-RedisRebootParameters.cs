using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Redis.v2023_08_01.Redis;


internal class RedisRebootParametersModel
{
    [JsonPropertyName("ports")]
    public List<int>? Ports { get; set; }

    [JsonPropertyName("rebootType")]
    public RebootTypeConstant? RebootType { get; set; }

    [JsonPropertyName("shardId")]
    public int? ShardId { get; set; }
}
