using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.LabServices.v2023_06_07;

public partial class Definition : ApiVersionDefinition
{
    public string ApiVersion => "2023-06-07";
    public bool Preview => false;
    public Source Source => Source.ResourceManagerRestApiSpecs;

    public IEnumerable<ResourceDefinition> Resources => new List<ResourceDefinition>
    {
        new Image.Definition(),
        new Lab.Definition(),
        new LabPlan.Definition(),
        new Schedule.Definition(),
        new Skus.Definition(),
        new Usages.Definition(),
        new User.Definition(),
        new VirtualMachine.Definition(),
    };
}
