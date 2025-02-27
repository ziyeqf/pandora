using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.FrontDoor.v2020_04_01.WebApplicationFirewallManagedRuleSets;

internal class Definition : ResourceDefinition
{
    public string Name => "WebApplicationFirewallManagedRuleSets";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ManagedRuleSetsListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ActionTypeConstant),
        typeof(ManagedRuleEnabledStateConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ManagedRuleDefinitionModel),
        typeof(ManagedRuleGroupDefinitionModel),
        typeof(ManagedRuleSetDefinitionModel),
        typeof(ManagedRuleSetDefinitionPropertiesModel),
    };
}
