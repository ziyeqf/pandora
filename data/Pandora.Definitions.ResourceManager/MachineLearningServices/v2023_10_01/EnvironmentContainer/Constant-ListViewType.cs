using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_10_01.EnvironmentContainer;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ListViewTypeConstant
{
    [Description("ActiveOnly")]
    ActiveOnly,

    [Description("All")]
    All,

    [Description("ArchivedOnly")]
    ArchivedOnly,
}
