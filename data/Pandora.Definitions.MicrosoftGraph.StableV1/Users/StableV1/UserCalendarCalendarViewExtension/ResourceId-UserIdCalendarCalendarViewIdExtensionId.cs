// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Users.StableV1.UserCalendarCalendarViewExtension;

internal class UserIdCalendarCalendarViewIdExtensionId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/users/{userId}/calendar/calendarView/{eventId}/extensions/{extensionId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticUsers", "users"),
        ResourceIDSegment.UserSpecified("userId"),
        ResourceIDSegment.Static("staticCalendar", "calendar"),
        ResourceIDSegment.Static("staticCalendarView", "calendarView"),
        ResourceIDSegment.UserSpecified("eventId"),
        ResourceIDSegment.Static("staticExtensions", "extensions"),
        ResourceIDSegment.UserSpecified("extensionId")
    };
}
