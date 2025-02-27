using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Consumption.v2023_05_01.Events;

internal class Definition : ResourceDefinition
{
    public string Name => "Events";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ListByBillingAccountOperation(),
        new ListByBillingProfileOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(EventTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(AmountModel),
        typeof(AmountWithExchangeRateModel),
        typeof(EventPropertiesModel),
        typeof(EventSummaryModel),
        typeof(ResellerModel),
    };
}
