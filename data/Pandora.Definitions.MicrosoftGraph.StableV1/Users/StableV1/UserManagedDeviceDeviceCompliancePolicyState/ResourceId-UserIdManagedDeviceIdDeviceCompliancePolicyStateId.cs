// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Users.StableV1.UserManagedDeviceDeviceCompliancePolicyState;

internal class UserIdManagedDeviceIdDeviceCompliancePolicyStateId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/users/{userId}/managedDevices/{managedDeviceId}/deviceCompliancePolicyStates/{deviceCompliancePolicyStateId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticUsers", "users"),
        ResourceIDSegment.UserSpecified("userId"),
        ResourceIDSegment.Static("staticManagedDevices", "managedDevices"),
        ResourceIDSegment.UserSpecified("managedDeviceId"),
        ResourceIDSegment.Static("staticDeviceCompliancePolicyStates", "deviceCompliancePolicyStates"),
        ResourceIDSegment.UserSpecified("deviceCompliancePolicyStateId")
    };
}
