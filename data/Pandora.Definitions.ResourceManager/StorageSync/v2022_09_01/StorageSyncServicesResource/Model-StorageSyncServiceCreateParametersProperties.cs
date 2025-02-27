using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.StorageSync.v2022_09_01.StorageSyncServicesResource;


internal class StorageSyncServiceCreateParametersPropertiesModel
{
    [JsonPropertyName("incomingTrafficPolicy")]
    public IncomingTrafficPolicyConstant? IncomingTrafficPolicy { get; set; }

    [JsonPropertyName("useIdentity")]
    public bool? UseIdentity { get; set; }
}
