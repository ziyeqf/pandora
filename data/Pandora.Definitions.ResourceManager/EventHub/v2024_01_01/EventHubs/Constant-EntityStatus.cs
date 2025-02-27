using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.EventHub.v2024_01_01.EventHubs;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum EntityStatusConstant
{
    [Description("Active")]
    Active,

    [Description("Creating")]
    Creating,

    [Description("Deleting")]
    Deleting,

    [Description("Disabled")]
    Disabled,

    [Description("ReceiveDisabled")]
    ReceiveDisabled,

    [Description("Renaming")]
    Renaming,

    [Description("Restoring")]
    Restoring,

    [Description("SendDisabled")]
    SendDisabled,

    [Description("Unknown")]
    Unknown,
}
