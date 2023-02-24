using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.KeyVault.v2022_11_01.Vaults;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum VaultProvisioningStateConstant
{
    [Description("RegisteringDns")]
    RegisteringDns,

    [Description("Succeeded")]
    Succeeded,
}
