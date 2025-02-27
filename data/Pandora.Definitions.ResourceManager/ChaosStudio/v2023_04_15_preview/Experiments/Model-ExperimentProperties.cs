using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ChaosStudio.v2023_04_15_preview.Experiments;


internal class ExperimentPropertiesModel
{
    [MinItems(1)]
    [JsonPropertyName("selectors")]
    [Required]
    public List<SelectorModel> Selectors { get; set; }

    [JsonPropertyName("startOnCreation")]
    public bool? StartOnCreation { get; set; }

    [MinItems(1)]
    [JsonPropertyName("steps")]
    [Required]
    public List<StepModel> Steps { get; set; }
}
