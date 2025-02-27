using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ServiceFabric.v2021_06_01.Service;


internal class ServiceLoadMetricDescriptionModel
{
    [JsonPropertyName("defaultLoad")]
    public int? DefaultLoad { get; set; }

    [JsonPropertyName("name")]
    [Required]
    public string Name { get; set; }

    [JsonPropertyName("primaryDefaultLoad")]
    public int? PrimaryDefaultLoad { get; set; }

    [JsonPropertyName("secondaryDefaultLoad")]
    public int? SecondaryDefaultLoad { get; set; }

    [JsonPropertyName("weight")]
    public ServiceLoadMetricWeightConstant? Weight { get; set; }
}
