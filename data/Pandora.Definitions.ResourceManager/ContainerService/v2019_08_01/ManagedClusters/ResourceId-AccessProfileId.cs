using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerService.v2019_08_01.ManagedClusters;

internal class AccessProfileId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{managedClusterName}/accessProfiles/{accessProfileName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftContainerService", "Microsoft.ContainerService"),
        ResourceIDSegment.Static("staticManagedClusters", "managedClusters"),
        ResourceIDSegment.UserSpecified("managedClusterName"),
        ResourceIDSegment.Static("staticAccessProfiles", "accessProfiles"),
        ResourceIDSegment.UserSpecified("accessProfileName"),
    };
}
