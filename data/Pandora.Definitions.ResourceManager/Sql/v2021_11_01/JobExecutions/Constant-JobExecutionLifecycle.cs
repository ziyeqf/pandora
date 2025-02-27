using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2021_11_01.JobExecutions;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum JobExecutionLifecycleConstant
{
    [Description("Canceled")]
    Canceled,

    [Description("Created")]
    Created,

    [Description("Failed")]
    Failed,

    [Description("InProgress")]
    InProgress,

    [Description("Skipped")]
    Skipped,

    [Description("Succeeded")]
    Succeeded,

    [Description("SucceededWithSkipped")]
    SucceededWithSkipped,

    [Description("TimedOut")]
    TimedOut,

    [Description("WaitingForChildJobExecutions")]
    WaitingForChildJobExecutions,

    [Description("WaitingForRetry")]
    WaitingForRetry,
}
