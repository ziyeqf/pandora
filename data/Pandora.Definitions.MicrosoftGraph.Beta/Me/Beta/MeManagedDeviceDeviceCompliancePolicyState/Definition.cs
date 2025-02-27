// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Me.Beta.MeManagedDeviceDeviceCompliancePolicyState;

internal class Definition : ResourceDefinition
{
    public string Name => "MeManagedDeviceDeviceCompliancePolicyState";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateMeManagedDeviceByIdDeviceCompliancePolicyStateOperation(),
        new DeleteMeManagedDeviceByIdDeviceCompliancePolicyStateByIdOperation(),
        new GetMeManagedDeviceByIdDeviceCompliancePolicyStateByIdOperation(),
        new GetMeManagedDeviceByIdDeviceCompliancePolicyStateCountOperation(),
        new ListMeManagedDeviceByIdDeviceCompliancePolicyStatesOperation(),
        new UpdateMeManagedDeviceByIdDeviceCompliancePolicyStateByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
