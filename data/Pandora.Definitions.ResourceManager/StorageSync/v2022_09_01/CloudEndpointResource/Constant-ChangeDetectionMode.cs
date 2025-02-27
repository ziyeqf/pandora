using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.StorageSync.v2022_09_01.CloudEndpointResource;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ChangeDetectionModeConstant
{
    [Description("Default")]
    Default,

    [Description("Recursive")]
    Recursive,
}
