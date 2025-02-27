using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2023_02_01_preview.ManagedInstances;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum BackupStorageRedundancyConstant
{
    [Description("Geo")]
    Geo,

    [Description("GeoZone")]
    GeoZone,

    [Description("Local")]
    Local,

    [Description("Zone")]
    Zone,
}
