using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ServiceNetworking.v2023_11_01.FrontendsInterface;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ProvisioningStateConstant
{
    [Description("Accepted")]
    Accepted,

    [Description("Canceled")]
    Canceled,

    [Description("Deleting")]
    Deleting,

    [Description("Failed")]
    Failed,

    [Description("Provisioning")]
    Provisioning,

    [Description("Succeeded")]
    Succeeded,

    [Description("Updating")]
    Updating,
}
