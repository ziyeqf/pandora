using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.AppPlatform.v2023_09_01_preview.AppPlatform;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum GitImplementationConstant
{
    [Description("go-git")]
    GoNegativegit,

    [Description("libgit2")]
    LibgitTwo,
}
