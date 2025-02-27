using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2023_03_01_preview.Schema;

internal class Definition : ResourceDefinition
{
    public string Name => "Schema";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new GlobalSchemaCreateOrUpdateOperation(),
        new GlobalSchemaDeleteOperation(),
        new GlobalSchemaGetOperation(),
        new GlobalSchemaGetEntityTagOperation(),
        new GlobalSchemaListByServiceOperation(),
        new WorkspaceGlobalSchemaCreateOrUpdateOperation(),
        new WorkspaceGlobalSchemaDeleteOperation(),
        new WorkspaceGlobalSchemaGetOperation(),
        new WorkspaceGlobalSchemaGetEntityTagOperation(),
        new WorkspaceGlobalSchemaListByServiceOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(SchemaTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(GlobalSchemaContractModel),
        typeof(GlobalSchemaContractPropertiesModel),
    };
}
