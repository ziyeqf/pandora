using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ChaosStudio.v2023_11_01.CapabilityTypes;

internal class Definition : ResourceDefinition
{
    public string Name => "CapabilityTypes";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(CapabilityTypeModel),
        typeof(CapabilityTypePropertiesModel),
        typeof(CapabilityTypePropertiesRuntimePropertiesModel),
    };
}
