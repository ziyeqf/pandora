// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Users.Beta.UserSettingRegionalAndLanguageSetting;

internal class UpdateUserByIdSettingRegionalAndLanguageSettingOperation : Operations.PatchOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override Type? RequestObject() => typeof(RegionalAndLanguageSettingsModel);
    public override ResourceID? ResourceId() => new UserId();
    public override Type? ResponseObject() => typeof(RegionalAndLanguageSettingsModel);
    public override string? UriSuffix() => "/settings/regionalAndLanguageSettings";
}
