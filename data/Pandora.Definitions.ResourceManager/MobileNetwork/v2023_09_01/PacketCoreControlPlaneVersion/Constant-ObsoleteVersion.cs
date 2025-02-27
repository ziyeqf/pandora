using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.MobileNetwork.v2023_09_01.PacketCoreControlPlaneVersion;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ObsoleteVersionConstant
{
    [Description("NotObsolete")]
    NotObsolete,

    [Description("Obsolete")]
    Obsolete,
}
