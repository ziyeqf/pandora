// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Users.Beta.UserCalendarCalendarPermission;

internal class CreateUserByIdCalendarByIdCalendarPermissionOperation : Operations.PostOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override Type? RequestObject() => typeof(CalendarPermissionModel);
    public override ResourceID? ResourceId() => new UserIdCalendarId();
    public override Type? ResponseObject() => typeof(CalendarPermissionModel);
    public override string? UriSuffix() => "/calendarPermissions";
}
