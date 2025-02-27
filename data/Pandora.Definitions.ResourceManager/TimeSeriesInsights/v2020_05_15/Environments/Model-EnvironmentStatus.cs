using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.TimeSeriesInsights.v2020_05_15.Environments;


internal class EnvironmentStatusModel
{
    [JsonPropertyName("ingress")]
    public IngressEnvironmentStatusModel? Ingress { get; set; }

    [JsonPropertyName("warmStorage")]
    public WarmStorageEnvironmentStatusModel? WarmStorage { get; set; }
}
