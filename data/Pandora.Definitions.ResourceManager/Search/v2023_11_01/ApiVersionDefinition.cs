using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Search.v2023_11_01;

public partial class Definition : ApiVersionDefinition
{
    public string ApiVersion => "2023-11-01";
    public bool Preview => false;
    public Source Source => Source.ResourceManagerRestApiSpecs;

    public IEnumerable<ResourceDefinition> Resources => new List<ResourceDefinition>
    {
        new AdminKeys.Definition(),
        new PrivateEndpointConnections.Definition(),
        new PrivateLinkResources.Definition(),
        new QueryKeys.Definition(),
        new Services.Definition(),
        new SharedPrivateLinkResources.Definition(),
        new Usages.Definition(),
    };
}
