using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.StorageSync.v2022_09_01.ServerEndpointResource;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum InitialDownloadPolicyConstant
{
    [Description("AvoidTieredFiles")]
    AvoidTieredFiles,

    [Description("NamespaceOnly")]
    NamespaceOnly,

    [Description("NamespaceThenModifiedFiles")]
    NamespaceThenModifiedFiles,
}
