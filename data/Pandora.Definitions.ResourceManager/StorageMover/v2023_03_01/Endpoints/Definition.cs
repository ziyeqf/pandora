using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.StorageMover.v2023_03_01.Endpoints;

internal class Definition : ResourceDefinition
{
    public string Name => "Endpoints";
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
        typeof(EndpointTypeConstant),
        typeof(NfsVersionConstant),
        typeof(ProvisioningStateConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(AzureStorageBlobContainerEndpointPropertiesModel),
        typeof(EndpointModel),
        typeof(EndpointBasePropertiesModel),
        typeof(EndpointBaseUpdateParametersModel),
        typeof(EndpointBaseUpdatePropertiesModel),
        typeof(NfsMountEndpointPropertiesModel),
    };
}
