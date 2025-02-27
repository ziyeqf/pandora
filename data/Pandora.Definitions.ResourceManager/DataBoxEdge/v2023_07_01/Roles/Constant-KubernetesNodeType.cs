using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DataBoxEdge.v2023_07_01.Roles;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum KubernetesNodeTypeConstant
{
    [Description("Invalid")]
    Invalid,

    [Description("Master")]
    Master,

    [Description("Worker")]
    Worker,
}
