using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ServiceFabric.v2021_06_01.ClusterVersion;

internal class ListByEnvironmentOperation : Pandora.Definitions.Operations.GetOperation
{
    public override ResourceID? ResourceId() => new EnvironmentId();

    public override Type? ResponseObject() => typeof(ClusterCodeVersionsListResultModel);

    public override string? UriSuffix() => "/clusterVersions";


}
