using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MobileNetwork.v2023_09_01.DiagnosticsPackages;

internal class ListByPacketCoreControlPlaneOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new PacketCoreControlPlaneId();

    public override Type NestedItemType() => typeof(DiagnosticsPackageModel);

    public override string? UriSuffix() => "/diagnosticsPackages";


}
