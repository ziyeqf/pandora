// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Me.Beta.MeTodoListTaskAttachment;

internal class CreateMeTodoListByIdTaskByIdAttachmentOperation : Operations.PostOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override Type? RequestObject() => typeof(AttachmentBaseModel);
    public override ResourceID? ResourceId() => new MeTodoListIdTaskId();
    public override Type? ResponseObject() => typeof(AttachmentBaseModel);
    public override string? UriSuffix() => "/attachments";
}
