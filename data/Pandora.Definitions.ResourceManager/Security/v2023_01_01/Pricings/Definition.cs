using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Security.v2023_01_01.Pricings;

internal class Definition : ResourceDefinition
{
    public string Name => "Pricings";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new GetOperation(),
        new ListOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(CodeConstant),
        typeof(IsEnabledConstant),
        typeof(PricingTierConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ExtensionModel),
        typeof(OperationStatusModel),
        typeof(PricingModel),
        typeof(PricingListModel),
        typeof(PricingPropertiesModel),
    };
}
