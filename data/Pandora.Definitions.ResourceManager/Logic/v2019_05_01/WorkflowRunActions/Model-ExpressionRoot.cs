using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Logic.v2019_05_01.WorkflowRunActions;


internal class ExpressionRootModel
{
    [JsonPropertyName("error")]
    public AzureResourceErrorInfoModel? Error { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("subexpressions")]
    public List<ExpressionModel>? Subexpressions { get; set; }

    [JsonPropertyName("text")]
    public string? Text { get; set; }

    [JsonPropertyName("value")]
    public object? Value { get; set; }
}
