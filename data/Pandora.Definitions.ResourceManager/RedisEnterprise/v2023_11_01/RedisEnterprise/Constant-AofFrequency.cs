using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RedisEnterprise.v2023_11_01.RedisEnterprise;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AofFrequencyConstant
{
    [Description("always")]
    Always,

    [Description("1s")]
    Ones,
}
