using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Logz.v2020_10_01;

public partial class Definition : ApiVersionDefinition
{
    public string ApiVersion => "2020-10-01";
    public bool Preview => false;
    public Source Source => Source.ResourceManagerRestApiSpecs;

    public IEnumerable<ResourceDefinition> Resources => new List<ResourceDefinition>
    {
        new Monitors.Definition(),
        new SingleSignOn.Definition(),
        new SubAccount.Definition(),
        new TagRules.Definition(),
        new VMHost.Definition(),
    };
}
