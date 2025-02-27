using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Sql.v2021_11_01.ServerTrustCertificates;


internal class ServerTrustCertificatePropertiesModel
{
    [JsonPropertyName("certificateName")]
    public string? CertificateName { get; set; }

    [JsonPropertyName("publicBlob")]
    public string? PublicBlob { get; set; }

    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}
