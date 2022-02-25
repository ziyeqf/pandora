using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.RedisEnterprise.v2022_01_01.Databases;


internal class DatabaseUpdateModel
{
    [JsonPropertyName("properties")]
    public DatabasePropertiesModel? Properties { get; set; }
}
