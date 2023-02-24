using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.SecurityInsights.v2022_10_01_preview.EntityQueries;

internal class Definition : ResourceDefinition
{
    public string Name => "EntityQueries";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new EntityQueryTemplatesGetOperation(),
        new EntityQueryTemplatesListOperation(),
        new GetOperation(),
        new ListOperation(),
    };
}
