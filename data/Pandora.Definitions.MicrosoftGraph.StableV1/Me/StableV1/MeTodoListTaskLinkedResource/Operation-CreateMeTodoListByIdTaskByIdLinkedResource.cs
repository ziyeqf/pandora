// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Me.StableV1.MeTodoListTaskLinkedResource;

internal class CreateMeTodoListByIdTaskByIdLinkedResourceOperation : Operations.PostOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override Type? RequestObject() => typeof(LinkedResourceModel);
    public override ResourceID? ResourceId() => new MeTodoListIdTaskId();
    public override Type? ResponseObject() => typeof(LinkedResourceModel);
    public override string? UriSuffix() => "/linkedResources";
}
