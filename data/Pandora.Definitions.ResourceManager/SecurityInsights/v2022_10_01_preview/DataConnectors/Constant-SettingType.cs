using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.SecurityInsights.v2022_10_01_preview.DataConnectors;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SettingTypeConstant
{
    [Description("CopyableLabel")]
    CopyableLabel,

    [Description("InfoMessage")]
    InfoMessage,

    [Description("InstructionStepsGroup")]
    InstructionStepsGroup,
}
