using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2023_04_01.ReplicationRecoveryPlans;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SourceSiteOperationsConstant
{
    [Description("NotRequired")]
    NotRequired,

    [Description("Required")]
    Required,
}
