using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataFactory.v2018_06_01.PipelineRuns;


internal class RunQueryFilterModel
{
    [JsonPropertyName("operand")]
    [Required]
    public RunQueryFilterOperandConstant Operand { get; set; }

    [JsonPropertyName("operator")]
    [Required]
    public RunQueryFilterOperatorConstant Operator { get; set; }

    [JsonPropertyName("values")]
    [Required]
    public List<string> Values { get; set; }
}
