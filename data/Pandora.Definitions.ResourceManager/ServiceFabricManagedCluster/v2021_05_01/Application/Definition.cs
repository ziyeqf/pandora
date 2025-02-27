using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ServiceFabricManagedCluster.v2021_05_01.Application;

internal class Definition : ResourceDefinition
{
    public string Name => "Application";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(FailureActionConstant),
        typeof(RollingUpgradeModeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ApplicationHealthPolicyModel),
        typeof(ApplicationResourceModel),
        typeof(ApplicationResourcePropertiesModel),
        typeof(ApplicationUpdateParametersModel),
        typeof(ApplicationUpgradePolicyModel),
        typeof(ApplicationUserAssignedIdentityModel),
        typeof(RollingUpgradeMonitoringPolicyModel),
        typeof(ServiceTypeHealthPolicyModel),
        typeof(SystemDataModel),
    };
}
