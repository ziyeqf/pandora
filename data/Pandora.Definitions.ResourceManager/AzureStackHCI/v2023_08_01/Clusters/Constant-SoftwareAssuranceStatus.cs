using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.AzureStackHCI.v2023_08_01.Clusters;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SoftwareAssuranceStatusConstant
{
    [Description("Disabled")]
    Disabled,

    [Description("Enabled")]
    Enabled,
}
