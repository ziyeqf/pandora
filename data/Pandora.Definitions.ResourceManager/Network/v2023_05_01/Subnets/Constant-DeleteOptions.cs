using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_05_01.Subnets;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DeleteOptionsConstant
{
    [Description("Delete")]
    Delete,

    [Description("Detach")]
    Detach,
}
