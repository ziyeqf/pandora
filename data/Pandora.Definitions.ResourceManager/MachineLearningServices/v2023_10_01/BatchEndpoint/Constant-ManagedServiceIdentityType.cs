using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_10_01.BatchEndpoint;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ManagedServiceIdentityTypeConstant
{
    [Description("None")]
    None,

    [Description("SystemAssigned")]
    SystemAssigned,

    [Description("SystemAssigned,UserAssigned")]
    SystemAssignedUserAssigned,

    [Description("UserAssigned")]
    UserAssigned,
}
