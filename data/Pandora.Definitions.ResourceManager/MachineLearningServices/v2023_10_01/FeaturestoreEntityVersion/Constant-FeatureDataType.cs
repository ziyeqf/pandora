using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_10_01.FeaturestoreEntityVersion;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum FeatureDataTypeConstant
{
    [Description("Binary")]
    Binary,

    [Description("Boolean")]
    Boolean,

    [Description("Datetime")]
    Datetime,

    [Description("Double")]
    Double,

    [Description("Float")]
    Float,

    [Description("Integer")]
    Integer,

    [Description("Long")]
    Long,

    [Description("String")]
    String,
}
