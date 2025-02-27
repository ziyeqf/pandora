using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Maps.v2023_06_01;

public partial class Definition : ApiVersionDefinition
{
    public string ApiVersion => "2023-06-01";
    public bool Preview => false;
    public Source Source => Source.ResourceManagerRestApiSpecs;

    public IEnumerable<ResourceDefinition> Resources => new List<ResourceDefinition>
    {
        new Accounts.Definition(),
        new Creators.Definition(),
        new Operations.Definition(),
    };
}
