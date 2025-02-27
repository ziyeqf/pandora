using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.AlertsManagement.v2019_05_05_preview.SmartGroups;

internal class GetHistoryOperation : Pandora.Definitions.Operations.GetOperation
{
    public override ResourceID? ResourceId() => new SmartGroupId();

    public override Type? ResponseObject() => typeof(SmartGroupModificationModel);

    public override string? UriSuffix() => "/history";


}
