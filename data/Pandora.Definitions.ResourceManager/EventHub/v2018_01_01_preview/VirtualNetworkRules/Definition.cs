using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.EventHub.v2018_01_01_preview.VirtualNetworkRules
{
    internal class Definition : ApiDefinition
    {
        // Generated from Swagger revision "191a721de644cc3f872f4fe9d676cf366083a106" 

        public string ApiVersion => "2018-01-01-preview";
        public string Name => "VirtualNetworkRules";
        public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
        {
            new NamespacesCreateOrUpdateVirtualNetworkRuleOperation(),
            new NamespacesDeleteVirtualNetworkRuleOperation(),
            new NamespacesGetVirtualNetworkRuleOperation(),
            new NamespacesListVirtualNetworkRulesOperation(),
        };
    }
}
