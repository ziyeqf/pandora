// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.Beta.RoleManagement.Beta.RoleManagementEnterpriseAppRoleEligibilitySchedule;

internal class RoleManagementEnterpriseAppIdRoleEligibilityScheduleId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/roleManagement/enterpriseApps/{rbacApplicationId}/roleEligibilitySchedules/{unifiedRoleEligibilityScheduleId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticRoleManagement", "roleManagement"),
        ResourceIDSegment.Static("staticEnterpriseApps", "enterpriseApps"),
        ResourceIDSegment.UserSpecified("rbacApplicationId"),
        ResourceIDSegment.Static("staticRoleEligibilitySchedules", "roleEligibilitySchedules"),
        ResourceIDSegment.UserSpecified("unifiedRoleEligibilityScheduleId")
    };
}
