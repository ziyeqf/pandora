// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Users.Beta.UserCalendarGroupCalendarCalendarViewExceptionOccurrenceInstanceExtension;

internal class GetUserByIdCalendarGroupByIdCalendarByIdCalendarViewByIdExceptionOccurrenceByIdInstanceByIdExtensionCountOperation : Operations.GetOperation
{
    public override string? ContentType() => "text/plain";
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override ResourceID? ResourceId() => new UserIdCalendarGroupIdCalendarIdCalendarViewIdExceptionOccurrenceIdInstanceId();
    public override Type? ResponseObject() => null;
    public override string? UriSuffix() => "/extensions/$count";
}
