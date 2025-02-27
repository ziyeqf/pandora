using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Batch.v2023_05_01.Pool;


internal class ContainerConfigurationModel
{
    [JsonPropertyName("containerImageNames")]
    public List<string>? ContainerImageNames { get; set; }

    [JsonPropertyName("containerRegistries")]
    public List<ContainerRegistryModel>? ContainerRegistries { get; set; }

    [JsonPropertyName("type")]
    [Required]
    public ContainerTypeConstant Type { get; set; }
}
