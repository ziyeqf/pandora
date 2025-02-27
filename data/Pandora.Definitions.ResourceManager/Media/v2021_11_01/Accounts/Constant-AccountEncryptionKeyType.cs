using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Media.v2021_11_01.Accounts;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AccountEncryptionKeyTypeConstant
{
    [Description("CustomerKey")]
    CustomerKey,

    [Description("SystemKey")]
    SystemKey,
}
