using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Compute.v2023_04_02.Disks;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DataAccessAuthModeConstant
{
    [Description("AzureActiveDirectory")]
    AzureActiveDirectory,

    [Description("None")]
    None,
}
