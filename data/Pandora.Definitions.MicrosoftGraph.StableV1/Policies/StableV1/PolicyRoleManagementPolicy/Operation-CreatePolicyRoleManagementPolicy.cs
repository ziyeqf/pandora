// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Policies.StableV1.PolicyRoleManagementPolicy;

internal class CreatePolicyRoleManagementPolicyOperation : Operations.PostOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.OK,
        };
    public override Type? RequestObject() => typeof(UnifiedRoleManagementPolicyModel);
    public override ResourceID? ResourceId() => null;
    public override Type? ResponseObject() => typeof(UnifiedRoleManagementPolicyModel);
    public override string? UriSuffix() => "/policies/roleManagementPolicies";
}
