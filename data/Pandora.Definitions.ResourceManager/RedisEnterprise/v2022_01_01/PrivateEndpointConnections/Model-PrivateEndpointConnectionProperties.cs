using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.RedisEnterprise.v2022_01_01.PrivateEndpointConnections;


internal class PrivateEndpointConnectionPropertiesModel
{
    [JsonPropertyName("privateEndpoint")]
    public PrivateEndpointModel? PrivateEndpoint { get; set; }

    [JsonPropertyName("privateLinkServiceConnectionState")]
    [Required]
    public PrivateLinkServiceConnectionStateModel PrivateLinkServiceConnectionState { get; set; }

    [JsonPropertyName("provisioningState")]
    public PrivateEndpointConnectionProvisioningStateConstant? ProvisioningState { get; set; }
}
