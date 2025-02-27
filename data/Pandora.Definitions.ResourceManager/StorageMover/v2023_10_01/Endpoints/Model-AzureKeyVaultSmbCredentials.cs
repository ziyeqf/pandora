using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.StorageMover.v2023_10_01.Endpoints;

[ValueForType("AzureKeyVaultSmb")]
internal class AzureKeyVaultSmbCredentialsModel : CredentialsModel
{
    [JsonPropertyName("passwordUri")]
    public string? PasswordUri { get; set; }

    [JsonPropertyName("usernameUri")]
    public string? UsernameUri { get; set; }
}
