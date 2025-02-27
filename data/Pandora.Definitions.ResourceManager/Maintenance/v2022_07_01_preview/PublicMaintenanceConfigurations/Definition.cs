using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Maintenance.v2022_07_01_preview.PublicMaintenanceConfigurations;

internal class Definition : ResourceDefinition
{
    public string Name => "PublicMaintenanceConfigurations";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new GetOperation(),
        new ListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(MaintenanceScopeConstant),
        typeof(RebootOptionsConstant),
        typeof(TaskScopeConstant),
        typeof(VisibilityConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(InputLinuxParametersModel),
        typeof(InputPatchConfigurationModel),
        typeof(InputWindowsParametersModel),
        typeof(ListMaintenanceConfigurationsResultModel),
        typeof(MaintenanceConfigurationModel),
        typeof(MaintenanceConfigurationPropertiesModel),
        typeof(MaintenanceWindowModel),
        typeof(SoftwareUpdateConfigurationTasksModel),
        typeof(TaskPropertiesModel),
    };
}
