using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Maintenance.v2023_04_01.ConfigurationAssignments;

internal class ListOperation : Pandora.Definitions.Operations.GetOperation
{
    public override ResourceID? ResourceId() => new ScopeId();

    public override Type? ResponseObject() => typeof(ListConfigurationAssignmentsResultModel);

    public override string? UriSuffix() => "/providers/Microsoft.Maintenance/configurationAssignments";


}
