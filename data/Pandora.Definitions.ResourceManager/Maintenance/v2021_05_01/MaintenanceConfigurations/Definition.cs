using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Maintenance.v2021_05_01.MaintenanceConfigurations;

internal class Definition : ResourceDefinition
{
    public string Name => "MaintenanceConfigurations";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new ForResourceGroupListOperation(),
        new GetOperation(),
        new ListOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(MaintenanceScopeConstant),
        typeof(VisibilityConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ListMaintenanceConfigurationsResultModel),
        typeof(MaintenanceConfigurationModel),
        typeof(MaintenanceConfigurationPropertiesModel),
        typeof(MaintenanceWindowModel),
    };
}
