// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum UserSecurityStateUserAccountTypeConstant
{
    [Description("Unknown")]
    @unknown,

    [Description("Standard")]
    @standard,

    [Description("Power")]
    @power,

    [Description("Administrator")]
    @administrator,
}
