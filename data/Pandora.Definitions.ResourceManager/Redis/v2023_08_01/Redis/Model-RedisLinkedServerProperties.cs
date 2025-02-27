using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Redis.v2023_08_01.Redis;


internal class RedisLinkedServerPropertiesModel
{
    [JsonPropertyName("geoReplicatedPrimaryHostName")]
    public string? GeoReplicatedPrimaryHostName { get; set; }

    [JsonPropertyName("linkedRedisCacheId")]
    [Required]
    public string LinkedRedisCacheId { get; set; }

    [JsonPropertyName("linkedRedisCacheLocation")]
    [Required]
    public string LinkedRedisCacheLocation { get; set; }

    [JsonPropertyName("primaryHostName")]
    public string? PrimaryHostName { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("serverRole")]
    [Required]
    public ReplicationRoleConstant ServerRole { get; set; }
}
