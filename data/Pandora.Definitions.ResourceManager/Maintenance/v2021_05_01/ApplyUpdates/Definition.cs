using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Maintenance.v2021_05_01.ApplyUpdates;

internal class Definition : ResourceDefinition
{
    public string Name => "ApplyUpdates";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new CreateOrUpdateParentOperation(),
        new GetOperation(),
        new GetParentOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(UpdateStatusConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ApplyUpdateModel),
        typeof(ApplyUpdatePropertiesModel),
    };
}
