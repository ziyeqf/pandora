// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Users.StableV1.UserCalendarEventExtension;

internal class UserIdCalendarEventIdExtensionId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/users/{userId}/calendar/events/{eventId}/extensions/{extensionId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticUsers", "users"),
        ResourceIDSegment.UserSpecified("userId"),
        ResourceIDSegment.Static("staticCalendar", "calendar"),
        ResourceIDSegment.Static("staticEvents", "events"),
        ResourceIDSegment.UserSpecified("eventId"),
        ResourceIDSegment.Static("staticExtensions", "extensions"),
        ResourceIDSegment.UserSpecified("extensionId")
    };
}
