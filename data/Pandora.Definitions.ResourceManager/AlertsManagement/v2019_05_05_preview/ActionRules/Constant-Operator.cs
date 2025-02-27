using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.AlertsManagement.v2019_05_05_preview.ActionRules;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum OperatorConstant
{
    [Description("Contains")]
    Contains,

    [Description("DoesNotContain")]
    DoesNotContain,

    [Description("Equals")]
    Equals,

    [Description("NotEquals")]
    NotEquals,
}
